using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.Entity
{
    public class Quote
    {
        /// <summary>
        /// 为了方便指定从按个tick 开始继续播放
        /// </summary>
        public int index { get; set; }
        public DateTime datetime { get; set; }

        public float ask_price1 { get; set; }

        public float ask_volume1 { get; set; }

        public float bid_price1 { get; set; }

        public float bid_volume1 { get; set; }

        public float ask_price2 { get; set; }
        public float ask_volume2 { get; set; }
        public float bid_price2 { get; set; }
        public float bid_volume2 { get; set; }
        public float ask_price3 { get; set; }
        public float ask_volume3 { get; set; }
        public float bid_price3 { get; set; }
        public float bid_volume3 { get; set; }
        public float ask_price4 { get; set; }
        public float ask_volume4 { get; set; }

        public float bid_price4 { get; set; }
        public float bid_volume4 { get; set; }


        public float ask_price5 { get; set; }
        public float ask_volume5 { get; set; }

        public float bid_price5 { get; set; }
        public float bid_volume5 { get; set; }


        public float last_price { get; set; }

        public float highest { get; set; }

        public float lowest { get; set; }

        public float open { get; set; }

        public float close { get; set; }

        public float average { get; set; }

        public float volume { get; set; }

        public float amount { get; set; }

    }
}
