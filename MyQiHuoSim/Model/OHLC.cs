using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.Model
{
    public class OHLC
    {
        /// <summary>
        /// Tick的索引，用来管理quote的，方便找到起始的quote
        /// </summary>
        public int Index { get; set; }
        public DateTime Date { get; set; }

        public float Volumn { get; set; }

        public float Open { get; set;}

        public float Close { get; set; }

        public float High { get; set; }

        public float Low { get; set; }

        public override string ToString()
        {
            return Date.ToString("HH:mm:ss:fff") + "\n"                
                 + "开:" + Open.ToString() + "\n"
                 + "收:" + Close.ToString() + "\n"
                 + "最高:" + High.ToString() + "\n"
                 + "最低:" + Low.ToString() + "\n"
                 + "量:" + Volumn.ToString() + "\n"

                 ;
        }
    }
}
