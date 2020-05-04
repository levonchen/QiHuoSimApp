namespace MyQiHuoSim
{
    partial class DealPanel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Buy = new System.Windows.Forms.Button();
            this.bt_Sell = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bt_Buy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Sell, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_Buy
            // 
            this.bt_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_Buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Buy.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Buy.Location = new System.Drawing.Point(15, 15);
            this.bt_Buy.Margin = new System.Windows.Forms.Padding(5);
            this.bt_Buy.Name = "bt_Buy";
            this.bt_Buy.Size = new System.Drawing.Size(124, 65);
            this.bt_Buy.TabIndex = 0;
            this.bt_Buy.Text = "买";
            this.bt_Buy.UseVisualStyleBackColor = false;
            this.bt_Buy.Click += new System.EventHandler(this.bt_Buy_Click);
            // 
            // bt_Sell
            // 
            this.bt_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Sell.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Sell.ForeColor = System.Drawing.Color.Black;
            this.bt_Sell.Location = new System.Drawing.Point(149, 13);
            this.bt_Sell.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.bt_Sell.Name = "bt_Sell";
            this.bt_Sell.Size = new System.Drawing.Size(127, 67);
            this.bt_Sell.TabIndex = 1;
            this.bt_Sell.Text = "卖";
            this.bt_Sell.UseVisualStyleBackColor = false;
            this.bt_Sell.Click += new System.EventHandler(this.bt_Sell_Click);
            // 
            // DealPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DealPanel";
            this.Size = new System.Drawing.Size(289, 95);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_Sell;
        private System.Windows.Forms.Button bt_Buy;
    }
}
