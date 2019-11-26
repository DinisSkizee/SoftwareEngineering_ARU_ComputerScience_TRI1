using System;
using System.Windows.Forms;

namespace FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetTimer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            Timer timer = new Timer();
        }

        public static System.Timers.Timer timer;

        public static void SetTimer()
        {
            timer = new System.Timers.Timer(1500);
            timer.Elapsed += SocketConfiguration.StartRandom;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
        }
    }
}
