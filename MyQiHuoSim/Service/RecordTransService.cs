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


        public event EventHandler<OrderArgs> OnInsertWaitingOrder;
        public event EventHandler<OrderArgs> OnRemoveWaitingOrder;

        

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

        public void Invoke_OnInsertWaitingOrder(RecordTransItem item)
        {
            OrderArgs args = new OrderArgs();
            args.order = item;
            OnInsertWaitingOrder?.Invoke(this, args);
        }

        public void Invoke_OnRemoveWaitingOrder(RecordTransItem item)
        {
            OrderArgs args = new OrderArgs();
            args.order = item;
            OnRemoveWaitingOrder?.Invoke(this, args);
        }

        /// <summary>
        /// 历史记录
        /// </summary>
        public List<RecordTransItem> HistoryRecords { get; set; }

        /// <summary>
        /// 持仓
        /// </summary>
        public List<RecordTransItem> PositionRecords { get; set; }


        /// <summary>
        /// 委托单，--类似一般系统中的围成单
        /// </summary> 
        System.Collections.Concurrent.ConcurrentQueue<RecordTransItem> WaitingRecords { get; set; }


        public RecordTransService()
        {
            HistoryRecords = new List<RecordTransItem>();
            PositionRecords = new List<RecordTransItem>();
            WaitingRecords = new System.Collections.Concurrent.ConcurrentQueue<RecordTransItem>();

            DataService.Instance.OnQuoteTick += Instance_OnQuoteTick;

        }

        private void Instance_OnQuoteTick(object sender, QuoteEventArgs e)
        {
            List<RecordTransItem> needsTestNextTime = new List<RecordTransItem>();
            RecordTransItem testItem;
            while(WaitingRecords.TryDequeue(out testItem))
            {
                if(testItem.direction == TransDirection.Buy)
                {
                    if(e.quote.ask_price1 <= testItem.price)
                    {
                        Invoke_OnRemoveWaitingOrder(testItem);
                        //成交
                        _TradedOrder(testItem);
                    }
                    else
                    {
                        needsTestNextTime.Add(testItem);
                    }
                }
                else
                {
                    if(e.quote.bid_price1 >= testItem.price)
                    {
                        Invoke_OnRemoveWaitingOrder(testItem);
                        //成交
                        _TradedOrder(testItem);
                    }
                    else
                    {
                        needsTestNextTime.Add(testItem);
                    }
                }
            }

            foreach(var it in needsTestNextTime)
            {
                WaitingRecords.Enqueue(it);
            }
        }

        /// <summary>
        /// 插入队列等候成交
        /// </summary>
        /// <param name="item"></param>
        public void InsertOrder(RecordTransItem item)
        {
            Invoke_OnInsertWaitingOrder(item);
            WaitingRecords.Enqueue(item);
        }

        public void CancelOrders()
        {
            RecordTransItem testItem;
            while (WaitingRecords.TryDequeue(out testItem))
            {
                Invoke_OnRemoveWaitingOrder(testItem);
            }
        }

        

        /// <summary>
        /// 已经成交了的订单
        /// </summary>
        /// <param name="item"></param>
        public void _TradedOrder(RecordTransItem item)
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
