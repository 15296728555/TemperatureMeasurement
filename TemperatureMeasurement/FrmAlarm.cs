using DAL;
using Entity;
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

namespace TemperatureMeasurement
{
    public partial class FrmAlarm : Form
    {
        public FrmAlarm()
        {
            InitializeComponent();
            Load += FrmAlarm_Load;
        }

        #region 定义变量
        public bool IsSystemExit = false;
        List<AlarmInfo> list = new List<AlarmInfo>();

        #endregion


        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            cmbHisCout.DataSource = new int[3] { 10, 20, 50 };
            cmbHisCout.Text = new  IniConfigHelper().ReadIniData("历史报警显示条数", "Count", "", CommonMethods.FilePath);
            lsvAlarm.Columns[1].Width = lsvAlarm.ClientSize.Width - lsvAlarm.Columns[0].Width - 50;
            dgv_Log.AutoGenerateColumns = false;
        }
        /// <summary>
        /// 在窗体初始化调用方法，给dgv_log.dataSource赋值
        /// </summary>
        /// <param name="count">SQL里的  Top值  </param>
        public void InitialDGV(int count)
        {
            string sql = $"Select  Top  {count}    * from AlarmData order by InsertTime DESC  ";

            this.dgv_Log.DataSource = null;

            this.dgv_Log.DataSource = SQLHelper.GetDataSet(sql).Tables[0];

        }
        public void AddLog(AlarmInfo info)
        {
            Invoke(new Action(() =>
            {
                //当info.AlarmState==ACK是在listView里插入一条记录
                if (info.AlarmState.ToLower() == "ack")
                {
                    int index = info.Priority <= 2 && info.Priority >= 0 ? info.Priority : 2;

                    ListViewItem lst = new ListViewItem("     " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), index);

                    lst.SubItems.Add(info.Note);

                    lsvAlarm.Items.Insert(0, lst);

                }
                else
                {
                    //当nfo.AlarmState=ACK是在listView删除 info.Note==lv.SubItems[1].Text
                    foreach (ListViewItem lv in lsvAlarm.Items)
                    {
                        if (lv.SubItems[1].Text == info.Note)
                        {
                            lsvAlarm.Items.Remove(lv);
                        }
                    }
                }
                try
                {
                    CommonMethods.LogSQLite(info);
                }
                catch (Exception ex)
                {

                    LogHelper.WriteLog("报警信息写入数据库失败", ex);
                }
              

            }));



        }
        #region 窗体关闭处理
        private void FrmAlarm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (!IsSystemExit)
            {
               //当点击关闭窗体是，如果不是退出程序，隐藏窗体，不退出
                this.Hide();
                e.Cancel = true;
            }
        }
        #endregion

        /// <summary>
        /// 查询dpt_Start.Text, this.dpt_End.Text之间的报警记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {

            //list=new TempService().GetAlarmInfoValues(this.dpt_Start.Text, this.dpt_End.Text);
            //this.dgv_Log.DataSource = null;

            //this.dgv_Log.DataSource = list;

            string sql = $"Select  * from AlarmData where 1=1 and  InsertTime between '{dpt_Start.Text}' and '{dpt_End.Text}' order by InsertTime DESC";

            this.dgv_Log.DataSource = null;
            try
            {
                this.dgv_Log.DataSource = SQLHelper.GetDataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogHelper.WriteLog("FrmAlarm按钮btn_Query查询故障记录失败", ex);
            }



        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XLS文件(*.xls)|*.xls|所有文件|*.*";//设置保存文件的类型
            sfd.FileName = "历史日志导出Excel";
            sfd.DefaultExt = "xls";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (NiceExcelSaveAndRead.SaveToExcelNew(sfd.FileName, this.dgv_Log))
                {
                    MessageBox.Show("报警历史日志导出成功！", "日志导出");
                    LogHelper.WriteLog(CommonMethods.objAdmins.LoginName + "导出报警日志");
                }

                else
                {
                    MessageBox.Show("历史日志导出失败！", "日志导出");
                    LogHelper.WriteLog("FrmAlarm按钮btn_Export导出故障记录失败");
                }

            }
        }
      
        private void dgv_Log_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new DataGridViewStyle().DgvRowPostPaint(this.dgv_Log, e);

            if (e.RowIndex >= dgv_Log.Rows.Count - 1)
                return;
            //通过Priority改变error行的字体颜色
            try
            {
                if (dgv_Log.Rows[e.RowIndex].Cells["Priority"].Value.ToString() == "2")
                {
                    dgv_Log.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                LogHelper.WriteLog("通过priority值改变所在行的字体颜色失败", ex);
            }
            //通过Priority改变error行的背景颜色
            //if (dgv_Log.Rows[e.RowIndex].Cells["Priority"].Value.ToString()=="2")
            //{
            //    dgv_Log.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            //}

        }


        ///把选定的SQL语句TOP的值存入INI文件
        private void BtnSave_Click(object sender, EventArgs e)
        {


            new IniConfigHelper().WriteIniData("历史报警显示条数", "Count", cmbHisCout.Text, CommonMethods.FilePath);
            LogHelper.WriteLog(CommonMethods.objAdmins.LoginName + "修改历史报警显示条数");


        }
      
        private void dgv_log_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
            if (dgv_Log.Columns[e.ColumnIndex].Name.Equals("AlarmImage"))
            {

                try
                {

                    if (e.Value.ToString().Length > 20)
                    {
                        e.Value = new SerializeObjectToString().DeserializeObject(e.Value.ToString());
                    }
                    else
                    {

                        e.Value = Properties.Resources.info;

                    }

                }
                catch (Exception ex)
                {

                    LogHelper.WriteLog("Dgv_log插入图片 失败", ex);
                }
             


            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //string sql = "Insert into AlarmData(InsertTime,VarName,AlarmState,Priority,AlarmValue,Note,Operator,AlarmImage) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}')";

        //    //sql = string.Format(sql, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), "aaa", "ack",2, 123, "dfdfd士大夫地方", CommonMethods.objAdmins.LoginName, new SerializeObjectToString().AlarmImageToString(4));

        //    //SQLHelper.Update(sql);
        //}
    }
}
