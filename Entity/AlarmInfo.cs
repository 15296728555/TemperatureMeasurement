using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entity
{
    [Serializable]
    public class AlarmInfo
    {
         //变量名
        public string VarName { get; set; }
        //插入数据库时间
        public string InsertTime { get; set; }

        //ACK UNACK
        public string AlarmState { get; set; }
        //报警优先级，根据不同的值对应不同的报警图片
        public int Priority { get; set; }
        //报警值
        public string AlarmValue { get; set; }
        //报警文本
        public string Note { get; set; }
        //操作员name
        public string Operator { get; set; }


        //报警图片，分为info,warning,error三级
        public string AlarmImage { get; set; }
       

    }
}
