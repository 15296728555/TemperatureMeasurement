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
    public partial class FrmHighFrequency : Form
    {
        public FrmHighFrequency()
        {
            InitializeComponent();
            this.Dgv.AutoGenerateColumns = false;
            Load += FrmHighFrequency_Load;

        }

        private void FrmHighFrequency_Load(object sender, EventArgs e)
        {
            dtpStart.Text = DateTime.Now.AddHours(-10.0).ToString();


        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {


            QueryTemp();




        }
        private void QueryTemp()
        {
            string start = dtpStart.Text.Trim();
            string end = dtpEnd.Text.Trim();
            string sql;
            TimeSpan ts = Convert.ToDateTime(end) - Convert.ToDateTime(start);
            if (Convert.ToDateTime(start) > Convert.ToDateTime(end))
            {
                MessageBox.Show("开始时间不能大于结束时间", "错误提示");
                return;
            }
            if (ts.TotalHours > 12.0)
            {
                MessageBox.Show("时间间隔不能大于12个小时", "错误提示");
                return;
            }
            if(TxbFormula.Text.Trim().Length>0)
            {
                 sql = $"select * from HighFrequency where Formula='{TxbFormula.Text.Trim()}'  and InsertTime between '{start}' and '{end}' order by InsertTime DESC   ";
            }
            
            else
            {
                 sql = $"select * from HighFrequency where 1=1  and InsertTime between '{start}' and '{end}' order by InsertTime DESC   ";
            }
            this.Dgv.DataSource = null;
            try
            {
                this.Dgv.DataSource = SQLHelper.GetDataSet(sql).Tables[0];
                LogHelper.WriteLog($"读取数据{start}至{end}时间段内数据");
                if (Dgv.Rows.Count == 0)
                {
                    MessageBox.Show("当前所选时间段内数据为空，请重新选择", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.WriteLog("读取数据库失败", ex);
            }

        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            string start = Convert.ToDateTime(dtpStart.Text.Trim()).ToString("yyyyMMddHHmm");
            string end = Convert.ToDateTime(dtpEnd.Text.Trim()).ToString("yyyyMMddHHmm");

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XLS文件(*.xls)|*.xls|所有文件|*.*";//设置保存文件的类型
            sfd.InitialDirectory = "D:\\";
            //sfd.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "测量数据表";
            //sfd.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            sfd.FileName = start + "-" + end;
            sfd.DefaultExt = "xls";
            sfd.AddExtension = true;
            if (Dgv.Rows.Count > 65535)
            {
                MessageBox.Show("报表导出失败！,原因是表格行数超过65535", "报表导出");
                return;
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (NiceExcelSaveAndRead.SaveToExcelNew(sfd.FileName, this.Dgv))
                {
                    LogHelper.WriteLog($" {CommonMethods.objAdmins.LoginName}导出数据报表");
                    MessageBox.Show("报表导出成功！", "报表导出");
                }

                else
                {
                    LogHelper.WriteLog($" {CommonMethods.objAdmins.LoginName}导出数据失败");
                    MessageBox.Show("报表导出失败！", "报表导出");
                }
            }
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.RowCount != 0 && Dgv.CurrentRow != null)
            {
                TxbFormula.Text = Dgv.CurrentRow.Cells["Formula"].Value.ToString();
            }


            QueryTemp();

        }

        private void Dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new DataGridViewStyle().DgvRowPostPaint(Dgv, e);
        }
    }
}
