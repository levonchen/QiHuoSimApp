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
    internal class OneMinBar : MinBar
    {
        public OneMinBar() : base(MinBarType.B1Min)
        {
        }

        public override void StartNew()
        {
            base.StartNew();
            FirstBar = null;

            mVolumnContext.MaxVolumn = 1000;

            RedrawAllDatas();
        }

        public override void InsertTick(Quote qt)
        {
            float volumn = 0;
            if (LatestQuote != null)
            {
                volumn = qt.volume - LatestQuote.volume;
            }

            

            if (LatestBar == null)
            {
                LatestBar = new OHLC();
                LatestBar.Index = qt.index;
                LatestBar.Date = qt.datetime;
                LatestBar.Open = qt.last_price;
                LatestBar.Close = qt.last_price;
                LatestBar.High = qt.last_price;
                LatestBar.Low = qt.last_price;
                LatestBar.Volumn = volumn;

                mDatas.Add(LatestBar);
            }
            else
            {
                if(LatestBar.Date.Minute != qt.datetime.Minute)
                {
                    LatestBar = new OHLC();
                    LatestBar.Index = qt.index;
                    LatestBar.Date = qt.datetime;
                    LatestBar.Open = qt.last_price;
                    LatestBar.Close = qt.last_price;
                    LatestBar.High = qt.last_price;
                    LatestBar.Low = qt.last_price;
                    LatestBar.Volumn = volumn;

                    mDatas.Add(LatestBar);
                }
                else
                {
                    if(LatestBar.High < qt.last_price)
                    {
                        LatestBar.High = qt.last_price;
                    }
                    if(LatestBar.Low > qt.last_price)
                    {
                        LatestBar.Low = qt.last_price;
                    }
                    LatestBar.Volumn += volumn;

                    LatestBar.Close = qt.last_price;
                }
            }

            //就是为了敲过第一个tick
            if(LatestQuote == null)
            {
                LatestQuote = qt;
                return;
            }            

            if (FirstBar == null)
            {
                FirstBar = LatestBar;
                mCurveContext.YOffset = LatestBar.Open;

                if (20 * LatestBar.Volumn > mVolumnContext.MaxVolumn)
                {
                    mVolumnContext.MaxVolumn = 20 * LatestBar.Volumn;
                }
            }

            if(LatestBar.Volumn > mVolumnContext.MaxVolumn)
            {
                mVolumnContext.MaxVolumn = LatestBar.Volumn + 100;

            }

            lock (syncObj)
            {
                DrawIncrease(LatestBar);
                DrawVolumnIncrease(LatestBar);
            }

            LatestQuote = qt;

        }


        private void DrawIncrease(OHLC lastItem)
        {
            int xNow = mDatas.Count();
            if (xNow >= mCurveContext.BWidth - 100)
            {
                ResizeCurveImage(mCurveContext.BWidth + 1000, mCurveContext.BHeight);
            }

            if (mCurveContext.YMinPoint < 200 || mCurveContext.YMaxPoint > mCurveContext.BHeight - 200)
            {
                ResizeCurveImage(mCurveContext.BWidth, mCurveContext.BHeight + 400);

                mCurveContext.YMinPoint = mCurveContext.YMidPoint;
                mCurveContext.YMaxPoint = mCurveContext.YMidPoint;
            }

            using (Graphics gr = Graphics.FromImage(mCurveContext.mCanvas))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                DrawOneBar(xNow, gr, lastItem);
            }

            FitScreen();
        }


        private void DrawVolumnIncrease(OHLC newItem)
        {
            int xNow = mDatas.Count();

            float xOff = (xNow - 1) * 10;

            using (Graphics gr = Graphics.FromImage(mVolumnContext.Canvas))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;


                float vRation = newItem.Volumn / mVolumnContext.MaxVolumn;

                float barHeight = mVolumnContext.Height * vRation;

                float y = mVolumnContext.Height - barHeight;

                Brush cl = Brushes.White;
                if (newItem.Open < newItem.Close)
                {
                    cl = Brushes.Red;
                }
                else if (newItem.Open > newItem.Close)
                {
                    cl = Brushes.Green;
                }
                //刷背景
                gr.FillRectangle(Brushes.Black, xOff, 2, 10, mVolumnContext.Height);

                gr.FillRectangle(cl, xOff + 2, y, 8, barHeight);           
              

            }
        }


        private void DrawOneBar(int xNow, Graphics gr,OHLC lastItem)
        {

            float xOff = (xNow - 1) * 10;

            float yOff = 20 * (lastItem.Open - mCurveContext.YOffset);

            float y = mCurveContext.YMidPoint - yOff;

            int barHeight = 20 * (int)Math.Abs(lastItem.Open - lastItem.Close);

            float yTmpMax = 20 * (lastItem.High - mCurveContext.YOffset);
            yTmpMax = mCurveContext.YMidPoint - yTmpMax;

            float yTmpMin = 20 * (lastItem.Low - mCurveContext.YOffset);
            yTmpMin = mCurveContext.YMidPoint - yTmpMin;

            //清空背景
            gr.FillRectangle(Brushes.Black, xOff, 0, 10, mCurveContext.BHeight);


            if (barHeight == 0)
            {
                gr.DrawLine(Pens.White, xOff + 1, y, xOff + 9, y);
                gr.DrawLine(Pens.White, xOff + 4, yTmpMax, xOff + 4, yTmpMin);
            }
            else
            {
                
                if (lastItem.Close < lastItem.Open)
                {
                    Rectangle rect = new Rectangle((int)xOff + 1, (int)y, 8, barHeight);
                    gr.FillRectangle(Brushes.Green, rect);

                    gr.DrawLine(Pens.Green, xOff + 5, yTmpMax, xOff + 5, yTmpMin);
                }
                else
                {
                    Rectangle rect = new Rectangle((int)xOff + 1, (int)y - barHeight, 8, barHeight);
                    gr.FillRectangle(Brushes.Red, rect);

                    gr.DrawLine(Pens.Red, xOff + 5, yTmpMax, xOff + 5, yTmpMin);
                }            

    
            }


            //记录最后一个点，方便做屏幕在切换不同类型时能自动的找到最近的点。
            LastDrawPoint.x = (int)xOff;
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


        private void RedrawAllDatas()
        {
            using (Graphics gr = Graphics.FromImage(mCurveContext.mCanvas))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                //Rectangle rect = new Rectangle(0, 0, mCurveContext.BWidth, mCurveContext.BHeight);
                //gr.FillRectangle(Brushes.Black, rect);


                int xIndex = 1;
                foreach (var item in mDatas)
                {
                    DrawOneBar(xIndex, gr, item);
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

            if(DrawWindowWidth == 0)
            {
                return null;
            }

            float xZoom = ((float)xImageWidth / DrawWindowWidth) * x;

            int realX = (int)(XStart + xZoom);

            //每一个bar是10个像素的宽度
            int indexReal = realX / 10;

            int ohlcCount = mDatas.Count();
            if (ohlcCount > indexReal)
            {
                return mDatas[indexReal];
            }

            return null;
        }

    }
}
