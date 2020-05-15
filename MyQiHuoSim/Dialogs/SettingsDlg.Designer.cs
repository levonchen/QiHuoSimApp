namespace MyQiHuoSim.Dialogs
{
    partial class SettingsDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_save_shutcutkeys = new System.Windows.Forms.Button();
            this.tb_Sell_Buy1 = new System.Windows.Forms.TextBox();
            this.tb_Buy_Buy1 = new System.Windows.Forms.TextBox();
            this.tb_Sell_Sell1 = new System.Windows.Forms.TextBox();
            this.tb_CancelOrder = new System.Windows.Forms.TextBox();
            this.tb_CloseAllPosition = new System.Windows.Forms.TextBox();
            this.tb_Buy_Sell1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_NormalSpeedPlay = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_NormalSpeedPlay);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button_save_shutcutkeys);
            this.tabPage1.Controls.Add(this.tb_Sell_Buy1);
            this.tabPage1.Controls.Add(this.tb_Buy_Buy1);
            this.tabPage1.Controls.Add(this.tb_Sell_Sell1);
            this.tabPage1.Controls.Add(this.tb_CancelOrder);
            this.tabPage1.Controls.Add(this.tb_CloseAllPosition);
            this.tabPage1.Controls.Add(this.tb_Buy_Sell1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "快捷键";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_save_shutcutkeys
            // 
            this.button_save_shutcutkeys.Location = new System.Drawing.Point(431, 270);
            this.button_save_shutcutkeys.Name = "button_save_shutcutkeys";
            this.button_save_shutcutkeys.Size = new System.Drawing.Size(75, 23);
            this.button_save_shutcutkeys.TabIndex = 12;
            this.button_save_shutcutkeys.Text = "保存";
            this.button_save_shutcutkeys.UseVisualStyleBackColor = true;
            this.button_save_shutcutkeys.Click += new System.EventHandler(this.button_save_shutcutkeys_Click);
            // 
            // tb_Sell_Buy1
            // 
            this.tb_Sell_Buy1.Location = new System.Drawing.Point(133, 102);
            this.tb_Sell_Buy1.Name = "tb_Sell_Buy1";
            this.tb_Sell_Buy1.Size = new System.Drawing.Size(100, 21);
            this.tb_Sell_Buy1.TabIndex = 11;
            this.tb_Sell_Buy1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_Sell_Buy1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_Buy_Buy1
            // 
            this.tb_Buy_Buy1.Location = new System.Drawing.Point(133, 161);
            this.tb_Buy_Buy1.Name = "tb_Buy_Buy1";
            this.tb_Buy_Buy1.Size = new System.Drawing.Size(100, 21);
            this.tb_Buy_Buy1.TabIndex = 10;
            this.tb_Buy_Buy1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_Buy_Buy1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_Sell_Sell1
            // 
            this.tb_Sell_Sell1.Location = new System.Drawing.Point(133, 211);
            this.tb_Sell_Sell1.Name = "tb_Sell_Sell1";
            this.tb_Sell_Sell1.Size = new System.Drawing.Size(100, 21);
            this.tb_Sell_Sell1.TabIndex = 9;
            this.tb_Sell_Sell1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_Sell_Sell1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_CancelOrder
            // 
            this.tb_CancelOrder.Location = new System.Drawing.Point(406, 50);
            this.tb_CancelOrder.Name = "tb_CancelOrder";
            this.tb_CancelOrder.Size = new System.Drawing.Size(100, 21);
            this.tb_CancelOrder.TabIndex = 8;
            this.tb_CancelOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_CancelOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_CloseAllPosition
            // 
            this.tb_CloseAllPosition.Location = new System.Drawing.Point(406, 105);
            this.tb_CloseAllPosition.Name = "tb_CloseAllPosition";
            this.tb_CloseAllPosition.Size = new System.Drawing.Size(100, 21);
            this.tb_CloseAllPosition.TabIndex = 7;
            this.tb_CloseAllPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_CloseAllPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_Buy_Sell1
            // 
            this.tb_Buy_Sell1.Location = new System.Drawing.Point(133, 50);
            this.tb_Buy_Sell1.Name = "tb_Buy_Sell1";
            this.tb_Buy_Sell1.Size = new System.Drawing.Size(100, 21);
            this.tb_Buy_Sell1.TabIndex = 6;
            this.tb_Buy_Sell1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_Buy_Sell1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "全平：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "撤单：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "卖（卖一）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "买（买一）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "卖（买一）：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "买（卖一）：";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "常速播放：";
            // 
            // tb_NormalSpeedPlay
            // 
            this.tb_NormalSpeedPlay.Location = new System.Drawing.Point(406, 205);
            this.tb_NormalSpeedPlay.Name = "tb_NormalSpeedPlay";
            this.tb_NormalSpeedPlay.Size = new System.Drawing.Size(100, 21);
            this.tb_NormalSpeedPlay.TabIndex = 14;
            this.tb_NormalSpeedPlay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_NormalSpeedPlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // SettingsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 339);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsDlg";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_Sell_Buy1;
        private System.Windows.Forms.TextBox tb_Buy_Buy1;
        private System.Windows.Forms.TextBox tb_Sell_Sell1;
        private System.Windows.Forms.TextBox tb_CancelOrder;
        private System.Windows.Forms.TextBox tb_CloseAllPosition;
        private System.Windows.Forms.TextBox tb_Buy_Sell1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_save_shutcutkeys;
        private System.Windows.Forms.TextBox tb_NormalSpeedPlay;
        private System.Windows.Forms.Label label7;
    }
}