using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xktComm;
namespace Entity
{
    public class PLCConnectData
    {
        //<DeviceNode Name = "三菱PLC"  Description="PLC" DeviceType="30"  
        //    IpAddress="192.168.1.10" Port="102" PlcType="FX5U">
        public PLCConnectData()
        {
            objMelsec = new Melsec(MelsecProtocolType.MCBinary);
            listPLCGroup = new List<PLCGroup>();
        }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public bool IsConncet { get; set; } = false;
        public  Melsec objMelsec ;
        public List<PLCGroup> listPLCGroup;
    }
}
