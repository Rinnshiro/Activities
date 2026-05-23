using System;
using System.Windows.Forms;
using EdoriaCashierApplication1;

namespace EdoriaCashierApplication1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginAccount());
        }
    }
}