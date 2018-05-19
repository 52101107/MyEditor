using System;
using System.Windows.Forms;

namespace MultiText
{
    static class Boot
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DocumentProcessor());
        }
    }
}
