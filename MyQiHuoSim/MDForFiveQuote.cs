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

namespace MyQiHuoSim
{
    public partial class MDForFiveQuote : UserControl
    {
        private Quote mQuote { get; set; }
        public MDForFiveQuote()
        {
            InitializeComponent();
            DataService.Instance.OnQuoteTick += Instance_OnQuoteTick;
        }

        private void Instance_OnQuoteTick(object sender, QHEvents.QuoteEventArgs e)
        {           

            if (this.InvokeRequired)
            {
                Invoke(new Action(() =>
                {  
                    SetQuote(e.quote);
                }));
            }
            else
            {
                SetQuote(e.quote);
            }

        }

        protected void SetQuote(Quote qt)
        {
            if (qt.last_price >= qt.ask_price1)
            {
                labelIndector.ForeColor = Color.Red;
            }
            if (qt.last_price <= qt.bid_price1)
            {
                labelIndector.ForeColor = Color.Green;
            }

            mQuote = qt;

            tb_ask_price1.Text = qt.ask_price1.ToString();
            tb_ask_volume1.Text = qt.ask_volume1.ToString();

            tb_ask_price2.Text = qt.ask_price2.ToString();
            tb_ask_volume2.Text = qt.ask_volume2.ToString();

            tb_ask_price3.Text = qt.ask_price3.ToString();
            tb_ask_volume3.Text = qt.ask_volume3.ToString();


            tb_bid_price1.Text = qt.bid_price1.ToString();
            tb_bid_volume1.Text = qt.bid_volume1.ToString();

            tb_bid_price2.Text = qt.bid_price2.ToString();
            tb_bid_volume2.Text = qt.bid_volume2.ToString();

            tb_bid_price3.Text = qt.bid_price3.ToString();
            tb_bid_volume3.Text = qt.bid_volume3.ToString();
        }
    }
}
