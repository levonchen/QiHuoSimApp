namespace MyQiHuoSim
{
    partial class CandleStickView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip_OHLCText = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip_CandleStick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.从当前点开始播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_CandleStick.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip_OHLCText
            // 
            this.toolTip_OHLCText.ToolTipTitle = "Test";
            // 
            // contextMenuStrip_CandleStick
            // 
            this.contextMenuStrip_CandleStick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从当前点开始播放ToolStripMenuItem});
            this.contextMenuStrip_CandleStick.Name = "contextMenuStrip_CandleStick";
            this.contextMenuStrip_CandleStick.Size = new System.Drawing.Size(181, 48);
            // 
            // 从当前点开始播放ToolStripMenuItem
            // 
            this.从当前点开始播放ToolStripMenuItem.Name = "从当前点开始播放ToolStripMenuItem";
            this.从当前点开始播放ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.从当前点开始播放ToolStripMenuItem.Text = "从当前点开始播放";
            this.从当前点开始播放ToolStripMenuItem.Click += new System.EventHandler(this.从当前点开始播放ToolStripMenuItem_Click);
            // 
            // CandleStickView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip_CandleStick;
            this.Name = "CandleStickView";
            this.Size = new System.Drawing.Size(840, 511);
            this.Click += new System.EventHandler(this.CandleStickView_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CandleStickView_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CandleStickView_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandleStickView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CandleStickView_MouseMove);
            this.contextMenuStrip_CandleStick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip_OHLCText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_CandleStick;
        private System.Windows.Forms.ToolStripMenuItem 从当前点开始播放ToolStripMenuItem;
    }
}
