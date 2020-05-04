using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQiHuoSim.Model;
using MyQiHuoSim.Service;
using System.Windows;
using System.Drawing.Drawing2D;

namespace MyQiHuoSim
{
    public partial class CandleStickView : UserControl
    {    
        public CandleStickView()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            DataService.Instance.OnQuoteTick += Instance_OnQuoteTick;

            this.MouseWheel += CandleStickView_MouseWheel;

            //setup();
        }



        private void Instance_OnQuoteTick(object sender, QHEvents.QuoteEventArgs e)
        {
            Invalidate();
        }

        private void CandleStickView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Width, this.Height);

            //e.Graphics.DrawLine(Pens.White, mContext.ClickPoint.x, 0, mContext.ClickPoint.x, this.Height);
            //e.Graphics.DrawLine(Pens.White, 0, mContext.ClickPoint.y,this.Width, mContext.ClickPoint.y);

            DrawImageService.Instance.DrawOnGraphics(e.Graphics, this.Width,this.Height);

            
            //e.Graphics.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), new Rectangle(0, 0, this.Width, this.Height),GraphicsUnit.Pixel);
            //);

        }

        private void CandleStickView_MouseClick(object sender, MouseEventArgs e)
        {
            //mContext.ClickPoint.x = e.X;
           // mContext.ClickPoint.y = e.Y;
        }

        int xMoveStart = 0;
        int yMoveStart = 0;

        private void CandleStickView_MouseMove(object sender, MouseEventArgs e)
        {
            //mContext.ClickPoint.x = e.X;
            // mContext.ClickPoint.y = e.Y;
            //this.Invalidate();

            if (e.Button == MouseButtons.Left)
            {
                int xOffset =  xMoveStart - e.X;
                int yOffset =  yMoveStart - e.Y;

                DrawImageService.Instance.mCandleContext.offsetImage(xOffset, yOffset);

                xMoveStart = e.X;
                yMoveStart = e.Y;

                Invalidate();
            }
        }

        private void CandleStickView_MouseDown(object sender, MouseEventArgs e)
        {
           if( e.Button == MouseButtons.Left)
            {
                xMoveStart = e.X;
                yMoveStart = e.Y;
            }
        }

        private void CandleStickView_MouseWheel(object sender, MouseEventArgs e)
        {
            Console.WriteLine( e.Delta);

            int zoomOffset = e.Delta / 120;

            DrawImageService.Instance.mCandleContext.ZoomOffset(10*zoomOffset);
            Invalidate();
        }
    }
}
