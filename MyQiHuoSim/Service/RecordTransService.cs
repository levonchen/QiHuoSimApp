using MyQiHuoSim.Model;
using MyQiHuoSim.QHEvents;
using MyQiHuoSim.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.Service
{
    public class RecordTransService : BaseLazySingleton<RecordTransService>
    {
        public event EventHandler<OrderArgs> OnInsertPosition;

        public event EventHandler<OrderArgs> OnRemovePosition;

        public event EventHandler<OrderArgs> OnInsertOrder;


        public void Invoke_OnInsertPosition(RecordTransItem item)
        {
            OrderArgs args = new OrderArgs();
            args.order = item;
            OnInsertPosition?.Invoke(this, args);
        }

        public void Invoke_OnRemovePosition(RecordTransItem item)
        {
            OrderArgs args = new OrderArgs();
            args.order = item;
            OnRemovePosition?.Invoke(this, args);
        }

        public void Invoke_OnInsertOrder(RecordTransItem item)
        {
            OrderArgs args = new OrderArgs();
            args.order = item;
            OnInsertOrder?.Invoke(this, args);
        }

        /// <summary>
        /// 历史记录
        /// </summary>
        public List<RecordTransItem> HistoryRecords { get; set; }

        /// <summary>
        /// 持仓
        /// </summary>
        public List<RecordTransItem> PositionRecords { get; set; }


        public RecordTransService()
        {
            HistoryRecords = new List<RecordTransItem>();
            PositionRecords = new List<RecordTransItem>();
        }

        public void InsertOrder(RecordTransItem item)
        {
            List<RecordTransItem> removeItems = new List<RecordTransItem>();
            foreach(var it in PositionRecords)
            {
                if(it.direction != item.direction)
                {
                    removeItems.Add(it);
                    break;
                }
            }

            if (removeItems.Count() > 0)
            {
                foreach(var it in removeItems)
                { 
                    Invoke_OnRemovePosition(it);
                    PositionRecords.Remove(it);
                }
            }
            else
            {
                Invoke_OnInsertPosition(item);
                PositionRecords.Add(item);
            }


            Invoke_OnInsertOrder(item);

            HistoryRecords.Add(item);
        }
    }
}
