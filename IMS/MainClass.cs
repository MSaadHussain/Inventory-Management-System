using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    internal class MainClass
    {
        public static void ShowWindow(Form openWin , Form clsWin, Form MDIWin)
        {
            clsWin.Close();
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void ShowWindow(Form openWin, Form MDIWin)
        {
            //clsWin.Close();
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
    }
}
