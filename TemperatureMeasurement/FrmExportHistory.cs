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
    public partial class FrmExportHistory : Form
    {
        public FrmExportHistory()
        {
            InitializeComponent();
            this.DgvExport.AutoGenerateColumns = false;
            Load += FrmExportHistory_Load;
        }

        public FrmExportHistory(string start,string end     )
        {
            InitializeComponent();
            dtpStart.Text = start;
            dtpEnd.Text = end;

            this.DgvExport.AutoGenerateColumns = false;
            Load += FrmExportHistory_Load;
        }



        #region 定义变量
        string[] sqlArray;
        private List<string> HeaderTextList = new List<string>();
        private List<string> sqlString = new List<string>();

        #endregion



        private void FrmExportHistory_Load(object sender, EventArgs e)
        {
          
            
            string str = new IniConfigHelper().ReadIniData("已选曲线", "selectTrend", "", CommonMethods.FilePath);
            sqlArray = str.Split(',');
            if (sqlArray.Length == 1 && sqlArray[0] == "@")
            {
                return;
            }
            HeaderTextList.Add("日期时间");
            sqlString.Add("InsertTime");

            for (int i = 0; i < sqlArray.Length; i++)
            {
                HeaderTextList.Add(CommonMethods.TrendName[sqlArray[i]].Description);
                sqlString.Add((CommonMethods.TrendName[sqlArray[i]].Name));
            }

         

            for (int i = 0; i < HeaderTextList.Count; i++)
            {
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.HeaderText = HeaderTextList[i];
                dgvc.ReadOnly = true;
                dgvc.Width = 150;
                dgvc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                dgvc.DataPropertyName = sqlString[i];
                dgvc.Name = sqlString[i];
                this.DgvExport.Columns.Add(dgvc);
            }

            //拼接SQL语句
            StringBuilder sb = new StringBuilder();

            sb.Append("select ");


            string str1 = string.Join(",", sqlString.ToArray());
            sb.Append(str1);


            sb.Append(" from TemperaTureMeasure where 1=1 and InsertTime between '{0}' and '{1}'");

            string sql = string.Format(sb.ToString(), dtpStart.Text.Trim(), dtpEnd.Text.Trim());

            DataTable dt = SQLHelper.GetDataSet(sql).Tables[0];


            //如何把DataTable赋值到DataGridView

            int index = this.DgvExport.Rows.Add();
            DgvExport.DataSource = null;
            DgvExport.DataSource = dt;




        }

        private void BtnExportExecle_Click(object sender, EventArgs e)
        {
           if(DgvExport.Rows.Count>65535)
            {
                LogHelper.WriteLog($" {CommonMethods.objAdmins.LoginName}导出数据失败");
                MessageBox.Show("报表导出失败！,原因是行数超过65535，请重新筛选数据", "报表导出");
                return;
            }

            if (DgvExport.Rows.Count <=0)
            {
                LogHelper.WriteLog($" {CommonMethods.objAdmins.LoginName}导出数据失败");
                MessageBox.Show("报表导出失败！,原因是行数为0，请重新筛选数据", "报表导出");
                return;
            }




            string start = Convert.ToDateTime(dtpStart.Text.Trim()).ToString("yyyyMMddHHmm");
            string end = Convert.ToDateTime(dtpEnd.Text.Trim()).ToString("yyyyMMddHHmm");

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XLS文件(*.xls)|*.xls|所有文件|*.*";//设置保存文件的类型
            sfd.InitialDirectory = "D:\\";
            //sfd.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "测量数据表";
            sfd.FileName = start + "-" + end;
            sfd.DefaultExt = "xls";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (NiceExcelSaveAndRead.SaveToExcelNew(sfd.FileName, this.DgvExport))
                {
                    LogHelper.WriteLog($" {CommonMethods.objAdmins.LoginName}导出数据报表");
                    MessageBox.Show("报表导出成功！", "报表导出");
                    this.Close();
                }

                else
                {
                    LogHelper.WriteLog($" {CommonMethods.objAdmins.LoginName}导出数据失败");
                    MessageBox.Show("报表导出失败！", "报表导出");
                }
            }
        }

        private void DgvExport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new DataGridViewStyle().DgvRowPostPaint(DgvExport, e);
        }
    }
}
