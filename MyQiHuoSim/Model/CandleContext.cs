using MyQiHuoSim.Entity;
using MyQiHuoSim.Model.Bars;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyQiHuoSim.Model
{
    public class CandleContext
    {
        private MinBar m_TickBar { get; set; }
        private MinBar m_OneMinBar { get; set; }

        public CandleContext()
        {
            ClickPoint = new Point();

            //TickBar = new TickBar();

           m_TickBar = new TickBar();
            m_OneMinBar = new OneMinBar();

            TickBar = m_TickBar;

            //TickBar = new OneMinBar();
        }

        public void SetBarType(MinBarType tp)
        {
            if(tp == MinBarType.BTick)
            {
                TickBar = m_TickBar;
            }
            else
            {
                TickBar = m_OneMinBar;
            }

            TickBar.FitScreen();
        }
        
        public Point ClickPoint { get; set; }

        /// <summary>
        /// 分时图
        /// </summary>
        public MinBar TickBar { get; set; }

        public void StartNew()
        {
            m_TickBar.StartNew();
            m_OneMinBar.StartNew();
        }

        public void OnTick(Quote qt)
        {
            m_TickBar.InsertTick(qt);
            m_OneMinBar.InsertTick(qt);
        }

        public OHLC GetBarFromScreenPoint(int x, int y)
        {
            return TickBar.GetBarFromScreenPoint(x, y);
        }

        public void DrawOnGraphics(Graphics gs, int width, int height)
        {
            TickBar.DrawOnGraphics(gs, width, height);
        }

        public void FitBarView()
        {
            TickBar.FitScreen();
        }

        public void offsetImage(int xoffset,int yoffset)
        {
            m_TickBar.offsetImage(xoffset, yoffset);
            m_OneMinBar.offsetImage(xoffset, yoffset);
        }

        public void ZoomOffset(int offset)
        {
            m_TickBar.ZoomOffset(offset);
            m_OneMinBar.ZoomOffset(offset);
        }
    }
}
