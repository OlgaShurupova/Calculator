using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    /// <summary>
    /// Работа с памятью: MS, MR, M+, M-, MC.
    /// </summary>
    class Storage
    {
        private double Memory { get; set; }


        public double AddToMemory(double argument)
        {
            Memory += argument;
            return Memory;
        }

        public double SubtractFromMemory(double argument)
        {
            Memory -= argument;
            return Memory;
        }

        public double ClearMemory()
        {
            Memory = 0;
            return Memory;
        }

        public double SaveToMemory(double argument)
        {
            Memory = argument;
            return Memory;
        }

        public double ReadFromMemory()
        {
            return Memory;
        }
    }
}
