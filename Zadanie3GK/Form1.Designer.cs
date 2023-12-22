namespace Zadanie3GK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.chartR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.funChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.modeBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.RadioButton();
            this.negButton = new System.Windows.Forms.RadioButton();
            this.gammaButton = new System.Windows.Forms.RadioButton();
            this.contrastButton = new System.Windows.Forms.RadioButton();
            this.lightButton = new System.Windows.Forms.RadioButton();
            this.valueNum = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBox = new System.Windows.Forms.GroupBox();
            this.radiusNum = new System.Windows.Forms.NumericUpDown();
            this.hslButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hueBar = new System.Windows.Forms.TrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.bBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(12, 41);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(600, 600);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseLeave += new System.EventHandler(this.Canvas_MouseLeave);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            // 
            // chartR
            // 
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chartR.ChartAreas.Add(chartArea1);
            this.chartR.Location = new System.Drawing.Point(623, 40);
            this.chartR.Name = "chartR";
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Name = "Series1";
            this.chartR.Series.Add(series1);
            this.chartR.Size = new System.Drawing.Size(359, 140);
            this.chartR.TabIndex = 1;
            this.chartR.Text = "chart1";
            // 
            // chartG
            // 
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea2.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chartG.ChartAreas.Add(chartArea2);
            this.chartG.Location = new System.Drawing.Point(623, 186);
            this.chartG.Name = "chartG";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.Name = "Series1";
            this.chartG.Series.Add(series2);
            this.chartG.Size = new System.Drawing.Size(359, 140);
            this.chartG.TabIndex = 2;
            this.chartG.Text = "chart1";
            // 
            // chartB
            // 
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea3.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chartB.ChartAreas.Add(chartArea3);
            this.chartB.Location = new System.Drawing.Point(623, 332);
            this.chartB.Name = "chartB";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series3.Name = "Series1";
            this.chartB.Series.Add(series3);
            this.chartB.Size = new System.Drawing.Size(359, 140);
            this.chartB.TabIndex = 3;
            this.chartB.Text = "chart1";
            // 
            // funChart
            // 
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.MajorGrid.Interval = 51D;
            chartArea4.AxisX.Maximum = 255D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.MajorGrid.Interval = 85D;
            chartArea4.AxisY.Maximum = 255D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.funChart.ChartAreas.Add(chartArea4);
            this.funChart.Location = new System.Drawing.Point(623, 489);
            this.funChart.Name = "funChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series4.MarkerSize = 15;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "Series1";
            this.funChart.Series.Add(series4);
            this.funChart.Size = new System.Drawing.Size(735, 140);
            this.funChart.TabIndex = 4;
            this.funChart.Text = "funChart";
            this.funChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.funChart_MouseDown);
            this.funChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.funChart_MouseMove);
            this.funChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.funChart_MouseUp);
            // 
            // modeBox
            // 
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Location = new System.Drawing.Point(1116, 41);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(121, 24);
            this.modeBox.TabIndex = 5;
            this.modeBox.SelectedIndexChanged += new System.EventHandler(this.modeBox_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1116, 72);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset Image";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // customButton
            // 
            this.customButton.AutoSize = true;
            this.customButton.Checked = true;
            this.customButton.Location = new System.Drawing.Point(1116, 101);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(126, 20);
            this.customButton.TabIndex = 7;
            this.customButton.TabStop = true;
            this.customButton.Text = "Custom Function";
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.CheckedChanged += new System.EventHandler(this.customButton_CheckedChanged);
            // 
            // negButton
            // 
            this.negButton.AutoSize = true;
            this.negButton.Location = new System.Drawing.Point(1116, 128);
            this.negButton.Name = "negButton";
            this.negButton.Size = new System.Drawing.Size(136, 20);
            this.negButton.TabIndex = 8;
            this.negButton.Text = "Negation Function";
            this.negButton.UseVisualStyleBackColor = true;
            this.negButton.CheckedChanged += new System.EventHandler(this.negButton_CheckedChanged);
            // 
            // gammaButton
            // 
            this.gammaButton.AutoSize = true;
            this.gammaButton.Location = new System.Drawing.Point(1116, 155);
            this.gammaButton.Name = "gammaButton";
            this.gammaButton.Size = new System.Drawing.Size(140, 20);
            this.gammaButton.TabIndex = 9;
            this.gammaButton.Text = "Gamma Correction";
            this.gammaButton.UseVisualStyleBackColor = true;
            this.gammaButton.CheckedChanged += new System.EventHandler(this.gammaButton_CheckedChanged);
            // 
            // contrastButton
            // 
            this.contrastButton.AutoSize = true;
            this.contrastButton.Location = new System.Drawing.Point(1116, 181);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(77, 20);
            this.contrastButton.TabIndex = 10;
            this.contrastButton.Text = "Contrast";
            this.contrastButton.UseVisualStyleBackColor = true;
            this.contrastButton.CheckedChanged += new System.EventHandler(this.contrastButton_CheckedChanged);
            // 
            // lightButton
            // 
            this.lightButton.AutoSize = true;
            this.lightButton.Location = new System.Drawing.Point(1116, 208);
            this.lightButton.Name = "lightButton";
            this.lightButton.Size = new System.Drawing.Size(106, 20);
            this.lightButton.TabIndex = 11;
            this.lightButton.Text = "Light Change";
            this.lightButton.UseVisualStyleBackColor = true;
            this.lightButton.CheckedChanged += new System.EventHandler(this.lightButton_CheckedChanged);
            // 
            // valueNum
            // 
            this.valueNum.Enabled = false;
            this.valueNum.Location = new System.Drawing.Point(1116, 235);
            this.valueNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.valueNum.Name = "valueNum";
            this.valueNum.Size = new System.Drawing.Size(120, 22);
            this.valueNum.TabIndex = 12;
            this.valueNum.ValueChanged += new System.EventHandler(this.valueNum_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1388, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // bBox
            // 
            this.bBox.Controls.Add(this.radiusNum);
            this.bBox.Location = new System.Drawing.Point(1267, 40);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(100, 55);
            this.bBox.TabIndex = 14;
            this.bBox.TabStop = false;
            this.bBox.Text = "Brush radius";
            this.bBox.Visible = false;
            // 
            // radiusNum
            // 
            this.radiusNum.Location = new System.Drawing.Point(6, 21);
            this.radiusNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.radiusNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radiusNum.Name = "radiusNum";
            this.radiusNum.Size = new System.Drawing.Size(85, 22);
            this.radiusNum.TabIndex = 0;
            this.radiusNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.radiusNum.ValueChanged += new System.EventHandler(this.radiusNum_ValueChanged);
            // 
            // hslButton
            // 
            this.hslButton.Location = new System.Drawing.Point(1116, 290);
            this.hslButton.Name = "hslButton";
            this.hslButton.Size = new System.Drawing.Size(172, 23);
            this.hslButton.TabIndex = 15;
            this.hslButton.Text = "HSL Color";
            this.hslButton.UseVisualStyleBackColor = true;
            this.hslButton.Click += new System.EventHandler(this.hslButton_Click);
            // 
            // hueBar
            // 
            this.hueBar.Location = new System.Drawing.Point(1116, 320);
            this.hueBar.Maximum = 359;
            this.hueBar.Name = "hueBar";
            this.hueBar.Size = new System.Drawing.Size(172, 56);
            this.hueBar.TabIndex = 16;
            this.hueBar.Scroll += new System.EventHandler(this.hueBar_Scroll);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(988, 71);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1388, 653);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.hueBar);
            this.Controls.Add(this.hslButton);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.valueNum);
            this.Controls.Add(this.lightButton);
            this.Controls.Add(this.contrastButton);
            this.Controls.Add(this.gammaButton);
            this.Controls.Add(this.negButton);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.funChart);
            this.Controls.Add(this.chartB);
            this.Controls.Add(this.chartG);
            this.Controls.Add(this.chartR);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radiusNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
        private System.Windows.Forms.DataVisualization.Charting.Chart funChart;
        private System.Windows.Forms.ComboBox modeBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RadioButton customButton;
        private System.Windows.Forms.RadioButton negButton;
        private System.Windows.Forms.RadioButton gammaButton;
        private System.Windows.Forms.RadioButton contrastButton;
        private System.Windows.Forms.RadioButton lightButton;
        private System.Windows.Forms.NumericUpDown valueNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox bBox;
        private System.Windows.Forms.NumericUpDown radiusNum;
        private System.Windows.Forms.Button hslButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar hueBar;
        private System.Windows.Forms.Button saveButton;
    }
}

