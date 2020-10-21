namespace TemperatureMeasurement
{
    partial class FrmRealTrendConfig
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
            this.Btn_SetTrend = new System.Windows.Forms.Button();
            this.btn_AddAll = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_DelAll = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.selectListBox = new System.Windows.Forms.ListBox();
            this.unSelectListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btn_SetTrend
            // 
            this.Btn_SetTrend.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_SetTrend.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_SetTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SetTrend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SetTrend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_SetTrend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SetTrend.Location = new System.Drawing.Point(562, 62);
            this.Btn_SetTrend.Name = "Btn_SetTrend";
            this.Btn_SetTrend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_SetTrend.Size = new System.Drawing.Size(102, 39);
            this.Btn_SetTrend.TabIndex = 65;
            this.Btn_SetTrend.Text = "生成曲线参数";
            this.Btn_SetTrend.UseVisualStyleBackColor = false;
            this.Btn_SetTrend.Click += new System.EventHandler(this.Btn_SetTrend_Click);
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
            this.btn_AddAll.Location = new System.Drawing.Point(252, 174);
            this.btn_AddAll.Name = "btn_AddAll";
            this.btn_AddAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_AddAll.Size = new System.Drawing.Size(64, 35);
            this.btn_AddAll.TabIndex = 62;
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
            this.btn_Add.Location = new System.Drawing.Point(252, 133);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Add.Size = new System.Drawing.Size(64, 35);
            this.btn_Add.TabIndex = 61;
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
            this.btn_DelAll.Location = new System.Drawing.Point(252, 289);
            this.btn_DelAll.Name = "btn_DelAll";
            this.btn_DelAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_DelAll.Size = new System.Drawing.Size(64, 35);
            this.btn_DelAll.TabIndex = 64;
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
            this.btn_Del.Location = new System.Drawing.Point(252, 248);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Del.Size = new System.Drawing.Size(64, 35);
            this.btn_Del.TabIndex = 63;
            this.btn_Del.Text = "<";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // selectListBox
            // 
            this.selectListBox.FormattingEnabled = true;
            this.selectListBox.ItemHeight = 12;
            this.selectListBox.Location = new System.Drawing.Point(345, 59);
            this.selectListBox.Name = "selectListBox";
            this.selectListBox.Size = new System.Drawing.Size(191, 364);
            this.selectListBox.TabIndex = 60;
            // 
            // unSelectListBox
            // 
            this.unSelectListBox.FormattingEnabled = true;
            this.unSelectListBox.ItemHeight = 12;
            this.unSelectListBox.Location = new System.Drawing.Point(11, 57);
            this.unSelectListBox.Name = "unSelectListBox";
            this.unSelectListBox.Size = new System.Drawing.Size(191, 364);
            this.unSelectListBox.TabIndex = 59;
            // 
            // FrmRealTrendConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 548);
            this.Controls.Add(this.Btn_SetTrend);
            this.Controls.Add(this.btn_AddAll);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_DelAll);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.selectListBox);
            this.Controls.Add(this.unSelectListBox);
            this.Name = "FrmRealTrendConfig";
            this.Text = "FrmRealTrendConfig";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button Btn_SetTrend;
        protected System.Windows.Forms.Button btn_AddAll;
        protected System.Windows.Forms.Button btn_Add;
        protected System.Windows.Forms.Button btn_DelAll;
        protected System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.ListBox selectListBox;
        private System.Windows.Forms.ListBox unSelectListBox;
    }
}