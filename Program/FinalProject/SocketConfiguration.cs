using System;
using System.Windows.Forms;

namespace FinalProject
{
    class SocketConfiguration
    {
        public static int weight, age, height;
        public static int syValue, diValue, prValue, brValue, tempValue;
        public static int intVerifier;
        public static int diMinI, diMaxI, syMinI, syMaxI, prMinI, prMaxI, brMinI, brMaxI, tpMinI, tpMaxI;
        public static int diDiff, syDiff, prDiff, brDiff, tempDiff;

        public SocketConfiguration()
        {
            SocketSelection socket = new SocketSelection();
            /* A randomizer is implemented generating a value from 0 to 100
             * so then we can randomize the values with percentage deciding
             * then in each if how much would it be for the same statement */

            RandomGenBasicValues();

            #region Difference Verifier
            // Blood Pressure Secondary Variables Integer
            diMinI = Convert.ToInt32(socket.BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text);
            diMaxI = Convert.ToInt32(socket.BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text);
            syMinI = Convert.ToInt32(socket.BloodPressureTextBox_SystolicMinimum_ParameterValue.Text);
            syMaxI = Convert.ToInt32(socket.BloodPressureTextBox_SystolicMaximum_ParameterValue.Text);

            // Pulse Rate Secondary Variables Integer
            prMinI = Convert.ToInt32(socket.PulseRate_Minimum_TextBox.Text);
            prMaxI = Convert.ToInt32(socket.PulseRate_Maximum_TextBox.Text);

            // Breathing Rate Secondary Variables Integer
            brMinI = Convert.ToInt32(socket.BreathingRate_Minimum_TextBox.Text);
            brMaxI = Convert.ToInt32(socket.BreathingRate_Maximum_TextBox.Text);

            // Temperature Secondary Variables Integer
            tpMinI = Convert.ToInt32(socket.Temperature_Minimum_TextBox.Text);
            tpMaxI = Convert.ToInt32(socket.Temperature_Maximum_TextBox.Text);

            diDiff = diMaxI - diMinI;      // BPDi = 30
            syDiff = syMaxI - syMinI;      // BPSy = 20
            prDiff = prMaxI - prMinI;      // PR = 30
            brDiff = brMaxI - brMinI;      // BR = 5
            tempDiff = tpMaxI - tpMinI;    // TP = 2

            if (diDiff < 30 && syDiff < 20)
            {
                MessageBox.Show("The Systolic / Diastolic Values are INVALID, their difference MUST be greater than Di: 30; Sy: 20");
                intVerifier = 0;
            }
            else { intVerifier = 1; }
            if (prDiff < 30)
            {
                MessageBox.Show("The Pulse Rate Values are INVALID, their difference MUST be greater than 30");
                intVerifier = 0;
            }
            else { intVerifier = 1; }
            if (brDiff < 5)
            {
                MessageBox.Show("The Breathing Rate Values are INVALID, their difference MUST be greater than 5");
                intVerifier = 0;
            }
            else { intVerifier = 1; }
            if (tempDiff < 1)
            {
                MessageBox.Show("The Temperature Values are INVALID, their difference MUST be greater than 1");
                intVerifier = 0;
            }
            else { intVerifier = 1; }
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

                #region Pulse Rate * bpm * -- Dinis & Jorge

                Random randomPR = new Random();
                int randomizerPR = randomPR.Next(0, 100);

                if (randomizerPR <= 5)
                {
                    Random prLowRandomizer = new Random();
                    prValue = prLowRandomizer.Next(30, 49);
                }
                else if ((randomizerPR > 5) && (randomizerPR < 95))
                {
                    Random hrNormalRandomizer = new Random();
                    prValue = hrNormalRandomizer.Next(50, 75);
                }
                else if (randomizerPR > 95)
                {
                    Random hrHighRandomizer = new Random();
                    prValue = hrHighRandomizer.Next(76, 95);
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
        /// <summary>
        /// Weight + Age + Height -- Dinis & Jorge
        /// </summary>
        /// <returns>
        /// Weight
        /// Age
        /// Height
        /// </returns>
        void RandomGenBasicValues()
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