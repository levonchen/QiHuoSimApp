using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQiHuoSim.Views
{
    public class DataTimeCellTemplateCell : DataGridViewTextBoxCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            DateTime dir = (DateTime)value;

            return dir.ToString("HH:mm:ss:ms");
        }
    }
}
