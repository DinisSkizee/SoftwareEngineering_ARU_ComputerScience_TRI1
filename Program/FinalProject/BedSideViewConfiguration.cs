using System.Windows.Forms;

namespace FinalProject
{
    class BedSideViewConfiguration
    {
        public static Timer timer = new Timer();

        public BedSideViewConfiguration()
        {
            timer.Tick += SocketConfiguration.StartRandom;
            timer.Interval = 1500;
            timer.Start();
        }
    }
}
