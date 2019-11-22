using System;
using System.Collections.Generic;
using System.Timers;

namespace FinalProject
{
    class SocketConfiguration : SocketSelection
    {
        #region Variable 
        // Variables used for the Randoms
        public static int syValue, diValue, prValue, brValue, tempValue;
        public static Timer timer;

        static Random randomizer = new Random();

        // User Variables
        public static int weight, age, height;
        public static int firstNameNumber, lastNameNumber;
        public static string firstName, lastName;
        List<string> firstNameList = new List<string>()
        {
            "Dinis", "Jorge", "Haris", "Kelly", "Brett", "Kevin", "Aaron", "Elias", "Erica", "Jacob", "Kye",
            "Herbert", "Lucie", "Nancy", "Rebekah", "Maria", "Jamie", "Rhonda", "Haleema", "Poppy", "Melanie"
        };
        List<string> lastNameList = new List<string>()
        {
            "Silva", "Costa", "Cooper", "Dunn", "Jordan", "Patton", "Gibson", "Lopez", "King", "Carroll",
            "Sanchez", "Benson", "Lane", "Kennedy", "Luna", "Harrison", "Morris", "Henry", "Keller", "Daniel", "Russell"
        };

        // Verifiers Variables
        public static int bpParameters, prParameters, brParameters, tpParameters;
        public static int dockActive;

        // Values Variables
        public static int diDiff, syDiff, prDiff, brDiff, tempDiff;
        public bool dMi, dMa, sMi, sMa, pMi, pMa, bMi, bMa, tMi, tMa;
        public static int diMin, diMax, syMin, syMax, prMin, prMax, brMin, brMax, tpMin, tpMax;
        #endregion

        public SocketConfiguration()
        {

            diDiff = diMax - diMin;      // BPDi = 30
            syDiff = syMax - syMin;      // BPSy = 20
            prDiff = prMax - prMin;      // PR = 30
            brDiff = brMax - brMin;      // BR = 5
            tempDiff = tpMax - tpMin;    // TP = 2

            /* A randomizer is implemented generating a value from 0 to 100
             * so then we can randomize the values with percentage deciding
             * then in each if how much would it be for the same statement */

            RandomNameGenerator();
            RandomGenUserValues();

            #region Verifier

            // Parameters Verification
            dMi = IsNumeric(Convert.ToString(diMin));
            dMa = IsNumeric(Convert.ToString(diMax));
            sMi = IsNumeric(Convert.ToString(syMin));
            sMa = IsNumeric(Convert.ToString(syMax));

            pMi = IsNumeric(Convert.ToString(prMin));
            pMa = IsNumeric(Convert.ToString(prMax));

            bMi = IsNumeric(Convert.ToString(brMin));
            bMa = IsNumeric(Convert.ToString(brMax));
            tMi = IsNumeric(Convert.ToString(tpMin));
            tMa = IsNumeric(Convert.ToString(tpMax));

            // Check if the string has a numeric value

            #endregion

            #region String Verifier - Must be only numeric  -- Dinis & Jorge
            // Check if every textbox has input - Blood Pressure
            if (dMi == true && dMa == true && sMi == true && sMa == true)
            {
                bpParameters = 1;
            }
            else { bpParameters = 0; }

            // Pulse Rate
            if (pMi == true && pMa == true)
            {
                prParameters = 1;
            }
            else { prParameters = 0; }

            // Breathing Rate
            if (bMi == true && bMa == true)
            {
                brParameters = 1;
            }
            else { brParameters = 0; }

            // Temperature
            if (tMi == true && tMa == true)
            {
                tpParameters = 1;
            }
            else { tpParameters = 0; }
            #endregion

        }

        bool IsNumeric(string var)
        {
            int Result;
            return int.TryParse(var, out Result);
        }

        /*public static void RandomGenModValues()
        {
            #region Blood Pressure * Systolic & Diastolic * -- Dinis & Jorge
            // Random randomSyDi = new Random();  // Create a Randomizer for the Systolic and Diastolic Values
            int randomizerSyDi = randomizer.Next(0, 100);

            if (randomizerSyDi <= 5)
            {
                // Random syDiLowRandomizer = new Random();
                syValue = randomizer.Next(syMin - 20, syMin - 1); // 70 - 89
                diValue = randomizer.Next(diMin - 20, diMin - 1); // 40 - 59
            }
            else if ((randomizerSyDi > 5) && (randomizerSyDi < 95))
            {
                // Random syDiNormalRandomizer = new Random();
                syValue = randomizer.Next(syMin, syMax); // 90 - 140
                diValue = randomizer.Next(diMin, diMax); // 60 - 90
            }
            else if (randomizerSyDi >= 95)
            {
                // Random syDiHighRandomizer = new Random();
                syValue = randomizer.Next(syMax + 1, syMax + 20); // 141 - 160
                diValue = randomizer.Next(diMin + 1, diMax + 20); // 91 - 110
            }
            #endregion

            #region Pulse Rate * bpm * -- Dinis & Jorge

            // Random randomPR = new Random();
            int randomizerPR = randomizer.Next(0, 100);

            if (randomizerPR <= 5)
            {
                // Random prLowRandomizer = new Random();
                prValue = randomizer.Next(30, 49);
            }
            else if ((randomizerPR > 5) && (randomizerPR < 95))
            {
                // Random hrNormalRandomizer = new Random();
                prValue = randomizer.Next(50, 75);
            }
            else if (randomizerPR > 95)
            {
                // Random hrHighRandomizer = new Random();
                prValue = randomizer.Next(76, 95);
            }
            #endregion

            #region Breathing Rate * Breaths Per Minute * -- Dinis & Jorge

            // Random randomBR = new Random();
            int randomizerBR = randomizer.Next(0, 100);

            if (randomizerBR <= 5)
            {
                // Random brLowRandomizer = new Random();
                brValue = randomizer.Next(2, 6);
            }
            else if ((randomizerBR > 5) && (randomizerBR < 95))
            {
                // Random brNormalRandomizer = new Random();
                brValue = randomizer.Next(7, 45);
            }
            else if (randomizerBR >= 95)
            {
                // Random brHighRandomizer = new Random();
                brValue = randomizer.Next(46, 100);
            }
            #endregion

            #region Temperature * °C * -- Dinis & Jorge

            // Random randomTemp = new Random();
            int randomizerTemp = randomizer.Next(0, 100);

            if (randomizerTemp <= 25)
            {
                // Random tempLowRandomizer = new Random();
                tempValue = randomizer.Next(350, 364);
                tempValue /= 10;
            }
            else if ((randomizerTemp > 25) && (randomizerTemp < 75))
            {
                // Random tempNormalRandomizer = new Random();
                tempValue = randomizer.Next(365, 375);
                tempValue /= 10;
            }
            else if (randomizerTemp >= 75)
            {
                // Random tempHighRandomizer = new Random();
                tempValue = randomizer.Next(376, 410);
                tempValue /= 10;
            }
            #endregion

        }*/

