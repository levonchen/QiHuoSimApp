using MyQiHuoSim.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.QHEvents
{
    public class QuoteEventArgs : EventArgs
    {
        public Quote  quote { get; set; }
    }
}
