using MyQiHuoSim.Setings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQiHuoSim.Dialogs
{
    public partial class SettingsDlg : Form
    {
        public SettingsDlg()
        {
            InitializeComponent();

            SettingsToUI();
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            String strKey = e.KeyCode.ToString();

            TextBox tb = sender as TextBox;

            tb.Text = strKey;
            
        }

        private void SettingsToUI()
        {
            AppOptSettings appSettings = AppOptSettings.Load();

            if(appSettings != null)
            {
                if(appSettings.ShutcutKeys != null)
                {
                    tb_Buy_Sell1.Text = appSettings.ShutcutKeys.Buy_On_Sell1.ToString();
                    tb_Sell_Buy1.Text = appSettings.ShutcutKeys.Sell_On_Buy1.ToString();
                    tb_Buy_Buy1.Text = appSettings.ShutcutKeys.Buy_On_Buy1.ToString();
                    tb_Sell_Sell1.Text = appSettings.ShutcutKeys.Sell_On_Sell1.ToString();

                    tb_CancelOrder.Text = appSettings.ShutcutKeys.CancelOrder.ToString();
                    tb_CloseAllPosition.Text = appSettings.ShutcutKeys.CloseAllPosition.ToString();

                    tb_NormalSpeedPlay.Text = appSettings.ShutcutKeys.NormalSpeedPlay.ToString();
                }
            }

        }

        private void UIToSettings()
        {
            AppOptSettings appSettings = new AppOptSettings();

            appSettings.ShutcutKeys = new ShutcutKeySettings();
            if (!String.IsNullOrEmpty(tb_Buy_Sell1.Text))
            {
                appSettings.ShutcutKeys.Buy_On_Sell1 = (Keys)Enum.Parse(typeof(Keys), tb_Buy_Sell1.Text);
            }
            if (!String.IsNullOrEmpty(tb_Buy_Buy1.Text))
            {
                appSettings.ShutcutKeys.Buy_On_Buy1 = (Keys)Enum.Parse(typeof(Keys), tb_Buy_Buy1.Text);
            }

            if (!String.IsNullOrEmpty(tb_Sell_Sell1.Text))
            {
                appSettings.ShutcutKeys.Sell_On_Sell1 = (Keys)Enum.Parse(typeof(Keys), tb_Sell_Sell1.Text);
            }
            if (!String.IsNullOrEmpty(tb_Sell_Buy1.Text))
            {
                appSettings.ShutcutKeys.Sell_On_Buy1 = (Keys)Enum.Parse(typeof(Keys), tb_Sell_Buy1.Text);
            }
            if (!String.IsNullOrEmpty(tb_CancelOrder.Text))
            {
                appSettings.ShutcutKeys.CancelOrder = (Keys)Enum.Parse(typeof(Keys), tb_CancelOrder.Text);
            }
            if (!String.IsNullOrEmpty(tb_CloseAllPosition.Text))
            {
                appSettings.ShutcutKeys.CloseAllPosition = (Keys)Enum.Parse(typeof(Keys), tb_CloseAllPosition.Text);
            }

            if(!String.IsNullOrEmpty(tb_NormalSpeedPlay.Text))
            {
                appSettings.ShutcutKeys.NormalSpeedPlay = (Keys)Enum.Parse(typeof(Keys), tb_NormalSpeedPlay.Text);
            }

            appSettings.Save();
        }

        private void button_save_shutcutkeys_Click(object sender, EventArgs e)
        {
            UIToSettings();
            this.Close();
        }

    }
}
