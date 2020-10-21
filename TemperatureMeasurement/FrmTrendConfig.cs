using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace TemperatureMeasurement
{
    public partial class FrmTrendConfig : Form
    {
        public FrmTrendConfig()
        {
            InitializeComponent();
            Load += FrmTrendConfig_Load;
        }

        #region 定义变量
      
        IniConfigHelper inihelper = new IniConfigHelper();
     
        private List<string> listTotalTrend = new List<string>();
        private List<string> listSelectTrend = new List<string>();
        private List<string> listUnSelectTrend = new List<string>();
        private List<string> strList = new List<string>();
        #endregion
        private void FrmTrendConfig_Load(object sender, EventArgs e)
        {
            foreach (var item in CommonMethods.TrendName.Keys)
            {
                listTotalTrend.Add(item);
            }


            string str = inihelper.ReadIniData("已选曲线", "selectTrend", "", CommonMethods.FilePath);

            strList = str.Split(',').ToList();
            for (int i = 0; i < strList.Count; i++)
            {
                if(strList[i]== "@")
                {

                    strList.RemoveAt(i);
                }

            }

            listSelectTrend = strList;
            foreach (var item in listSelectTrend)
            {
                listTotalTrend.Remove(item);
            }
            listUnSelectTrend = listTotalTrend;
            listSelectTrend = listSelectTrend.ToList();
            UpdateData();

        }

        private void UpdateData()
        {
            unSelectListBox.DataSource = null;
            selectListBox.DataSource = null;
           
            unSelectListBox.DataSource = listUnSelectTrend;
            selectListBox.DataSource = listSelectTrend;


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(unSelectListBox.Items.Count==0|| unSelectListBox.SelectedItem==null)
            {
                return;
            }
            else
            {
                string str = unSelectListBox.SelectedValue.ToString();
                listSelectTrend.Add(str);
                listUnSelectTrend.Remove(str);
                UpdateData();
            }
        }

        private void btn_AddAll_Click(object sender, EventArgs e)
        {
            if (unSelectListBox.Items.Count == 0 || unSelectListBox.SelectedItem == null)
            {
                return;
            }

            foreach (var item in listUnSelectTrend)
            {
                listSelectTrend.Add(item);
            }

            listUnSelectTrend.Clear();
                UpdateData();
          
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (selectListBox.Items.Count == 0 || selectListBox.SelectedItem == null)
                return;
            string str = selectListBox.SelectedValue.ToString();
            listSelectTrend.Remove(str);
            listUnSelectTrend.Add(str);
            UpdateData();
        }

        private void btn_DelAll_Click(object sender, EventArgs e)
        {
            if (selectListBox.Items.Count == 0 || selectListBox.SelectedItem == null)
                return;

            foreach (var item in listSelectTrend)
            {
                listUnSelectTrend.Add(item);
            }
            listSelectTrend.Clear();
            UpdateData();
        }

     

        private void Btn_SetTrend_Click_1(object sender, EventArgs e)
        {
            string str = string.Empty;
            if (listSelectTrend.Count != 0)
            {
                str = string.Join(",", listSelectTrend.ToArray());
            }
            else
            {
                str = "@";
            }

            if (inihelper.WriteIniData("已选曲线", "selectTrend", str, CommonMethods.FilePath))
            {
                MessageBox.Show("曲线参数保存成功", "信息提示");
                LogHelper.WriteLog($"写入配置文件成功，写入内容为{str}");
            }
           
        }

      
    }
}
