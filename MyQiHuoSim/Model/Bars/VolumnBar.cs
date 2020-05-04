using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQiHuoSim.Entity;

namespace MyQiHuoSim.Model.Bars
{
    internal class VolumnBar
    {
        private MinBarType mCurveBarType { get; set; }

        private int MHeight { get; set; }
        private int MWeight { get; set; }
        public VolumnBar(MinBarType barType)
        {
            mCurveBarType = barType;

            //默认
            MHeight = 1000;
            MWeight = 1000;
        }
        public void InsertVolumn(OHLC oc)
        {
            
        }
    }
}
