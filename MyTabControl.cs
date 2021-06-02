using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
namespace регистрация
{
    public partial class TablessControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs in RunTime mode
            if (m.Msg == 0x1328 && !DesignMode)
            {
                m.Result = (IntPtr)1;
            }
            // Hide tabs in DesignMode
            else if (m.Msg == 0x1328 && DesignMode)
            {
                m.Result = m.Result;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}