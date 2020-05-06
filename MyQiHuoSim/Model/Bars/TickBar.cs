using MyQiHuoSim.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.Model.Bars
{
    internal class TickBar : MinBar
    {
        public TickBar():base(MinBarType.BTick)
        {
        }

        public override void StartNew()
        {
            base.StartNew();
            RedrawAllDatas();
        }



        public override void InsertTick(Quote qt)
        {
            OHLC hl = new OHLC();
            hl.Index = qt.index;
            hl.Open = qt.last_price;
            hl.Date = qt.datetime;
            if(LatestQuote != null)
            {
                hl.Volumn = qt.volume - LatestQuote.volume;
            }
            mDatas.Add(hl);

            if (FirstBar == null)
            {
                FirstBar = hl;

                mVolumnContext.MaxVolumn = hl.Volumn;

                //根据第一个传进来的价格定义偏移量
                mCurveContext.YOffset = hl.Open;
            }

            //调整量的大小
            if(mVolumnContext.MaxVolumn < hl.Volumn)
            {
                mVolumnContext.MaxVolumn = hl.Volumn;
            }

            if (LatestBar != null)
            {
                lock (syncObj)
                {
                    DrawCanvasIncrease(LatestBar, hl);

                    DrawVolumnIncrease(LatestBar, hl);
                }
            }


            LatestQuote = qt;
            LatestBar = hl;
        }





        private void DrawCanvasIncrease(OHLC lastItem, OHLC newItem)
        {
            int xNow = mDatas.Count();
            if(xNow >= mCurveContext.BWidth - 100)
            {
                ResizeCurveImage(mCurveContext.BWidth + 1000, mCurveContext.BHeight);
            }

            if(mCurveContext.YMinPoint < 200 || mCurveContext.YMaxPoint > mCurveContext.BHeight - 200)
            {
                ResizeCurveImage(mCurveContext.BWidth, mCurveContext.BHeight + 400);

                mCurveContext.YMinPoint = mCurveContext.YMidPoint;
                mCurveContext.YMaxPoint = mCurveContext.YMidPoint;
            }

            using (Graphics gr = Graphics.FromImage(mCurveContext.mCanvas))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                
                //Open里面表示的就是当前的价格
                float yOff = newItem.Open - mCurveContext.YOffset;

                //注意方向，增加的话向上的，那么就是减的
                float y = mCurveContext.YMidPoint - 20 * yOff;            

                if (lastItem != null)
                {
                    Color cl = Color.White;
                    if(lastItem.Open < newItem.Open)
                    {
                        cl = Color.Red;
                    }else if(lastItem.Open > newItem.Open)
                    {
                        cl = Color.Green;
                    }
                    using (Pen thick_pen = new Pen(cl, 1))
                    {
                        yOff = lastItem.Open - mCurveContext.YOffset;
                        float yLast = mCurveContext.YMidPoint - 20 * yOff;

                        gr.DrawLine(thick_pen, xNow-1, yLast, xNow, y);
                    }
                }

                //记录最后一个点，方便做屏幕在切换不同类型时能自动的找到最近的点。
                LastDrawPoint.x = xNow - 1;
                LastDrawPoint.y = (int)y;



                if (FirstBar != null)
                {
                    if (y < mCurveContext.YMinPoint)
                    {
                        mCurveContext.YMinPoint = y;
                    }

                    if (y > mCurveContext.YMaxPoint)
                    {
                        mCurveContext.YMaxPoint = y;
                    }
                }
            }

            FitScreen();
        }

        private void DrawVolumnIncrease(OHLC lastItem, OHLC newItem)
        {
            int xNow = mDatas.Count();

            //if (newItem.Volumn > mVolumnContext.Canvas.Height - 10)
            //{
            //    this.ResizeCurveImage(mVolumnContext.Width, (int)newItem.Volumn + 20);
            //}

            using (Graphics gr = Graphics.FromImage(mVolumnContext.Canvas))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                

                float vRation = newItem.Volumn / mVolumnContext.MaxVolumn;

                float barHeight = mVolumnContext.Height * vRation;

                float y = mVolumnContext.Height - barHeight;

                Color cl = Color.White;
                if (lastItem.Open < newItem.Open)
                {
                    cl = Color.Red;
                }
                else if (lastItem.Open > newItem.Open)
                {
                    cl = Color.Green;
                }
                using (Pen thick_pen = new Pen(cl, 1))
                {                  

                    gr.DrawLine(thick_pen, xNow, mVolumnContext.Height - 1, xNow, y);
                }


            }
        }

        private void RedrawAllDatas()
        {
            using (Graphics gr = Graphics.FromImage(mCurveContext.mCanvas))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                //Rectangle rect = new Rectangle(0, 0, mCurveContext.BWidth, mCurveContext.BHeight);
                //gr.FillRectangle(Brushes.Black, rect);

                OHLC lastItem = null;
                float xLast = 0;
                float yLast = 0;
                int xIndex = 1;
                foreach(var item in mDatas)
                {
                    float yOff = item.Open - mCurveContext.YOffset;
                    float y = mCurveContext.YMidPoint + yOff;                   

                    if(lastItem != null)
                    {
                        using (Pen thick_pen = new Pen(Color.White, 1))
                        {
                            thick_pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Flat);
                            gr.DrawLine(thick_pen, xLast, yLast, xIndex, y);
                        }                        
                    }

                    xLast = xIndex;
                    yLast = y;
                    lastItem = item;
                }

                //using (Pen thick_pen = new Pen(Color.Blue, 5))
                //{
                //    gr.DrawRectangle(thick_pen, rect);
                //}
            }
        }

        public override OHLC GetBarFromScreenPoint(int x, int y)
        {
            int xImageWidth = DrawWindowWidth - ZoomIndex;

            float xZoom = ((float)xImageWidth / DrawWindowWidth) * x;

            int realX = (int)(XStart + xZoom);

            int ohlcCount = mDatas.Count();
            if(ohlcCount > realX)
            {
                return mDatas[realX];
            }

            return null;
        }
    }
}
