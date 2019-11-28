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
            timer.Tick += BedSideView1.bed1singleton.UpdateTextBox;
            timer.Tick += BedSideView2.bed2singleton.UpdateTextBox;
            timer.Tick += BedSideView3.bed3singleton.UpdateTextBox;
            timer.Interval = 1500;
            timer.Start();
        }
    }
}
