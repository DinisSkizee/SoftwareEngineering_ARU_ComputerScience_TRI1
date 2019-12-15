﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BedSideView7 : Form
    {
        public static BedSideView7 bed7singleton = new BedSideView7();

        public BedSideView7()
        {
            bed7singleton = this;
            InitializeComponent();
            new BedSideViewConfiguration();

            BedSideViewConfiguration.timer.Tick += ActiveCheck;
            BedSideViewConfiguration.timer.Tick += UpdateRandoms;
            BedSideViewConfiguration.timer.Tick += UpdateTextBox;
            BedSideViewConfiguration.timer.Tick += UpdateCentralStation;
            BedSideViewConfiguration.timer.Tick += UpdateColor;

            #region moduleState[i] Variable Assign
            if ((BreathingRatePanelBed1.Dock == DockStyle.Fill) || (BloodPressurePanelBed1.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed1.Dock == DockStyle.Fill) || (PulseRatePanelBed1.Dock == DockStyle.Fill)) { moduleState1 = 1; }

            if ((BreathingRatePanelBed2.Dock == DockStyle.Fill) || (BloodPressurePanelBed2.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed2.Dock == DockStyle.Fill) || (PulseRatePanelBed2.Dock == DockStyle.Fill)) { moduleState2 = 1; }

            if ((BreathingRatePanelBed3.Dock == DockStyle.Fill) || (BloodPressurePanelBed3.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed3.Dock == DockStyle.Fill) || (PulseRatePanelBed3.Dock == DockStyle.Fill)) { moduleState3 = 1; }

            if ((BreathingRatePanelBed4.Dock == DockStyle.Fill) || (BloodPressurePanelBed4.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed4.Dock == DockStyle.Fill) || (PulseRatePanelBed4.Dock == DockStyle.Fill)) { moduleState4 = 1; }
            #endregion

            #region TextBox Multiline Disable
            tbfn.Multiline = false;
            tbgender.Multiline = false;
            tbage.Multiline = false;
            tbln.Multiline = false;
            tbheight.Multiline = false;
            tbweight.Multiline = false;
            BreathingRate_Actual_Text.Multiline = false;
            BreathingRate_Actual_Text2.Multiline = false;
            BreathingRate_Actual_Text3.Multiline = false;
            BreathingRate_Actual_Text4.Multiline = false;
            BreathingRate_Minimum_Text.Multiline = false;
            BreathingRate_Minimum_Text2.Multiline = false;
            BreathingRate_Minimum_Text3.Multiline = false;
            BreathingRate_Minimum_Text4.Multiline = false;
            BreathingRate_Maximum_Text.Multiline = false;
            BreathingRate_Maximum_Text2.Multiline = false;
            BreathingRate_Maximum_Text3.Multiline = false;
            BreathingRate_Maximum_Text4.Multiline = false;
            DiBloodPressurePanelBed_Actual_Text.Multiline = false;
            DiBloodPressurePanelBed_Actual_Text2.Multiline = false;
            DiBloodPressurePanelBed_Actual_Text3.Multiline = false;
            DiBloodPressurePanelBed_Actual_Text4.Multiline = false;
            DiBloodPressurePanelBed_Maximum_Text.Multiline = false;
            DiBloodPressurePanelBed_Maximum_Text2.Multiline = false;
            DiBloodPressurePanelBed_Maximum_Text3.Multiline = false;
            DiBloodPressurePanelBed_Maximum_Text4.Multiline = false;
            DiBloodPressurePanelBed_Minimum_Text.Multiline = false;
            DiBloodPressurePanelBed_Minimum_Text2.Multiline = false;
            DiBloodPressurePanelBed_Minimum_Text3.Multiline = false;
            DiBloodPressurePanelBed_Minimum_Text4.Multiline = false;
            PulseRate_Actual_Text.Multiline = false;
            PulseRate_Actual_Text2.Multiline = false;
            PulseRate_Actual_Text3.Multiline = false;
            PulseRate_Actual_Text4.Multiline = false;
            PulseRate_Maximum_Text.Multiline = false;
            PulseRate_Maximum_Text2.Multiline = false;
            PulseRate_Maximum_Text3.Multiline = false;
            PulseRate_Maximum_Text4.Multiline = false;
            PulseRate_Minimum_Text.Multiline = false;
            PulseRate_Minimum_Text2.Multiline = false;
            PulseRate_Minimum_Text3.Multiline = false;
            PulseRate_Minimum_Text4.Multiline = false;
            SyBloodPressurePanelBed_Actual_Text.Multiline = false;
            SyBloodPressurePanelBed_Actual_Text2.Multiline = false;
            SyBloodPressurePanelBed_Actual_Text3.Multiline = false;
            SyBloodPressurePanelBed_Actual_Text4.Multiline = false;
            SyBloodPressurePanelBed_Maximum_Text.Multiline = false;
            SyBloodPressurePanelBed_Maximum_Text2.Multiline = false;
            SyBloodPressurePanelBed_Maximum_Text3.Multiline = false;
            SyBloodPressurePanelBed_Maximum_Text4.Multiline = false;
            SyBloodPressurePanelBed_Minimum_Text.Multiline = false;
            SyBloodPressurePanelBed_Minimum_Text2.Multiline = false;
            SyBloodPressurePanelBed_Minimum_Text3.Multiline = false;
            SyBloodPressurePanelBed_Minimum_Text4.Multiline = false;
            Temperature_Actual_Text.Multiline = false;
            Temperature_Actual_Text2.Multiline = false;
            Temperature_Actual_Text3.Multiline = false;
            Temperature_Actual_Text4.Multiline = false;
            Temperature_Maximum_Text.Multiline = false;
            Temperature_Maximum_Text2.Multiline = false;
            Temperature_Maximum_Text3.Multiline = false;
            Temperature_Maximum_Text4.Multiline = false;
            Temperature_Minimum_Text.Multiline = false;
            Temperature_Minimum_Text2.Multiline = false;
            Temperature_Minimum_Text3.Multiline = false;
            Temperature_Minimum_Text4.Multiline = false;

            #endregion

            #region AutoSize False
            tbfn.AutoSize = false;
            tbgender.AutoSize = false;
            tbage.AutoSize = false;
            tbln.AutoSize = false;
            tbheight.AutoSize = false;
            tbweight.AutoSize = false;
            BreathingRate_Actual_Text.AutoSize = false;
            BreathingRate_Actual_Text2.AutoSize = false;
            BreathingRate_Actual_Text3.AutoSize = false;
            BreathingRate_Actual_Text4.AutoSize = false;
            BreathingRate_Minimum_Text.AutoSize = false;
            BreathingRate_Minimum_Text2.AutoSize = false;
            BreathingRate_Minimum_Text3.AutoSize = false;
            BreathingRate_Minimum_Text4.AutoSize = false;
            BreathingRate_Maximum_Text.AutoSize = false;
            BreathingRate_Maximum_Text2.AutoSize = false;
            BreathingRate_Maximum_Text3.AutoSize = false;
            BreathingRate_Maximum_Text4.AutoSize = false;
            DiBloodPressurePanelBed_Actual_Text.AutoSize = false;
            DiBloodPressurePanelBed_Actual_Text2.AutoSize = false;
            DiBloodPressurePanelBed_Actual_Text3.AutoSize = false;
            DiBloodPressurePanelBed_Actual_Text4.AutoSize = false;
            DiBloodPressurePanelBed_Maximum_Text.AutoSize = false;
            DiBloodPressurePanelBed_Maximum_Text2.AutoSize = false;
            DiBloodPressurePanelBed_Maximum_Text3.AutoSize = false;
            DiBloodPressurePanelBed_Maximum_Text4.AutoSize = false;
            DiBloodPressurePanelBed_Minimum_Text.AutoSize = false;
            DiBloodPressurePanelBed_Minimum_Text2.AutoSize = false;
            DiBloodPressurePanelBed_Minimum_Text3.AutoSize = false;
            DiBloodPressurePanelBed_Minimum_Text4.AutoSize = false;
            PulseRate_Actual_Text.AutoSize = false;
            PulseRate_Actual_Text2.AutoSize = false;
            PulseRate_Actual_Text3.AutoSize = false;
            PulseRate_Actual_Text4.AutoSize = false;
            PulseRate_Maximum_Text.AutoSize = false;
            PulseRate_Maximum_Text2.AutoSize = false;
            PulseRate_Maximum_Text3.AutoSize = false;
            PulseRate_Maximum_Text4.AutoSize = false;
            PulseRate_Minimum_Text.AutoSize = false;
            PulseRate_Minimum_Text2.AutoSize = false;
            PulseRate_Minimum_Text3.AutoSize = false;
            PulseRate_Minimum_Text4.AutoSize = false;
            SyBloodPressurePanelBed_Actual_Text.AutoSize = false;
            SyBloodPressurePanelBed_Actual_Text2.AutoSize = false;
            SyBloodPressurePanelBed_Actual_Text3.AutoSize = false;
            SyBloodPressurePanelBed_Actual_Text4.AutoSize = false;
            SyBloodPressurePanelBed_Maximum_Text.AutoSize = false;
            SyBloodPressurePanelBed_Maximum_Text2.AutoSize = false;
            SyBloodPressurePanelBed_Maximum_Text3.AutoSize = false;
            SyBloodPressurePanelBed_Maximum_Text4.AutoSize = false;
            SyBloodPressurePanelBed_Minimum_Text.AutoSize = false;
            SyBloodPressurePanelBed_Minimum_Text2.AutoSize = false;
            SyBloodPressurePanelBed_Minimum_Text3.AutoSize = false;
            SyBloodPressurePanelBed_Minimum_Text4.AutoSize = false;
            Temperature_Actual_Text.AutoSize = false;
            Temperature_Actual_Text2.AutoSize = false;
            Temperature_Actual_Text3.AutoSize = false;
            Temperature_Actual_Text4.AutoSize = false;
            Temperature_Maximum_Text.AutoSize = false;
            Temperature_Maximum_Text2.AutoSize = false;
            Temperature_Maximum_Text3.AutoSize = false;
            Temperature_Maximum_Text4.AutoSize = false;
            Temperature_Minimum_Text.AutoSize = false;
            Temperature_Minimum_Text2.AutoSize = false;
            Temperature_Minimum_Text3.AutoSize = false;
            Temperature_Minimum_Text4.AutoSize = false;
            #endregion

            #region TextBox Size
            tbfn.Size = new Size(151, 36);
            tbgender.Size = new Size(151, 36);
            tbage.Size = new Size(151, 36);
            tbln.Size = new Size(151, 36);
            tbheight.Size = new Size(151, 36);
            tbweight.Size = new Size(151, 36);
            BreathingRate_Actual_Text.Size = new Size(65, 20);
            BreathingRate_Actual_Text2.Size = new Size(65, 20);
            BreathingRate_Actual_Text3.Size = new Size(65, 20);
            BreathingRate_Actual_Text4.Size = new Size(65, 20);
            BreathingRate_Minimum_Text.Size = new Size(65, 20);
            BreathingRate_Minimum_Text2.Size = new Size(65, 20);
            BreathingRate_Minimum_Text3.Size = new Size(65, 20);
            BreathingRate_Minimum_Text4.Size = new Size(65, 20);
            BreathingRate_Maximum_Text.Size = new Size(65, 20);
            BreathingRate_Maximum_Text2.Size = new Size(65, 20);
            BreathingRate_Maximum_Text3.Size = new Size(65, 20);
            BreathingRate_Maximum_Text4.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Actual_Text.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Actual_Text2.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Actual_Text3.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Actual_Text4.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Maximum_Text.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Maximum_Text2.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Maximum_Text3.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Maximum_Text4.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Minimum_Text.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Minimum_Text2.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Minimum_Text3.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Minimum_Text4.Size = new Size(65, 20);
            PulseRate_Actual_Text.Size = new Size(65, 20);
            PulseRate_Actual_Text2.Size = new Size(65, 20);
            PulseRate_Actual_Text3.Size = new Size(65, 20);
            PulseRate_Actual_Text4.Size = new Size(65, 20);
            PulseRate_Maximum_Text.Size = new Size(65, 20);
            PulseRate_Maximum_Text2.Size = new Size(65, 20);
            PulseRate_Maximum_Text3.Size = new Size(65, 20);
            PulseRate_Maximum_Text4.Size = new Size(65, 20);
            PulseRate_Minimum_Text.Size = new Size(65, 20);
            PulseRate_Minimum_Text2.Size = new Size(65, 20);
            PulseRate_Minimum_Text3.Size = new Size(65, 20);
            PulseRate_Minimum_Text4.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Actual_Text.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Actual_Text2.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Actual_Text3.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Actual_Text4.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Maximum_Text.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Maximum_Text2.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Maximum_Text3.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Maximum_Text4.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Minimum_Text.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Minimum_Text2.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Minimum_Text3.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Minimum_Text4.Size = new Size(65, 20);
            Temperature_Actual_Text.Size = new Size(65, 20);
            Temperature_Actual_Text2.Size = new Size(65, 20);
            Temperature_Actual_Text3.Size = new Size(65, 20);
            Temperature_Actual_Text4.Size = new Size(65, 20);
            Temperature_Maximum_Text.Size = new Size(65, 20);
            Temperature_Maximum_Text2.Size = new Size(65, 20);
            Temperature_Maximum_Text3.Size = new Size(65, 20);
            Temperature_Maximum_Text4.Size = new Size(65, 20);
            Temperature_Minimum_Text.Size = new Size(65, 20);
            Temperature_Minimum_Text2.Size = new Size(65, 20);
            Temperature_Minimum_Text3.Size = new Size(65, 20);
            Temperature_Minimum_Text4.Size = new Size(65, 20);
            #endregion

            #region TextBox ReadOnly
            tbfn.ReadOnly = true;
            tbgender.ReadOnly = true;
            tbage.ReadOnly = true;
            tbln.ReadOnly = true;
            tbheight.ReadOnly = true;
            tbweight.ReadOnly = true;
            BreathingRate_Actual_Text.ReadOnly = true;
            BreathingRate_Actual_Text2.ReadOnly = true;
            BreathingRate_Actual_Text3.ReadOnly = true;
            BreathingRate_Actual_Text4.ReadOnly = true;
            BreathingRate_Minimum_Text.ReadOnly = true;
            BreathingRate_Minimum_Text2.ReadOnly = true;
            BreathingRate_Minimum_Text3.ReadOnly = true;
            BreathingRate_Minimum_Text4.ReadOnly = true;
            BreathingRate_Maximum_Text.ReadOnly = true;
            BreathingRate_Maximum_Text2.ReadOnly = true;
            BreathingRate_Maximum_Text3.ReadOnly = true;
            BreathingRate_Maximum_Text4.ReadOnly = true;
            DiBloodPressurePanelBed_Actual_Text.ReadOnly = true;
            DiBloodPressurePanelBed_Actual_Text2.ReadOnly = true;
            DiBloodPressurePanelBed_Actual_Text3.ReadOnly = true;
            DiBloodPressurePanelBed_Actual_Text4.ReadOnly = true;
            DiBloodPressurePanelBed_Maximum_Text.ReadOnly = true;
            DiBloodPressurePanelBed_Maximum_Text2.ReadOnly = true;
            DiBloodPressurePanelBed_Maximum_Text3.ReadOnly = true;
            DiBloodPressurePanelBed_Maximum_Text4.ReadOnly = true;
            DiBloodPressurePanelBed_Minimum_Text.ReadOnly = true;
            DiBloodPressurePanelBed_Minimum_Text2.ReadOnly = true;
            DiBloodPressurePanelBed_Minimum_Text3.ReadOnly = true;
            DiBloodPressurePanelBed_Minimum_Text4.ReadOnly = true;
            PulseRate_Actual_Text.ReadOnly = true;
            PulseRate_Actual_Text2.ReadOnly = true;
            PulseRate_Actual_Text3.ReadOnly = true;
            PulseRate_Actual_Text4.ReadOnly = true;
            PulseRate_Maximum_Text.ReadOnly = true;
            PulseRate_Maximum_Text2.ReadOnly = true;
            PulseRate_Maximum_Text3.ReadOnly = true;
            PulseRate_Maximum_Text4.ReadOnly = true;
            PulseRate_Minimum_Text.ReadOnly = true;
            PulseRate_Minimum_Text2.ReadOnly = true;
            PulseRate_Minimum_Text3.ReadOnly = true;
            PulseRate_Minimum_Text4.ReadOnly = true;
            SyBloodPressurePanelBed_Actual_Text.ReadOnly = true;
            SyBloodPressurePanelBed_Actual_Text2.ReadOnly = true;
            SyBloodPressurePanelBed_Actual_Text3.ReadOnly = true;
            SyBloodPressurePanelBed_Actual_Text4.ReadOnly = true;
            SyBloodPressurePanelBed_Maximum_Text.ReadOnly = true;
            SyBloodPressurePanelBed_Maximum_Text2.ReadOnly = true;
            SyBloodPressurePanelBed_Maximum_Text3.ReadOnly = true;
            SyBloodPressurePanelBed_Maximum_Text4.ReadOnly = true;
            SyBloodPressurePanelBed_Minimum_Text.ReadOnly = true;
            SyBloodPressurePanelBed_Minimum_Text2.ReadOnly = true;
            SyBloodPressurePanelBed_Minimum_Text3.ReadOnly = true;
            SyBloodPressurePanelBed_Minimum_Text4.ReadOnly = true;
            Temperature_Actual_Text.ReadOnly = true;
            Temperature_Actual_Text2.ReadOnly = true;
            Temperature_Actual_Text3.ReadOnly = true;
            Temperature_Actual_Text4.ReadOnly = true;
            Temperature_Maximum_Text.ReadOnly = true;
            Temperature_Maximum_Text2.ReadOnly = true;
            Temperature_Maximum_Text3.ReadOnly = true;
            Temperature_Maximum_Text4.ReadOnly = true;
            Temperature_Minimum_Text.ReadOnly = true;
            Temperature_Minimum_Text2.ReadOnly = true;
            Temperature_Minimum_Text3.ReadOnly = true;
            Temperature_Minimum_Text4.ReadOnly = true;
            #endregion

        }

        public static int dirandom, syrandom, prrandom, brrandom;
        public static double tprandom;
        public static int ditext, sytext, prtext, brtext, tptext;
        public void UpdateColor(object sender, EventArgs e)
        {
            // Passing textbox.text to variable
            int.TryParse(CentralStation.centralsingleton.tbdi7l.Text, out ditext); // Diastolic Value
            int.TryParse(CentralStation.centralsingleton.tbsy7l.Text, out sytext); // Systolic Value
            int.TryParse(CentralStation.centralsingleton.tbpr7l.Text, out prtext); // Pulse Value
            int.TryParse(CentralStation.centralsingleton.tbbr7l.Text, out brtext); // Breathing Value
            int.TryParse(CentralStation.centralsingleton.tbtp7l.Text, out tptext); // Temperature Value

            #region Textbox Color
            // Diastolic TextBox Color
            if (ditext < SocketConfiguration.diMin7 || ditext > SocketConfiguration.diMax7)
            {
                CentralStation.centralsingleton.tbdi7.BackColor = Color.Red;
                CentralStation.centralsingleton.tbdi7l.BackColor = Color.Red;
            }
            else if (ditext > SocketConfiguration.diMin7 && ditext < SocketConfiguration.diMax7)
            {
                CentralStation.centralsingleton.tbdi7.BackColor = Color.FromArgb(105, 105, 105);
                CentralStation.centralsingleton.tbdi7l.BackColor = Color.FromArgb(105, 105, 105);
            }

            // Systolic TextBox Color
            if (sytext < SocketConfiguration.syMin7 || sytext > SocketConfiguration.syMax7)
            {
                CentralStation.centralsingleton.tbsy7.BackColor = Color.Red;
                CentralStation.centralsingleton.tbsy7l.BackColor = Color.Red;
            }
            else if (sytext > SocketConfiguration.syMin7 && sytext < SocketConfiguration.syMax7)
            {
                CentralStation.centralsingleton.tbsy7.BackColor = Color.FromArgb(105, 105, 105);
                CentralStation.centralsingleton.tbsy7l.BackColor = Color.FromArgb(105, 105, 105);
            }

            // Pulse Textbox Color
            if (prtext < SocketConfiguration.prMin7 || prtext > SocketConfiguration.prMax7)
            {
                CentralStation.centralsingleton.tbpr7.BackColor = Color.Red;
                CentralStation.centralsingleton.tbpr7l.BackColor = Color.Red;
            }
            else if (prtext > SocketConfiguration.prMin7 && prtext < SocketConfiguration.prMax7)
            {
                CentralStation.centralsingleton.tbpr7.BackColor = Color.FromArgb(105, 105, 105);
                CentralStation.centralsingleton.tbpr7l.BackColor = Color.FromArgb(105, 105, 105);
            }

            // Breathing Textbox Color
            if (brtext < SocketConfiguration.brMin7 || brtext > SocketConfiguration.brMax7)
            {
                CentralStation.centralsingleton.tbbr7.BackColor = Color.Red;
                CentralStation.centralsingleton.tbbr7l.BackColor = Color.Red;
            }
            else if (brtext > SocketConfiguration.brMin7 && brtext < SocketConfiguration.brMax7)
            {
                CentralStation.centralsingleton.tbbr7.BackColor = Color.FromArgb(105, 105, 105);
                CentralStation.centralsingleton.tbbr7l.BackColor = Color.FromArgb(105, 105, 105);
            }

            // Temperature Textbox Color
            if (tptext < SocketConfiguration.tpMin7 || tptext < SocketConfiguration.tpMax7)
            {
                CentralStation.centralsingleton.tbtp7.BackColor = Color.Red;
                CentralStation.centralsingleton.tbtp7l.BackColor = Color.Red;
            }
            else if (tptext > SocketConfiguration.tpMin7 && tptext > SocketConfiguration.tpMax7)
            {
                CentralStation.centralsingleton.tbtp7.BackColor = Color.FromArgb(105, 105, 105);
                CentralStation.centralsingleton.tbtp7l.BackColor = Color.FromArgb(105, 105, 105);
            }
            #endregion

        }

        public void UpdateRandoms(object sender, EventArgs e)
        {
            dirandom = SocketConfiguration.DiastolicValueRandom();
            syrandom = SocketConfiguration.SystolicValueRandom();
            prrandom = SocketConfiguration.PulseValueRandom();
            brrandom = SocketConfiguration.BreathingValueRandom();
            tprandom = SocketConfiguration.TemperatureValueRandom();
        }

        public void UpdateTextBox(object sender, EventArgs e)
        {
            DiBloodPressurePanelBed_Actual_Text.Text = dirandom.ToString();
            DiBloodPressurePanelBed_Actual_Text2.Text = dirandom.ToString();
            DiBloodPressurePanelBed_Actual_Text3.Text = dirandom.ToString();
            DiBloodPressurePanelBed_Actual_Text4.Text = dirandom.ToString();

            SyBloodPressurePanelBed_Actual_Text.Text = syrandom.ToString();
            SyBloodPressurePanelBed_Actual_Text2.Text = syrandom.ToString();
            SyBloodPressurePanelBed_Actual_Text3.Text = syrandom.ToString();
            SyBloodPressurePanelBed_Actual_Text4.Text = syrandom.ToString();

            PulseRate_Actual_Text.Text = prrandom.ToString();
            PulseRate_Actual_Text2.Text = prrandom.ToString();
            PulseRate_Actual_Text3.Text = prrandom.ToString();
            PulseRate_Actual_Text4.Text = prrandom.ToString();

            BreathingRate_Actual_Text.Text = brrandom.ToString();
            BreathingRate_Actual_Text2.Text = brrandom.ToString();
            BreathingRate_Actual_Text3.Text = brrandom.ToString();
            BreathingRate_Actual_Text4.Text = brrandom.ToString();

            Temperature_Actual_Text.Text = tprandom.ToString();
            Temperature_Actual_Text2.Text = tprandom.ToString();
            Temperature_Actual_Text3.Text = tprandom.ToString();
            Temperature_Actual_Text4.Text = tprandom.ToString();
        }

        public void UpdateCentralStation(object sender, EventArgs e)
        {
            if (bloodActive == true)
            {
                CentralStation.centralsingleton.tbdi7l.Text = dirandom.ToString();
                CentralStation.centralsingleton.tbsy7l.Text = syrandom.ToString();
            }
            else
            {
                CentralStation.centralsingleton.tbdi7l.Text = "";
                CentralStation.centralsingleton.tbsy7l.Text = "";
            }

            if (breathingActive == true)
            {
                CentralStation.centralsingleton.tbbr7l.Text = brrandom.ToString();
            }
            else { CentralStation.centralsingleton.tbbr7l.Text = ""; }

            if (pulseActive == true)
            {
                CentralStation.centralsingleton.tbpr7l.Text = prrandom.ToString();
            }
            else { CentralStation.centralsingleton.tbpr7l.Text = ""; }

            if (tempActive == true)
            {
                CentralStation.centralsingleton.tbtp7l.Text = tprandom.ToString();
            }
            else { CentralStation.centralsingleton.tbtp7l.Text = ""; }
        }

        public static int moduleState1, moduleState2, moduleState3, moduleState4;

        public static int insertClicked1, insertClicked2, insertClicked3, insertClicked4;

        public static bool bloodActive, pulseActive, breathingActive, tempActive;

        private void CentralStationPic_Click(object sender, EventArgs e)
        {
            CentralStation.centralsingleton.Show();
            CentralStation.centralsingleton.Location = this.Location;
            this.Hide();
        }

        #region Draggable Top Panel
        // Draggable Top Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Close/Minimize Buttons
        // Close Button
        private void CloseButtonBedSideView_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Button
        private void MinimizeButtonBedSideView_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            AfterLogin.aftersingleton.Show();
            AfterLogin.aftersingleton.Location = this.Location;
            this.Hide();
        }

        #region Bed Buttons Click
        private void Bed1_Click(object sender, EventArgs e)
        {
            BedSideView1.bed1singleton.Show();
            BedSideView1.bed1singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed2_Click(object sender, EventArgs e)
        {
            BedSideView2.bed2singleton.Show();
            BedSideView2.bed2singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed3_Click(object sender, EventArgs e)
        {
            BedSideView3.bed3singleton.Show();
            BedSideView3.bed3singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed4_Click(object sender, EventArgs e)
        {
            BedSideView4.bed4singleton.Show();
            BedSideView4.bed4singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed5_Click(object sender, EventArgs e)
        {
            BedSideView5.bed5singleton.Show();
            BedSideView5.bed5singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed6_Click(object sender, EventArgs e)
        {
            BedSideView6.bed6singleton.Show();
            BedSideView6.bed6singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed8_Click(object sender, EventArgs e)
        {
            BedSideView8.bed8singleton.Show();
            BedSideView8.bed8singleton.Location = this.Location;
            this.Hide();
        }
        #endregion

        private void BedPicture_Click(object sender, EventArgs e)
        {
            if (tbfn.Text == "")
            {
                SocketConfiguration.RandomGenUserValues();
                tbweight.Text = SocketConfiguration.weight.ToString() + " Kg";
                tbheight.Text = SocketConfiguration.height.ToString() + " Centimeters";
                tbage.Text = SocketConfiguration.age.ToString();

                SocketConfiguration.RandomNameGenerator();
                tbfn.Text = SocketConfiguration.firstName;
                tbln.Text = SocketConfiguration.lastName;

                if (SocketConfiguration.firstNameNumber <= 11)
                {
                    tbgender.Text = "Male";
                }
                else { tbgender.Text = "Female"; }
            }
            else { MessageBox.Show("You already have a person assigned to this Bed"); }
        }

        #region InsertButtons Configuration
        private void InsertButton1_Click(object sender, EventArgs e)
        {
            if (tbfn.Text != "")
            {
                if (moduleState1 == 0)
                {
                    insertClicked1 = 1;

                    SocketSelection.socketsingleton.BedLabel.Text = "Bed 7";
                    SocketSelection.socketsingleton.Show();
                    SocketSelection.socketsingleton.Location = this.Location;
                    this.Hide();
                }
                else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
            }
            else { MessageBox.Show("Please Click on the Bed Picture to Add a Person to this bed"); }
        }

        private void InsertButton2_Click(object sender, EventArgs e)
        {
            if (tbfn.Text != "")
            {
                if (moduleState2 == 0)
                {
                    insertClicked2 = 1;

                    SocketSelection.socketsingleton.BedLabel.Text = "Bed 7";
                    SocketSelection.socketsingleton.Show();
                    SocketSelection.socketsingleton.Location = this.Location;
                    this.Hide();
                }
                else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
            }
            else { MessageBox.Show("Please Click on the Bed Picture to Add a Person to this bed"); }
        }

        private void InsertButton3_Click(object sender, EventArgs e)
        {
            if (tbfn.Text != "")
            {
                if (moduleState3 == 0)
                {
                    insertClicked3 = 1;

                    SocketSelection.socketsingleton.BedLabel.Text = "Bed 7";
                    SocketSelection.socketsingleton.Show();
                    SocketSelection.socketsingleton.Location = this.Location;
                    this.Hide();
                }
                else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
            }
            else { MessageBox.Show("Please Click on the Bed Picture to Add a Person to this bed"); }
        }

        private void InsertButton4_Click(object sender, EventArgs e)
        {
            if (tbfn.Text != "")
            {
                if (moduleState4 == 0)
                {
                    insertClicked4 = 1;

                    SocketSelection.socketsingleton.BedLabel.Text = "Bed 7";
                    SocketSelection.socketsingleton.Show();
                    SocketSelection.socketsingleton.Location = this.Location;
                    this.Hide();
                }
                else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
            }
            else { MessageBox.Show("Please Click on the Bed Picture to Add a Person to this bed"); }
        }
        #endregion

        #region EjectButton Configuration
        private void EjectButton1_Click(object sender, EventArgs e)
        {
            moduleState1 = 0;

            BreathingRatePanelBed1.Dock = DockStyle.None;
            BloodPressurePanelBed1.Dock = DockStyle.None;
            TemperaturePanelBed1.Dock = DockStyle.None;
            PulseRatePanelBed1.Dock = DockStyle.None;

            BreathingRatePanelBed1.Visible = false;
            BloodPressurePanelBed1.Visible = false;
            TemperaturePanelBed1.Visible = false;
            PulseRatePanelBed1.Visible = false;
            InsertASocket1.Visible = true;
        }

        private void EjectButton2_Click(object sender, EventArgs e)
        {
            moduleState2 = 0;

            BreathingRatePanelBed2.Dock = DockStyle.None;
            BloodPressurePanelBed2.Dock = DockStyle.None;
            TemperaturePanelBed2.Dock = DockStyle.None;
            PulseRatePanelBed2.Dock = DockStyle.None;

            BreathingRatePanelBed2.Visible = false;
            BloodPressurePanelBed2.Visible = false;
            TemperaturePanelBed2.Visible = false;
            PulseRatePanelBed2.Visible = false;
            InsertASocket2.Visible = true;
        }

        private void EjectButton3_Click(object sender, EventArgs e)
        {
            moduleState3 = 0;

            BreathingRatePanelBed3.Dock = DockStyle.None;
            BloodPressurePanelBed3.Dock = DockStyle.None;
            TemperaturePanelBed3.Dock = DockStyle.None;
            PulseRatePanelBed3.Dock = DockStyle.None;

            BreathingRatePanelBed3.Visible = false;
            BloodPressurePanelBed3.Visible = false;
            TemperaturePanelBed3.Visible = false;
            PulseRatePanelBed3.Visible = false;
            InsertASocket3.Visible = true;
        }

        private void EjectButton4_Click(object sender, EventArgs e)
        {
            moduleState4 = 0;

            BreathingRatePanelBed4.Dock = DockStyle.None;
            BloodPressurePanelBed4.Dock = DockStyle.None;
            TemperaturePanelBed4.Dock = DockStyle.None;
            PulseRatePanelBed4.Dock = DockStyle.None;

            BreathingRatePanelBed4.Visible = false;
            BloodPressurePanelBed4.Visible = false;
            TemperaturePanelBed4.Visible = false;
            PulseRatePanelBed4.Visible = false;
            InsertASocket4.Visible = true;
        }
        #endregion

        public void ActiveCheck(object sender, EventArgs e)
        {
            if (BloodPressurePanelBed1.Dock == DockStyle.Fill || BloodPressurePanelBed2.Dock == DockStyle.Fill ||
                BloodPressurePanelBed3.Dock == DockStyle.Fill || BloodPressurePanelBed4.Dock == DockStyle.Fill)
            {
                bloodActive = true;
            }
            else { bloodActive = false; }

            if (PulseRatePanelBed1.Dock == DockStyle.Fill || PulseRatePanelBed2.Dock == DockStyle.Fill ||
                PulseRatePanelBed3.Dock == DockStyle.Fill || PulseRatePanelBed4.Dock == DockStyle.Fill)
            {
                pulseActive = true;
            }
            else { pulseActive = false; }

            if (BreathingRatePanelBed1.Dock == DockStyle.Fill || BreathingRatePanelBed2.Dock == DockStyle.Fill ||
                BreathingRatePanelBed3.Dock == DockStyle.Fill || BreathingRatePanelBed4.Dock == DockStyle.Fill)
            {
                breathingActive = true;
            }
            else { breathingActive = false; }

            if (TemperaturePanelBed1.Dock == DockStyle.Fill || TemperaturePanelBed2.Dock == DockStyle.Fill ||
                TemperaturePanelBed3.Dock == DockStyle.Fill || TemperaturePanelBed4.Dock == DockStyle.Fill)
            {
                tempActive = true;
            }
            else { tempActive = false; }

        }

    }
}
