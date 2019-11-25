using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class BedSideViewConfiguration
    {
        BedSideView1 bed1 = new BedSideView1();
        BedSideView2 bed2 = new BedSideView2();
        BedSideView3 bed3 = new BedSideView3();
        BedSideView4 bed4 = new BedSideView4();
        BedSideView5 bed5 = new BedSideView5();
        BedSideView6 bed6 = new BedSideView6();
        BedSideView7 bed7 = new BedSideView7();
        BedSideView8 bed8 = new BedSideView8();

        List<string> DiastolicValue = new List<string>(SocketConfiguration.diValue);

        List<string> SystolicValue = new List<string>(SocketConfiguration.syValue);
        List<string> PulseRateValue = new List<string>(SocketConfiguration.prValue);
        List<string> BreathingRateValue = new List<string>(SocketConfiguration.brValue);
        List<string> TemperatureValue = new List<string>(SocketConfiguration.tempValue);

        // Variables




    }
}
