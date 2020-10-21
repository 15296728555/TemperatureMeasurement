namespace TemperatureMeasurement
{
    partial class FrmModifPaw
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
            this.txbOldLoginPwd = new System.Windows.Forms.TextBox();
            this.txbLoginUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbModifPaw = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPawConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbOldLoginPwd
            // 
            this.txbOldLoginPwd.Location = new System.Drawing.Point(194, 81);
            this.txbOldLoginPwd.Name = "txbOldLoginPwd";
            this.txbOldLoginPwd.PasswordChar = '*';
            this.txbOldLoginPwd.Size = new System.Drawing.Size(138, 21);
            this.txbOldLoginPwd.TabIndex = 21;
            // 
            // txbLoginUser
            // 
            this.txbLoginUser.Enabled = false;
            this.txbLoginUser.Location = new System.Drawing.Point(194, 41);
            this.txbLoginUser.Name = "txbLoginUser";
            this.txbLoginUser.Size = new System.Drawing.Size(138, 21);
            this.txbLoginUser.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "原 密 码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "登录用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(53, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "新 密 码：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbModifPaw
            // 
            this.txbModifPaw.Location = new System.Drawing.Point(194, 122);
            this.txbModifPaw.Name = "txbModifPaw";
            this.txbModifPaw.PasswordChar = '*';
            this.txbModifPaw.Size = new System.Drawing.Size(138, 21);
            this.txbModifPaw.TabIndex = 21;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(132, 199);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(90, 30);
            this.btnModif.TabIndex = 24;
            this.btnModif.Text = "确定";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(263, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(53, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "密码确认：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbPawConfirm
            // 
            this.txbPawConfirm.Location = new System.Drawing.Point(194, 161);
            this.txbPawConfirm.Name = "txbPawConfirm";
            this.txbPawConfirm.PasswordChar = '*';
            this.txbPawConfirm.Size = new System.Drawing.Size(138, 21);
            this.txbPawConfirm.TabIndex = 21;
            // 
            // FrmModifPaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.txbPawConfirm);
            this.Controls.Add(this.txbModifPaw);
            this.Controls.Add(this.txbOldLoginPwd);
            this.Controls.Add(this.txbLoginUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifPaw";
            this.Text = "FrmModifPaw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOldLoginPwd;
        private System.Windows.Forms.TextBox txbLoginUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbModifPaw;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPawConfirm;
    }
}