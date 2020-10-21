using DAL;
using Entity;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //SQLiteHelper.ConStr = "Data Source=" + Application.StartupPath + "\\DB\\JDT;Pooling=true;FaillfMissing=false";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (txbLoginID.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写登录ID", "登录提示");
                txbLoginID.Focus();
                return;
            }
            if (txbLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写登录密码", "登录提示");
                txbLoginPwd.Focus();
                return;
            }
            SysAdmins objAdmins = new SysAdmins()
            {
                LoginId = Convert.ToInt32(txbLoginID.Text.Trim()),
                LoginPwd = txbLoginPwd.Text.Trim()

            };

            objAdmins = adminsLogin(objAdmins);
            if (objAdmins == null)
            {
                MessageBox.Show("用户名或密码错误", "登录提示'");
                return;


            }
            else
            {
               
                CommonMethods.objAdmins = objAdmins;
                DialogResult = DialogResult.OK;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private SysAdmins adminsLogin(SysAdmins objadmins)
        {
            string sql = $"select LoginName ,Role from SysAdmins where LoginId={objadmins.LoginId} and LoginPwd={objadmins.LoginPwd}";
            DataSet ds = SQLHelper.GetDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
            {
                objadmins.LoginName = ds.Tables[0].Rows[0]["LoginName"].ToString();
                objadmins.Role = Convert.ToInt32(ds.Tables[0].Rows[0]["Role"]);
                return objadmins;
            }
            else
            {
                return null;
            }


        }

      
    }
}
