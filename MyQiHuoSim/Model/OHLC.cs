using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.Model
{
    public class OHLC
    {
        public DateTime Date { get; set; }

        public float Volumn { get; set; }

        public float Open { get; set;}

        public float Close { get; set; }

        public float High { get; set; }

        public float Low { get; set; }
    }
}
