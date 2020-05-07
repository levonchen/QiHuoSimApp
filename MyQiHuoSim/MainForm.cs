using MyQiHuoSim.Dialogs;
using MyQiHuoSim.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQiHuoSim
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const String PipeName = "qihuopipe";

        private static NamedPipeServerStream server;
        private static BinaryReader bReader;
        private static BinaryWriter bWriter;

        private static bool goon = true;
        private readonly object _lock = new object();
        private readonly Queue<string> _queue = new Queue<string>();

        private Thread producerThread = null;

        private delegate void delegateSetTickValue(String tick);

        private void Form1_Load(object sender, EventArgs e)
        {
            //server = new NamedPipeServerStream(PipeName);
            //bReader = new BinaryReader(server);
            //bWriter = new BinaryWriter(server);
            //producerThread = new Thread(new ThreadStart(ProducerThread));

            //producerThread.Start();

            Console.WriteLine("Form.... loaded");

            //加载配置
            dealPanel1.LoadAppSetting();

            toolStripComboBox_Speed.Items.AddRange(DataService.Instance.TimeSpeed.Keys.ToArray());
            toolStripComboBox_Speed.SelectedIndex = 0;            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //goon = false;
            //Console.WriteLine("Stopping .... ");
            //producerThread.Join();
            //Console.WriteLine("Stopped .... ");

            //if (server != null)
            //{  
            //    server.Close();
            //    server.Dispose();
            //    server = null;
            //}
            //Application.Exit();
        }

        private void setTickDelegate(String tick)
        {
            string[] items = tick.Split(',');
            if (items.Length <3)
                return;

            Double ask1 = Double.Parse(items[0]);
            Double bid1 = Double.Parse(items[1]);   

        }

        private void ProducerThread()
        {
            while (goon)
            {  
                try
                {
                    if(server == null)
                    {
                        server = new NamedPipeServerStream(PipeName);
                        bReader = new BinaryReader(server);
                        bWriter = new BinaryWriter(server);
                    }

                    if ( !server.IsConnected)
                        server.WaitForConnection();

                    if (server != null && server.IsConnected)
                    {
                        var len = (int)bReader.ReadUInt32();
                        var str = new string(bReader.ReadChars(len));
                        Console.WriteLine(str);

                        this.BeginInvoke(new delegateSetTickValue(setTickDelegate), str);
                    }
                }
                catch (Exception EX)
                {
                    //MessageBox.Show(EX.Message.ToString());
                    if (server != null)
                    {
                        server.Close();
                        server.Dispose();
                        server = null;
                    }
                }
            }
        }

        private void toolStripButtonLoadDatas_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String filePath = dlg.FileName;
                DataService.Instance.LoadAllDatas(filePath);
            }
            DrawImageService.Instance.StartDraw();
            candleStickView1.Invalidate();

            init_starttime_droplist();
        }

        private void init_starttime_droplist()
        {
            toolStripDropDownButton_SpecifyTimeStart.DropDownItems.Clear();
            var items = DataService.Instance.GetAllTimeStartKeys();
            foreach (var it in items)
            {
                toolStripDropDownButton_SpecifyTimeStart.DropDownItems.Add(it);
            }
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            DrawImageService.Instance.StartDraw();
            DataService.Instance.StartPlay(false);           
        }

        private void toolStripButton_randomStart_Click(object sender, EventArgs e)
        {
            DrawImageService.Instance.StartDraw();
            DataService.Instance.StartPlay(true);
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            DataService.Instance.EndReadData();
        }

        private void toolStripButtonNextTick_Click(object sender, EventArgs e)
        {
            DataService.Instance.NextTick();
            candleStickView1.Invalidate();
        }

        private void toolStripButton_Pause_Click(object sender, EventArgs e)
        {
            DataService.Instance.Pause();

        }

        private void toolStripButton_Continue_Click(object sender, EventArgs e)
        {
            DataService.Instance.Continue();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripComboBox_Speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            String txt = toolStripComboBox_Speed.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(txt))
            {
                DataService.Instance.UpdateSpeed(txt);
            }
        }

        private void oolStripMenuItem_TickBar_Click(object sender, EventArgs e)
        {
            DrawImageService.Instance.mCandleContext.SetBarType(Model.MinBarType.BTick);
            toolStripDropDownButton_BarTypeSelect.Text = "分时图";
            DrawImageService.Instance.mCandleContext.FitBarView();
            candleStickView1.Invalidate();
            
        }

        private void ToolStripMenuItem_OneMiBar_Click(object sender, EventArgs e)
        {
            DrawImageService.Instance.mCandleContext.SetBarType(Model.MinBarType.B1Min);
            toolStripDropDownButton_BarTypeSelect.Text = "1分钟";
            DrawImageService.Instance.mCandleContext.FitBarView();
            candleStickView1.Invalidate();
        }

        private void toolStripDropDownButton_SpecifyTimeStart_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton_SpecifyTimeStart_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String strText = e.ClickedItem.Text;
            DrawImageService.Instance.StartDraw();
            DataService.Instance.StartPlayBySpecifyTimeKey(strText);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.NumPad4)
            //{
            //    Console.WriteLine("Num 4 pressed");
            //}

            //if (e.KeyCode == Keys.NumPad6)
            //{
            //    Console.WriteLine("Num 6 pressed");
            //}

            dealPanel1.ExecuteShutupCommand(e.KeyCode);
        }

        private void toolStripButton_Setting_Click(object sender, EventArgs e)
        {
            SettingsDlg dlg = new SettingsDlg();

            dlg.ShowDialog(this);
            dealPanel1.LoadAppSetting();
        }
    }
}
