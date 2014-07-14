using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionAsker
{
    static class Program
    {
        static TimeSpan SleepSpan = new TimeSpan(0, 30, 0);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while(true)
            {
                Application.Run(new PopupForm());

                System.Threading.Thread.Sleep(SleepSpan);
            }
        }
    }
}
