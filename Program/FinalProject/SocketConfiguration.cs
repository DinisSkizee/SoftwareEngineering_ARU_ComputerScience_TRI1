using System;
using System.Windows.Forms;

namespace FinalProject
{
    class SocketConfiguration : SocketSelection
    {
        #region Variable Region
        // Variables used for the Randoms
        public static int syValue, diValue, prValue, brValue, tempValue;
        Random randomSyDi = new Random();
        Random syDiLowRandomizer = new Random();
        Random syDiNormalRandomizer = new Random();
        Random syDiHighRandomizer = new Random();

        Random randomPR = new Random();
        Random prLowRandomizer = new Random();
        Random hrNormalRandomizer = new Random();
        Random hrHighRandomizer = new Random();

        Random randomBR = new Random();
        Random brLowRandomizer = new Random();
        Random brNormalRandomizer = new Random();
        Random brHighRandomizer = new Random();

        Random randomTemp = new Random();
        Random tempLowRandomizer = new Random();
        Random tempNormalRandomizer = new Random();
        Random tempHighRandomizer = new Random();

        // User Variables
        public static int weight, age, height;

        // Verifiers Variables
        public static int intVerifier;
        public static int bpParameters, prParameters, brParameters, tpParameters;
        public static int dockActive = 0;

        // Values Variables
        public static int diDiff, syDiff, prDiff, brDiff, tempDiff;
        public bool dMi, dMa, sMi, sMa, pMi, pMa, bMi, bMa, tMi, tMa;
        public static int diMin, diMax, syMin, syMax, prMin, prMax, brMin, brMax, tpMin, tpMax;
        // public int diMinI, diMaxI, syMinI, syMaxI, prMinI, prMaxI, brMinI, brMaxI, tpMinI, tpMaxI;
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

            RandomGenUserValues();
            RandomGenModValues();

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

        public static int Difference()
        {
            if (dockActive == 0)
            {
                if (diDiff < 30 && syDiff < 20)
                {
                    intVerifier = 0;
                    MessageBox.Show("The Systolic / Diastolic Values are INVALID, their difference MUST be greater than Di: 30; Sy: 20");
                }
                else { intVerifier = 1; }
            }

            else if (dockActive == 1)
            {
                if (prDiff < 30)
                {
                    intVerifier = 0;
                    MessageBox.Show("The Pulse Rate Values are INVALID, their difference MUST be greater than 30");
                }
                else { intVerifier = 1; }
            }

            else if (dockActive == 2)
            {
                if (brDiff < 5)
                {
                    intVerifier = 0;
                    MessageBox.Show("The Breathing Rate Values are INVALID, their difference MUST be greater than 5");
                }
                else { intVerifier = 1; }
            }

            else if (dockActive == 3)
            {
                if (tempDiff < 1)
                {
                    intVerifier = 0;
                    MessageBox.Show("The Temperature Values are INVALID, their difference MUST be greater than 1");
                }
                else { intVerifier = 1; }
            }

            return intVerifier;
        }

        void RandomGenModValues()
        {

            #region Blood Pressure * Systolic & Diastolic * -- Dinis & Jorge
            // Random randomSyDi = new Random();  // Create a Randomizer for the Systolic and Diastolic Values
            int randomizerSyDi = randomSyDi.Next(0, 100);

            if (randomizerSyDi <= 5)
            {
                // Random syDiLowRandomizer = new Random();
                syValue = syDiLowRandomizer.Next(70, 89);
                diValue = syDiLowRandomizer.Next(40, 59);
            }
            else if ((randomizerSyDi > 5) && (randomizerSyDi < 95))
            {
                // Random syDiNormalRandomizer = new Random();
                syValue = syDiNormalRandomizer.Next(90, 140);
                diValue = syDiNormalRandomizer.Next(60, 90);
            }
            else if (randomizerSyDi >= 95)
            {
                // Random syDiHighRandomizer = new Random();
                syValue = syDiHighRandomizer.Next(141, 160);
                diValue = syDiHighRandomizer.Next(91, 110);
            }
            #endregion

            #region Pulse Rate * bpm * -- Dinis & Jorge

            // Random randomPR = new Random();
            int randomizerPR = randomPR.Next(0, 100);

            if (randomizerPR <= 5)
            {
                // Random prLowRandomizer = new Random();
                prValue = prLowRandomizer.Next(30, 49);
            }
            else if ((randomizerPR > 5) && (randomizerPR < 95))
            {
                // Random hrNormalRandomizer = new Random();
                prValue = hrNormalRandomizer.Next(50, 75);
            }
            else if (randomizerPR > 95)
            {
                // Random hrHighRandomizer = new Random();
                prValue = hrHighRandomizer.Next(76, 95);
            }
            #endregion

            #region Breathing Rate * Breaths Per Minute * -- Dinis & Jorge

            // Random randomBR = new Random();
            int randomizerBR = randomBR.Next(0, 100);

            if (randomizerBR <= 5)
            {
                // Random brLowRandomizer = new Random();
                brValue = brLowRandomizer.Next(2, 6);
            }
            else if ((randomizerBR > 5) && (randomizerBR < 95))
            {
                // Random brNormalRandomizer = new Random();
                brValue = brNormalRandomizer.Next(7, 45);
            }
            else if (randomizerBR >= 95)
            {
                // Random brHighRandomizer = new Random();
                brValue = brHighRandomizer.Next(46, 100);
            }
            #endregion

            #region Temperature * °C * -- Dinis & Jorge

            // Random randomTemp = new Random();
            int randomizerTemp = randomTemp.Next(0, 100);

            if (randomizerTemp <= 25)
            {
                // Random tempLowRandomizer = new Random();
                tempValue = tempLowRandomizer.Next(350, 364);
                tempValue /= 10;
            }
            else if ((randomizerTemp > 25) && (randomizerTemp < 75))
            {
                // Random tempNormalRandomizer = new Random();
                tempValue = tempNormalRandomizer.Next(365, 375);
                tempValue /= 10;
            }
            else if (randomizerTemp >= 75)
            {
                // Random tempHighRandomizer = new Random();
                tempValue = tempHighRandomizer.Next(376, 410);
                tempValue /= 10;
            }
            #endregion

        }

        void RandomGenUserValues()
        {
            Random randomWeight = new Random();
            Random randomAge = new Random();
            Random randomHeight = new Random();

            weight = randomWeight.Next(60, 85);
            age = randomAge.Next(25, 45);
            height = randomHeight.Next(150, 210);
        }

    }
}