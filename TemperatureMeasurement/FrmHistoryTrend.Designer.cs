namespace TemperatureMeasurement
{
    partial class FrmHistoryTrend
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
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries2 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            this.chartHistory = new SeeSharpTools.JY.GUI.StripChartX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExportExecle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartHistory
            // 
            this.chartHistory.AutoScroll = true;
            this.chartHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chartHistory.AxisX.AutoScale = false;
            this.chartHistory.AxisX.AutoZoomReset = false;
            this.chartHistory.AxisX.Color = System.Drawing.Color.Black;
            this.chartHistory.AxisX.InitWithScaleView = false;
            this.chartHistory.AxisX.IsLogarithmic = false;
            this.chartHistory.AxisX.LabelAngle = 0;
            this.chartHistory.AxisX.LabelEnabled = true;
            this.chartHistory.AxisX.LabelFormat = null;
            this.chartHistory.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.chartHistory.AxisX.MajorGridCount = 6;
            this.chartHistory.AxisX.MajorGridEnabled = true;
            this.chartHistory.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartHistory.AxisX.Maximum = 1000D;
            this.chartHistory.AxisX.Minimum = 0D;
            this.chartHistory.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.chartHistory.AxisX.MinorGridEnabled = false;
            this.chartHistory.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Solid;
            this.chartHistory.AxisX.TickWidth = 1F;
            this.chartHistory.AxisX.Title = "";
            this.chartHistory.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartHistory.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Far;
            this.chartHistory.AxisX.ViewMaximum = 1000D;
            this.chartHistory.AxisX.ViewMinimum = 0D;
            this.chartHistory.AxisX2.AutoScale = false;
            this.chartHistory.AxisX2.AutoZoomReset = false;
            this.chartHistory.AxisX2.Color = System.Drawing.Color.Black;
            this.chartHistory.AxisX2.InitWithScaleView = false;
            this.chartHistory.AxisX2.IsLogarithmic = false;
            this.chartHistory.AxisX2.LabelAngle = 0;
            this.chartHistory.AxisX2.LabelEnabled = true;
            this.chartHistory.AxisX2.LabelFormat = null;
            this.chartHistory.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.chartHistory.AxisX2.MajorGridCount = 6;
            this.chartHistory.AxisX2.MajorGridEnabled = true;
            this.chartHistory.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartHistory.AxisX2.Maximum = 1000D;
            this.chartHistory.AxisX2.Minimum = 0D;
            this.chartHistory.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.chartHistory.AxisX2.MinorGridEnabled = false;
            this.chartHistory.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartHistory.AxisX2.TickWidth = 1F;
            this.chartHistory.AxisX2.Title = "";
            this.chartHistory.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartHistory.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartHistory.AxisX2.ViewMaximum = 1000D;
            this.chartHistory.AxisX2.ViewMinimum = 0D;
            this.chartHistory.AxisY.AutoScale = true;
            this.chartHistory.AxisY.AutoZoomReset = false;
            this.chartHistory.AxisY.Color = System.Drawing.Color.Black;
            this.chartHistory.AxisY.InitWithScaleView = false;
            this.chartHistory.AxisY.IsLogarithmic = false;
            this.chartHistory.AxisY.LabelAngle = 0;
            this.chartHistory.AxisY.LabelEnabled = true;
            this.chartHistory.AxisY.LabelFormat = null;
            this.chartHistory.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.chartHistory.AxisY.MajorGridCount = 6;
            this.chartHistory.AxisY.MajorGridEnabled = true;
            this.chartHistory.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartHistory.AxisY.Maximum = 3D;
            this.chartHistory.AxisY.Minimum = 0D;
            this.chartHistory.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.chartHistory.AxisY.MinorGridEnabled = false;
            this.chartHistory.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartHistory.AxisY.TickWidth = 1F;
            this.chartHistory.AxisY.Title = "";
            this.chartHistory.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartHistory.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartHistory.AxisY.ViewMaximum = 3.5D;
            this.chartHistory.AxisY.ViewMinimum = 0.5D;
            this.chartHistory.AxisY2.AutoScale = true;
            this.chartHistory.AxisY2.AutoZoomReset = false;
            this.chartHistory.AxisY2.Color = System.Drawing.Color.Black;
            this.chartHistory.AxisY2.InitWithScaleView = false;
            this.chartHistory.AxisY2.IsLogarithmic = false;
            this.chartHistory.AxisY2.LabelAngle = 0;
            this.chartHistory.AxisY2.LabelEnabled = true;
            this.chartHistory.AxisY2.LabelFormat = null;
            this.chartHistory.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.chartHistory.AxisY2.MajorGridCount = 6;
            this.chartHistory.AxisY2.MajorGridEnabled = true;
            this.chartHistory.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartHistory.AxisY2.Maximum = 3D;
            this.chartHistory.AxisY2.Minimum = 0D;
            this.chartHistory.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.chartHistory.AxisY2.MinorGridEnabled = false;
            this.chartHistory.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartHistory.AxisY2.TickWidth = 1F;
            this.chartHistory.AxisY2.Title = "";
            this.chartHistory.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartHistory.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartHistory.AxisY2.ViewMaximum = 3.5D;
            this.chartHistory.AxisY2.ViewMinimum = 0.5D;
            this.chartHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chartHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chartHistory.CausesValidation = false;
            this.chartHistory.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chartHistory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chartHistory.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.chartHistory.DisplayPoints = 4000;
            this.chartHistory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chartHistory.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.chartHistory.LegendBackColor = System.Drawing.Color.Transparent;
            this.chartHistory.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chartHistory.LegendForeColor = System.Drawing.Color.Black;
            this.chartHistory.LegendVisible = true;
            stripChartXSeries1.Color = System.Drawing.Color.Red;
            stripChartXSeries1.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries1.Name = "Series1";
            stripChartXSeries1.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries1.Visible = true;
            stripChartXSeries1.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries2.Color = System.Drawing.Color.Blue;
            stripChartXSeries2.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries2.Name = "Series2";
            stripChartXSeries2.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries2.Visible = false;
            stripChartXSeries2.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries2.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries2.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.chartHistory.LineSeries.Add(stripChartXSeries1);
            this.chartHistory.LineSeries.Add(stripChartXSeries2);
            this.chartHistory.Location = new System.Drawing.Point(1, 1);
            this.chartHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartHistory.Miscellaneous.CheckInfinity = false;
            this.chartHistory.Miscellaneous.CheckNaN = false;
            this.chartHistory.Miscellaneous.CheckNegtiveOrZero = false;
            this.chartHistory.Miscellaneous.DirectionChartCount = 3;
            this.chartHistory.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.chartHistory.Miscellaneous.MaxSeriesCount = 32;
            this.chartHistory.Miscellaneous.MaxSeriesPointCount = 4000;
            this.chartHistory.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.chartHistory.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.chartHistory.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.chartHistory.Miscellaneous.SplitViewAutoLayout = true;
            this.chartHistory.Name = "chartHistory";
            this.chartHistory.NextTimeStamp = new System.DateTime(((long)(0)));
            this.chartHistory.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.chartHistory.SeriesCount = 1;
            this.chartHistory.Size = new System.Drawing.Size(1122, 574);
            this.chartHistory.SplitView = false;
            this.chartHistory.StartIndex = 0;
            this.chartHistory.TabIndex = 0;
            this.chartHistory.TabStop = false;
            this.chartHistory.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.chartHistory.TimeStampFormat = null;
            this.chartHistory.XCursor.AutoInterval = true;
            this.chartHistory.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chartHistory.XCursor.Interval = 0.001D;
            this.chartHistory.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Cursor;
            this.chartHistory.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chartHistory.XCursor.Value = double.NaN;
            this.chartHistory.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.String;
            this.chartHistory.YCursor.AutoInterval = true;
            this.chartHistory.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chartHistory.YCursor.Interval = 0.001D;
            this.chartHistory.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.chartHistory.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chartHistory.YCursor.Value = double.NaN;
            this.chartHistory.AxisViewChanged += new SeeSharpTools.JY.GUI.StripChartX.ViewEvent(this.chartHistory_AxisViewChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartHistory);
            this.splitContainer1.Size = new System.Drawing.Size(1123, 637);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExportExecle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 71);
            this.panel1.TabIndex = 0;
            // 
            // BtnExportExecle
            // 
            this.BtnExportExecle.Location = new System.Drawing.Point(673, 22);
            this.BtnExportExecle.Name = "BtnExportExecle";
            this.BtnExportExecle.Size = new System.Drawing.Size(85, 29);
            this.BtnExportExecle.TabIndex = 32;
            this.BtnExportExecle.Text = "导出";
            this.BtnExportExecle.UseVisualStyleBackColor = true;
            this.BtnExportExecle.Click += new System.EventHandler(this.BtnExportExecle_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(247, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "结束时间:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 37);
            this.label4.TabIndex = 29;
            this.label4.Text = "开始时间:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuery
            // 
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Image = global::TemperatureMeasurement.Properties.Resources.搜索;
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(511, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(96, 30);
            this.btnQuery.TabIndex = 30;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpStart.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(79, 23);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(165, 26);
            this.dtpStart.TabIndex = 27;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEnd.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(322, 23);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(174, 26);
            this.dtpEnd.TabIndex = 26;
            // 
            // FrmHistoryTrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 637);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistoryTrend";
            this.Text = "FrmHistoryTrend";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public SeeSharpTools.JY.GUI.StripChartX chartHistory;
        private System.Windows.Forms.Button BtnExportExecle;
    }
}