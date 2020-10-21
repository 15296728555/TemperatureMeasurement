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
    public partial class FrmHistoryTrend : Form
    {
        public FrmHistoryTrend()
        {
            InitializeComponent();
            Load += FrmHistoryTrend_Load;
            dtpStart.Text = DateTime.Now.AddHours(-1.0).ToString();
            dtpStart.Text= DateTime.Now.AddHours(-10.0).ToString();
        }
        #region 定义变量

        //历史曲线保存List集合
        private List<string> listParameter = new List<string>();
        //INI文件读取的保存对象
        string[] sqlArray;

        string[] XData;
        private string StartView;
        private string EndView;




        #endregion
        private void FrmHistoryTrend_Load(object sender, EventArgs e)
        {
            chartHistory.AxisX.MajorGridCount = 4;
            string str =  new IniConfigHelper().ReadIniData("已选曲线", "selectTrend", "", CommonMethods.FilePath);
            chartHistory.DisplayPoints =Convert.ToInt32( new IniConfigHelper().ReadIniData("历史显示点数", "Points", "", CommonMethods.FilePath));

            sqlArray = str.Split(',');
           if( sqlArray.Length==1&&sqlArray[0]=="@"  )
            {
                return;
            }


            for (int i = 0; i < sqlArray.Length; i++)
            {
                listParameter.Add(CommonMethods.TrendName[sqlArray[i]].Name);
            }

        }


        /// <summary>
        /// 历史数据查询方法
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void QueryProcess(string start, string end)
        {
            if (listParameter.Count == 0)
            {
                MessageBox.Show("至少要选择一个参数！", "查询提示");
                return;
            }

            //对于参数进行一定的判断

            DateTime t1 = Convert.ToDateTime(start);
            DateTime t2 = Convert.ToDateTime(end);

            if (t1 > t2)
            {
                MessageBox.Show("开始时间不能大于结束时间！", "查询提示");
                return;
            }

            TimeSpan ts = t2 - t1;

            if (ts.TotalHours > 10.0)
            {
                MessageBox.Show("查询间隔范围太大【10H】！", "查询提示");
                return;
            }

            //拼接SQL语句
            StringBuilder sb = new StringBuilder();

            sb.Append("select InsertTime,");

            
            string str = string.Join(",", listParameter.ToArray());
            sb.Append(str);


            sb.Append(" from TemperaTureMeasure where 1=1 and InsertTime between '{0}' and '{1}'");

            string sql = string.Format(sb.ToString(), start, end);

            DataTable dt = SQLHelper.GetDataSet(sql).Tables[0];

            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {

                try
                {
                    Invoke(new Action(() =>
                    {

                        this.chartHistory.Clear();

                        this.chartHistory.SeriesCount = listParameter.Count;

                        for (int i = 0; i < sqlArray.Length; i++)
                        {
                            this.chartHistory.Series[i].Name = sqlArray[i];
                        }


                        //DataTable转换为需要的类型

                        double[,] YData = new double[listParameter.Count, rowcount];

                       XData = new string[rowcount];


                        for (int i = 0; i < rowcount; i++)
                        {
                            for (int j = 0; j < listParameter.Count; j++)
                            {
                                if (dt.Rows[i][j + 1] is DBNull)
                                {
                                    YData[j, i] = 0.0;
                                }
                                else
                                {
                                    try
                                    {
                                        YData[j, i] = Convert.ToDouble(dt.Rows[i][j + 1]);
                                    }
                                    catch (Exception)
                                    {
                                        YData[j, i] = 0.0;
                                    }
                                }
                            }
                            XData[i] = Convert.ToDateTime(dt.Rows[i][0]).ToString("yyyy/MM/dd HH:mm:ss");
                        }

                        this.chartHistory.Plot(YData, XData);
                        LogHelper.WriteLog($"历史曲线生成成功");
                    }));
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog($"历史曲线生成失败",ex);
                    MessageBox.Show(ex.Message, "查询提示");
                }
             
              
            }

            else
            {
                MessageBox.Show("未查询到数据，请检查！", "查询提示");
                return;
            }
        }


        /// <summary>
        /// 查询dtpStart.Text.Trim(), dtpEnd.Text.Trim()之间的历史数据记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
           
            QueryProcess(dtpStart.Text.Trim(), dtpEnd.Text.Trim());
        }

        private void BtnExportExecle_Click(object sender, EventArgs e)
        {
      



            FrmExportHistory feh = new FrmExportHistory(StartView,EndView);
           

            feh.ShowDialog();
        }

        private void chartHistory_AxisViewChanged(object sender, SeeSharpTools.JY.GUI.StripChartXViewEventArgs e)
        {
            try
            {
                StartView = chartHistory.AxisX.CustomLabels[0].Text;
                EndView = chartHistory.AxisX.CustomLabels[chartHistory.AxisX.MajorGridCount].Text;
            }
            catch (Exception ex)
            {

                LogHelper.WriteLog("导出ChartHistory的左右时间坐标 错误", ex);
            }
          
        }
    }
}
