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

namespace MyQiHuoSim
{
    public partial class DealPanel : UserControl
    {
        private Quote mLatestQuote {get;set;}

        public DealPanel()
        {
            InitializeComponent();
            DataService.Instance.OnQuoteTick += Instance_OnQuoteTick;
        }

        private void Instance_OnQuoteTick(object sender, QHEvents.QuoteEventArgs e)
        {
            mLatestQuote = e.quote;
        }

        private void bt_Buy_Click(object sender, EventArgs e)
        {
            float price = mLatestQuote.ask_price1;
            RecordTransItem newItem = new RecordTransItem();
            newItem.direction = TransDirection.Buy;
            newItem.price = price;
            newItem.volumn = 1;
            newItem.datetime = mLatestQuote.datetime;
            RecordTransService.Instance.InsertOrder(newItem);
        }

        private void bt_Sell_Click(object sender, EventArgs e)
        {
            float price = mLatestQuote.bid_price1;
            RecordTransItem newItem = new RecordTransItem();
            newItem.direction = TransDirection.Sell;
            newItem.price = price;
            newItem.volumn = 1;
            newItem.datetime = mLatestQuote.datetime;
            RecordTransService.Instance.InsertOrder(newItem);
        }
    }
}
