namespace TemperatureMeasurement
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LabConnect = new System.Windows.Forms.Label();
            this.lblCommstate = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblLoginlb = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAlarm = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnParameter = new System.Windows.Forms.Button();
            this.BtnLoginPawModif = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDgvShow = new System.Windows.Forms.Button();
            this.BtnRealTime = new System.Windows.Forms.Button();
            this.BtnHFTrend = new System.Windows.Forms.Button();
            this.btnHistoryTrend = new System.Windows.Forms.Button();
            this.BtnHighFrequency = new System.Windows.Forms.Button();
            this.btnTrendConfig = new System.Windows.Forms.Button();
            this.btnMeasureShow = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(44)))), ((int)(((byte)(75)))));
            this.splitContainer1.Panel1.Controls.Add(this.LabConnect);
            this.splitContainer1.Panel1.Controls.Add(this.lblCommstate);
            this.splitContainer1.Panel1.Controls.Add(this.lblLoginName);
            this.splitContainer1.Panel1.Controls.Add(this.lblLoginlb);
            this.splitContainer1.Panel1.Controls.Add(this.lblTime);
            this.splitContainer1.Panel1.Controls.Add(this.lblDate);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 729);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // LabConnect
            // 
            this.LabConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabConnect.Location = new System.Drawing.Point(468, 22);
            this.LabConnect.Name = "LabConnect";
            this.LabConnect.Size = new System.Drawing.Size(159, 39);
            this.LabConnect.TabIndex = 14;
            this.LabConnect.Text = "远程数据库连接错误,网络恢复后双击继续连接";
            this.LabConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabConnect.Click += new System.EventHandler(this.LabConnect_Click);
            // 
            // lblCommstate
            // 
            this.lblCommstate.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCommstate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCommstate.Location = new System.Drawing.Point(766, 22);
            this.lblCommstate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommstate.Name = "lblCommstate";
            this.lblCommstate.Size = new System.Drawing.Size(136, 51);
            this.lblCommstate.TabIndex = 8;
            this.lblCommstate.Text = "通讯正常";
            this.lblCommstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginName
            // 
            this.lblLoginName.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginName.ForeColor = System.Drawing.Color.Lime;
            this.lblLoginName.Location = new System.Drawing.Point(1122, 47);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(104, 35);
            this.lblLoginName.TabIndex = 9;
            this.lblLoginName.Text = "李四";
            this.lblLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginlb
            // 
            this.lblLoginlb.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginlb.ForeColor = System.Drawing.Color.Lime;
            this.lblLoginlb.Location = new System.Drawing.Point(1005, 47);
            this.lblLoginlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginlb.Name = "lblLoginlb";
            this.lblLoginlb.Size = new System.Drawing.Size(120, 35);
            this.lblLoginlb.TabIndex = 10;
            this.lblLoginlb.Text = "登录用户：";
            this.lblLoginlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(1226, 3);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(120, 35);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "20:10:14";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDate.Location = new System.Drawing.Point(1106, 3);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 35);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "2020/1/5";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1005, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "系统时间：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Image = global::TemperatureMeasurement.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MainPanel);
            this.splitContainer2.Size = new System.Drawing.Size(1350, 637);
            this.splitContainer2.SplitterDistance = 226;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(44)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.BtnAlarm);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.btnParameter);
            this.panel1.Controls.Add(this.BtnLoginPawModif);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDgvShow);
            this.panel1.Controls.Add(this.BtnRealTime);
            this.panel1.Controls.Add(this.BtnHFTrend);
            this.panel1.Controls.Add(this.btnHistoryTrend);
            this.panel1.Controls.Add(this.BtnHighFrequency);
            this.panel1.Controls.Add(this.btnTrendConfig);
            this.panel1.Controls.Add(this.btnMeasureShow);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 637);
            this.panel1.TabIndex = 0;
            // 
            // BtnAlarm
            // 
            this.BtnAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.BtnAlarm.Location = new System.Drawing.Point(12, 384);
            this.BtnAlarm.Name = "BtnAlarm";
            this.BtnAlarm.Size = new System.Drawing.Size(90, 46);
            this.BtnAlarm.TabIndex = 9;
            this.BtnAlarm.Text = "报警日志";
            this.BtnAlarm.UseVisualStyleBackColor = false;
            this.BtnAlarm.Click += new System.EventHandler(this.BtnAlarm_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(226, 32);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.SystemColors.Control;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(85, 27);
            this.lblVersion.Text = " 版本号：V1.0";
            // 
            // btnParameter
            // 
            this.btnParameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnParameter.Location = new System.Drawing.Point(11, 269);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Size = new System.Drawing.Size(91, 46);
            this.btnParameter.TabIndex = 7;
            this.btnParameter.Text = "参 数 设 置";
            this.btnParameter.UseVisualStyleBackColor = false;
            this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
            // 
            // BtnLoginPawModif
            // 
            this.BtnLoginPawModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.BtnLoginPawModif.Location = new System.Drawing.Point(12, 325);
            this.BtnLoginPawModif.Name = "BtnLoginPawModif";
            this.BtnLoginPawModif.Size = new System.Drawing.Size(90, 46);
            this.BtnLoginPawModif.TabIndex = 6;
            this.BtnLoginPawModif.Text = "登录密码修改";
            this.BtnLoginPawModif.UseVisualStyleBackColor = false;
            this.BtnLoginPawModif.Click += new System.EventHandler(this.BtnLoginPawModif_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnExit.Location = new System.Drawing.Point(107, 530);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDgvShow
            // 
            this.btnDgvShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnDgvShow.Location = new System.Drawing.Point(11, 208);
            this.btnDgvShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnDgvShow.Name = "btnDgvShow";
            this.btnDgvShow.Size = new System.Drawing.Size(91, 43);
            this.btnDgvShow.TabIndex = 4;
            this.btnDgvShow.Text = "数据表格显示";
            this.btnDgvShow.UseVisualStyleBackColor = false;
            this.btnDgvShow.Click += new System.EventHandler(this.btnDgvShow_Click);
            // 
            // BtnRealTime
            // 
            this.BtnRealTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.BtnRealTime.Location = new System.Drawing.Point(105, 447);
            this.BtnRealTime.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRealTime.Name = "BtnRealTime";
            this.BtnRealTime.Size = new System.Drawing.Size(91, 46);
            this.BtnRealTime.TabIndex = 5;
            this.BtnRealTime.Text = "实 时 曲 线";
            this.BtnRealTime.UseVisualStyleBackColor = false;
            this.BtnRealTime.Click += new System.EventHandler(this.BtnRealTime_Click);
            // 
            // BtnHFTrend
            // 
            this.BtnHFTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.BtnHFTrend.Location = new System.Drawing.Point(107, 384);
            this.BtnHFTrend.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHFTrend.Name = "BtnHFTrend";
            this.BtnHFTrend.Size = new System.Drawing.Size(90, 46);
            this.BtnHFTrend.TabIndex = 5;
            this.BtnHFTrend.Text = "历 史 曲 线";
            this.BtnHFTrend.UseVisualStyleBackColor = false;
            // 
            // btnHistoryTrend
            // 
            this.btnHistoryTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnHistoryTrend.Location = new System.Drawing.Point(106, 326);
            this.btnHistoryTrend.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistoryTrend.Name = "btnHistoryTrend";
            this.btnHistoryTrend.Size = new System.Drawing.Size(90, 46);
            this.btnHistoryTrend.TabIndex = 5;
            this.btnHistoryTrend.Text = "历 史 曲 线";
            this.btnHistoryTrend.UseVisualStyleBackColor = false;
            this.btnHistoryTrend.Click += new System.EventHandler(this.btnHistoryTrend_Click);
            // 
            // BtnHighFrequency
            // 
            this.BtnHighFrequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.BtnHighFrequency.Location = new System.Drawing.Point(105, 269);
            this.BtnHighFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHighFrequency.Name = "BtnHighFrequency";
            this.BtnHighFrequency.Size = new System.Drawing.Size(91, 43);
            this.BtnHighFrequency.TabIndex = 5;
            this.BtnHighFrequency.Text = "高频数据查看";
            this.BtnHighFrequency.UseVisualStyleBackColor = false;
            this.BtnHighFrequency.Click += new System.EventHandler(this.BtnHighFrequency_Click);
            // 
            // btnTrendConfig
            // 
            this.btnTrendConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnTrendConfig.Location = new System.Drawing.Point(106, 208);
            this.btnTrendConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrendConfig.Name = "btnTrendConfig";
            this.btnTrendConfig.Size = new System.Drawing.Size(91, 43);
            this.btnTrendConfig.TabIndex = 5;
            this.btnTrendConfig.Text = "曲线配置界面";
            this.btnTrendConfig.UseVisualStyleBackColor = false;
            this.btnTrendConfig.Click += new System.EventHandler(this.btnTrendConfig_Click);
            // 
            // btnMeasureShow
            // 
            this.btnMeasureShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnMeasureShow.Location = new System.Drawing.Point(12, 447);
            this.btnMeasureShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnMeasureShow.Name = "btnMeasureShow";
            this.btnMeasureShow.Size = new System.Drawing.Size(90, 43);
            this.btnMeasureShow.TabIndex = 5;
            this.btnMeasureShow.Text = "测量结果显示";
            this.btnMeasureShow.UseVisualStyleBackColor = false;
            this.btnMeasureShow.Click += new System.EventHandler(this.btnMeasureShow_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(3, 2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1123, 637);
            this.MainPanel.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "3D成型玻璃";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblCommstate;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblLoginlb;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDgvShow;
        private System.Windows.Forms.Button btnMeasureShow;
        private System.Windows.Forms.Button BtnLoginPawModif;
        private System.Windows.Forms.Button btnParameter;
        private System.Windows.Forms.Button btnTrendConfig;
        private System.Windows.Forms.Button btnHistoryTrend;
        private System.Windows.Forms.Button BtnRealTime;
        private System.Windows.Forms.Label LabConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.Button BtnAlarm;
        private System.Windows.Forms.Button BtnHighFrequency;
        private System.Windows.Forms.Button BtnHFTrend;
    }
}

