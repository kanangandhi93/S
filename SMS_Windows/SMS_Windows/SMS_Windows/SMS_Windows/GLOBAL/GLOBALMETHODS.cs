using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Windows.GLOBAL
{
    public static class GLOBALMETHODS
    {
        public static void SHOW_MESSAGEBOX(string MESSAGE,string Title,MessageBoxButtons button,MessageBoxIcon icon)
        {
            MessageBox.Show(MESSAGE, Title, button, icon);
        }
    }
}
