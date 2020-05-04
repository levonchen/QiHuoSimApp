using MyQiHuoSim.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQiHuoSim.Views
{
    public class DirectionCellTemplateCell : DataGridViewTextBoxCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            TransDirection dir = (TransDirection)value;
            if(dir == TransDirection.Buy)
            {
                return "买";
            }
            else
            {
                return "卖";
            }
        }
    }
}
