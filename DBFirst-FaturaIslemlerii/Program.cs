using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com 

namespace DBFirst_FaturaIslemlerii
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSiparisSecenekleri());
        }
    }
}
//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com 