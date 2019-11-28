﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject
{
    class SocketConfiguration
    {
        #region Variable 
        // Variables used for the Randoms
        public static int syValue, diValue, prValue, brValue;
        public static double tempValue;

        static Random randomizer = new Random();

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


        // Variables for the Randomizers below
        public static int randomizerSy, randomizerDi, randomizerPR, randomizerBR, randomizerTemp;

        public static string SystolicValueRandom() // Returns syValue
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

            return syValue.ToString();
        }

        public static string DiastolicValueRandom() // Returns diValue
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

            return diValue.ToString();
        }

        public static string PulseValueRandom()
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

            return prValue.ToString();
        } // Returns prValue

        public static string BreathingValueRandom()
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

            return brValue.ToString();
        } // Returns brValue

        public static string TemperatureValueRandom()
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

            return tempValue.ToString();
        } // Returns tempValue

        public static void StartRandom(object sender, EventArgs e)
        {
            SystolicValueRandom();
            DiastolicValueRandom();
            PulseValueRandom();
            BreathingValueRandom();
            TemperatureValueRandom();
        }
    }
}