using System;

namespace FinalProject
{
    class SocketConfiguration
    {
        public SocketConfiguration()
        {
            #region General Variables -- Dinis & Jorge
            // Declarate Variables for the Sockets
            int syValue;
            int diValue;
            int hrValue;
            int brValue;
            int tempValue;
            int weight;
            int age;
            int height;
            #endregion


            // 
            // NEEDS TO BE COMPLETED WITH A WHILE FORM
            //

            /* A randomizer is implemented generating a value from 0 to 100
             * so then we can randomize the values with percentage deciding
             * then in each if how much would it be for the same statement */

            #region Weight + Age + Height * Kg / yOld / Cm * -- Dinis & Jorge
            Random randomWeight = new Random();
            Random randomAge = new Random();
            Random randomHeight = new Random();

            weight = randomWeight.Next(60, 85);
            age = randomAge.Next(25, 45);
            height = randomHeight.Next(150, 210);
            #endregion

            while (true)
            {
                #region Blood Pressure * Systolic & Diastolic * -- Dinis & Jorge
                Random randomSyDi = new Random();  // Create a Randomizer for the Systolic and Diastolic Values
                int randomizerSyDi = randomSyDi.Next(0, 100);

                if (randomizerSyDi <= 5)
                {
                    Random syDiLowRandomizer = new Random();
                    syValue = syDiLowRandomizer.Next(70, 89);
                    diValue = syDiLowRandomizer.Next(40, 59);
                }
                else if ((randomizerSyDi > 5) && (randomizerSyDi < 95))
                {
                    Random syDiNormalRandomizer = new Random();
                    syValue = syDiNormalRandomizer.Next(90, 140);
                    diValue = syDiNormalRandomizer.Next(60, 90);
                }
                else if (randomizerSyDi >= 95)
                {
                    Random syDiHighRandomizer = new Random();
                    syValue = syDiHighRandomizer.Next(141, 160);
                    diValue = syDiHighRandomizer.Next(91, 110);
                }
                #endregion

                #region Heart Rate * bpm * -- Dinis & Jorge

                Random randomHR = new Random();
                int randomizerHR = randomHR.Next(0, 100);

                if (randomizerHR <= 5)
                {
                    Random hrLowRandomizer = new Random();
                    hrValue = hrLowRandomizer.Next(30, 49);
                }
                else if ((randomizerHR > 5) && (randomizerHR < 95))
                {
                    Random hrNormalRandomizer = new Random();
                    hrValue = hrNormalRandomizer.Next(50, 75);
                }
                else if (randomizerHR > 95)
                {
                    Random hrHighRandomizer = new Random();
                    hrValue = hrHighRandomizer.Next(76, 95);
                }
                #endregion

                #region Breathing Rate * Breaths Per Minute * -- Dinis & Jorge

                Random randomBR = new Random();
                int randomizerBR = randomBR.Next(0, 100);

                if (randomizerBR <= 5)
                {
                    Random brLowRandomizer = new Random();
                    brValue = brLowRandomizer.Next(2, 6);
                }
                else if ((randomizerBR > 5) && (randomizerBR < 95))
                {
                    Random brNormalRandomizer = new Random();
                    brValue = brNormalRandomizer.Next(7, 45);
                }
                else if (randomizerBR >= 95)
                {
                    Random brHighRandomizer = new Random();
                    brValue = brHighRandomizer.Next(46, 100);
                }
                #endregion

                #region Temperature * °C * -- Dinis & Jorge

                Random randomTemp = new Random();
                int randomizerTemp = randomTemp.Next(0, 100);

                if (randomizerTemp <= 25)
                {
                    Random tempLowRandomizer = new Random();
                    tempValue = tempLowRandomizer.Next(350, 364);
                    tempValue = tempValue / 10;
                }
                else if ((randomizerTemp > 25) && (randomizerTemp < 75))
                {
                    Random tempNormalRandomizer = new Random();
                    tempValue = tempNormalRandomizer.Next(365, 375);
                    tempValue = tempValue / 10;
                }
                else if (randomizerTemp >= 75)
                {
                    Random tempHighRandomizer = new Random();
                    tempValue = tempHighRandomizer.Next(376, 410);
                    tempValue = tempValue / 10;
                }
                #endregion 
            }
        }
    }
}