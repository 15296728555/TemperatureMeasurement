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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCommstate = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblLoginlb = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginPawModif = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnDgvShow = new System.Windows.Forms.Button();
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
            this.lblDate.ForeColor = System.Drawing.Color.Lime;
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
            this.panel1.Controls.Add(this.btnLoginPawModif);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.btnDgvShow);
            this.panel1.Controls.Add(this.btnMeasureShow);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 637);
            this.panel1.TabIndex = 0;
            // 
            // btnLoginPawModif
            // 
            this.btnLoginPawModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnLoginPawModif.Location = new System.Drawing.Point(12, 387);
            this.btnLoginPawModif.Name = "btnLoginPawModif";
            this.btnLoginPawModif.Size = new System.Drawing.Size(90, 46);
            this.btnLoginPawModif.TabIndex = 6;
            this.btnLoginPawModif.Text = "登录密码修改";
            this.btnLoginPawModif.UseVisualStyleBackColor = false;
            this.btnLoginPawModif.Click += new System.EventHandler(this.btnLoginPawModif_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnExit.Location = new System.Drawing.Point(55, 550);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnConfig.Location = new System.Drawing.Point(11, 330);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(91, 43);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "参数设置";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnDgvShow_Click);
            // 
            // btnDgvShow
            // 
            this.btnDgvShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnDgvShow.Location = new System.Drawing.Point(11, 272);
            this.btnDgvShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnDgvShow.Name = "btnDgvShow";
            this.btnDgvShow.Size = new System.Drawing.Size(91, 43);
            this.btnDgvShow.TabIndex = 4;
            this.btnDgvShow.Text = "数据表格显示";
            this.btnDgvShow.UseVisualStyleBackColor = false;
            this.btnDgvShow.Click += new System.EventHandler(this.btnDgvShow_Click);
            // 
            // btnMeasureShow
            // 
            this.btnMeasureShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(163)))));
            this.btnMeasureShow.Location = new System.Drawing.Point(11, 210);
            this.btnMeasureShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnMeasureShow.Name = "btnMeasureShow";
            this.btnMeasureShow.Size = new System.Drawing.Size(91, 43);
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
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnLoginPawModif;
    }
}

