using MyQiHuoSim.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyQiHuoSim.Model
{
    
    public abstract class MinBar
    {
        public MinBarType Type { get; set; }

        protected class CurveImageContext
        {
            /// <summary>
            /// 曲线Canvas
            /// </summary>
            public Bitmap mCanvas { get; set; }

            public int BWidth { get; set; }
            public int BHeight { get; set; }

            public int YMidPoint { get; set; }

            public  float YMinPoint { get; set; }
            public  float YMaxPoint { get; set; }

            //偏移量
            public float YOffset { get; set; }
        }

        protected CurveImageContext mCurveContext { get; set; }



        public List<OHLC> mDatas { get; set; }

        public OHLC LatestBar { get; set; }

        public OHLC FirstBar { get; set; }

        public Quote LatestQuote { get; set; }

        public object syncObj = new object();


        public Point LastDrawPoint { get; set; }
        public int mDrawWindowWidth { get; set; }
        public int mDrawWindowHeight { get; set; }


        public int XStart { get; set; }

        public int YStart { get; set; }



        public int ZoomIndex { get; set; }



        //************* 与交易量相关的

        protected class VolumnImageContext
        {
            public int Height { get; set; }
            public int Width { get; set; }

            /// <summary>
            /// 量Canvas
            /// </summary>
            public Bitmap Canvas { get; set; }

            public float MaxVolumn { get; set; }
        }

        protected VolumnImageContext mVolumnContext { get; set; }

        public MinBar(MinBarType tp)
        {
            Type = tp;
            mDatas = new List<OHLC>();

            mCurveContext = new CurveImageContext();

            mCurveContext.BWidth = 1200;
            mCurveContext.BHeight = 600;
            mCurveContext.YMidPoint = mCurveContext.BHeight / 2;
            mCurveContext.mCanvas = new Bitmap(mCurveContext.BWidth, mCurveContext.BHeight);

            mCurveContext.YMinPoint = mCurveContext.YMidPoint;
            mCurveContext.YMaxPoint = mCurveContext.YMidPoint;

            //交易量
            mVolumnContext = new VolumnImageContext();
            //交易量的宽度必须和Curve的宽度相通
            mVolumnContext.Width = mCurveContext.BWidth;
            mVolumnContext.Height = 200;
            mVolumnContext.Canvas = new Bitmap(mVolumnContext.Width, mVolumnContext.Height);

            LastDrawPoint = new Point();


        }

        public virtual void StartNew()
        {
            XStart = 0;
            YStart = 0;
            ZoomIndex = 0;

            mDatas.Clear();
            FirstBar = null;
            LatestQuote = null;
            LatestBar = null;

            ClearVolumnCanvas();
        }

        protected void ClearVolumnCanvas()
        {
            using (Graphics gr = Graphics.FromImage(mVolumnContext.Canvas))
            {
                Rectangle rect = new Rectangle(0, 0, mVolumnContext.Width, mVolumnContext.Height);
                //gr.FillRectangle(Brushes.Gray, rect);

                //gr.FillRectangle(Brushes.Gray, rect);
                gr.DrawRectangle(Pens.Yellow, rect);
            }
        }
        public abstract void InsertTick(Quote qt);

        protected void ResizeCurveImage(int width, int height)
        {
            Bitmap oldBmp = mCurveContext.mCanvas;
            int oldWidth = mCurveContext.BWidth;
            int oldHeight = mCurveContext.BHeight;

            mCurveContext.mCanvas = new Bitmap(width, height);
            mCurveContext.BWidth = width;
            mCurveContext.BHeight = height;
            mCurveContext.YMidPoint = mCurveContext.BHeight / 2;

            using (Graphics gr = Graphics.FromImage(mCurveContext.mCanvas))
            {
                //Rectangle rect = new Rectangle(0, 0, mCurveContext.BWidth - 3, mCurveContext.BHeight - 3);
                //gr.FillRectangle(Brushes.Black, rect);
                //gr.DrawRectangle(Pens.Red, rect);
                gr.DrawImage(oldBmp, new Rectangle(0, mCurveContext.YMidPoint - oldHeight / 2, oldWidth, oldHeight), new Rectangle(0, 0, oldWidth, oldHeight), GraphicsUnit.Pixel);

            }
            oldBmp = null;

            if(width > oldWidth)
            {
                //宽度跟着Curve变，但是高度不变
                this.ResizeVolumnImage(width, mVolumnContext.Height);
            }
            
        }

        protected void ResizeVolumnImage(int width, int height)
        {
            Bitmap oldBmp = mVolumnContext.Canvas;
            int oldWidth = mVolumnContext.Width;
            int oldHeight = mVolumnContext.Height;

            mVolumnContext.Canvas = new Bitmap(width, height);
            mVolumnContext.Width = width;
            mVolumnContext.Height = height;
  

            using (Graphics gr = Graphics.FromImage(mVolumnContext.Canvas))
            {
                Rectangle rect = new Rectangle(0, 0, mVolumnContext.Width, mVolumnContext.Height);
                //gr.FillRectangle(Brushes.Gray, rect);
                gr.DrawRectangle(Pens.Yellow, rect);

                //画在下方
                gr.DrawImage(oldBmp, new Rectangle(0, height - oldHeight, oldWidth, oldHeight), new Rectangle(0, 0, oldWidth, oldHeight), GraphicsUnit.Pixel);

            }
            oldBmp = null;
        }

        public void FitScreen()
        {
            XStart = LastDrawPoint.x - 500;
            YStart = LastDrawPoint.y - 300;
        }

        public void offsetImage(int xoffset, int yoffset)
        {
            XStart += xoffset;
            YStart += yoffset;

            if(XStart < 0)
            {
                XStart = 0;
            }

            if(XStart > mCurveContext.BWidth)
            {
                XStart = mCurveContext.BWidth;
            }
        }

        public void ZoomOffset(int offset)
        {
            ZoomIndex += offset;

        }


        public void _updateCurveWindow(int w,int h)
        {
            mDrawWindowWidth = w;
            mDrawWindowHeight = h;            
        }

        public void DrawOnGraphics(Graphics gs,int width,int height)
        {
            if (mCurveContext.mCanvas == null)
                return;

            int xImage = width - ZoomIndex;    

            int yImage = height;// - ZoomIndex;
            //gs.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //new Rectangle(0, 0, mCanvas.Width, mCanvas.Height)
            //new Rectangle(0, 0, width, height)

            int volumnCanvasHeight = 200;
            int canvasHeight = height - volumnCanvasHeight;

            lock (syncObj)
            {
                gs.DrawImage(mCurveContext.mCanvas, new Rectangle(0, 0, width, canvasHeight), new Rectangle(XStart, YStart, xImage, canvasHeight), GraphicsUnit.Pixel);

                gs.DrawImage(mVolumnContext.Canvas, new Rectangle(0, canvasHeight, width, volumnCanvasHeight), new Rectangle(XStart, 0, xImage, mVolumnContext.Height), GraphicsUnit.Pixel);
            }
        }
    }
}
