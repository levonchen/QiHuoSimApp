using MyQiHuoSim.Model;
using MyQiHuoSim.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.Service
{
    public class DrawImageService : BaseLazySingleton<DrawImageService>
    {
        public CandleContext mCandleContext { get; set; }
        public DrawImageService()
        {
            DataService.Instance.OnQuoteTick += Instance_OnQuoteTick;
            mCandleContext = new CandleContext();

        }

        private void Instance_OnQuoteTick(object sender, QHEvents.QuoteEventArgs e)
        {
            mCandleContext.OnTick(e.quote);   
        }

        public void StartDraw()
        {
            mCandleContext.StartNew();
        }

        public void DrawOnGraphics(Graphics gs, int width, int height)
        {
            mCandleContext.DrawOnGraphics(gs, width, height);
        }


    }
}
