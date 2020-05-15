using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQiHuoSim.Setings
{
    public class ShutcutKeySettings
    {
        public ShutcutKeySettings()
        {
            Buy_On_Sell1 = Keys.NumPad1;
            Sell_On_Buy1 = Keys.NumPad3;

            Buy_On_Buy1 = Keys.NumPad4;
            Sell_On_Sell1 = Keys.NumPad6;

            CancelOrder = Keys.NumPad8;
            CloseAllPosition = Keys.NumPad5;

            NormalSpeedPlay = Keys.Space;

        }
        /// <summary>
        /// 卖一价买
        /// </summary>
        public Keys Buy_On_Sell1 { get; set; }

        /// <summary>
        /// 买一价卖
        /// </summary>
        public Keys Sell_On_Buy1 { get; set; }

        /// <summary>
        /// 买一价买
        /// </summary>
        public Keys Buy_On_Buy1 { get; set; }

        /// <summary>
        /// 卖一价卖
        /// </summary>
        public Keys Sell_On_Sell1 { get; set; }


        /// <summary>
        /// 撤单
        /// </summary>
        public Keys CancelOrder { get; set; }

        /// <summary>
        /// 全部平仓
        /// </summary>
        public Keys CloseAllPosition { get; set; }

        /// <summary>
        /// 正常速度播放，为了是在快进的时候快速切换到正常速度
        /// </summary>
        public Keys NormalSpeedPlay { get; set; }
    }
}