        void RandomGenUserValues()
        {
            weight = randomizer.Next(60, 85);
            age = randomizer.Next(25, 45);
            height = randomizer.Next(150, 210);
        }

        void RandomNameGenerator()
        {
            firstNameNumber = randomizer.Next(0, firstNameList.Count);
            lastNameNumber = randomizer.Next(0, lastNameList.Count);

            firstName = firstNameList[firstNameNumber];
            lastName = lastNameList[lastNameNumber];
        }


        // Variables for the Randomizers below
        public static int randomizerSy, randomizerDi, randomizerPR, randomizerBR, randomizerTemp;

        public static int SystolicValueRandom() // Returns syValue
        {
                randomizerSy = randomizer.Next(0, 100);

                if (randomizerSy <= 5)
                {
                    syValue = randomizer.Next(syMin - 20, syMin - 1);
                }
                else if ((randomizerSy > 5) && (randomizerSy < 95))
                {
                    syValue = randomizer.Next(syMin, syMax);
                }
                else if (randomizerSy >= 95)
                {
                    syValue = randomizer.Next(syMax + 1, syMax + 20);
                }

                return syValue;
        }

        public static int DiastolicValueRandom() // Returns diValue
        {
                randomizerDi = randomizer.Next(0, 100);

                if (randomizerDi <= 5)
                {
                    diValue = randomizer.Next(diMin - 20, diMin - 1);
                }
                else if ((randomizerDi > 5) && (randomizerDi < 95))
                {
                    diValue = randomizer.Next(diMin, diMax);
                }
                else if (randomizerDi >= 95)
                {
                    diValue = randomizer.Next(diMin + 1, diMax + 20);
                }

                return diValue;
        }

        public static int PulseValueRandom()
        {
            randomizerPR = randomizer.Next(0, 100);

            if (randomizerPR <= 5)
            {
                prValue = randomizer.Next(prMin - 20, prMin - 1);
            }
            else if ((randomizerPR > 5) && (randomizerPR < 95))
            {
                prValue = randomizer.Next(prMin, prMax);
            }
            else if (randomizerPR >= 95)
            {
                prValue = randomizer.Next(prMax + 1, prMax + 20);
            }

            return prValue;
        } // Returns prValue

        public static int BreathingValueRandom()
        {
            randomizerBR = randomizer.Next(0, 100);

            if (randomizerBR <= 5)
            {
                brValue = randomizer.Next(brMin - 5, brMin - 1);
            }
            else if ((randomizerBR > 5) && (randomizerBR < 95))
            {
                brValue = randomizer.Next(brMin, brMax);
            }
            else if (randomizerBR >= 95)
            {
                brValue = randomizer.Next(brMax + 1, brMax + 50);
            }

            return brValue;
        } // Returns brValue

        public static int TemperatureValueRandom()
        {
            randomizerTemp = randomizer.Next(0, 100);

            if (randomizerTemp <= 25)
            {
                tempValue = randomizer.Next(tpMin - 25, tpMin - 1);
                tempValue /= 10;
            }
            else if ((randomizerTemp > 25) && (randomizerTemp < 75))
            {
                tempValue = randomizer.Next(tpMin, tpMax);
                tempValue /= 10;
            }
            else if (randomizerTemp >= 75)
            {
                tempValue = randomizer.Next(tpMax + 1, tpMax + 45);
                tempValue /= 10;
            }

            return tempValue;
        } // Returns tempValue

        public static void Timer()
        {
            timer = new Timer(3000);

            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            StartRandom();
            timer.Start();
        }

        public static void StartRandom()
        {
            for (int i = 0; i < 10;)
            {
                SystolicValueRandom();
                DiastolicValueRandom();
                PulseValueRandom();
                BreathingValueRandom();
                TemperatureValueRandom();
            }
        }
    }
}