using System;
using System.Collections.Generic;

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
        public static List<string> firstNameList = new List<string>()
        {
            "Dinis", "Jorge", "Haris", "John", "Herbert", "Kevin", "Aaron", "Elias", "Jamie", "Jacob", "Kye",
            "Brett", "Lucie", "Nancy", "Rebekah", "Maria", "Erica", "Rhonda", "Haleema", "Poppy", "Melanie"
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

        }

        // Variables for the Randoms To connect with the BedSideViews
        public static int diMin1, diMax1, syMin1, syMax1, prMin1, prMax1, brMin1, brMax1, tpMin1, tpMax1;
        public static int diMin2, diMax2, syMin2, syMax2, prMin2, prMax2, brMin2, brMax2, tpMin2, tpMax2;
        public static int diMin3, diMax3, syMin3, syMax3, prMin3, prMax3, brMin3, brMax3, tpMin3, tpMax3;
        public static int diMin4, diMax4, syMin4, syMax4, prMin4, prMax4, brMin4, brMax4, tpMin4, tpMax4;
        public static int diMin5, diMax5, syMin5, syMax5, prMin5, prMax5, brMin5, brMax5, tpMin5, tpMax5;
        public static int diMin6, diMax6, syMin6, syMax6, prMin6, prMax6, brMin6, brMax6, tpMin6, tpMax6;
        public static int diMin7, diMax7, syMin7, syMax7, prMin7, prMax7, brMin7, brMax7, tpMin7, tpMax7;
        public static int diMin8, diMax8, syMin8, syMax8, prMin8, prMax8, brMin8, brMax8, tpMin8, tpMax8;

        public static int weight, age, height;
        public static int firstNameNumber, lastNameNumber;
        public static string firstName, lastName;
        public static void RandomGenUserValues()
        {
            weight = randomizer.Next(60, 85);
            height = randomizer.Next(150, 210);
            age = randomizer.Next(25, 45);
        }

        public static void RandomNameGenerator()
        {
            firstNameNumber = randomizer.Next(0, firstNameList.Count);
            lastNameNumber = randomizer.Next(0, lastNameList.Count);

            firstName = firstNameList[firstNameNumber];
            lastName = lastNameList[lastNameNumber];
        }

        // Variables for the Randomizers below
        public static int syValue, diValue, prValue, brValue;
        public static double tempValue;
        public static int randomizerSy, randomizerDi, randomizerPR, randomizerBR, randomizerTemp;

        public static int SystolicValueRandom() // Returns syValue
        {
            randomizerSy = randomizer.Next(0, 100);

            if (randomizerSy <= 5)
            {
                syValue = randomizer.Next(syMin1 - 20, syMin1 - 1);
            }
            else if ((randomizerSy > 5) && (randomizerSy < 95))
            {
                syValue = randomizer.Next(syMin1, syMax1);
            }
            else if (randomizerSy >= 95)
            {
                syValue = randomizer.Next(syMax1 + 1, syMax1 + 20);
            }

            return syValue;
        }

        public static int DiastolicValueRandom() // Returns diValue
        {
            randomizerDi = randomizer.Next(0, 100);

            if (randomizerDi <= 5)
            {
                diValue = randomizer.Next(diMin1 - 20, diMin1 - 1);
            }
            else if ((randomizerDi > 5) && (randomizerDi < 95))
            {
                diValue = randomizer.Next(diMin1, diMax1);
            }
            else if (randomizerDi >= 95)
            {
                diValue = randomizer.Next(diMin1 + 1, diMax1 + 20);
            }

            return diValue;
        }

        public static int PulseValueRandom()
        {
            randomizerPR = randomizer.Next(0, 100);

            if (randomizerPR <= 5)
            {
                prValue = randomizer.Next(prMin1 - 20, prMin1 - 1);
            }
            else if ((randomizerPR > 5) && (randomizerPR < 95))
            {
                prValue = randomizer.Next(prMin1, prMax1);
            }
            else if (randomizerPR >= 95)
            {
                prValue = randomizer.Next(prMax1 + 1, prMax1 + 20);
            }

            return prValue;
        } // Returns prValue

        public static int BreathingValueRandom()
        {
            randomizerBR = randomizer.Next(0, 100);

            if (randomizerBR <= 5)
            {
                brValue = randomizer.Next(brMin1 - 5, brMin1 - 1);
            }
            else if ((randomizerBR > 5) && (randomizerBR < 95))
            {
                brValue = randomizer.Next(brMin1, brMax1);
            }
            else if (randomizerBR >= 95)
            {
                brValue = randomizer.Next(brMax1 + 1, brMax1 + 50);
            }

            return brValue;
        } // Returns brValue

        public static double TemperatureValueRandom()
        {
            randomizerTemp = randomizer.Next(0, 100);

            if (randomizerTemp <= 25)
            {
                tempValue = randomizer.Next(tpMin1 - 25, tpMin1 - 1);
            }
            else if ((randomizerTemp > 25) && (randomizerTemp < 75))
            {
                tempValue = randomizer.Next(tpMin1, tpMax1);
            }
            else if (randomizerTemp >= 75)
            {
                tempValue = randomizer.Next(tpMax1 + 1, tpMax1 + 45);
            }

            return tempValue;
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