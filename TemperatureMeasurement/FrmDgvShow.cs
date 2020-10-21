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
    public partial class FrmDgvShow : Form
    {
        public FrmDgvShow()
        {
            InitializeComponent();
            this.dgv.AutoGenerateColumns = false;
        }

        

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string start=  dtpStart.Text.Trim();
            string end =dtpEnd.Text.Trim();
        

            this.dgv.DataSource = null;

            this.dgv.DataSource = new tempService().GetTempValues(start, end);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XLS文件(*.xls)|*.xls|所有文件|*.*";//设置保存文件的类型

            string filename = string.Empty;


            filename = DateTime.Now.ToString("yyyyMMdd")+"测量数据表";


            sfd.FileName = filename;
            sfd.DefaultExt = "xls";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (NiceExcelSaveAndRead.SaveToExcelNew(sfd.FileName, this.dgv))
                {
                    MessageBox.Show("报表导出成功！", "报表导出");
                }

                else
                {
                    MessageBox.Show("报表导出失败！", "报表导出");
                }

            }
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new DataGridViewStyle().DgvRowPostPaint(dgv, e);
        }
    }
}
