using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject
{
    class SocketConfiguration
    {
        #region Variable 
        // Variables used for the Randoms
        //public static int syValue, diValue, prValue, brValue;
        //public static double tempValue;

        public static Random randomizer = new Random();

        // User Variables
        public static int weight, age, height;
        public static int firstNameNumber, lastNameNumber;
        public static string firstName, lastName;
        public static List<string> firstNameList = new List<string>()
        {
            "Dinis", "Jorge", "Haris", "Kelly", "Brett", "Kevin", "Aaron", "Elias", "Erica", "Jacob", "Kye",
            "Herbert", "Lucie", "Nancy", "Rebekah", "Maria", "Jamie", "Rhonda", "Haleema", "Poppy", "Melanie"
        };
        public static List<string> lastNameList = new List<string>()
        {
            "Silva", "Costa", "Cooper", "Dunn", "Jordan", "Patton", "Gibson", "Lopez", "King", "Carroll",
            "Sanchez", "Benson", "Lane", "Kennedy", "Luna", "Harrison", "Morris", "Henry", "Keller", "Daniel", "Russell"
        };

        // Verifiers Variables
        public static int dockActive;

        // Values Variables
        public static int diDiff, syDiff, prDiff, brDiff, tempDiff;

        public static int diMinC, diMaxC, syMinC, syMaxC, prMinC, prMaxC, brMinC, brMaxC, tpMinC, tpMaxC;
        #endregion
        
        public SocketConfiguration()
        {
            
            diDiff = diMaxC - diMinC;      // BPDi = 30
            syDiff = syMaxC - syMinC;      // BPSy = 20
            prDiff = prMaxC - prMinC;      // PR = 30
            brDiff = brMaxC - brMinC;      // BR = 5
            tempDiff = tpMaxC - tpMinC;    // TP = 2

            /* A randomizer is implemented generating a value from 0 to 100
             * so then we can randomize the values with percentage deciding
             * then in each if how much would it be for the same statement */

            RandomNameGenerator();
            RandomGenUserValues();

        }

        public static void RandomGenUserValues()
        {
            weight = randomizer.Next(60, 85);
            age = randomizer.Next(25, 45);
            height = randomizer.Next(150, 210);
        }

        public static void RandomNameGenerator()
        {
            firstNameNumber = randomizer.Next(0, firstNameList.Count);
            lastNameNumber = randomizer.Next(0, lastNameList.Count);

            firstName = firstNameList[firstNameNumber];
            lastName = lastNameList[lastNameNumber];
        }

        public static void StartRandom(object sender, EventArgs e)
        {
            BedSideView1.SystolicValueRandom();
            BedSideView2.SystolicValueRandom();
            BedSideView3.SystolicValueRandom();
            BedSideView4.SystolicValueRandom();
            BedSideView5.SystolicValueRandom();
            BedSideView6.SystolicValueRandom();
            BedSideView7.SystolicValueRandom();
            BedSideView8.SystolicValueRandom();

            BedSideView1.DiastolicValueRandom();
            BedSideView2.DiastolicValueRandom();
            BedSideView3.DiastolicValueRandom();
            BedSideView4.DiastolicValueRandom();
            BedSideView5.DiastolicValueRandom();
            BedSideView6.DiastolicValueRandom();
            BedSideView7.DiastolicValueRandom();
            BedSideView8.DiastolicValueRandom();

            BedSideView1.PulseValueRandom();
            BedSideView2.PulseValueRandom();
            BedSideView3.PulseValueRandom();
            BedSideView4.PulseValueRandom();
            BedSideView5.PulseValueRandom();
            BedSideView6.PulseValueRandom();
            BedSideView7.PulseValueRandom();
            BedSideView8.PulseValueRandom();

            BedSideView1.BreathingValueRandom();
            BedSideView2.BreathingValueRandom();
            BedSideView3.BreathingValueRandom();
            BedSideView4.BreathingValueRandom();
            BedSideView5.BreathingValueRandom();
            BedSideView6.BreathingValueRandom();
            BedSideView7.BreathingValueRandom();
            BedSideView8.BreathingValueRandom();

            BedSideView1.TemperatureValueRandom();
            BedSideView2.TemperatureValueRandom();
            BedSideView3.TemperatureValueRandom();
            BedSideView4.TemperatureValueRandom();
            BedSideView5.TemperatureValueRandom();
            BedSideView6.TemperatureValueRandom();
            BedSideView7.TemperatureValueRandom();
            BedSideView8.TemperatureValueRandom();
        }
    }
}