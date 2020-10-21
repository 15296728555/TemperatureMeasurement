using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

    public delegate void SetInterval(int i);
    //第一步：声明委托
    public delegate void AddLog(AlarmInfo info);
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;

        }
        #region 定义变量
        //INI文件path路径
        private readonly  string ConfigPath = Application.StartupPath + "\\3rd\\readPLC.xml";
        //定义运行状态
        private bool IsRun = false;
        //定义PLC连接数据
        private PLCConnectData plcConData;
        //定义PLC数据组
        //public List<PLCGroup> listPLCGroup = new List<PLCGroup>();
        System.Windows.Forms.Timer InsertDataTime = new System.Windows.Forms.Timer();
        //PLC系统时间
        public string PLCTime;
       
        //定义插入数据库变量集合
        List<string> strListCurrentName = new List<string>();
        //心跳更新
        System.Windows.Forms.Timer HeartBeattimer = new System.Windows.Forms.Timer();


        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {

            LoadXmlFile(ConfigPath);
            lblVersion.Text = "当前版本：V" + ConfigurationManager.AppSettings["Version"].ToString();
            IsRun = true;

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 500;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
            HeartBeattimer.Interval = 5000;
            HeartBeattimer.Tick += HeartBeattimer_Tick;
            HeartBeattimer.Enabled = true;



            if (!CommonMethods.IsServer)
            {
                btnMeasureShow.Enabled = false;
                btnMeasureShow.Visible = false;
                lblCommstate.Visible = false;
             
              
            }
            else
            {
                InitialAndConnect();
                btnDgvShow_Click(null, null);
            }
          
            InsertDataTimeSet(Convert.ToInt32(new IniConfigHelper().ReadIniData("参数", "Interval", "", CommonMethods.FilePath)));
            InsertDataTime.Tick += Mytime_Tick;
            plcConData.IsConncet = false;
            InsertDataTime.Enabled = true;

            //提示是否连接数据库状态
            LabConnect.Visible = false;
            //初始化报警变量集合
            InitialAlarmVar();

           
            if (objFrmAlarm == null)
            {
                objFrmAlarm = new FrmAlarm();

                //第四步：绑定委托
                myAddLog = objFrmAlarm.AddLog;

                objFrmAlarm.Show();
                objFrmAlarm.Visible = false;
            }
          

            //开启线程，进行报警的检测
            Task AlarmCheck = Task.Run(() =>
            {
                UpdateAlarmStatus();

            });


        }

        private void HeartBeattimer_Tick(object sender, EventArgs e)
        {

            plcConData.objMelsec.Write("D96", 0);

        }
        #region 窗体控件操作
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblLoginName.Text = CommonMethods.objAdmins.LoginName;
            if (CommonMethods.IsServer)
            {
                lblCommstate.Text = plcConData.IsConncet ? "连接成功" : "连接失败";
                this.lblCommstate.ForeColor = plcConData.IsConncet ? Color.FromArgb(0, 192, 192) : Color.White;
                this.lblCommstate.BackColor = plcConData.IsConncet ? Color.FromArgb(11, 115, 163) : Color.Red;
            }

        }


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
            LogHelper.WriteLog($" {CommonMethods.objAdmins.LoginName}退出系统成功");
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
        private void btnDgvShow_Click(object sender, EventArgs e)
        {
            FrmDgvShow fds = new FrmDgvShow();
            if (!CloseWindow(fds))
            {
                OpenWindow(fds);
            }
        }


        private void btnParameter_Click(object sender, EventArgs e)
        {
            FrmParameter fp = new FrmParameter();
            fp.Setval += InsertDataTimeSet;
            if (!CloseWindow(fp))
            {
                OpenWindow(fp);
            }
        }
        private void BtnHighFrequency_Click(object sender, EventArgs e)
        {
            FrmHighFrequency fp = new FrmHighFrequency();
          
            if (!CloseWindow(fp))
            {
                OpenWindow(fp);
            }
        }
        private void btnTrendConfig_Click(object sender, EventArgs e)
        {
            FrmTrendConfig fds = new FrmTrendConfig();
            if (!CloseWindow(fds))
            {
                OpenWindow(fds);
            }
        }

        private void btnHistoryTrend_Click(object sender, EventArgs e)
        {
            FrmHistoryTrend fht = new FrmHistoryTrend();
            if (!CloseWindow(fht))
            {
                OpenWindow(fht);
            }
        }

        private void BtnLoginPawModif_Click_1(object sender, EventArgs e)
        {
            FrmModifPaw fht = new FrmModifPaw(CommonMethods.objAdmins.LoginName);
            fht.ShowDialog();
        }

        private void BtnRealTime_Click(object sender, EventArgs e)
        {
            FrmRealTrend frt = new FrmRealTrend();
            if (!CloseWindow(frt))
            {
                OpenWindow(frt);
            }
        }



        #endregion

        #region 报警检测
        private AddLog myAddLog;

        //报警变量的结合
        private List<Variable> AlarmVarList = new List<Variable>();

        //报警日志窗体对象
        private FrmAlarm objFrmAlarm = null;
        // 定义根据Priority值选择不同图片的实例化类
        public SerializeObjectToString objSerialize = new SerializeObjectToString();
        //定义实时存储定时器
       



        private void InitialAlarmVar()
        {
            foreach (PLCConnectData plc in CommonMethods.listPLCConectData)
            {
                foreach (PLCGroup gp in plc.listPLCGroup)
                {
                    foreach (Variable var in gp.listVar)
                    {
                        //表示该变量配置报警
                        if (var.alarm.AlarmEnable)
                        {
                            AlarmVarList.Add(var);
                        }
                        //表示该变量配置归档
                        if (var.alarm.ArchiveEnable)
                        {
                            CommonMethods.ArchiveVar.Add(var);
                        }
                    }
                }
            }


        }
        private void UpdateAlarmStatus()
        {
            while (IsRun)
            {
                if (CommonMethods.listPLCConectData[0].IsConncet)
                {
                    foreach (Variable var in AlarmVarList)
                    {
                        //判断是条件报警还是离散报警
                        if (var.alarm.AlarmType)
                        {
                            if (CommonMethods.CurrentPLCValue.ContainsKey(var.Name))
                            {
                                //获取当前值
                                string val = CommonMethods.CurrentPLCValue[var.Name].ToString();

                                float currentValue = 0.0f;

                                float.TryParse(val, out currentValue);

                                //高高报警判断
                                if (var.alarm.HiHiAlarmEnable)
                                {
                                    //当前值大于设定值并且缓冲值小于或者等于设定


                                    //表示触发报警
                                    if (currentValue > var.alarm.HiHiAlarmValue && var.alarm.HiHiCacheValue <= var.alarm.HiHiAlarmValue)
                                    {
                                        //第五步：调用委托对象
                                        myAddLog(new AlarmInfo()
                                        {
                                            VarName = var.Name,
                                            Priority = var.alarm.HiHiAlarmPriority,
                                            AlarmState = "ACK",
                                            Note = var.alarm.HiHiAlarmNote,
                                            AlarmValue = currentValue.ToString(),
                                            AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                        });

                                    }

                                    //表示触发消除
                                    if (currentValue <= var.alarm.HiHiAlarmValue && var.alarm.HiHiCacheValue > var.alarm.HiHiAlarmValue)
                                    {
                                        //第五步：调用委托对象
                                        myAddLog(new AlarmInfo()
                                        {
                                            VarName = var.Name,
                                            Priority = var.alarm.HiHiAlarmPriority,
                                            AlarmState = "UNACK",
                                            Note = var.alarm.HiHiAlarmNote,
                                            AlarmValue = currentValue.ToString(),
                                            AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                        });

                                    }

                                    //给缓冲值赋值
                                    var.alarm.HiHiCacheValue = currentValue;
                                }


                                //高报警判断
                                if (var.alarm.HighAlarmEnable)
                                {
                                    //当前值大于设定值并且缓冲值小于或者等于设定


                                    //表示触发报警
                                    if (currentValue > var.alarm.HighAlarmValue && var.alarm.HighCacheValue <= var.alarm.HighAlarmValue)
                                    {
                                        //第五步：调用委托对象
                                        myAddLog(new AlarmInfo()
                                        {
                                            VarName = var.Name,
                                            Priority = var.alarm.HighAlarmPriority,
                                            AlarmState = "ACK",
                                            Note = var.alarm.HighAlarmNote,
                                            AlarmValue = currentValue.ToString(),
                                            AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                        });

                                    }

                                    //表示触发消除
                                    if (currentValue <= var.alarm.HighAlarmValue && var.alarm.HighCacheValue > var.alarm.HighAlarmValue)
                                    {
                                        //第五步：调用委托对象
                                        myAddLog(new AlarmInfo()
                                        {
                                            VarName = var.Name,
                                            Priority = var.alarm.HighAlarmPriority,
                                            AlarmState = "UNACK",
                                            Note = var.alarm.HighAlarmNote,
                                            AlarmValue = currentValue.ToString(),
                                            AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                        });

                                    }

                                    //给缓冲值赋值
                                    var.alarm.HighCacheValue = currentValue;
                                }


                                //低报警判断
                                if (var.alarm.LowAlarmEnable)
                                {
                                    //当前值小于设定值并且缓冲值大于或者等于设定

                                    //表示触发报警
                                    if (currentValue < var.alarm.LowAlarmValue && var.alarm.LowCacheValue >= var.alarm.LowAlarmValue)
                                    {
                                        //第五步：调用委托对象
                                        myAddLog(new AlarmInfo()
                                        {
                                            VarName = var.Name,
                                            Priority = var.alarm.LowAlarmPriority,
                                            AlarmState = "ACK",
                                            Note = var.alarm.LowAlarmNote,
                                            AlarmValue = currentValue.ToString(),
                                            AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                        });

                                    }

                                    //表示触发消除
                                    if (currentValue >= var.alarm.LowAlarmValue && var.alarm.LowCacheValue < var.alarm.LowAlarmValue)
                                    {
                                        //第五步：调用委托对象
                                        myAddLog(new AlarmInfo()
                                        {
                                            VarName = var.Name,
                                            Priority = var.alarm.LowAlarmPriority,
                                            AlarmState = "UNACK",
                                            Note = var.alarm.LowAlarmNote,
                                            AlarmValue = currentValue.ToString(),
                                            AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                        });

                                    }
                                    //给缓冲值赋值
                                    var.alarm.LowCacheValue = currentValue;
                                }

                                //低低报警判断
                                if (var.alarm.LoLoAlarmEnable)
                                {
                                    //当前值小于设定值并且缓冲值大于或者等于设定

                                    //表示触发报警
                                    if (currentValue < var.alarm.LoLoAlarmValue && var.alarm.LoLoCacheValue >= var.alarm.LoLoAlarmValue)
                                    {
                                        //第五步：调用委托对象
                                        myAddLog(new AlarmInfo()
                                        {
                                            VarName = var.Name,
                                            Priority = var.alarm.LoLoAlarmPriority,
                                            AlarmState = "ACK",
                                            Note = var.alarm.LoLoAlarmNote,
                                            AlarmValue = currentValue.ToString(),
                                            AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                        });

                                    }

                                    //表示触发消除
                                    if (currentValue >= var.alarm.LoLoAlarmValue && var.alarm.LoLoCacheValue < var.alarm.LoLoAlarmValue)
                                    {
                                        //第五步：调用委托对象
                                        myAddLog(new AlarmInfo()
                                        {
                                            VarName = var.Name,
                                            Priority = var.alarm.LoLoAlarmPriority,
                                            AlarmState = "UNACK",
                                            Note = var.alarm.LoLoAlarmNote,
                                            AlarmValue = currentValue.ToString(),
                                            AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                        });

                                    }
                                    //给缓冲值赋值
                                    var.alarm.LoLoCacheValue = currentValue;
                                }

                            }
                        }
                        else
                        {
                            //获取当前值
                            string val = CommonMethods.CurrentPLCValue[var.Name].ToString();

                            bool currentValue = false;

                            Boolean.TryParse(val, out currentValue);

                            //上升沿报警
                            if (var.alarm.DiscreteAlarmType)
                            {
                                //表示报警触发
                                if (currentValue && !var.alarm.DiscreteCacheValue)
                                {
                                    //第五步：调用委托对象
                                    myAddLog(new AlarmInfo()
                                    {
                                        VarName = var.Name,
                                        Priority = var.alarm.DiscreteAlarmPriority,
                                        AlarmState = "ACK",
                                        Note = var.alarm.DiscreteAlarmNote,
                                        AlarmValue = currentValue.ToString(),
                                        AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                    });
                                }

                                //表示报警消除
                                if (!currentValue && var.alarm.DiscreteCacheValue)
                                {
                                    //第五步：调用委托对象
                                    myAddLog(new AlarmInfo()
                                    {
                                        VarName = var.Name,
                                        Priority = var.alarm.DiscreteAlarmPriority,
                                        AlarmState = "UNACK",
                                        Note = var.alarm.DiscreteAlarmNote,
                                        AlarmValue = currentValue.ToString(),
                                        AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                    });
                                }

                                //给缓冲值赋值
                                var.alarm.DiscreteCacheValue = currentValue;
                            }
                            else
                            {
                                //表示报警触发
                                if (!currentValue && var.alarm.DiscreteCacheValue)
                                {
                                    //第五步：调用委托对象
                                    myAddLog(new AlarmInfo()
                                    {
                                        VarName = var.Name,
                                        Priority = var.alarm.DiscreteAlarmPriority,
                                        AlarmState = "ACK",
                                        Note = var.alarm.DiscreteAlarmNote,
                                        AlarmValue = currentValue.ToString(),
                                        AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)
                                    });
                                }

                                //表示报警消除
                                if (currentValue && !var.alarm.DiscreteCacheValue)
                                {
                                    //第五步：调用委托对象
                                    myAddLog(new AlarmInfo()
                                    {
                                        VarName = var.Name,
                                        Priority = var.alarm.DiscreteAlarmPriority,
                                        AlarmState = "UNACK",
                                        Note = var.alarm.DiscreteAlarmNote,
                                        AlarmValue = currentValue.ToString(),
                                        AlarmImage = objSerialize.AlarmImageToString(var.alarm.DiscreteAlarmPriority)


                                    }); ;
                                }
                                //给缓冲值赋值
                                var.alarm.DiscreteCacheValue = currentValue;

                            }
                        }
                    }
                }
            }
        }

        #endregion
        private void InsertDataTimeSet(int Interval)
        {

            InsertDataTime.Interval = Interval;

        }

        private void Mytime_Tick(object sender, EventArgs e)
        {

            UpdataTemp();
            //Updata();
            InsertHighFreData();
        }
        private string PLCIntToDataTime()
        {

            string str = string.Empty;
            str = CommonMethods.CurrentPLCValue["year"].ToString().PadLeft(2, '0');
            str += CommonMethods.CurrentPLCValue["months"].ToString().PadLeft(2, '0');
            str += CommonMethods.CurrentPLCValue["day"].ToString().PadLeft(2, '0');
            str += CommonMethods.CurrentPLCValue["Hour"].ToString().PadLeft(2, '0');
            str += CommonMethods.CurrentPLCValue["Minutes"].ToString().PadLeft(2, '0');
            str += CommonMethods.CurrentPLCValue["second"].ToString().PadLeft(2, '0');
            DateTime dt = DateTime.ParseExact(str, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);

            return dt.ToString("yyyy/MM/dd HH:mm:ss");

        }


        #region 建立连接并获取变量值
        private void InitialAndConnect()
        {
            if (plcConData != null)
            {

                Task taskPlc = Task.Run(() =>
                {
                    GetMelsecValue();
                });

            }

        }
        //解析PLC数据，并断线重连
        private void GetMelsecValue()
        {

            while (IsRun)
            {

                if (plcConData.IsConncet)
                {
                    foreach (var item in plcConData.listPLCGroup)
                    {
                        string sg = string.Empty;
                        sg = item.Name;
                        string start = item.StoreArea + item.Start;
                        byte[] res = plcConData.objMelsec.ReadBytes(start, (ushort)item.Length);
                        if (res != null)
                        {
                            foreach (var dt in item.listVar)
                            {
                                switch (dt.DateType)
                                {
                                    case VarType.Bit:
                                        string[] str = dt.VariableAddress.Split('.');
                                        if (str.Length == 2)
                                        {

                                            int offset = int.Parse(str[1]);

                                            dt.VarValue = GetbitValue(BitConverter.ToInt16(new byte[] { res[dt.Start], res[dt.Start + 1] }, 0), offset) == "1";

                                        }


                                        break;
                                    case VarType.Byte:
                                        break;
                                    case VarType.Word:
                                        break;
                                    case VarType.DWord:
                                        break;
                                    case VarType.Int:
                                        //从PLC读取过来的实时参数一组数据是short类型，实际数值是float型，* 0.1转换为float
                                        if (sg == "实时参数")
                                        {
                                            if (dt.Name == "RelativeHeight" || dt.Name == "TravelHeight")
                                            {
                                                dt.VarValue = (BitConverter.ToInt16(new byte[] { res[dt.Start], res[dt.Start + 1] }, 0)) * 0.01;


                                            }
                                            else if (dt.Name == "HighFrequency2FirstConfigPressure" || dt.Name == "HighFrequency2SecondConfigPressure" || dt.Name == "HighFrequency2ThreeConfigPressure" || dt.Name == "HighFrequency2HeightToSetPressure")
                                            {
                                                //dt.VarValue = (BitConverter.ToInt16(new byte[] { res[dt.Start], res[dt.Start + 1] }, 0)) * 1;
                                                dt.VarValue = (BitConverter.ToInt16(new byte[] { res[dt.Start], res[dt.Start + 1] }, 0)) * 0.001;
                                            }
                                            else
                                            {
                                                dt.VarValue = (BitConverter.ToInt16(new byte[] { res[dt.Start], res[dt.Start + 1] }, 0)) * 0.1;
                                            }
                                        }
                                        else
                                        {
                                            dt.VarValue = BitConverter.ToInt16(new byte[] { res[dt.Start], res[dt.Start + 1] }, 0);
                                        }
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
                                if (CommonMethods.CurrentPLCValue.ContainsKey(dt.Name))
                                {
                                    CommonMethods.CurrentPLCValue[dt.Name] = dt.VarValue;

                                }
                                if (CommonMethods.TrendName.ContainsKey(dt.Name))
                                {
                                    CommonMethods.TrendName[dt.Name].VarValue = dt.VarValue;
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
                    Thread.Sleep(2000);
                    plcConData.objMelsec.Connect(plcConData.IpAddress, plcConData.Port);

                    byte[] res = plcConData.objMelsec.ReadBytes("D0", 2);
                    if (res != null)
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


        /// <summary>
        /// 根据字节获取位
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private string GetbitValue(short input, int index)
        {
            switch (index)
            {
                case 0: return ((short)((input >> 0) & 0x1)).ToString();
                case 1: return ((short)((input >> 1) & 0x1)).ToString();
                case 2: return ((short)((input >> 2) & 0x1)).ToString();
                case 3: return ((short)((input >> 3) & 0x1)).ToString();
                case 4: return ((short)((input >> 4) & 0x1)).ToString();
                case 5: return ((short)((input >> 5) & 0x1)).ToString();
                case 6: return ((short)((input >> 6) & 0x1)).ToString();
                case 7: return ((short)((input >> 7) & 0x1)).ToString();
                case 8: return ((short)((input >> 8) & 0x1)).ToString();
                case 9: return ((short)((input >> 9) & 0x1)).ToString();
                case 10: return ((short)((input >> 10) & 0x1)).ToString();
                case 11: return ((short)((input >> 11) & 0x1)).ToString();
                case 12: return ((short)((input >> 12) & 0x1)).ToString();
                case 13: return ((short)((input >> 13) & 0x1)).ToString();
                case 14: return ((short)((input >> 14) & 0x1)).ToString();
                case 15: return ((short)((input >> 15) & 0x1)).ToString();


                default:
                    return "-1";
            }
        }

        #endregion



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
                        //string plctype = XMLAttributeGetValue(dev, "DeviceType");

                        plcConData = new PLCConnectData()
                        {
                            Name = XMLAttributeGetValue(dev, "Name"),

                            IpAddress = XMLAttributeGetValue(dev, "IpAddress"),
                            Port = int.Parse(XMLAttributeGetValue(dev, "Port")),
                        };
                        XmlNodeList groupdevice = dev.ChildNodes;
                        foreach (XmlNode group in groupdevice)
                        {
                            PLCGroup gp = new PLCGroup()
                            {
                                Name = XMLAttributeGetValue(group, "Name"),
                                Description = XMLAttributeGetValue(group, "Description"),
                                StoreArea = XMLAttributeGetValue(group, "StoreArea"),
                                Start = int.Parse(XMLAttributeGetValue(group, "Start")),
                                Length = int.Parse(XMLAttributeGetValue(group, "Length")),
                            };

                            foreach (XmlNode var in group)
                            {
                                //遍历group里的每个参数值，添加值到变量
                                string varName = XMLAttributeGetValue(var, "Name");
                                string varAddress = XMLAttributeGetValue(var, "VarAddress");
                                string Description = XMLAttributeGetValue(var, "Description");
                                bool TrendEnable = bool.Parse(XMLAttributeGetValue(var, "TrendEnable"));
                                bool ArchiveEnable= bool.Parse(XMLAttributeGetValue(var, "ArchiveEnable"));
                                if (!CommonMethods.CurrentPLCValue.ContainsKey(varName))
                                {
                                    CommonMethods.CurrentPLCValue.Add(varName, "NA");

                                }

                                //strListCurrentName
                                if(!strListCurrentName.Contains(varName)&& ArchiveEnable)
                                {

                                    strListCurrentName.Add(varName);
                                }



                                if (!CommonMethods.CurrentPLCAddress.ContainsKey(varName))
                                {
                                    CommonMethods.CurrentPLCAddress.Add(varName, varAddress);
                                }
                                if (!CommonMethods.TrendName.ContainsKey(Description) && TrendEnable)
                                {
                                    Variable variable = new Variable()
                                    {
                                        Name = varName,
                                        Description = XMLAttributeGetValue(var, "Description"),
                                        VariableAddress = varAddress,
                                        DateType = (VarType)Enum.Parse(typeof(VarType), XMLAttributeGetValue(var, "VarType")),
                                        ByteLength = Convert.ToInt32(XMLAttributeGetValue(var, "ByteLength")),
                                        Start = Convert.ToInt32(XMLAttributeGetValue(var, "Start")),
                                        TrendEnable = bool.Parse(XMLAttributeGetValue(var, "TrendEnable")),
                                        VarValue = XMLAttributeGetValue(var, "VarValue")
                                    };
                                    CommonMethods.TrendName.Add(Description, variable);
                                }







                                gp.listVar.Add(new Variable()
                                    {
                                        Name = varName,
                                        Description = XMLAttributeGetValue(var, "Description"),
                                        VariableAddress = varAddress,
                                        DateType = (VarType)Enum.Parse(typeof(VarType), XMLAttributeGetValue(var, "VarType")),
                                        ByteLength = Convert.ToInt32(XMLAttributeGetValue(var, "ByteLength")),
                                        Start = Convert.ToInt32(XMLAttributeGetValue(var, "Start")),
                                        TrendEnable = bool.Parse(XMLAttributeGetValue(var, "TrendEnable")),
                                        VarValue = XMLAttributeGetValue(var, "VarValue"),
                                        alarm = new Alarm()
                                        {
                                            AlarmEnable = bool.Parse(XMLAttributeGetValue(var, "AlarmEnable")),
                                            AlarmType = bool.Parse(XMLAttributeGetValue(var, "AlarmType")),
                                            ArchiveEnable = bool.Parse(XMLAttributeGetValue(var, "ArchiveEnable")),
                                            DiscreteAlarmType = bool.Parse(XMLAttributeGetValue(var, "DiscreteAlarmType")),
                                            DiscreteAlarmPriority = int.Parse(XMLAttributeGetValue(var, "DiscreteAlarmPriority")),
                                            DiscreteAlarmNote = XMLAttributeGetValue(var, "DiscreteAlarmNote"),

                                            LoLoAlarmEnable = bool.Parse(XMLAttributeGetValue(var, "LoLoAlarmEnable")),
                                            LoLoAlarmValue = float.Parse(XMLAttributeGetValue(var, "LoLoAlarmValue")),
                                            LoLoAlarmPriority = int.Parse(XMLAttributeGetValue(var, "LoLoAlarmPriority")),
                                            LoLoAlarmNote = XMLAttributeGetValue(var, "LoLoAlarmNote"),

                                            LowAlarmEnable = bool.Parse(XMLAttributeGetValue(var, "LowAlarmEnable")),
                                            LowAlarmValue = float.Parse(XMLAttributeGetValue(var, "LowAlarmValue")),
                                            LowAlarmPriority = int.Parse(XMLAttributeGetValue(var, "LowAlarmPriority")),
                                            LowAlarmNote = XMLAttributeGetValue(var, "LowAlarmNote"),

                                            HighAlarmEnable = bool.Parse(XMLAttributeGetValue(var, "HighAlarmEnable")),
                                            HighAlarmValue = float.Parse(XMLAttributeGetValue(var, "HighAlarmValue")),
                                            HighAlarmPriority = int.Parse(XMLAttributeGetValue(var, "HighAlarmPriority")),
                                            HighAlarmNote = XMLAttributeGetValue(var, "HighAlarmNote"),


                                            HiHiAlarmEnable = bool.Parse(XMLAttributeGetValue(var, "HiHiAlarmEnable")),
                                            HiHiAlarmValue = float.Parse(XMLAttributeGetValue(var, "HiHiAlarmValue")),
                                            HiHiAlarmPriority = int.Parse(XMLAttributeGetValue(var, "HiHiAlarmPriority")),
                                            HiHiAlarmNote = XMLAttributeGetValue(var, "HiHiAlarmNote"),

                                        }
                                    });
                            
                            }
                            plcConData.listPLCGroup.Add(gp);

                        }
                        CommonMethods.listPLCConectData.Add(plcConData);
                    }

                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("导入PLC配置文件失败", ex);
                MessageBox.Show("加载文件失败，请确认文件格式是否正确！原因：" + ex.Message);
                Environment.Exit(0);
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


        #region 数据插入数据库
       
        /// <summary>
        /// 更新TemperaTureMeasure表数据
        /// </summary>
        private void UpdataTemp()
        {
           
           if (plcConData.IsConncet)
                {
                int mark =0;

             if(   int.TryParse(CommonMethods.CurrentPLCValue["RunFinish"].ToString(), out mark))
                {

                    if (mark != 0)
                    {
                        try
                        {

                            List<float> fList = new List<float>();
                            List<string> strList = new List<string>();

                            for (int i = 0; i < strListCurrentName.Count; i++)
                            {
                                strList.Add(strListCurrentName[i]);
                                fList.Add(Convert.ToSingle(CommonMethods.CurrentPLCValue[strList[i]]));
                            }

                            StringBuilder strSql = new StringBuilder();
                            strSql.Append(" insert into   TemperaTureMeasure ( InsertTime,");
                            strSql.Append(string.Join(",", strList.ToArray()));
                            strSql.Append("," + " Formula" + "," + "Auto");
                            strSql.Append(") values( ");
                            strSql.Append("'" + PLCIntToDataTime() + "'" + ",");

                            strSql.Append(string.Join(",", fList.ToArray()));
                            strSql.Append("," + "'" + GetString(CommonMethods.CurrentPLCValue["Formula"].ToString()) + "'");
                            strSql.Append("," + CommonMethods.CurrentPLCValue["Auto"]);
                            strSql.Append(" )");

                            if (SQLHelper.Update(strSql.ToString()) > 0)
                            {
                                LogHelper.WriteLog("写入数据库成功");
                                //short i2 = 0;
                                //plcConData.objMelsec.Write(CommonMethods.CurrentPLCAddress["ReadTemp"], i2);
                            }
                        }
                        catch (Exception ex)
                        {
                            //if (LabConnect.Visible)
                            //{
                            LogHelper.WriteLog("写入数据库失败", ex);
                            //}                           
                            LabConnect.Visible = false;
                        }

                        if (Convert.ToInt32(CommonMethods.CurrentPLCValue["RunFinish"]) == 1)
                        {
                            short i2 = 0;
                            try
                            {
                                plcConData.objMelsec.Write(CommonMethods.CurrentPLCAddress["RunFinish"], i2);
                            }
                            catch (Exception ex)
                            {
                                LogHelper.WriteLog("写入PLC失败", ex);
                            }
                        }

                    }

                }

                //if (mark != 0 && !LabConnect.Visible)
       
            }

        }


        private void InsertHighFreData()
        {

            if (plcConData.IsConncet)
            {
                int mark = 0;
                if(  int.TryParse (CommonMethods.CurrentPLCValue["HFRead"].ToString(),out mark))
                 {
                    if (mark ==1)
                    {
                        try
                        {
                            StringBuilder strSql = new StringBuilder();
                            strSql.Append(" insert into   HighFrequency ( InsertTime, Formula, RelativeHeight, HighFrequencyRunTime, HighFrequencyArrivaltime, ");
                            strSql.Append(" MoldingTime, HighFrequency1UpTempPv, HighFrequency1DownTempPv, HighFrequency2UpMaxTemp, HighFrequency2DownMaxTemp,");
                            strSql.Append(" HighFrequency2FirstConfigPressure, HighFrequency2SecondConfigPressure, HighFrequency2ThreeConfigPressure, HighFrequency2HeightToSetPressure)");
                            strSql.Append(" values( @InsertTime, @Formula, @RelativeHeight, @HighFrequencyRunTime, @HighFrequencyArrivaltime,    ");
                            strSql.Append("@MoldingTime, @HighFrequency1UpTempPv, @HighFrequency1DownTempPv, @HighFrequency2UpMaxTemp, @HighFrequency2DownMaxTemp,");
                            strSql.Append(" @HighFrequency2FirstConfigPressure, @HighFrequency2SecondConfigPressure, @HighFrequency2ThreeConfigPressure, @HighFrequency2HeightToSetPressure)");
                            SqlParameter[] para = new SqlParameter[]
                            {
                                new SqlParameter("@InsertTime",PLCIntToDataTime()),
                                new SqlParameter("@Formula",   GetString( CommonMethods.CurrentPLCValue["Formula"].ToString()) ),
                                new SqlParameter("@RelativeHeight", Math.Round(Convert.ToDouble(CommonMethods.CurrentPLCValue["RelativeHeight"]),2)),
                                new SqlParameter("@HighFrequencyRunTime",CommonMethods.CurrentPLCValue["HighFrequencyRunTime"].ToString()+"s"),
                                new SqlParameter("@HighFrequencyArrivaltime",CommonMethods.CurrentPLCValue["HighFrequencyArrivaltime"].ToString()+"s"),
                                new SqlParameter("@MoldingTime",Math.Round((Convert.ToDouble(CommonMethods.CurrentPLCValue["HighFrequencyRunTime"]) - Convert.ToDouble(CommonMethods.CurrentPLCValue["HighFrequencyArrivaltime"])),2 ).ToString()+"s"),
                                new SqlParameter("@HighFrequency1UpTempPv",CommonMethods.CurrentPLCValue["HighFrequency1UpTempPv"]),
                                new SqlParameter("@HighFrequency1DownTempPv",CommonMethods.CurrentPLCValue["HighFrequency1DownTempPv"]),
                                new SqlParameter("@HighFrequency2UpMaxTemp",CommonMethods.CurrentPLCValue["HighFrequency2UpMaxTemp"]),
                                new SqlParameter("@HighFrequency2DownMaxTemp",CommonMethods.CurrentPLCValue["HighFrequency2DownMaxTemp"]),
                                new SqlParameter("@HighFrequency2FirstConfigPressure",CommonMethods.CurrentPLCValue["HighFrequency2FirstConfigPressure"]),
                                new SqlParameter("@HighFrequency2SecondConfigPressure",CommonMethods.CurrentPLCValue["HighFrequency2SecondConfigPressure"]),
                                new SqlParameter("@HighFrequency2ThreeConfigPressure",CommonMethods.CurrentPLCValue["HighFrequency2ThreeConfigPressure"]),
                                new SqlParameter("@HighFrequency2HeightToSetPressure",CommonMethods.CurrentPLCValue["HighFrequency2HeightToSetPressure"]),



                            };



                            if (SQLHelper.ExecuteNonQuery(strSql.ToString(),para) > 0)
                            {
                                LogHelper.WriteLog("写入数据库成功");
                                short i2 = 0;
                                plcConData.objMelsec.Write(CommonMethods.CurrentPLCAddress["HFRead"], i2);
                            }
                        }
                        catch (Exception ex)
                        {
                            LabConnect.Visible = false;
                            LogHelper.WriteLog("写入数据库失败", ex);

                        }
                    }
                }
              
            }


        }


        #endregion
        private void LabConnect_Click(object sender, EventArgs e)
        {
            LabConnect.Visible = true;
        }
        private string GetString(string str)
        {
            string[] strArray = str.Split('\0');
            return strArray[0];

        }

        private void BtnAlarm_Click(object sender, EventArgs e)
        {
            if (objFrmAlarm == null)
            {
                objFrmAlarm = new FrmAlarm();

                //第四步：绑定委托
                myAddLog = objFrmAlarm.AddLog;
            }
            else
            {
                objFrmAlarm.InitialDGV(Convert.ToInt32(new IniConfigHelper().ReadIniData("历史报警显示条数", "Count", "", CommonMethods.FilePath)));
                objFrmAlarm.BringToFront();
            }
            objFrmAlarm.Show();
        }

     
    }

}
