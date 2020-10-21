using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Alarm

    {
        //报警是否启用
        public bool AlarmEnable { get; set; } = false;
        //报警归档是否启用，True是写入数据库，false 只是报警显示
       public bool ArchiveEnable { get; set; } = false;
        //报警类型，True为条件报警，False为离散报警
        public bool AlarmType { get; set; } = false;
        //报警类型  True为上升沿报警，False为下降沿报警
        public bool DiscreteAlarmType { get; set; } = false;

        public bool DiscreteCacheValue { get; set; } = false;

        public int DiscreteAlarmPriority { get; set; } = 0;

        public string DiscreteAlarmNote { get; set; } = string.Empty;

        public bool LoLoAlarmEnable { get; set; } = false;

        public float LoLoAlarmValue { get; set; } = 0.0f;

        public float LoLoCacheValue { get; set; } = 100000.0f;

        public int LoLoAlarmPriority { get; set; } = 0;

        public string LoLoAlarmNote { get; set; } = string.Empty;

        public bool LowAlarmEnable { get; set; } = false;

        public float LowAlarmValue { get; set; } = 0.0f;

        public float LowCacheValue { get; set; } = 100000.0f;

        public int LowAlarmPriority { get; set; } = 0;

        public string LowAlarmNote { get; set; } = string.Empty;

        public bool HighAlarmEnable { get; set; } = false;

        public float HighAlarmValue { get; set; } = 0.0f;

        public float HighCacheValue { get; set; } = -100000.0f;

        public int HighAlarmPriority { get; set; } = 0;

        public string HighAlarmNote { get; set; } = string.Empty;

        public bool HiHiAlarmEnable { get; set; } = false;

        public float HiHiAlarmValue { get; set; } = 0.0f;

        public float HiHiCacheValue { get; set; } = -100000.0f;

        public int HiHiAlarmPriority { get; set; } = 0;

        public string HiHiAlarmNote { get; set; } = string.Empty;

        
    }
}
