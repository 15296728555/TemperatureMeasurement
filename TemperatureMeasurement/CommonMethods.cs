
using DAL;
using Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace TemperatureMeasurement
{
  public static  class CommonMethods
    {
        //变量名称和变量数值的字典集合
        public static Dictionary<string, object> CurrentPLCValue = new Dictionary<string, object>();
        //PLC系统时间
       
        //变量名称和变量地址的字典集合
        public static Dictionary<string, string> CurrentPLCAddress = new Dictionary<string, string>();
        //定义静态登录名
        public static SysAdmins objAdmins = new SysAdmins();
        //定义INI文件路径
        public  static readonly string FilePath = Application.StartupPath + "\\3rd\\Config.ini";
       
        //变量描述和变量名称的字典集合
        public static Dictionary<string, Variable> TrendName = new Dictionary<string, Variable>();
        //读取"\\3rd\\Config.ini"文件的[C/S选择]，为True时运行服务器程序，为False时执行远程客户段程序
        public static  bool IsServer;
        //PLC 装置集合
        public static List<PLCConnectData> listPLCConectData = new List<PLCConnectData>();
       
        //如果后期增加其他品牌PLC，可以使用ArrayList,来适应多个品牌
        //public static ArrayList listPLCConectData1 = new ArrayList();
        //创建归档变量集合
        public static List<Variable> ArchiveVar = new List<Variable>();
     
        //报警记录载入数据库
        public static void LogSQLite(AlarmInfo info)
        {
            string sql = "Insert into AlarmData(InsertTime,VarName,AlarmState,Priority,AlarmValue,Note,Operator,AlarmImage) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}')";

            sql = string.Format(sql, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), info.VarName, info.AlarmState, info.Priority, info.AlarmValue, info.Note, CommonMethods.objAdmins.LoginName,info.AlarmImage);

            SQLHelper.Update(sql);
        }
      
       


   }


 }

   




