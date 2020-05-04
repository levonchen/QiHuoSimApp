using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQiHuoSim.Model
{
    public class RecordTransItem
    {        
        public RecordTransItem()
        {
            Id = Guid.NewGuid().ToString();
            datetime = DateTime.Now;
        }
        public String Id { get; set; }

        public int volumn { get; set; }

        public TransDirection direction { get; set;}

        public float price { get; set; }

        public float profit { get; set; }

        public DateTime datetime { get; set; }
    }
}
