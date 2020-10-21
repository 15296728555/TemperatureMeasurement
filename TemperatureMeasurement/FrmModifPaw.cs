using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMeasurement
{
    public partial class FrmModifPaw : Form
    {
        public FrmModifPaw()
        {
            InitializeComponent();
        }
        
        public FrmModifPaw(string str)
        {
         
            InitializeComponent();
            txbLoginUser.Text = str;
        }








        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            //string sql = $"select loginpwd,loginname from sysadmins where loginname='{txbOldLoginPwd.Text.Trim() }'  and  loginpwd='{txbModifPaw.Text.Trim()}'";
         
            string sqlModif = $" update  SysAdmins set LoginPwd='{txbModifPaw.Text.Trim()}'  where  LoginName='{txbLoginUser.Text.Trim()}'";


            if (txbOldLoginPwd.Text.Trim().Length<6&&txbModifPaw.Text.Trim().Length<6)
            {
                MessageBox.Show("密码长度不能小于6", "提示");
                return;
            }

            if(txbOldLoginPwd.Text.Trim()!=CommonMethods.objAdmins.LoginPwd)
            {
                MessageBox.Show("旧密码输入错误，请重新输入", "提示");
                return;

            }
            if (txbModifPaw.Text.Trim() != txbPawConfirm.Text.Trim())
            {
                MessageBox.Show("新密码输入不一致，请重新输入", "提示");
                return;

            }

            try
            {

                if (SQLHelper.Update(sqlModif) ==1)
                {
                    MessageBox.Show("密码修改成功，请妥善保管", "提示");
                    CommonMethods.objAdmins.LoginPwd = txbModifPaw.Text.Trim();
                    this.Close();
                }
             


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "错误提示");
            }
            
           

        }
    }
}
