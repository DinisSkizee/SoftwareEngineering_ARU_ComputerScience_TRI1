using System.Windows.Forms;

namespace FinalProject
{
    class BedSideViewConfiguration
    {

        public BedSideViewConfiguration()
        {
            Timer timer = new Timer();
            timer = new Timer();
            timer.Tick += SocketConfiguration.StartRandom;
            timer.Tick += BedSideView1.singleton.UpdateTextBox;
            timer.Interval = 1500;
            timer.Start();
        }
    }
}
