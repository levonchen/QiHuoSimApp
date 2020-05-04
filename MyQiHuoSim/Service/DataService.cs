﻿using Microsoft.VisualBasic.FileIO;
using MyQiHuoSim.Entity;
using MyQiHuoSim.QHEvents;
using MyQiHuoSim.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyQiHuoSim.Service
{
    public class DataService : BaseLazySingleton<DataService>
    {

        public String DataInputFilePath {get;set;} 


        private System.Timers.Timer mTimer { get; set; }

        public Dictionary<String,int> TimeSpeed { get; set; }


        public event EventHandler<QuoteEventArgs> OnQuoteTick;

        public List<Quote> allQuotes { get; set; }
        public int readIndex { get; set; }

        public DataService()
        {
            DataInputFilePath = @"C:\DataRecord\SHFE.fu20092020_04_29.csv";

            TimeSpeed = new Dictionary<string, int>();
            TimeSpeed.Add("1倍", 500);
            TimeSpeed.Add("2倍", 200);
            TimeSpeed.Add("5倍", 100);
            TimeSpeed.Add("10倍", 50);
            TimeSpeed.Add("100倍", 5);

            mTimer = new System.Timers.Timer();
            mTimer.Interval = 500;
            mTimer.Elapsed += MTimer_Elapsed;
            mTimer.AutoReset = true;
        }

        public void UpdateSpeed(string key)
        {
            int v = TimeSpeed[key];
            mTimer.Interval = v;
        }

        private void MTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            NextTick();
        }

        public void Invoke_OnQuoteTick(Quote qt)
        {
            QuoteEventArgs args = new QuoteEventArgs();
            args.quote = qt;
            OnQuoteTick?.Invoke(this, args);
        }

        public void LoadAllDatas(String filePath)
        {
            allQuotes = new List<Quote>();
            using (var csvParse = new StreamReader(File.OpenRead(filePath)))
            {
                var qt = GetOneLine(csvParse);
                while (qt != null)
                {
                    //加一个索引
                    qt.index = allQuotes.Count();

                    allQuotes.Add(qt);
                    qt = GetOneLine(csvParse);
                }
            }
        }

        public void StartPlayData(bool bUseRandomStartIndex)
        {
            if(allQuotes.Count() == 0)
            {
                return;
            }

            DrawImageService.Instance.StartDraw();
            if (bUseRandomStartIndex)
            {
                Random random = new Random();
                int maxTicket = allQuotes.Count() - 600;
                readIndex = random.Next(maxTicket);
            }
            else
            {
                readIndex = 0;
            }
            mTimer.Enabled = true;
        }

        public void NextTick()
        {

            var qt = _NextTice();//GetOneLine();
            if (qt != null)
            {
                Invoke_OnQuoteTick(qt);
            }
            else
            {
                EndReadData();
            }
        }

        public void Pause()
        {
            mTimer.Enabled = false;
        }

        public void Continue()
        {
            mTimer.Enabled = true;
        }

        private Quote _NextTice()
        {
            if(readIndex < allQuotes.Count())
            {
                Quote qt = allQuotes[readIndex++];
                return qt;
            }
            else
            {
                return null;
            }
        }

        private Quote GetOneLine(StreamReader reader)
        {
            if(reader == null)
            {
                return null;
            }
            if(reader.EndOfStream)
                return null;

            var line = reader.ReadLine();
            string[] fields = line.Split(',');

            Quote qt = new Quote();
            qt.datetime = DateTime.Parse(fields[0]);

            qt.ask_price1 = float.Parse(fields[1]);
            qt.ask_volume1 = float.Parse(fields[2]);
            qt.bid_price1 = float.Parse(fields[3]);
            qt.bid_volume1 = float.Parse(fields[4]);

            qt.ask_price2 = float.Parse(fields[5]);
            qt.ask_volume2 = float.Parse(fields[6]);
            qt.bid_price2 = float.Parse(fields[7]);
            qt.bid_volume2 = float.Parse(fields[8]);

            qt.ask_price3 = float.Parse(fields[9]);
            qt.ask_volume3 = float.Parse(fields[10]);
            qt.bid_price3 = float.Parse(fields[11]);
            qt.bid_volume3 = float.Parse(fields[12]);

            qt.ask_price4 = float.Parse(fields[13]);
            qt.ask_volume4 = float.Parse(fields[14]);
            qt.bid_price4 = float.Parse(fields[15]);
            qt.bid_volume4 = float.Parse(fields[16]);

            qt.ask_price5 = float.Parse(fields[17]);
            qt.ask_volume5 = float.Parse(fields[18]);
            qt.bid_price5 = float.Parse(fields[19]);
            qt.bid_volume5 = float.Parse(fields[20]);

            qt.last_price = float.Parse(fields[21]);
            qt.highest = float.Parse(fields[22]);

            qt.lowest = float.Parse(fields[23]);
            qt.open = float.Parse(fields[24]);
            //qt.close = float.Parse(fields[25]);
            qt.average = float.Parse(fields[26]);
            qt.volume = float.Parse(fields[27]);
            qt.amount = float.Parse(fields[28]);

            return qt;
        }

        public void EndReadData()
        {
            mTimer.Enabled = false;
        }
    }
}