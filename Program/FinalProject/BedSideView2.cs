﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BedSideView2 : Form
    {
        public BedSideView2()
        {
            InitializeComponent();

            if ((BreathingRatePanelBed1.Dock == DockStyle.Fill) || (BloodPressurePanelBed1.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed1.Dock == DockStyle.Fill) || (PulseRatePanelBed1.Dock == DockStyle.Fill))
            {
                moduleState1 = 1;
            }

            if ((BreathingRatePanelBed2.Dock == DockStyle.Fill) || (BloodPressurePanelBed2.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed2.Dock == DockStyle.Fill) || (PulseRatePanelBed2.Dock == DockStyle.Fill))
            {
                moduleState2 = 1;
            }

            if ((BreathingRatePanelBed3.Dock == DockStyle.Fill) || (BloodPressurePanelBed3.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed3.Dock == DockStyle.Fill) || (PulseRatePanelBed3.Dock == DockStyle.Fill))
            {
                moduleState3 = 1;
            }

            if ((BreathingRatePanelBed4.Dock == DockStyle.Fill) || (BloodPressurePanelBed4.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed4.Dock == DockStyle.Fill) || (PulseRatePanelBed4.Dock == DockStyle.Fill))
            {
                moduleState4 = 1;
            }

            #region BloodInsert IF Statements
            if (bloodInsert1 == 1)
            {
                BloodPressurePanelBed1.Dock = DockStyle.Fill;
                BloodPressurePanelBed1.Visible = true;
                InsertASocket1.Visible = false;
            }
            else if (bloodInsert2 == 1)
            {
                BloodPressurePanelBed2.Dock = DockStyle.Fill;
                BloodPressurePanelBed2.Visible = true;
                InsertASocket2.Visible = false;
            }
            else if (bloodInsert3 == 1)
            {
                BloodPressurePanelBed3.Dock = DockStyle.Fill;
                BloodPressurePanelBed3.Visible = true;
                InsertASocket2.Visible = false;
            }
            else if (bloodInsert4 == 1)
            {
                BloodPressurePanelBed4.Dock = DockStyle.Fill;
                BloodPressurePanelBed4.Visible = true;
                InsertASocket4.Visible = false;
            }
            #endregion

            #region BreathingInsert IF Statements
            if (breathingInsert1 == 1)
            {
                BreathingRatePanelBed1.Dock = DockStyle.Fill;
                BreathingRatePanelBed1.Visible = true;
                InsertASocket1.Visible = false;
            }
            else if (breathingInsert2 == 1)
            {
                BreathingRatePanelBed2.Dock = DockStyle.Fill;
                BreathingRatePanelBed2.Visible = true;
                InsertASocket2.Visible = false;
            }
            else if (breathingInsert3 == 1)
            {
                BreathingRatePanelBed3.Dock = DockStyle.Fill;
                BreathingRatePanelBed3.Visible = true;
                InsertASocket3.Visible = false;
            }
            else if (breathingInsert4 == 1)
            {
                BreathingRatePanelBed4.Dock = DockStyle.Fill;
                BreathingRatePanelBed4.Visible = true;
                InsertASocket4.Visible = false;
            }
            #endregion

            #region PulseInsert IF Statements
            if (pulseInsert1 == 1)
            {
                PulseRatePanelBed1.Dock = DockStyle.Fill;
                PulseRatePanelBed1.Visible = true;
                InsertASocket1.Visible = false;
            }
            else if (pulseInsert2 == 1)
            {
                PulseRatePanelBed2.Dock = DockStyle.Fill;
                PulseRatePanelBed2.Visible = true;
                InsertASocket2.Visible = false;
            }
            else if (pulseInsert3 == 1)
            {
                PulseRatePanelBed3.Dock = DockStyle.Fill;
                PulseRatePanelBed3.Visible = true;
                InsertASocket3.Visible = false;
            }
            else if (pulseInsert4 == 1)
            {
                PulseRatePanelBed4.Dock = DockStyle.Fill;
                PulseRatePanelBed4.Visible = true;
                InsertASocket4.Visible = false;
            }
            #endregion

            #region TempInsert IF Statements
            if (tempInsert1 == 1)
            {
                TemperaturePanelBed1.Dock = DockStyle.Fill;
                TemperaturePanelBed1.Visible = true;
                InsertASocket1.Visible = false;
            }
            else if (tempInsert2 == 1)
            {
                TemperaturePanelBed2.Dock = DockStyle.Fill;
                TemperaturePanelBed2.Visible = true;
                InsertASocket2.Visible = false;
            }
            else if (tempInsert3 == 1)
            {
                TemperaturePanelBed3.Dock = DockStyle.Fill;
                TemperaturePanelBed3.Visible = true;
                InsertASocket3.Visible = false;
            }
            else if (tempInsert4 == 1)
            {
                TemperaturePanelBed4.Dock = DockStyle.Fill;
                TemperaturePanelBed4.Visible = true;
                InsertASocket4.Visible = false;
            }
            #endregion
        }

        // Variables
        public static int moduleState1, moduleState2, moduleState3, moduleState4;
        public static int insertClicked1, insertClicked2, insertClicked3, insertClicked4;
        public static int bloodInsert1, bloodInsert2, bloodInsert3, bloodInsert4;
        public static int pulseInsert1, pulseInsert2, pulseInsert3, pulseInsert4;
        public static int breathingInsert1, breathingInsert2, breathingInsert3, breathingInsert4;
        public static int tempInsert1, tempInsert2, tempInsert3, tempInsert4;

        #region Draggable Top Panel  -- Dinis & Jorge
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

        #region Close/Minimize Buttons  -- Dinis & Jorge
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


        // Small Icon on the Left Top corner to go back to the AfterLogin form
        private void MainPageButton_Click(object sender, EventArgs e)   // -- Dinis & Jorge
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            afterlogin.Location = this.Location;
            this.Hide();
        }

        #region Bed Buttons Click  -- Dinis & Jorge
        private void Bed1_Click(object sender, EventArgs e)
        {
            BedSideView1 bedSideView1 = new BedSideView1();
            bedSideView1.Show();
            bedSideView1.Location = this.Location;
            this.Hide();
        }

        private void Bed3_Click(object sender, EventArgs e)
        {
            BedSideView3 bedSideView3 = new BedSideView3();
            bedSideView3.Show();
            bedSideView3.Location = this.Location;
            this.Hide();
        }

        private void Bed4_Click(object sender, EventArgs e)
        {
            BedSideView4 bedSideView4 = new BedSideView4();
            bedSideView4.Show();
            bedSideView4.Location = this.Location;
            this.Hide();
        }

        private void Bed5_Click(object sender, EventArgs e)
        {
            BedSideView5 bedSideView5 = new BedSideView5();
            bedSideView5.Show();
            bedSideView5.Location = this.Location;
            this.Hide();
        }

        private void Bed6_Click(object sender, EventArgs e)
        {
            BedSideView6 bedSideView6 = new BedSideView6();
            bedSideView6.Show();
            bedSideView6.Location = this.Location;
            this.Hide();
        }

        private void Bed7_Click(object sender, EventArgs e)
        {
            BedSideView7 bedSideView7 = new BedSideView7();
            bedSideView7.Show();
            bedSideView7.Location = this.Location;
            this.Hide();
        }

        private void Bed8_Click(object sender, EventArgs e)
        {
            BedSideView8 bedSideView8 = new BedSideView8();
            bedSideView8.Show();
            bedSideView8.Location = this.Location;
            this.Hide();
        }
        #endregion

        #region InsertButtons Configuration  -- Dinis & Jorge
        private void InsertButton1_Click(object sender, EventArgs e)
        {
            SocketSelection soS = new SocketSelection();

            soS.BedLabel.Text = "Bed 2";
            soS.Show();
            soS.Location = this.Location;
            this.Hide();
        }

        private void InsertButton2_Click(object sender, EventArgs e)
        {
            SocketSelection soS = new SocketSelection();

            soS.BedLabel.Text = "Bed 2";
            soS.Show();
            soS.Location = this.Location;
            this.Hide();
        }

        private void InsertButton3_Click(object sender, EventArgs e)
        {
            SocketSelection soS = new SocketSelection();

            soS.BedLabel.Text = "Bed 2";
            soS.Show();
            soS.Location = this.Location;
            this.Hide();
        }

        private void InsertButton4_Click(object sender, EventArgs e)
        {
            SocketSelection soS = new SocketSelection();

            soS.BedLabel.Text = "Bed 2";
            soS.Show();
            soS.Location = this.Location;
            this.Hide();
        }
        #endregion

        #region EjectButton Configuration  -- Dinis & Jorge
        private void EjectButton1_Click(object sender, EventArgs e)
        {
            moduleState1 = 0;

            BreathingRatePanelBed1.Visible = false;
            BloodPressurePanelBed1.Visible = false;
            TemperaturePanelBed1.Visible = false;
            PulseRatePanelBed1.Visible = false;
            InsertASocket1.Visible = true;
        }

        private void EjectButton2_Click(object sender, EventArgs e)
        {
            moduleState2 = 0;

            BreathingRatePanelBed2.Visible = false;
            BloodPressurePanelBed2.Visible = false;
            TemperaturePanelBed2.Visible = false;
            PulseRatePanelBed2.Visible = false;
            InsertASocket2.Visible = true;
        }

        private void EjectButton3_Click(object sender, EventArgs e)
        {
            moduleState3 = 0;

            BreathingRatePanelBed3.Visible = false;
            BloodPressurePanelBed3.Visible = false;
            TemperaturePanelBed3.Visible = false;
            PulseRatePanelBed3.Visible = false;
            InsertASocket3.Visible = true;
        }

        private void EjectButton4_Click(object sender, EventArgs e)
        {
            moduleState4 = 0;

            BreathingRatePanelBed4.Visible = false;
            BloodPressurePanelBed4.Visible = false;
            TemperaturePanelBed4.Visible = false;
            PulseRatePanelBed4.Visible = false;
            InsertASocket4.Visible = true;
        }
        #endregion
    }
}
