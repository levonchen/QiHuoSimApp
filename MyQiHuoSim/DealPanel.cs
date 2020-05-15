using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQiHuoSim.Service;
using MyQiHuoSim.Entity;
using MyQiHuoSim.Model;
using MyQiHuoSim.Setings;

namespace MyQiHuoSim
{
    public partial class DealPanel : UserControl
    {
        private Quote mLatestQuote {get;set;}

        private AppOptSettings AppSetting { get; set; }

        public DealPanel()
        {
            InitializeComponent();
            DataService.Instance.OnQuoteTick += Instance_OnQuoteTick;

            bt_Buy.Text = "买\n(卖1)";
            bt_Sell.Text = "卖\n(买1)";
        }


        public void LoadAppSetting()
        {
            AppSetting = AppOptSettings.Load();
        }

        private void Instance_OnQuoteTick(object sender, QHEvents.QuoteEventArgs e)
        {
            mLatestQuote = e.quote;
        }

        private void bt_Buy_Click(object sender, EventArgs e)
        {
            Buy_On_Sell1();
        }

        private void Buy_On_Sell1()
        {
            float price = mLatestQuote.ask_price1;
            RecordTransItem newItem = new RecordTransItem();
            newItem.direction = TransDirection.Buy;
            newItem.price = price;
            newItem.volumn = 1;
            newItem.datetime = mLatestQuote.datetime;
            RecordTransService.Instance.InsertOrder(newItem);
        }

        private void Buy_On_Buy1()
        {
            float price = mLatestQuote.bid_price1;
            RecordTransItem newItem = new RecordTransItem();
            newItem.direction = TransDirection.Buy;
            newItem.price = price;
            newItem.volumn = 1;
            newItem.datetime = mLatestQuote.datetime;
            RecordTransService.Instance.InsertOrder(newItem);
        }

        private void bt_Sell_Click(object sender, EventArgs e)
        {
            Sell_On_Buy1();
        }

        private void Sell_On_Buy1()
        {
            float price = mLatestQuote.bid_price1;
            RecordTransItem newItem = new RecordTransItem();
            newItem.direction = TransDirection.Sell;
            newItem.price = price;
            newItem.volumn = 1;
            newItem.datetime = mLatestQuote.datetime;
            RecordTransService.Instance.InsertOrder(newItem);
        }
        private void Sell_On_Sell1()
        {
            float price = mLatestQuote.ask_price1;
            RecordTransItem newItem = new RecordTransItem();
            newItem.direction = TransDirection.Sell;
            newItem.price = price;
            newItem.volumn = 1;
            newItem.datetime = mLatestQuote.datetime;
            RecordTransService.Instance.InsertOrder(newItem);
        }


        public void ExecuteShutupCommand(Keys k)
        {
            if (AppSetting == null)
            {
                LoadAppSetting();
                return;
            }

            if (AppSetting.ShutcutKeys == null)
                return;
           
            if(mLatestQuote == null)
            {
                return;
            }

            if(k == AppSetting.ShutcutKeys.Buy_On_Sell1)
            {
                Buy_On_Sell1();
            }
            else if(k == AppSetting.ShutcutKeys.Buy_On_Buy1)
            {
                Buy_On_Buy1();
            }
            else if(k == AppSetting.ShutcutKeys.Sell_On_Buy1)
            {
                Sell_On_Buy1();
            }
            else if(k == AppSetting.ShutcutKeys.Sell_On_Sell1)
            {
                Sell_On_Sell1();
            }
            else if(k == AppSetting.ShutcutKeys.CancelOrder)
            {
                RecordTransService.Instance.CancelOrders();
            }
            else if(k == AppSetting.ShutcutKeys.CloseAllPosition)
            {
                //平仓
                var records = RecordTransService.Instance.PositionRecords;
                foreach (var it in records)
                {
                    if(it.direction == TransDirection.Buy)
                    {
                        Sell_On_Buy1();
                    }
                    else
                    {
                        Buy_On_Sell1();
                    }
                }
            }else if(k == AppSetting.ShutcutKeys.NormalSpeedPlay)
            {
                DataService.Instance.SetSpeedToNormal();
            }
        }
    }
}
