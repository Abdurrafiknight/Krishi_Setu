using System;
using System.Windows.Forms;
using KrishiSetuPro.Forms;

namespace KrishiSetuPro
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new frmLogin());
        }
    }
}
