using MyQiHuoSim.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.Views
{
    internal class OHLCBarDetailView
    {
        public OHLC LatestOHLC { get; set; }

        public System.Drawing.Point MousePoint { get; set; }

        public void DrawOnWindow(Graphics gs, int width, int height)
        {
           
        }
    }
}
