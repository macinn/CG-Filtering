using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Zadanie3GK
{
    public enum State
    {
        All, Brush
    }

    public partial class Form1 : Form
    {
        Bitmap originalBmp;
        State windomState = State.Brush;
        bool[,] marked;
        public Form1()
        {
            InitializeComponent();
            marked = new bool[Canvas.Width, Canvas.Height];
            modeBox.DataSource = Enum.GetValues(typeof(State));

            //originalBmp = new Bitmap("C:\\Users\\marci\\source\\repos\\Zadanie3GK\\Zadanie3GK\\photo.jpeg");
            //Canvas.Image = new Bitmap(originalBmp);
            //UpdateCharts();
            InitCustomFun();
            //Transform(x => 255 - x);
        }

        void UpdateCharts()
        {
            if (Canvas.Image == null) return;
            mouseMove = null;
            Canvas.Invalidate();

            int[] r = new int[256];
            int[] g = new int[256];
            int[] b = new int[256];

            Bitmap bmp = new Bitmap(Canvas.Image);
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData data = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            int depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8;
            byte[] buffer = new byte[data.Width * data.Height * depth];
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);

            //Parallel.For(0, data.Width, x =>
            //{
            for (int x = 0; x < data.Width; x++)
                for (int y = 0; y < data.Height; y++)
                {
                    //Color c = bmp.GetPixel(x, y);
                    int offset = ((y * data.Width) + x) * depth;
                    // A R G B
                    r[buffer[offset + 2]]++;
                    g[buffer[offset + 1]]++;
                    b[buffer[offset + 0]]++;
                }
            //});

            chartR.Series[0].Points.Clear();
            chartG.Series[0].Points.Clear();
            chartB.Series[0].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                chartR.Series[0].Points.AddXY(i, r[i]);
                chartG.Series[0].Points.AddXY(i, g[i]);
                chartB.Series[0].Points.AddXY(i, b[i]);
            }

            bmp.UnlockBits(data);
            bmp.Dispose();
        }
        void Transform(Func<byte, byte> func)
        {
            if (originalBmp == null) return;
            // https://stackoverflow.com/questions/21497537/allow-an-image-to-be-accessed-by-several-threads
            Bitmap bmp = new Bitmap(originalBmp);
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData data = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            int depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8;
            byte[] buffer = new byte[data.Width * data.Height * depth];
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);

            Parallel.For(0, data.Width, x =>
                {
                    for (int y = 0; y < data.Height; y++)
                    {
                        if (windomState == State.All
                            || (windomState == State.Brush && y < Canvas.Height && x < Canvas.Width
                            && marked[x, y]))
                        {
                            int offset = ((y * data.Width) + x) * depth;

                            buffer[offset + 0] = func(buffer[offset + 0]);
                            buffer[offset + 1] = func(buffer[offset + 1]);
                            buffer[offset + 2] = func(buffer[offset + 2]);
                        }
                    }
                });

            Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
            bmp.UnlockBits(data);
            Canvas.Image = bmp;

            UpdateCharts();
        }
        void InitCustomFun()
        {
            funChart.Series[0].Points.Clear();
            const int points = 8;
            for (int k = 0; k < points; k++)
                funChart.Series[0].Points.AddXY(k * 255 / points, (k * 255 / points) + 1);
            funChart.Series[0].Points.AddXY(255, 255);

        }
        DataPoint selectedDP;
        bool mousePressed = false;
        private void funChart_MouseDown(object sender, MouseEventArgs e)
        {
            HitTestResult hitRes = funChart.HitTest(e.X, e.Y);
            if (hitRes.Object is DataPoint)
            {
                selectedDP = hitRes.Object as DataPoint;
                mousePressed = true;
            }
            //else if (hitRes.Object is Axis)
            //{
            //    selectedDP = funChart.Series[0].Points[0];
            //    mousePressed = true;
            //}
            else
                mousePressed = false;
        }
        private void funChart_MouseUp(object sender, MouseEventArgs e)
        {
            if (mousePressed)
            {
                double pX, pY;
                try
                {
                    pX = funChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                }
                catch
                {
                    if (e.X < funChart.Width / 2)
                        pX = 0;
                    else
                        pX = 255;
                }
                try
                {
                    pY = funChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
                }
                catch
                {
                    if (e.Y < funChart.Height / 2)
                        pY = 255;
                    else
                        pY = 0;
                }

                selectedDP.XValue = pX;
                selectedDP.YValues[0] = pY;

                funChart.Series[0].Sort(
                    Comparer<DataPoint>.Create((a, b) => a.XValue.CompareTo(b.XValue)));

                funChart.Series[0].Points.Last<DataPoint>().XValue = 255;
                funChart.Series[0].Points.First<DataPoint>().XValue = 0;

                foreach (DataPoint dp in funChart.Series[0].Points)
                {
                    dp.YValues[0] = Math.Min(255, dp.YValues[0]);
                    dp.YValues[0] = Math.Max(0, dp.YValues[0]);
                }
                mousePressed = false;
                TransformFromChart();
            }
        }
        private void funChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
            {
                double pX, pY;
                try
                {
                    pX = funChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                }
                catch
                {
                    if (e.X < funChart.Width / 2)
                        pX = 0;
                    else
                        pX = 255;
                }
                try
                {
                    pY = funChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
                }
                catch
                {
                    if (e.Y < funChart.Height / 2)
                        pY = 255;
                    else
                        pY = 1;
                }

                selectedDP.XValue = pX;
                selectedDP.YValues[0] = pY;
            }
        }
        Func<byte, byte> CreateChartFun()
        {
            return x =>
            {
                int idxU = funChart.Series[0].Points.ToList().FindIndex(dp => dp.XValue >= x);
                DataPoint dpU = funChart.Series[0].Points[idxU];

                if (dpU.XValue == x)
                    return (byte)dpU.YValues[0];

                DataPoint dpL = funChart.Series[0].Points[idxU - 1];
                double m = dpU.YValues[0] - dpL.YValues[0];
                m /= dpU.XValue - dpL.XValue;
                byte val = (byte)(dpL.YValues[0] + ((x - dpL.XValue) * m));
                val = Math.Max(val, (byte)0);
                val = Math.Min(val, (byte)255);
                return val;
            };
        }
        void TransformFromChart()
        {
            Transform(CreateChartFun());
        }
        int bRadius = 100;
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMove = null;
            Canvas.Invalidate();
            Point s = e.Location;
            for (int y = s.Y + bRadius; y >= s.Y - bRadius; y--)
            {
                for (int x = s.X + bRadius; x >= s.X - bRadius; x--)
                {
                    if (x > 0 && y > 0 && x < Canvas.Width && y < Canvas.Height)
                    {
                        if (bRadius * bRadius >= ((x - s.X) * (x - s.X)) + ((y - s.Y) * (y - s.Y)))
                            marked[x, y] = true;
                    }
                }
            }
            TransformFromChart();
        }

        void Invalidate()
        {
            Bitmap bmp = (Bitmap)Canvas.Image;
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                    if (y < Canvas.Height && x < Canvas.Width && marked[x, y])
                        bmp.SetPixel(x, y, Color.Black);
            Canvas.Image = bmp;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Array.Clear(marked, 0, marked.Length);
            if (originalBmp != null)
                Canvas.Image = new Bitmap(originalBmp);
            UpdateCharts();
        }

        private void modeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            windomState = (State)modeBox.SelectedItem;
            bBox.Visible = windomState == State.Brush;
            switch (modeBox.SelectedItem)
            {
                case State.All:
                    if (funChart.Series[0].Points.Count > 0)
                        TransformFromChart();
                    break;
                case State.Brush:
                    resetButton_Click(null, null);
                    break;
            }
        }

        private void negButton_CheckedChanged(object sender, EventArgs e)
        {
            if (negButton.Checked)
            {
                valueNum.Enabled = false;
                funChart.Series[0].Points.Clear();
                const int points = 8;
                for (int k = 0; k < points; k++)
                    funChart.Series[0].Points.AddXY(k * 255 / points, (points - k) * 255 / points);
                funChart.Series[0].Points.AddXY(255, 0);
                TransformFromChart();
            }
        }

        private void customButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customButton.Checked)
            {
                valueNum.Enabled = false;
                InitCustomFun();
                TransformFromChart();
            }
        }

        private void gammaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gammaButton.Checked)
            {
                valueNum.Enabled = true;
                valueNum.DecimalPlaces = 2;
                valueNum.Minimum = 0;
                valueNum.Maximum = 3;
                valueNum.Increment = 0.2M;
                valueNum.Value = 1.0M;

                UpdateGammaFun();
                TransformFromChart();
            }
        }

        private void contrastButton_CheckedChanged(object sender, EventArgs e)
        {
            if (contrastButton.Checked)
            {
                valueNum.Enabled = true;
                valueNum.DecimalPlaces = 0;
                valueNum.Maximum = 255;
                valueNum.Minimum = 0;
                valueNum.Increment = 1M;

                UpdateContrastFun();
                TransformFromChart();
            }
        }
        void UpdateContrastFun()
        {
            byte value = (byte)valueNum.Value;
            funChart.Series[0].Points.Clear();

            funChart.Series[0].Points.AddXY(0, 0);
            funChart.Series[0].Points.AddXY(value / 2, 0);
            funChart.Series[0].Points.AddXY(255 - (value / 2), 255);
            funChart.Series[0].Points.AddXY(255, 255);
        }
        void UpdateLightFun()
        {
            sbyte value = (sbyte)valueNum.Value;
            InitCustomFun();
            for (int i = 0; i < funChart.Series[0].Points.Count; i++)
            {
                funChart.Series[0].Points[i].YValues[0] += value;
                funChart.Series[0].Points[i].YValues[0] = Math.Min(255, funChart.Series[0].Points[i].YValues[0]);
                funChart.Series[0].Points[i].YValues[0] = Math.Max(0, funChart.Series[0].Points[i].YValues[0]);
            }
        }
        private void lightButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lightButton.Checked)
            {
                valueNum.Enabled = true;
                valueNum.DecimalPlaces = 0;
                valueNum.Maximum = 127;
                valueNum.Minimum = -127;
                valueNum.Increment = 1M;

                UpdateLightFun();
                TransformFromChart();
            }
        }
        private void valueNum_ValueChanged(object sender, EventArgs e)
        {
            if (contrastButton.Checked)
            {
                UpdateContrastFun();
            }
            else if (lightButton.Checked)
            {
                UpdateLightFun();
            }
            else if (gammaButton.Checked)
            {
                UpdateGammaFun();
            }
            TransformFromChart();
        }
        void UpdateGammaFun()
        {
            double value = (double)valueNum.Value;
            const double points = 20.0;
            funChart.Series[0].Points.Clear();

            for (int i = 0; i < points; i++)
            {
                funChart.Series[0].Points.AddXY(i / (points - 1) * 255.0,
                    Math.Pow(i / (points - 1), value) * 255.0);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;";

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (originalBmp != null)
                        originalBmp.Dispose();
                    originalBmp = new Bitmap(Image.FromFile(openFileDialog.FileName));
                    Canvas.Image = new Bitmap(originalBmp);
                    UpdateCharts();
                }
            }
            catch
            {
                MessageBox.Show("Error loading picture!");
            }
            finally
            { openFileDialog.Dispose(); }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            dialog.RestoreDirectory = true;
            dialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap bmp = new Bitmap(Canvas.Image))
                {
                    bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                }
            }
        }

        MouseEventArgs mouseMove;
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (windomState == State.Brush)
            {
                mouseMove = e;
                Canvas.Invalidate();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (mouseMove != null)
            {
                Pen p = new Pen(Color.Black);
                e.Graphics.DrawEllipse(p, mouseMove.Location.X - bRadius, mouseMove.Location.Y - bRadius,
                    2 * bRadius, 2 * bRadius);
            }
        }

        private void radiusNum_ValueChanged(object sender, EventArgs e)
        {
            bRadius = (int)radiusNum.Value;
        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            mouseMove = null;
            Canvas.Invalidate();
        }

        private void hslButton_Click(object sender, EventArgs e)
        {
            DrawHSL();
        }

        private void hueBar_Scroll(object sender, EventArgs e)
        {
            DrawHSL();
        }

        private void DrawHSL()
        {
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = HSLColor(hueBar.Value, x / (double)bmp.Width, y / (double)bmp.Height);
                    bmp.SetPixel(x, y, c);
                }
            Canvas.Image = bmp;
            originalBmp = bmp;
            UpdateCharts();
        }
        Color HSLColor(double H, double S, double L)
        {
            double h = H / 60.0;
            double c = (1 - Math.Abs(2 * L - 1)) * S;
            double x = c * (1 - Math.Abs((h % 2) - 1));

            double r = 0.0, g = 0.0, b = 0.0;
            if (h <= 1)
            {
                (r, g, b) = (c, x, 0);
            }
            else if (h <= 2)
            {
                (r, g, b) = (x, c, 0);
            }
            else if (h <= 3)
            {
                (r, g, b) = (0, c, x);
            }
            else if (h <= 4)
            {
                (r, g, b) = (0, x, c);
            }
            else if (h <= 5)
            {
                (r, g, b) = (x, 0, c);
            }
            else if (h <= 6)
            {
                (r, g, b) = (c, 0, x);
            }
            double m = L - c / 2;
            r = (r + m) * 255;
            g = (g + m) * 255;
            b = (b + m) * 255;
            return Color.FromArgb((byte)r, (byte)g, (byte)b);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (originalBmp != null)
                originalBmp.Dispose();
            originalBmp = (Bitmap)Canvas.Image;
        }
    }
}
