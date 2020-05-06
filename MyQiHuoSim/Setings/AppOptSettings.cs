using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQiHuoSim.Setings
{
    public class AppOptSettings :AppSettings<AppOptSettings>
    {
      
        public ShutcutKeySettings ShutcutKeys { get; set; }
    }

}
