using System;
using System.Windows.Forms;

namespace StudentRecordApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmRegistration());
        }
    }
}
