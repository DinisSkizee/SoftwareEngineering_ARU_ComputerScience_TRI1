using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BedSideView1 : Form
    {
        public static BedSideView1 bed1singleton;

        public BedSideView1()
        {
            bed1singleton = this;
            InitializeComponent();

            new BedSideViewConfiguration();
            BedSideViewConfiguration.timer.Tick += UpdateTextBox;

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
                InsertASocket3.Visible = false;
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

            #region TextBox Text Assignment (Min & Max)

            #region Blood Pressure
            SyBloodPressurePanelBed_Minimum_Text.Text = syMin.ToString();
            SyBloodPressurePanelBed_Minimum_Text2.Text = syMin.ToString();
            SyBloodPressurePanelBed_Minimum_Text3.Text = syMin.ToString();
            SyBloodPressurePanelBed_Minimum_Text4.Text = syMin.ToString();

            SyBloodPressurePanelBed_Maximum_Text.Text = syMax.ToString();
            SyBloodPressurePanelBed_Maximum_Text2.Text = syMax.ToString();
            SyBloodPressurePanelBed_Maximum_Text3.Text = syMax.ToString();
            SyBloodPressurePanelBed_Maximum_Text4.Text = syMax.ToString();

            DiBloodPressurePanelBed_Minimum_Text.Text = diMin.ToString();
            DiBloodPressurePanelBed_Minimum_Text2.Text = diMin.ToString();
            DiBloodPressurePanelBed_Minimum_Text3.Text = diMin.ToString();
            DiBloodPressurePanelBed_Minimum_Text4.Text = diMin.ToString();

            DiBloodPressurePanelBed_Maximum_Text.Text = diMax.ToString();
            DiBloodPressurePanelBed_Maximum_Text2.Text = diMax.ToString();
            DiBloodPressurePanelBed_Maximum_Text3.Text = diMax.ToString();
            DiBloodPressurePanelBed_Maximum_Text4.Text = diMax.ToString();

            #endregion

            #region Breathing Rate
            BreathingRate_Minimum_Text.Text = brMin.ToString();
            BreathingRate_Minimum_Text2.Text = brMin.ToString();
            BreathingRate_Minimum_Text3.Text = brMin.ToString();
            BreathingRate_Minimum_Text4.Text = brMin.ToString();

            BreathingRate_Maximum_Text.Text = brMax.ToString();
            BreathingRate_Maximum_Text2.Text = brMax.ToString();
            BreathingRate_Maximum_Text3.Text = brMax.ToString();
            BreathingRate_Maximum_Text4.Text = brMax.ToString();
            #endregion

            #region Pulse Rate
            PulseRate_Minimum_Text.Text = prMin.ToString();
            PulseRate_Minimum_Text2.Text = prMin.ToString();
            PulseRate_Minimum_Text3.Text = prMin.ToString();
            PulseRate_Minimum_Text4.Text = prMin.ToString();

            PulseRate_Maximum_Text.Text = prMax.ToString();
            PulseRate_Maximum_Text2.Text = prMax.ToString();
            PulseRate_Maximum_Text3.Text = prMax.ToString();
            PulseRate_Maximum_Text4.Text = prMax.ToString();
            #endregion

            #region Temperature
            Temperature_Minimum_Text.Text = tpMin.ToString();
            Temperature_Minimum_Text2.Text = tpMin.ToString();
            Temperature_Minimum_Text3.Text = tpMin.ToString();
            Temperature_Minimum_Text4.Text = tpMin.ToString();

            Temperature_Maximum_Text.Text = tpMax.ToString();
            Temperature_Maximum_Text2.Text = tpMax.ToString();
            Temperature_Maximum_Text3.Text = tpMax.ToString();
            Temperature_Maximum_Text4.Text = tpMax.ToString();
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
            if (BloodPressurePanelBed2.Dock == DockStyle.Fill)
            {
                bloodInsert2 = 1;
            }
            if (BloodPressurePanelBed3.Dock == DockStyle.Fill)
            {
                bloodInsert3 = 1;
            }
            if (BloodPressurePanelBed4.Dock == DockStyle.Fill)
            {
                bloodInsert4 = 1;
            }
            #endregion

            #region Pulse Rate
            if (PulseRatePanelBed1.Dock == DockStyle.Fill)
            {
                pulseInsert1 = 1;
            }
            if (PulseRatePanelBed2.Dock == DockStyle.Fill)
            {
                pulseInsert2 = 1;
            }
            if (PulseRatePanelBed3.Dock == DockStyle.Fill)
            {
                pulseInsert3 = 1;
            }
            if (PulseRatePanelBed4.Dock == DockStyle.Fill)
            {
                pulseInsert4 = 1;
            }
            #endregion

            #region Breathing Rate
            if (BreathingRatePanelBed1.Dock == DockStyle.Fill)
            {
                breathingInsert1 = 1;
            }
            if (BreathingRatePanelBed2.Dock == DockStyle.Fill)
            {
                breathingInsert2 = 1;
            }
            if (BreathingRatePanelBed3.Dock == DockStyle.Fill)
            {
                breathingInsert3 = 1;
            }
            if (BreathingRatePanelBed4.Dock == DockStyle.Fill)
            {
                breathingInsert4 = 1;
            }
            #endregion

            #region Temperature
            if (TemperaturePanelBed1.Dock == DockStyle.Fill)
            {
                tempInsert1 = 1;
            }
            if (TemperaturePanelBed2.Dock == DockStyle.Fill)
            {
                tempInsert2 = 1;
            }
            if (TemperaturePanelBed3.Dock == DockStyle.Fill)
            {
                tempInsert3 = 1;
            }
            if (TemperaturePanelBed4.Dock == DockStyle.Fill)
            {
                tempInsert4 = 1;
            }
            #endregion

            #endregion

            // Parameters Verification
            SocketConfiguration.dMi = SocketConfiguration.IsNumeric(Convert.ToString(diMin));
            SocketConfiguration.dMa = SocketConfiguration.IsNumeric(Convert.ToString(diMax));
            SocketConfiguration.sMi = SocketConfiguration.IsNumeric(Convert.ToString(syMin));
            SocketConfiguration.sMa = SocketConfiguration.IsNumeric(Convert.ToString(syMax));

            SocketConfiguration.pMi = SocketConfiguration.IsNumeric(Convert.ToString(prMin));
            SocketConfiguration.pMa = SocketConfiguration.IsNumeric(Convert.ToString(prMax));

            SocketConfiguration.bMi = SocketConfiguration.IsNumeric(Convert.ToString(brMin));
            SocketConfiguration.bMa = SocketConfiguration.IsNumeric(Convert.ToString(brMax));
            SocketConfiguration.tMi = SocketConfiguration.IsNumeric(Convert.ToString(tpMin));
            SocketConfiguration.tMa = SocketConfiguration.IsNumeric(Convert.ToString(tpMax));
        }

        public void UpdateTextBox(object sender, EventArgs e)
        {
            DiBloodPressurePanelBed_Actual_Text.Text = DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text2.Text = DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text3.Text = DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text4.Text = DiastolicValueRandom();

            SyBloodPressurePanelBed_Actual_Text.Text = SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text2.Text = SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text3.Text = SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text4.Text = SystolicValueRandom();

            PulseRate_Actual_Text.Text = PulseValueRandom();
            PulseRate_Actual_Text2.Text = PulseValueRandom();
            PulseRate_Actual_Text3.Text = PulseValueRandom();
            PulseRate_Actual_Text4.Text = PulseValueRandom();

            BreathingRate_Actual_Text.Text = BreathingValueRandom();
            BreathingRate_Actual_Text2.Text = BreathingValueRandom();
            BreathingRate_Actual_Text3.Text = BreathingValueRandom();
            BreathingRate_Actual_Text4.Text = BreathingValueRandom();

            Temperature_Actual_Text.Text = TemperatureValueRandom();
            Temperature_Actual_Text2.Text = TemperatureValueRandom();
            Temperature_Actual_Text3.Text = TemperatureValueRandom();
            Temperature_Actual_Text4.Text = TemperatureValueRandom();
        }

        // Variables
        #region Variables
        // How the module is, if it's active or not
        public static int moduleState1, moduleState2, moduleState3, moduleState4;

        // What Insert was Clicked
        public static int insertClicked1, insertClicked2, insertClicked3, insertClicked4;

        // What was inserted
        public static int bloodInsert1, bloodInsert2, bloodInsert3, bloodInsert4;
        public static int pulseInsert1, pulseInsert2, pulseInsert3, pulseInsert4;
        public static int breathingInsert1, breathingInsert2, breathingInsert3, breathingInsert4;
        public static int tempInsert1, tempInsert2, tempInsert3, tempInsert4;
        // If the panel is visible
        public static bool bloodActive = false, pulseActive = false, breathingActive = false, tempActive = false;

        // TextBox Values
        public static int syValue, diValue, prValue, brValue;
        public static double tempValue;
        public static int diMin, diMax, syMin, syMax, prMin, prMax, brMin, brMax, tpMin, tpMax;
        #endregion

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

            bloodInsert1 = 0;
            pulseInsert1 = 0;
            breathingInsert1 = 0;
            tempInsert1 = 0;

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

            bloodInsert2 = 0;
            pulseInsert2 = 0;
            breathingInsert2 = 0;
            tempInsert2 = 0;

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

            bloodInsert3 = 0;
            pulseInsert3 = 0;
            breathingInsert3 = 0;
            tempInsert3 = 0;

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

            bloodInsert4 = 0;
            pulseInsert4 = 0;
            breathingInsert4 = 0;
            tempInsert4 = 0;

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

        // Variables for the Randomizers below
        public static int randomizerSy, randomizerDi, randomizerPR, randomizerBR, randomizerTemp;

        public static string SystolicValueRandom() // Returns syValue
        {
            randomizerSy = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerSy <= 5)
            {
                syValue = SocketConfiguration.randomizer.Next(syMin - 20, syMin - 1);
            }
            else if ((randomizerSy > 5) && (randomizerSy < 95))
            {
                syValue = SocketConfiguration.randomizer.Next(syMin, syMax);
            }
            else if (randomizerSy >= 95)
            {
                syValue = SocketConfiguration.randomizer.Next(syMax + 1, syMax + 20);
            }

            return syValue.ToString();
        }

        public static string DiastolicValueRandom() // Returns diValue
        {
            randomizerDi = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerDi <= 5)
            {
                diValue = SocketConfiguration.randomizer.Next(diMin - 20, diMin - 1);
            }
            else if ((randomizerDi > 5) && (randomizerDi < 95))
            {
                diValue = SocketConfiguration.randomizer.Next(diMin, diMax);
            }
            else if (randomizerDi >= 95)
            {
                diValue = SocketConfiguration.randomizer.Next(diMin + 1, diMax + 20);
            }

            return diValue.ToString();
        }

        public static string PulseValueRandom()
        {
            randomizerPR = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerPR <= 5)
            {
                prValue = SocketConfiguration.randomizer.Next(prMin - 20, prMin - 1);
            }
            else if ((randomizerPR > 5) && (randomizerPR < 95))
            {
                prValue = SocketConfiguration.randomizer.Next(prMin, prMax);
            }
            else if (randomizerPR >= 95)
            {
                prValue = SocketConfiguration.randomizer.Next(prMax + 1, prMax + 20);
            }

            return prValue.ToString();
        } // Returns prValue

        public static string BreathingValueRandom()
        {
            randomizerBR = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerBR <= 5)
            {
                brValue = SocketConfiguration.randomizer.Next(brMin - 5, brMin - 1);
            }
            else if ((randomizerBR > 5) && (randomizerBR < 95))
            {
                brValue = SocketConfiguration.randomizer.Next(brMin, brMax);
            }
            else if (randomizerBR >= 95)
            {
                brValue = SocketConfiguration.randomizer.Next(brMax + 1, brMax + 50);
            }

            return brValue.ToString();
        } // Returns brValue

        public static string TemperatureValueRandom()
        {
            randomizerTemp = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerTemp <= 25)
            {
                tempValue = SocketConfiguration.randomizer.Next(tpMin - 25, tpMin - 1);
                tempValue /= 10;
            }
            else if ((randomizerTemp > 25) && (randomizerTemp < 75))
            {
                tempValue = SocketConfiguration.randomizer.Next(tpMin, tpMax);
                tempValue /= 10;
            }
            else if (randomizerTemp >= 75)
            {
                tempValue = SocketConfiguration.randomizer.Next(tpMax + 1, tpMax + 45);
                tempValue /= 10;
            }

            return tempValue.ToString();
        } // Returns tempValue

    }
}
