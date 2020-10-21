using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DAL;
using Entity;


namespace TemperatureMeasurement
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;

        }
        #region 定义变量
        private string ConfigPath = Application.StartupPath + "\\3rd\\readPLC.xml";

        private bool IsRun = false;
        //定义PLC连接数据
        private PLCConnectData plcConData;
        //定义PLC数据组
        public List<PLCGroup> listPLCGroup = new List<PLCGroup>();


        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {

            LoadXmlFile(ConfigPath);

            IsRun = true;
            InitialAndConnect();
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();          
            timer1.Interval = 500;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;

            btnMeasureShow_Click(null,null);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //lblLoginName.Text = CommonMethods.objAdmins.LoginName;
            lblCommstate.Text = plcConData.IsConncet ? "连接成功" : "连接失败";
            this.lblCommstate.ForeColor = plcConData.IsConncet ? Color.FromArgb(0, 192, 192) : Color.White;
            this.lblCommstate.BackColor = plcConData.IsConncet ? Color.FromArgb(11, 115, 163) : Color.Red;
            Updata();
        }

        private void InitialAndConnect()
        {
            if(plcConData!=null)
            {

                Task taskPlc = Task.Run(() =>
                {
                    GetMelsecValue();
                });

            }

        }

        private void GetMelsecValue()
        {

            while (IsRun)
            {

                if(plcConData.IsConncet)
                {
                    foreach (var item in listPLCGroup)
                    {
                        string start = item.StoreArea + item.Start;
                        byte[] res = plcConData.objMelsec.ReadBytes(start, (ushort)item.Length);
                        if(res!=null)
                        {
                            foreach (var dt in item.listVar)
                            {

                                switch (dt.DateType)
                                {
                                    case VarType.Bit:
                                        break;
                                    case VarType.Byte:
                                        break;
                                    case VarType.Word:
                                        break;
                                    case VarType.DWord:
                                        break;
                                    case VarType.Int:                                    
                                        dt.VarValue = (BitConverter.ToInt16(new byte[] {res[dt.Start], res[dt.Start+1] }, 0))*0.1;
                                        break;
                                    case VarType.DInt:
                                        break;
                                    case VarType.Real:
                                        break;
                                    case VarType.String:
                                        dt.VarValue = Encoding.ASCII.GetString(res, dt.Start, dt.ByteLength);

                                        break;
                                    case VarType.Timer:
                                        break;
                                    case VarType.Counter:
                                        break;
                                    default:
                                        break;
                                }
                                if(CommonMethods.CurrentPLCValue.ContainsKey(dt.Name))
                                {
                                    CommonMethods.CurrentPLCValue[dt.Name] = dt.VarValue;
                                }
                            }
                        }
                        else
                        {
                            plcConData.IsConncet = false;
                        }
                    }
                }
                else
                {
                    Thread.Sleep(500);
                    plcConData.objMelsec.Connect(plcConData.IpAddress, plcConData.Port);
                  
                    byte[] res = plcConData.objMelsec.ReadBytes("D0", 2);
                    if(res!=null)
                    {

                        plcConData.IsConncet = true;
                    }
                    else
                    {
                        plcConData.IsConncet = false;
                    }
                }
            }
        }
        #region 解析XML文件
        /// <summary>
        /// 解析XML文件
        /// </summary>
        /// <param name="xml"></param>
        private void LoadXmlFile(string xml)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xml);

                XmlNode setting = doc.SelectSingleNode("Settings");
                //XmlNodeList nodeclass = setting.ChildNodes;
                    XmlNodeList nodedevice = setting.ChildNodes;
                    foreach (XmlNode dev in nodedevice)
                    {
                        if (dev.Name == "DeviceNode")
                        {
                            string plctype = XMLAttributeGetValue(dev, "DeviceType");
                          
                               plcConData = new PLCConnectData()
                                {
                                        Name = XMLAttributeGetValue(dev, "Name"),
                                   
                                        IpAddress = XMLAttributeGetValue(dev, "IpAddress"),
                                        Port = int.Parse(XMLAttributeGetValue(dev, "Port")),
                                };
                                 XmlNodeList groupdevice = dev.ChildNodes;
                               foreach (XmlNode group in groupdevice)
                                {
                                      PLCGroup   gp=new PLCGroup()
                                        {                                          
                                            Name = XMLAttributeGetValue(group, "Name"),
                                            Description = XMLAttributeGetValue(group, "Description"),
                                            StoreArea = XMLAttributeGetValue(group, "StoreArea"),
                                            Start = int.Parse(XMLAttributeGetValue(group, "Start")),
                                            Length = int.Parse(XMLAttributeGetValue(group, "Length")),
                                          
                                        };
                                    foreach (XmlNode var in group)
                                     {
                                            string varName = XMLAttributeGetValue(var, "Name");
                                            string varAddress = XMLAttributeGetValue(var, "VarAddress");
                                            if (!CommonMethods.CurrentPLCValue.ContainsKey(varName))
                                            {
                                                CommonMethods.CurrentPLCValue.Add(varName, "NA");
                                            }
                                            if (!CommonMethods.CurrentPLCAddress.ContainsKey(varName))
                                            {
                                                CommonMethods.CurrentPLCAddress.Add(varName, varAddress);
                                            }
                                     
                                        gp.listVar.Add(new Variable()
                                        {
                                            Name = varName,
                                            Description = XMLAttributeGetValue(var, "Description"),
                                            VariableAddress = varAddress,
                                            DateType = (VarType)Enum.Parse(typeof(VarType), XMLAttributeGetValue(var, "VarType")),
                                            ByteLength= Convert.ToInt32(XMLAttributeGetValue(var, "ByteLength")),
                                            Start = Convert.ToInt32(XMLAttributeGetValue(var, "Start")),
                                        });                                     
                                     }
                                 listPLCGroup.Add(gp);
                              }
                             
                        }
                    }
              }
            catch (Exception ex)
            {
                MessageBox.Show("加载文件失败，请确认文件格式是否正确！原因：" + ex.Message);
            }
         }

        private string XMLAttributeGetValue(XmlNode rootxml, string name)
        {
            string resvalue = string.Empty;
            if (rootxml != null && rootxml.Attributes != null && rootxml.Attributes[name] != null)
            {
                resvalue = rootxml.Attributes[name].Value;
            }
            return resvalue;
        }

        #endregion
        //private byte[] GetByteArray(byte[] byteArr, int start, int length)
        //{
        //    byte[] Res = new byte[length];
        //    if (byteArr != null && byteArr.Length >= start + length)
        //    {
        //        for (int i = 0; i < length; i++)
        //        {
        //            Res[i] = byteArr[i + start];
        //        }

        //    }
        //    return Res;
        //}


        private byte[] GetStringBytes(byte[] bytes,int start ,int length)
        {
            byte[] b = new byte[length];
           if(bytes!=null&&length<bytes.Length)
            {
                Buffer.BlockCopy(bytes, start, b, 0, length);
                return b;

            }

            return b;
     


        }
        #region 关闭打开窗体
        private bool CloseWindow(Form form)
        {
            bool result = false;
            foreach (Control item in MainPanel.Controls)
            {
                if (item is Form frm)
                {
                    if (form.Name == frm.Name)
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        frm.Close();

                    }
                }
            }
            return result;

        }
        private void OpenWindow(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Parent = MainPanel;
            //lblTitle.Text = frm.Text;
            BackColorSet(frm.Text);
            frm.Show();
        }
      
        private void BackColorSet(string FrmText)
        {
            //设置所有按钮为未选中颜色
            this.btnMeasureShow.BackColor = Color.FromArgb(11, 115, 163);
            this.btnDgvShow.BackColor = Color.FromArgb(11, 115, 163);

            //根据需要去修改点击按钮的背景颜色

            switch (FrmText)
            {
                case "测量结果显示":
                    this.btnMeasureShow.BackColor = Color.FromArgb(60, 179, 113);

                    break;
                case "数据表格显示":
                    this.btnDgvShow.BackColor = Color.FromArgb(60, 179, 113);
                    break;


            }


        }
    
        private void btnExit_Click(object sender, EventArgs e)
        {
            plcConData.objMelsec?.DisConnect();
        
            Environment.Exit(0);
        }

        private void btnMeasureShow_Click(object sender, EventArgs e)
        {
            FrmValueShow fvs = new FrmValueShow();
            if (!CloseWindow(fvs))
            {
                OpenWindow(fvs);
            }

          
        }
        #endregion

      
        private void btnDgvShow_Click(object sender, EventArgs e)
        {
            FrmDgvShow fds = new FrmDgvShow();
            if (!CloseWindow(fds))
            {
                OpenWindow(fds);
            }
        }
        private void Updata()
        {
            if (plcConData.IsConncet)
            {
                float mark = Convert.ToSingle(CommonMethods.CurrentPLCValue["writeMark"]);
                float finish = Convert.ToSingle(CommonMethods.CurrentPLCValue["writeFinish"]);
                if (mark != 0 && mark != 0 && finish == 0)
                {
                    List<string> strListCurrentName = new List<string>();
                    List<float> fList = new List<float>();
                    List<string> strList = new List<string>();
                    foreach (var item in CommonMethods.CurrentPLCValue)
                    {
                        strListCurrentName.Add(item.Key);
                    }

                    for (int i = 0; i < strListCurrentName.Count - 12; i++)
                    {
                        strList.Add(strListCurrentName[i + 12]);
                        fList.Add(Convert.ToSingle(CommonMethods.CurrentPLCValue[strList[i]]));
                    }
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append(" insert into   TemperaTureMeasure ( InsertTime,");
                    strSql.Append(string.Join(",", strList.ToArray()));
                    strSql.Append(") values( ");
                    strSql.Append("'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'" + ",");
                   
                    strSql.Append(string.Join(",", fList.ToArray()));               
                    strSql.Append(" )");
                    if (SQLHelper.Update(strSql.ToString()) > 0)
                    {
                        //if( plcConData.objMelsec.Write(CommonMethods.CurrentPLCAddress["writeFinish"],1))
                        short i1 = 256;
                        if (plcConData.objMelsec.Write("D99", i1))
                        {
                            short i2 = 0;
                            //plcConData.objMelsec.Write(CommonMethods.CurrentPLCAddress["writeMark"], i2);
                            plcConData.objMelsec.Write(CommonMethods.CurrentPLCAddress["writeMark"], i2);
                            MessageBox.Show("更新成功");
                        }

                    }

                }


            }



        }

        private void btnLoginPawModif_Click(object sender, EventArgs e)
        {
            FrmModifPaw mp = new FrmModifPaw(CommonMethods.objAdmins.LoginName);
         
            mp.ShowDialog();
        }
    }
}
