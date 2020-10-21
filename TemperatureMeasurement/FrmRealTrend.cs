using DAL;
using SeeSharpTools.JY.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMeasurement
{
    public partial class FrmRealTrend : Form
    {
        public FrmRealTrend()
        {
            InitializeComponent();
            Load += FrmRealTrend_Load;
        }
        #region 定义变量
        //INI读取类
        IniConfigHelper inihelper = new IniConfigHelper();
        //实时参数存储list
        private List<string> listParameter = new List<string>();
        string[] sqlArray;
        Timer mytimer;
     
        #endregion

        private void FrmRealTrend_Load(object sender, EventArgs e)
        {
            mytimer = new Timer();
            string str = inihelper.ReadIniData("已选实时曲线", "selectRealTrend", "", CommonMethods.FilePath);
            sqlArray = str.Split(',');
            if (sqlArray.Length == 1 && sqlArray[0] == "@")
            {
                return;
            }

            for (int i = 0; i < sqlArray.Length; i++)
            {
                listParameter.Add(CommonMethods.TrendName[sqlArray[i]].Name);
            }
            int a = 0;
            //设置Chart属性
            chart_Trend.SeriesCount = listParameter.Count < 12 ? listParameter.Count : 12;
            chart_Trend.XDataType = StripChartX.XAxisDataType.TimeStamp;
            chart_Trend.TimeStampFormat = "HH:mm:ss";
            chart_Trend.LegendVisible = true;
            chart_Trend.DisplayPoints = int.TryParse   ( inihelper.ReadIniData("已选实时显示点数", "selectRealTrend", "", CommonMethods.FilePath)  ,out  a )?a:100;        
            for (int i = 0; i < sqlArray.Length; i++)
            {
                chart_Trend.Series[i].Name = sqlArray[i];
            }

            //动态生成CheckBox
            for (int i = 0; i < sqlArray.Length; i++)
            {
                CheckBox chk = new CheckBox();
                chk.AutoSize = true;
                chk.Name = "chk_" + i.ToString();
                chk.Tag = i;
                chk.Checked = true;
                chk.ForeColor = chart_Trend.Series[i].Color;
                chk.Text = sqlArray[i];
                chk.CheckedChanged += Chk_CheckedChanged;
                chk.Location = new Point(15, 25 + 46 * i);
                this.MainPanel.Controls.Add(chk);
            }

            mytimer.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["Interval"].ToString()); ;
            mytimer.Enabled = true;
            mytimer.Tick += Mytimer_Tick;

        }

        /// <summary>
        /// 定时更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mytimer_Tick(object sender, EventArgs e)
        {
            if (CommonMethods.listPLCConectData[0].IsConncet)
            {
                List<double> ydata = new List<double>();

                for (int i = 0; i < listParameter.Count; i++)
                {
                    ydata.Add(Convert.ToDouble(CommonMethods.CurrentPLCValue[listParameter[i]]));
                }
                chart_Trend.PlotSingle(ydata.ToArray());
                
            }


            for (int i = 0; i < chart_Trend.Series.Count; i++)
            {
                
                    Chk_Changed(this.MainPanel, i, chart_Trend.Series[i].Visible);
              
            }


        }

        private void Chk_Changed(Control ct,int i,bool status)
        {
            //MainPanel.Controls
            foreach (var item in ct.Controls)
            {
                if(item is CheckBox chk)
                {
                    if(chk.Tag.ToString()==i.ToString())
                    {
                        chk.Checked = status;

                    }
                }

            }
               

        }


        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
         
                if (sender is CheckBox chk)
                {
                    if (chk.Tag != null && chk.Tag.ToString().Length > 0)
                    {
                        int index = Convert.ToInt32(chk.Tag.ToString());
                        this.chart_Trend.Series[index].Visible = chk.Checked;
                    }
                }

        }

        //显示实时曲线配置参数画面
        private void BtnTrendConfig_Click(object sender, EventArgs e)
        {
            new FrmRealTrendConfig().ShowDialog();
        }

        private void FrmRealTrend_FormClosing(object sender, FormClosingEventArgs e)
        {
            mytimer.Enabled = false;
        }
    }
}
