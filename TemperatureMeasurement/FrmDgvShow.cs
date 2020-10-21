using DAL;
using Entity;
using NPOI.SS.Formula.Functions;
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
            dtpStart.Text = DateTime.Now.AddHours(-10.0).ToString();
            //Load += FrmDgvShow_Load;
        }
      
        private void btnQuery_Click(object sender, EventArgs e)
        {
            
            TxbFormula.Text = null;
            QueryTemp();
        }
        private void QueryTemp()
        {
            string start = dtpStart.Text.Trim();
            string end = dtpEnd.Text.Trim();
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

            float height = 0;
            if(TxbHeight.Text.Length>0)
            {
                if (!float.TryParse(TxbHeight.Text.Trim(), out height))
                {
                    MessageBox.Show("请输入正确的数字");
                }
            }
           

            this.dgv.DataSource = null;
            try
            {
                this.dgv.DataSource = new TempService().GetTempValues(start, end, TxbFormula.Text.Trim(),height);
                LogHelper.WriteLog($"读取数据{start}至{end}时间段内数据");
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("当前所选时间段内数据为空，请重新选择", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.WriteLog("读取数据库失败",ex);
            }
       
        }
        /// <summary>
        /// 导出到EXCEL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            string start =    Convert.ToDateTime(dtpStart.Text.Trim()).ToString("yyyyMMddHHmm");
            string end = Convert.ToDateTime(dtpEnd.Text.Trim()).ToString("yyyyMMddHHmm");

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XLS文件(*.xls)|*.xls|所有文件|*.*";//设置保存文件的类型
            sfd.InitialDirectory = "D:\\";
            //sfd.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "测量数据表";
            //sfd.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            sfd.FileName = start +"-" + end;
            sfd.DefaultExt = "xls";
            sfd.AddExtension = true;
             if(    dgv.Rows.Count>65535)
            {
                MessageBox.Show("报表导出失败！,原因是表格行数超过65535", "报表导出");
                return;
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (NiceExcelSaveAndRead.SaveToExcelNew(sfd.FileName, this.dgv))
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

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new DataGridViewStyle().DgvRowPostPaint(dgv, e);
        }
        /// <summary>
        /// 当TxbFormula_TextChanged改变是调用QueryTemp();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbFormula_TextChanged(object sender, EventArgs e)
        {

            QueryTemp();

        }
        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.RowCount != 0 && dgv.CurrentRow != null)
            {
                TxbFormula.Text = dgv.CurrentRow.Cells["Formula"].Value.ToString();
            }
        }
    }
}
