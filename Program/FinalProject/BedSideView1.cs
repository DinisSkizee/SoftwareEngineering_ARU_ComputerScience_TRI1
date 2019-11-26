using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BedSideView1 : Form
    {

        public static BedSideView1 singleton;

        public BedSideView1()
        {
            InitializeComponent();

            singleton = this;
            new BedSideViewConfiguration();

            #region moduleState[i] Variable Assign
            if ((BreathingRatePanelBed1.Dock == DockStyle.Fill) || (BloodPressurePanelBed1.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed1.Dock == DockStyle.Fill) || (PulseRatePanelBed1.Dock == DockStyle.Fill)) { moduleState1 = 1; }
            else if ((BreathingRatePanelBed1.Dock == DockStyle.None) && (BloodPressurePanelBed1.Dock == DockStyle.None) &&
                (TemperaturePanelBed1.Dock == DockStyle.None) && (PulseRatePanelBed1.Dock == DockStyle.None)) { moduleState1 = 0; }

            if ((BreathingRatePanelBed2.Dock == DockStyle.Fill) || (BloodPressurePanelBed2.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed2.Dock == DockStyle.Fill) || (PulseRatePanelBed2.Dock == DockStyle.Fill)) { moduleState2 = 1; }
            else if ((BreathingRatePanelBed2.Dock == DockStyle.None) || (BloodPressurePanelBed2.Dock == DockStyle.None) ||
                (TemperaturePanelBed2.Dock == DockStyle.None) || (PulseRatePanelBed2.Dock == DockStyle.None)) { moduleState2 = 0; }

            if ((BreathingRatePanelBed3.Dock == DockStyle.Fill) || (BloodPressurePanelBed3.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed3.Dock == DockStyle.Fill) || (PulseRatePanelBed3.Dock == DockStyle.Fill)) { moduleState3 = 1; }
            else if ((BreathingRatePanelBed3.Dock == DockStyle.None) || (BloodPressurePanelBed3.Dock == DockStyle.None) ||
                (TemperaturePanelBed3.Dock == DockStyle.None) || (PulseRatePanelBed3.Dock == DockStyle.None)) { moduleState3 = 0; }

            if ((BreathingRatePanelBed4.Dock == DockStyle.Fill) || (BloodPressurePanelBed4.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed4.Dock == DockStyle.Fill) || (PulseRatePanelBed4.Dock == DockStyle.Fill)) { moduleState4 = 1; }
            else if ((BreathingRatePanelBed4.Dock == DockStyle.None) || (BloodPressurePanelBed4.Dock == DockStyle.None) ||
                (TemperaturePanelBed4.Dock == DockStyle.None) || (PulseRatePanelBed4.Dock == DockStyle.None)) { moduleState4 = 0; }
            #endregion

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
                bloodInsert2 = 0;
            }
            else if (bloodInsert3 == 1)
            {
                BloodPressurePanelBed3.Dock = DockStyle.Fill;
                BloodPressurePanelBed3.Visible = true;
                InsertASocket3.Visible = false;
                bloodInsert3 = 0;
            }
            else if (bloodInsert4 == 1)
            {
                BloodPressurePanelBed4.Dock = DockStyle.Fill;
                BloodPressurePanelBed4.Visible = true;
                InsertASocket4.Visible = false;
                bloodInsert4 = 0;
            }
            #endregion

            #region BreathingInsert IF Statements
            if (breathingInsert1 == 1)
            {
                BreathingRatePanelBed1.Dock = DockStyle.Fill;
                BreathingRatePanelBed1.Visible = true;
                InsertASocket1.Visible = false;
                breathingInsert1 = 0;
            }
            else if (breathingInsert2 == 1)
            {
                BreathingRatePanelBed2.Dock = DockStyle.Fill;
                BreathingRatePanelBed2.Visible = true;
                InsertASocket2.Visible = false;
                breathingInsert2 = 0;
            }
            else if (breathingInsert3 == 1)
            {
                BreathingRatePanelBed3.Dock = DockStyle.Fill;
                BreathingRatePanelBed3.Visible = true;
                InsertASocket3.Visible = false;
                breathingInsert3 = 0;
            }
            else if (breathingInsert4 == 1)
            {
                BreathingRatePanelBed4.Dock = DockStyle.Fill;
                BreathingRatePanelBed4.Visible = true;
                InsertASocket4.Visible = false;
                breathingInsert4 = 0;
            }
            #endregion

            #region PulseInsert IF Statements
            if (pulseInsert1 == 1)
            {
                PulseRatePanelBed1.Dock = DockStyle.Fill;
                PulseRatePanelBed1.Visible = true;
                InsertASocket1.Visible = false;
                pulseInsert1 = 0;
            }
            else if (pulseInsert2 == 1)
            {
                PulseRatePanelBed2.Dock = DockStyle.Fill;
                PulseRatePanelBed2.Visible = true;
                InsertASocket2.Visible = false;
                pulseInsert2 = 0;
            }
            else if (pulseInsert3 == 1)
            {
                PulseRatePanelBed3.Dock = DockStyle.Fill;
                PulseRatePanelBed3.Visible = true;
                InsertASocket3.Visible = false;
                pulseInsert3 = 0;
            }
            else if (pulseInsert4 == 1)
            {
                PulseRatePanelBed4.Dock = DockStyle.Fill;
                PulseRatePanelBed4.Visible = true;
                InsertASocket4.Visible = false;
                pulseInsert4 = 0;
            }
            #endregion

            #region TempInsert IF Statements
            if (tempInsert1 == 1)
            {
                TemperaturePanelBed1.Dock = DockStyle.Fill;
                TemperaturePanelBed1.Visible = true;
                InsertASocket1.Visible = false;
                tempInsert1 = 0;
            }
            else if (tempInsert2 == 1)
            {
                TemperaturePanelBed2.Dock = DockStyle.Fill;
                TemperaturePanelBed2.Visible = true;
                InsertASocket2.Visible = false;
                tempInsert2 = 0;
            }
            else if (tempInsert3 == 1)
            {
                TemperaturePanelBed3.Dock = DockStyle.Fill;
                TemperaturePanelBed3.Visible = true;
                InsertASocket3.Visible = false;
                tempInsert3 = 0;
            }
            else if (tempInsert4 == 1)
            {
                TemperaturePanelBed4.Dock = DockStyle.Fill;
                TemperaturePanelBed4.Visible = true;
                InsertASocket4.Visible = false;
                tempInsert4 = 0;
            }
            #endregion

            #region TextBox Text Assignment

            #region BloodPressure 1 Panel
            DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin.ToString();
            DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax.ToString();

            SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin.ToString();
            SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax.ToString();
            #endregion

            #endregion

            #region ActivePanels Variable Assignment
            if (BloodPressurePanelBed1.Visible == true || BloodPressurePanelBed2.Visible == true ||
                BloodPressurePanelBed3.Visible == true || BloodPressurePanelBed4.Visible == true)
            {
                bloodActive = true;
            }
            if (PulseRatePanelBed1.Visible == true || PulseRatePanelBed2.Visible == true ||
                PulseRatePanelBed3.Visible == true || PulseRatePanelBed4.Visible == true)
            {
                pulseActive = true;
            }
            if (BreathingRatePanelBed1.Visible == true || BreathingRatePanelBed2.Visible == true ||
                BreathingRatePanelBed3.Visible == true || BreathingRatePanelBed4.Visible == true)
            {
                breathingActive = true;
            }
            if (TemperaturePanelBed1.Visible == true || TemperaturePanelBed2.Visible == true ||
                TemperaturePanelBed3.Visible == true || TemperaturePanelBed4.Visible == true)
            {
                tempActive = true;
            }
            #endregion

            #region Insert Assignment

            #region Blood Pressure
            if (BloodPressurePanelBed1.Dock == DockStyle.Fill)
            {
                bloodInsert1 = 1;
            }
            else { bloodInsert1 = 0; }
            if (BloodPressurePanelBed2.Dock == DockStyle.Fill)
            {
                bloodInsert2 = 1;
            }
            else { bloodInsert2 = 0; }
            if (BloodPressurePanelBed3.Dock == DockStyle.Fill)
            {
                bloodInsert3 = 1;
            }
            else { bloodInsert3 = 0; }
            if (BloodPressurePanelBed4.Dock == DockStyle.Fill)
            {
                bloodInsert4 = 1;
            }
            else { bloodInsert4 = 0; }
            #endregion

            #region Pulse Rate
            if (PulseRatePanelBed1.Dock == DockStyle.Fill)
            {
                pulseInsert1 = 1;
            }
            else { pulseInsert1 = 0; }
            if (PulseRatePanelBed2.Dock == DockStyle.Fill)
            {
                pulseInsert2 = 1;
            }
            else { pulseInsert2 = 0; }
            if (PulseRatePanelBed3.Dock == DockStyle.Fill)
            {
                pulseInsert3 = 1;
            }
            else { pulseInsert3 = 0; }
            if (PulseRatePanelBed4.Dock == DockStyle.Fill)
            {
                pulseInsert4 = 1;
            }
            else { pulseInsert4 = 0; }
            #endregion

            #region Breathing Rate
            if (BreathingRatePanelBed1.Dock == DockStyle.Fill)
            {
                breathingInsert1 = 1;
            }
            else { breathingInsert1 = 0; }
            if (BreathingRatePanelBed2.Dock == DockStyle.Fill)
            {
                breathingInsert2 = 1;
            }
            else { breathingInsert2 = 0; }
            if (BreathingRatePanelBed3.Dock == DockStyle.Fill)
            {
                breathingInsert3 = 1;
            }
            else { breathingInsert3 = 0; }
            if (BreathingRatePanelBed4.Dock == DockStyle.Fill)
            {
                breathingInsert4 = 1;
            }
            else { breathingInsert4 = 0; }
            #endregion

            #region Temperature
            if (TemperaturePanelBed1.Dock == DockStyle.Fill)
            {
                tempInsert1 = 1;
            }
            else { tempInsert1 = 0; }
            if (TemperaturePanelBed2.Dock == DockStyle.Fill)
            {
                tempInsert2 = 1;
            }
            else { tempInsert2 = 0; }
            if (TemperaturePanelBed3.Dock == DockStyle.Fill)
            {
                tempInsert3 = 1;
            }
            else { tempInsert3 = 0; }
            if (TemperaturePanelBed4.Dock == DockStyle.Fill)
            {
                tempInsert4 = 1;
            }
            else { tempInsert4 = 0; }
            #endregion

            #endregion

        }


        public void UpdateTextBox(object sender, EventArgs e)
        {
            DiBloodPressurePanelBed_Actual_Text.Text = SocketConfiguration.DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text2.Text = SocketConfiguration.DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text3.Text = SocketConfiguration.DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text4.Text = SocketConfiguration.DiastolicValueRandom();

            SyBloodPressurePanelBed_Actual_Text.Text = SocketConfiguration.SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text2.Text = SocketConfiguration.SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text3.Text = SocketConfiguration.SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text4.Text = SocketConfiguration.SystolicValueRandom();

            PulseRate_Actual_Text.Text = SocketConfiguration.PulseValueRandom();
            PulseRate_Actual_Text2.Text = SocketConfiguration.PulseValueRandom();
            PulseRate_Actual_Text3.Text = SocketConfiguration.PulseValueRandom();
            PulseRate_Actual_Text4.Text = SocketConfiguration.PulseValueRandom();
        }

        // Variables
        // How the module is, if it's active or not
        public static int moduleState1, moduleState2, moduleState3, moduleState4;
        // What Insert was Clicked
        public static int insertClicked1, insertClicked2, insertClicked3, insertClicked4;
        // what was inserted
        public static int bloodInsert1, bloodInsert2, bloodInsert3, bloodInsert4;
        public static int pulseInsert1, pulseInsert2, pulseInsert3, pulseInsert4;
        public static int breathingInsert1, breathingInsert2, breathingInsert3, breathingInsert4;
        public static int tempInsert1, tempInsert2, tempInsert3, tempInsert4;
        // if the panel is visible
        public static bool bloodActive = false, pulseActive = false, breathingActive = false, tempActive = false;

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
        private void Bed2_Click(object sender, EventArgs e)
        {
            BedSideView2 bedSideView2 = new BedSideView2();
            bedSideView2.Show();
            bedSideView2.Location = this.Location;
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
            if (moduleState1 == 0)
            {
                insertClicked1 = 1;
                SocketSelection soS = new SocketSelection();

                soS.BedLabel.Text = "Bed 1";
                soS.Show();
                soS.Location = this.Location;
                this.Hide();
            }
            else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
        }

        private void InsertButton2_Click(object sender, EventArgs e)
        {
            if (moduleState2 == 0)
            {
                insertClicked2 = 1;
                SocketSelection soS = new SocketSelection();

                soS.BedLabel.Text = "Bed 1";
                soS.Show();
                soS.Location = this.Location;
                this.Hide();
            }
            else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
        }

        private void InsertButton3_Click(object sender, EventArgs e)
        {
            if (moduleState3 == 0)
            {
                insertClicked3 = 1;
                SocketSelection soS = new SocketSelection();

                soS.BedLabel.Text = "Bed 1";
                soS.Show();
                soS.Location = this.Location;
                this.Hide();
            }
            else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
        }

        private void InsertButton4_Click(object sender, EventArgs e)
        {
            if (moduleState4 == 0)
            {
                insertClicked4 = 1;
                SocketSelection soS = new SocketSelection();

                soS.BedLabel.Text = "Bed 1";
                soS.Show();
                soS.Location = this.Location;
                this.Hide();
            }
            else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
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
