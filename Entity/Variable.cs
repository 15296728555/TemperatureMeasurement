using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Variable
    {
        public int Start { get; set; }
        public string VariableAddress { get; set; }
        public string Name { get; set; }
        public object VarValue { get; set; }
        public int ByteLength { get; set; }
        public VarType DateType { get; set; }
        public string Description { get; set; }
    }

    public enum VarType
    {
        Bit = 0,
        Byte = 1,
        Word = 2,
        DWord = 3,
        Int = 4,
        DInt = 5,
        Real = 6,
        String = 7,
        Timer = 8,
        Counter = 9
    }

}
