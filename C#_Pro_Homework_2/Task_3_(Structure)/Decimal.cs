using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_2.Task_3__Structure_
{
    struct DecimalNumber
    {
        public int dValue;

        public DecimalNumber (int value)
        {
            dValue = value;
        }

        public string ToBinary()
        {
            return Convert.ToString(dValue,2);
        }

        public string ToOctal()
        {
            return Convert.ToString(dValue,8);
        }
        
        public string ToHex()
        {
            return Convert.ToString(dValue,16);
        }
    }
}
