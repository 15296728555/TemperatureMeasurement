namespace TemperatureMeasurement
{
    partial class FrmTrendConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrendConfig));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_SetTrend = new System.Windows.Forms.Button();
            this.btn_AddAll = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_DelAll = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.selectListBox = new System.Windows.Forms.ListBox();
            this.unSelectListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_SetTrend);
            this.tabPage1.Controls.Add(this.btn_AddAll);
            this.tabPage1.Controls.Add(this.btn_Add);
            this.tabPage1.Controls.Add(this.btn_DelAll);
            this.tabPage1.Controls.Add(this.btn_Del);
            this.tabPage1.Controls.Add(this.selectListBox);
            this.tabPage1.Controls.Add(this.unSelectListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1115, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "历史曲线配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_SetTrend
            // 
            this.Btn_SetTrend.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_SetTrend.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_SetTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SetTrend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SetTrend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_SetTrend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SetTrend.Location = new System.Drawing.Point(689, 73);
            this.Btn_SetTrend.Name = "Btn_SetTrend";
            this.Btn_SetTrend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_SetTrend.Size = new System.Drawing.Size(102, 39);
            this.Btn_SetTrend.TabIndex = 58;
            this.Btn_SetTrend.Text = "生成曲线参数";
            this.Btn_SetTrend.UseVisualStyleBackColor = false;
            this.Btn_SetTrend.Click += new System.EventHandler(this.Btn_SetTrend_Click_1);
            // 
            // btn_AddAll
            // 
            this.btn_AddAll.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_AddAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_AddAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AddAll.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AddAll.ForeColor = System.Drawing.Color.Black;
            this.btn_AddAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddAll.Location = new System.Drawing.Point(312, 184);
            this.btn_AddAll.Name = "btn_AddAll";
            this.btn_AddAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_AddAll.Size = new System.Drawing.Size(64, 35);
            this.btn_AddAll.TabIndex = 55;
            this.btn_AddAll.Text = ">>";
            this.btn_AddAll.UseVisualStyleBackColor = false;
            this.btn_AddAll.Click += new System.EventHandler(this.btn_AddAll_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.Location = new System.Drawing.Point(312, 143);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Add.Size = new System.Drawing.Size(64, 35);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = ">";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_DelAll
            // 
            this.btn_DelAll.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DelAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_DelAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_DelAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_DelAll.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DelAll.ForeColor = System.Drawing.Color.Black;
            this.btn_DelAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DelAll.Location = new System.Drawing.Point(312, 299);
            this.btn_DelAll.Name = "btn_DelAll";
            this.btn_DelAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_DelAll.Size = new System.Drawing.Size(64, 35);
            this.btn_DelAll.TabIndex = 57;
            this.btn_DelAll.Text = "<<";
            this.btn_DelAll.UseVisualStyleBackColor = false;
            this.btn_DelAll.Click += new System.EventHandler(this.btn_DelAll_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Del.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Del.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Del.ForeColor = System.Drawing.Color.Black;
            this.btn_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Del.Location = new System.Drawing.Point(312, 258);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Del.Size = new System.Drawing.Size(64, 35);
            this.btn_Del.TabIndex = 56;
            this.btn_Del.Text = "<";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // selectListBox
            // 
            this.selectListBox.FormattingEnabled = true;
            this.selectListBox.ItemHeight = 12;
            this.selectListBox.Location = new System.Drawing.Point(445, 70);
            this.selectListBox.Name = "selectListBox";
            this.selectListBox.Size = new System.Drawing.Size(191, 364);
            this.selectListBox.TabIndex = 1;
            // 
            // unSelectListBox
            // 
            this.unSelectListBox.FormattingEnabled = true;
            this.unSelectListBox.ItemHeight = 12;
            this.unSelectListBox.Location = new System.Drawing.Point(27, 70);
            this.unSelectListBox.Name = "unSelectListBox";
            this.unSelectListBox.Size = new System.Drawing.Size(191, 364);
            this.unSelectListBox.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1115, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmTrendConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 637);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTrendConfig";
            this.Text = "FrmTrendConfig";
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.Button Btn_SetTrend;
        protected System.Windows.Forms.Button btn_AddAll;
        protected System.Windows.Forms.Button btn_Add;
        protected System.Windows.Forms.Button btn_DelAll;
        protected System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.ListBox selectListBox;
        private System.Windows.Forms.ListBox unSelectListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}