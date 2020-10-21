
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
  public  class PLCGroup
    {
        //<DeviceGroup Name = "实时参数" Description="D100--D199  
        //    StoreArea="D区" Length="200" Start="0" DBNo="0" IsActive="true">
        public string Name { get; set; }
        public string Description { get; set; }
        public string StoreArea { get; set; }
        public int Length { get; set; }
        public int Start { get; set; }
        public List<Variable> listVar = new List<Variable>();

    }
}
