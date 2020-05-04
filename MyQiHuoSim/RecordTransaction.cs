using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQiHuoSim.Views;
using MyQiHuoSim.Model;
using MyQiHuoSim.Service;
using MyQiHuoSim.Entity;

namespace MyQiHuoSim
{
    public partial class RecordTransaction : UserControl
    {

        public RecordListType RecordType { get; set; }

        public RecordTransaction()
        {
            InitializeComponent();
            RecordType = RecordListType.Position;
            RecordTransService.Instance.OnInsertOrder += Instance_OnInsertOrder;
            RecordTransService.Instance.OnInsertPosition += Instance_OnInsertPosition;
            RecordTransService.Instance.OnRemovePosition += Instance_OnRemovePosition;

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

        private void SetQuote(Quote qt)
        {
            if (RecordType != RecordListType.Position)
            {
                return;
            }

            foreach(var item in recordTransItemBindingSource)
            {
                RecordTransItem itemOrder = item as RecordTransItem;

                if(itemOrder.direction == TransDirection.Buy)
                {
                    itemOrder.profit = qt.last_price - itemOrder.price;
                }
                else
                {
                    itemOrder.profit = itemOrder.price - qt.last_price;
                }
            }

            dgvMain.Invalidate();
        }

        private void RecordTransaction_Load(object sender, EventArgs e)
        {
            directionDataGridViewTextBoxColumn.CellTemplate = new DirectionCellTemplateCell();
            datetime.CellTemplate = new DataTimeCellTemplateCell();
        }

        /// <summary>
        /// 用于平仓时，删除持仓信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instance_OnRemovePosition(object sender, QHEvents.OrderArgs e)
        {
            if(RecordType != RecordListType.Position)
            {
                return;
            }

            recordTransItemBindingSource.Remove(e.order);

        }

        /// <summary>
        /// 用于插入持仓信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instance_OnInsertPosition(object sender, QHEvents.OrderArgs e)
        {
            if (RecordType != RecordListType.Position)
            {
                return;
            }
            recordTransItemBindingSource.Add(e.order);
        }

        /// <summary>
        /// 专用于history 记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instance_OnInsertOrder(object sender, QHEvents.OrderArgs e)
        {
            if (RecordType != RecordListType.History)
            {
                return;
            }

            recordTransItemBindingSource.Add(e.order);

        }

        private void dgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 4 && e.Value != null)
            {
                double profit = Convert.ToDouble(e.Value);
                if(profit > 0)
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 192, 192);
                }
                else if (profit < 0)
                {
                    e.CellStyle.BackColor =  Color.FromArgb(192,255,192);
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                }

            }
        }
    }
}
