using System.Windows.Forms;

namespace FinalProject
{
    class BedSideViewConfiguration
    {
        public static Timer timer = new Timer();

        public BedSideViewConfiguration()
        {
            timer.Tick += SocketConfiguration.StartRandom;
            timer.Tick += BedSideView1.bed1singleton.UpdateTextBox;
            /*.Tick += BedSideView2.bed2singleton.UpdateTextBox;
            timer.Tick += BedSideView3.bed3singleton.UpdateTextBox;
            timer.Tick += BedSideView4.bed4singleton.UpdateTextBox;
            timer.Tick += BedSideView5.bed5singleton.UpdateTextBox;
            timer.Tick += BedSideView6.bed6singleton.UpdateTextBox;
            timer.Tick += BedSideView7.bed7singleton.UpdateTextBox;
            timer.Tick += BedSideView8.bed8singleton.UpdateTextBox;*/
            timer.Interval = 1500;
            timer.Start();
        }
    }
}
