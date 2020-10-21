using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureMeasurement
{
  public static  class CommonMethods
    {
        //变量名称和变量数值的字典集合
        public static Dictionary<string, object> CurrentPLCValue = new Dictionary<string, object>();

        //变量名称和变量地址的字典集合
        public static Dictionary<string, string> CurrentPLCAddress = new Dictionary<string, string>();

        public static SysAdmins objAdmins = new SysAdmins();
    }
}
