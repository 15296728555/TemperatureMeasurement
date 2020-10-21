using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace TemperatureMeasurement
{
    public partial class FrmParameter : Form
    {
        public FrmParameter()
        {
            InitializeComponent();
            Load += FrmParameter_Load;
        }
        private DAL.IniConfigHelper inihelper = new IniConfigHelper();
   

        public SetInterval Setval;
        private void FrmParameter_Load(object sender, EventArgs e)
        {
           
            cmbTimeInterval.DataSource = new string[] { "500", "800"  , "1000", "2000", "3000", "5000", "10000", "50000", "100000" };
      
            cmbTimeInterval.Text = inihelper.ReadIniData("参数", "Interval", "", CommonMethods.FilePath);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!File.Exists(CommonMethods.FilePath))
            //{
                //FileStream fs = new FileStream(CommonMethods.FilePath, FileMode.Create);
                //fs.Close();
            //}
            //else
            //{
             
                if (inihelper.WriteIniData("参数", "Interval", cmbTimeInterval.Text.Trim(), CommonMethods.FilePath))
                {
                    Setval(Convert.ToInt32(cmbTimeInterval.Text.Trim()));
                    MessageBox.Show("保存成功", "保存参数");
                }
                else
                {
                    MessageBox.Show("保存失败", "保存参数");
                }







            //}

        }
    }
}
