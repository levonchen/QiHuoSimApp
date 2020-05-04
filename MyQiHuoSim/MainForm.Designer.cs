﻿namespace MyQiHuoSim
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.candleStickView1 = new MyQiHuoSim.CandleStickView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.mdForFiveQuote1 = new MyQiHuoSim.MDForFiveQuote();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dealPanel1 = new MyQiHuoSim.DealPanel();
            this.recordTransaction_Position = new MyQiHuoSim.RecordTransaction();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Pause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Continue = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNextTick = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.toolStripComboBox_Speed = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonLoadDatas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton_BarTypeSelect = new System.Windows.Forms.ToolStripDropDownButton();
            this.oolStripMenuItem_TickBar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OneMiBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.recordTransaction_History = new MyQiHuoSim.RecordTransaction();
            this.toolStripButton_randomStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.candleStickView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 526);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 5;
            // 
            // candleStickView1
            // 
            this.candleStickView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.candleStickView1.Location = new System.Drawing.Point(0, 0);
            this.candleStickView1.Name = "candleStickView1";
            this.candleStickView1.Size = new System.Drawing.Size(655, 522);
            this.candleStickView1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.mdForFiveQuote1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(388, 522);
            this.splitContainer2.SplitterDistance = 228;
            this.splitContainer2.TabIndex = 0;
            // 
            // mdForFiveQuote1
            // 
            this.mdForFiveQuote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdForFiveQuote1.Location = new System.Drawing.Point(0, 0);
            this.mdForFiveQuote1.Name = "mdForFiveQuote1";
            this.mdForFiveQuote1.Size = new System.Drawing.Size(386, 226);
            this.mdForFiveQuote1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dealPanel1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer4.Size = new System.Drawing.Size(386, 288);
            this.splitContainer4.SplitterDistance = 100;
            this.splitContainer4.TabIndex = 0;
            // 
            // dealPanel1
            // 
            this.dealPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealPanel1.Location = new System.Drawing.Point(0, 0);
            this.dealPanel1.Name = "dealPanel1";
            this.dealPanel1.Size = new System.Drawing.Size(386, 100);
            this.dealPanel1.TabIndex = 0;
            // 
            // recordTransaction_Position
            // 
            this.recordTransaction_Position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordTransaction_Position.Location = new System.Drawing.Point(3, 3);
            this.recordTransaction_Position.Name = "recordTransaction_Position";
            this.recordTransaction_Position.RecordType = MyQiHuoSim.Model.RecordListType.Position;
            this.recordTransaction_Position.Size = new System.Drawing.Size(372, 152);
            this.recordTransaction_Position.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadDatas,
            this.toolStripSeparator1,
            this.toolStripButtonStart,
            this.toolStripButton_randomStart,
            this.toolStripSeparator3,
            this.toolStripButton_Pause,
            this.toolStripButton_Continue,
            this.toolStripButtonNextTick,
            this.toolStripSeparator2,
            this.toolStripButtonStop,
            this.toolStripComboBox_Speed,
            this.toolStripDropDownButton_BarTypeSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1055, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.AutoToolTip = false;
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(36, 22);
            this.toolStripButtonStart.Text = "开始";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButton_Pause
            // 
            this.toolStripButton_Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Pause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Pause.Image")));
            this.toolStripButton_Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Pause.Name = "toolStripButton_Pause";
            this.toolStripButton_Pause.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_Pause.Text = "暂停";
            this.toolStripButton_Pause.Click += new System.EventHandler(this.toolStripButton_Pause_Click);
            // 
            // toolStripButton_Continue
            // 
            this.toolStripButton_Continue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Continue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Continue.Image")));
            this.toolStripButton_Continue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Continue.Name = "toolStripButton_Continue";
            this.toolStripButton_Continue.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_Continue.Text = "继续";
            this.toolStripButton_Continue.Click += new System.EventHandler(this.toolStripButton_Continue_Click);
            // 
            // toolStripButtonNextTick
            // 
            this.toolStripButtonNextTick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNextTick.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNextTick.Image")));
            this.toolStripButtonNextTick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNextTick.Name = "toolStripButtonNextTick";
            this.toolStripButtonNextTick.Size = new System.Drawing.Size(48, 22);
            this.toolStripButtonNextTick.Text = "下一步";
            this.toolStripButtonNextTick.Click += new System.EventHandler(this.toolStripButtonNextTick_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.AutoToolTip = false;
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(36, 22);
            this.toolStripButtonStop.Text = "结束";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Size = new System.Drawing.Size(1057, 565);
            this.splitContainer3.SplitterDistance = 33;
            this.splitContainer3.TabIndex = 7;
            // 
            // toolStripComboBox_Speed
            // 
            this.toolStripComboBox_Speed.AutoSize = false;
            this.toolStripComboBox_Speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_Speed.DropDownWidth = 50;
            this.toolStripComboBox_Speed.Name = "toolStripComboBox_Speed";
            this.toolStripComboBox_Speed.Size = new System.Drawing.Size(50, 25);
            this.toolStripComboBox_Speed.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_Speed_SelectedIndexChanged);
            // 
            // toolStripButtonLoadDatas
            // 
            this.toolStripButtonLoadDatas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadDatas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadDatas.Image")));
            this.toolStripButtonLoadDatas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadDatas.Name = "toolStripButtonLoadDatas";
            this.toolStripButtonLoadDatas.Size = new System.Drawing.Size(36, 22);
            this.toolStripButtonLoadDatas.Text = "加载";
            this.toolStripButtonLoadDatas.Click += new System.EventHandler(this.toolStripButtonLoadDatas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton_BarTypeSelect
            // 
            this.toolStripDropDownButton_BarTypeSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_BarTypeSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oolStripMenuItem_TickBar,
            this.ToolStripMenuItem_OneMiBar});
            this.toolStripDropDownButton_BarTypeSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_BarTypeSelect.Image")));
            this.toolStripDropDownButton_BarTypeSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_BarTypeSelect.Name = "toolStripDropDownButton_BarTypeSelect";
            this.toolStripDropDownButton_BarTypeSelect.Size = new System.Drawing.Size(57, 22);
            this.toolStripDropDownButton_BarTypeSelect.Text = "分时图";
            // 
            // oolStripMenuItem_TickBar
            // 
            this.oolStripMenuItem_TickBar.Name = "oolStripMenuItem_TickBar";
            this.oolStripMenuItem_TickBar.Size = new System.Drawing.Size(180, 22);
            this.oolStripMenuItem_TickBar.Text = "分时图";
            this.oolStripMenuItem_TickBar.Click += new System.EventHandler(this.oolStripMenuItem_TickBar_Click);
            // 
            // ToolStripMenuItem_OneMiBar
            // 
            this.ToolStripMenuItem_OneMiBar.Name = "ToolStripMenuItem_OneMiBar";
            this.ToolStripMenuItem_OneMiBar.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_OneMiBar.Text = "1分钟";
            this.ToolStripMenuItem_OneMiBar.Click += new System.EventHandler(this.ToolStripMenuItem_OneMiBar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 184);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.recordTransaction_Position);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(378, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "持仓";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.recordTransaction_History);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 158);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "历史成交";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // recordTransaction_History
            // 
            this.recordTransaction_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordTransaction_History.Location = new System.Drawing.Point(3, 3);
            this.recordTransaction_History.Name = "recordTransaction_History";
            this.recordTransaction_History.RecordType = MyQiHuoSim.Model.RecordListType.History;
            this.recordTransaction_History.Size = new System.Drawing.Size(372, 152);
            this.recordTransaction_History.TabIndex = 0;
            // 
            // toolStripButton_randomStart
            // 
            this.toolStripButton_randomStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_randomStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_randomStart.Image")));
            this.toolStripButton_randomStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_randomStart.Name = "toolStripButton_randomStart";
            this.toolStripButton_randomStart.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton_randomStart.Text = "随即开始";
            this.toolStripButton_randomStart.Click += new System.EventHandler(this.toolStripButton_randomStart_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 565);
            this.Controls.Add(this.splitContainer3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private CandleStickView candleStickView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MDForFiveQuote mdForFiveQuote1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNextTick;
        private System.Windows.Forms.ToolStripButton toolStripButton_Continue;
        private System.Windows.Forms.ToolStripButton toolStripButton_Pause;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private DealPanel dealPanel1;
        private RecordTransaction recordTransaction_Position;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Speed;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadDatas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_BarTypeSelect;
        private System.Windows.Forms.ToolStripMenuItem oolStripMenuItem_TickBar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OneMiBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private RecordTransaction recordTransaction_History;
        private System.Windows.Forms.ToolStripButton toolStripButton_randomStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
