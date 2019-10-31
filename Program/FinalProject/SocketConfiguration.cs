using System;

namespace FinalProject
{
    class SocketConfiguration
    {
        public SocketConfiguration()
        {
            // Declarate Variables for the Sockets
            int syValue;
            int diValue;
            int hrValue;
            int brValue;
            int tempValue;
            int Weight;
            int Age;
            int Height;


            // Blood Pressure (Systolic and Diastolic)

            // 
            // NEEDS TO BE COMPLETED WITH A WHILE FORM / NEED TO HAVE THE SOCKETS DONE FIRST
            //

            /* This randomizer will generate a value form 0 to 100
             * so then we can randomize the values with percentage
             * 5% to syDiLow and syDiHigh and the other 90% to syDiNormal */
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
            // Heart Rate (BPM)

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

            // Breathing Rate (BreathsPM)

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

            // Temperature (Celsius)


            // Weight (Meters)


            // Age + Height (Years + Centimeter)

        }
    }
}