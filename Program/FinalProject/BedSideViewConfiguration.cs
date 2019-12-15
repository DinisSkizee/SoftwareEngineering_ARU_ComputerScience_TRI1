using System.Windows.Forms;

namespace FinalProject
{
    class BedSideViewConfiguration
    {
        // Timer creation
        public static Timer timer = new Timer();

        public BedSideViewConfiguration()
        {
            // Add StartRandom Method to the timer
            timer.Tick += SocketConfiguration.StartRandom;
            // Timer tick will have interval of 2.5 seconds
            timer.Interval = 2500;
            // Start the timer
            timer.Start();
        }
    }
}
