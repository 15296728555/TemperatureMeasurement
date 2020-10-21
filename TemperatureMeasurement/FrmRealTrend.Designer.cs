namespace TemperatureMeasurement
{
    partial class FrmRealTrend
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
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries1 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnTrendConfig = new System.Windows.Forms.Button();
            this.chart_Trend = new SeeSharpTools.JY.GUI.StripChartX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(185)))), ((int)(((byte)(193)))));
            this.splitContainer1.Panel1.Controls.Add(this.MainPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart_Trend);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 634);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BtnTrendConfig);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(154, 634);
            this.MainPanel.TabIndex = 0;
            // 
            // BtnTrendConfig
            // 
            this.BtnTrendConfig.Location = new System.Drawing.Point(37, 577);
            this.BtnTrendConfig.Name = "BtnTrendConfig";
            this.BtnTrendConfig.Size = new System.Drawing.Size(92, 35);
            this.BtnTrendConfig.TabIndex = 0;
            this.BtnTrendConfig.Text = "实时趋势配置";
            this.BtnTrendConfig.UseVisualStyleBackColor = true;
            this.BtnTrendConfig.Click += new System.EventHandler(this.BtnTrendConfig_Click);
            // 
            // chart_Trend
            // 
            this.chart_Trend.AxisX.AutoScale = false;
            this.chart_Trend.AxisX.AutoZoomReset = false;
            this.chart_Trend.AxisX.Color = System.Drawing.Color.Black;
            this.chart_Trend.AxisX.InitWithScaleView = false;
            this.chart_Trend.AxisX.IsLogarithmic = false;
            this.chart_Trend.AxisX.LabelAngle = 0;
            this.chart_Trend.AxisX.LabelEnabled = true;
            this.chart_Trend.AxisX.LabelFormat = null;
            this.chart_Trend.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.chart_Trend.AxisX.MajorGridCount = 6;
            this.chart_Trend.AxisX.MajorGridEnabled = true;
            this.chart_Trend.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_Trend.AxisX.Maximum = 1000D;
            this.chart_Trend.AxisX.Minimum = 0D;
            this.chart_Trend.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.chart_Trend.AxisX.MinorGridEnabled = false;
            this.chart_Trend.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_Trend.AxisX.TickWidth = 1F;
            this.chart_Trend.AxisX.Title = "";
            this.chart_Trend.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_Trend.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_Trend.AxisX.ViewMaximum = 1000D;
            this.chart_Trend.AxisX.ViewMinimum = 0D;
            this.chart_Trend.AxisX2.AutoScale = false;
            this.chart_Trend.AxisX2.AutoZoomReset = false;
            this.chart_Trend.AxisX2.Color = System.Drawing.Color.Black;
            this.chart_Trend.AxisX2.InitWithScaleView = false;
            this.chart_Trend.AxisX2.IsLogarithmic = false;
            this.chart_Trend.AxisX2.LabelAngle = 0;
            this.chart_Trend.AxisX2.LabelEnabled = true;
            this.chart_Trend.AxisX2.LabelFormat = null;
            this.chart_Trend.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.chart_Trend.AxisX2.MajorGridCount = 6;
            this.chart_Trend.AxisX2.MajorGridEnabled = true;
            this.chart_Trend.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_Trend.AxisX2.Maximum = 1000D;
            this.chart_Trend.AxisX2.Minimum = 0D;
            this.chart_Trend.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.chart_Trend.AxisX2.MinorGridEnabled = false;
            this.chart_Trend.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_Trend.AxisX2.TickWidth = 1F;
            this.chart_Trend.AxisX2.Title = "";
            this.chart_Trend.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_Trend.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_Trend.AxisX2.ViewMaximum = 1000D;
            this.chart_Trend.AxisX2.ViewMinimum = 0D;
            this.chart_Trend.AxisY.AutoScale = true;
            this.chart_Trend.AxisY.AutoZoomReset = false;
            this.chart_Trend.AxisY.Color = System.Drawing.Color.Black;
            this.chart_Trend.AxisY.InitWithScaleView = false;
            this.chart_Trend.AxisY.IsLogarithmic = false;
            this.chart_Trend.AxisY.LabelAngle = 0;
            this.chart_Trend.AxisY.LabelEnabled = true;
            this.chart_Trend.AxisY.LabelFormat = null;
            this.chart_Trend.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.chart_Trend.AxisY.MajorGridCount = 6;
            this.chart_Trend.AxisY.MajorGridEnabled = true;
            this.chart_Trend.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_Trend.AxisY.Maximum = 3D;
            this.chart_Trend.AxisY.Minimum = 0D;
            this.chart_Trend.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.chart_Trend.AxisY.MinorGridEnabled = false;
            this.chart_Trend.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_Trend.AxisY.TickWidth = 1F;
            this.chart_Trend.AxisY.Title = "";
            this.chart_Trend.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_Trend.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_Trend.AxisY.ViewMaximum = 3.5D;
            this.chart_Trend.AxisY.ViewMinimum = 0.5D;
            this.chart_Trend.AxisY2.AutoScale = true;
            this.chart_Trend.AxisY2.AutoZoomReset = false;
            this.chart_Trend.AxisY2.Color = System.Drawing.Color.Black;
            this.chart_Trend.AxisY2.InitWithScaleView = false;
            this.chart_Trend.AxisY2.IsLogarithmic = false;
            this.chart_Trend.AxisY2.LabelAngle = 0;
            this.chart_Trend.AxisY2.LabelEnabled = true;
            this.chart_Trend.AxisY2.LabelFormat = null;
            this.chart_Trend.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.chart_Trend.AxisY2.MajorGridCount = 6;
            this.chart_Trend.AxisY2.MajorGridEnabled = true;
            this.chart_Trend.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chart_Trend.AxisY2.Maximum = 3.5D;
            this.chart_Trend.AxisY2.Minimum = 0.5D;
            this.chart_Trend.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.chart_Trend.AxisY2.MinorGridEnabled = false;
            this.chart_Trend.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chart_Trend.AxisY2.TickWidth = 1F;
            this.chart_Trend.AxisY2.Title = "";
            this.chart_Trend.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chart_Trend.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chart_Trend.AxisY2.ViewMaximum = 3.5D;
            this.chart_Trend.AxisY2.ViewMinimum = 0.5D;
            this.chart_Trend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(185)))), ((int)(((byte)(193)))));
            this.chart_Trend.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(185)))), ((int)(((byte)(193)))));
            this.chart_Trend.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.chart_Trend.DisplayPoints = 4000;
            this.chart_Trend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_Trend.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chart_Trend.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.chart_Trend.LegendBackColor = System.Drawing.Color.Transparent;
            this.chart_Trend.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chart_Trend.LegendForeColor = System.Drawing.Color.Black;
            this.chart_Trend.LegendVisible = true;
            stripChartXSeries1.Color = System.Drawing.Color.Red;
            stripChartXSeries1.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries1.Name = "Series1";
            stripChartXSeries1.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries1.Visible = true;
            stripChartXSeries1.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.chart_Trend.LineSeries.Add(stripChartXSeries1);
            this.chart_Trend.Location = new System.Drawing.Point(0, 0);
            this.chart_Trend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_Trend.Miscellaneous.CheckInfinity = false;
            this.chart_Trend.Miscellaneous.CheckNaN = false;
            this.chart_Trend.Miscellaneous.CheckNegtiveOrZero = false;
            this.chart_Trend.Miscellaneous.DirectionChartCount = 3;
            this.chart_Trend.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.chart_Trend.Miscellaneous.MaxSeriesCount = 32;
            this.chart_Trend.Miscellaneous.MaxSeriesPointCount = 4000;
            this.chart_Trend.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.chart_Trend.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.chart_Trend.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.chart_Trend.Miscellaneous.SplitViewAutoLayout = true;
            this.chart_Trend.Name = "chart_Trend";
            this.chart_Trend.NextTimeStamp = new System.DateTime(((long)(0)));
            this.chart_Trend.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.chart_Trend.SeriesCount = 1;
            this.chart_Trend.Size = new System.Drawing.Size(978, 634);
            this.chart_Trend.SplitView = false;
            this.chart_Trend.StartIndex = 0;
            this.chart_Trend.TabIndex = 1;
            this.chart_Trend.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.chart_Trend.TimeStampFormat = null;
            this.chart_Trend.XCursor.AutoInterval = true;
            this.chart_Trend.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chart_Trend.XCursor.Interval = 0.001D;
            this.chart_Trend.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Zoom;
            this.chart_Trend.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chart_Trend.XCursor.Value = double.NaN;
            this.chart_Trend.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.Index;
            this.chart_Trend.YCursor.AutoInterval = true;
            this.chart_Trend.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chart_Trend.YCursor.Interval = 0.001D;
            this.chart_Trend.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.chart_Trend.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chart_Trend.YCursor.Value = double.NaN;
            // 
            // FrmRealTrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 634);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRealTrend";
            this.Text = "FrmRealTrend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRealTrend_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnTrendConfig;
        private SeeSharpTools.JY.GUI.StripChartX chart_Trend;
        private System.Windows.Forms.Panel MainPanel;
    }
}