using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SocketSelection : Form
    {
        public SocketSelection()
        {
            InitializeComponent();

            HideAllSokets();

            AddNamesToSoketComboBox();

            SocketConfiguration.dockActive = DefaultPanel_SocketComboBox.SelectedIndex;
        }

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
        private void CloseButtonSocketSelection_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButtonSocketSelection_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region InsertReturnEffect  -- Dinis & Jorge

        #region TextBox Change effects BLOODPRESSURE  -- Dinis & Jorge

        /* On Mouse Down and the text is "Insert Minimum" it will clear the textbox
        / When is not being Selected/Focused and there's no input it would return to the normal "Insert Minimum"
           If there's any input it would stay in the textbox */

        // Diastolic Minimum TextBox \\
        private void BloodPressureTextBox_DiastolicMinimum_ParameterValue_MouseDown(object sender, MouseEventArgs e)
        {
            if (BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text == "Insert Minimum")
            {
                BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text = "";
            }
        }
        private void BloodPressureTextBox_DiastolicMinimum_ParameterValue_Leave(object sender, EventArgs e)
        {
            if (BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text == "")
            {
                BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text = "Insert Minimum";
            }
        }

        // Diastolic Maximum TextBox \\
        private void BloodPressureTextBox_DiastolicMaximum_ParameterValue_MouseDown(object sender, MouseEventArgs e)
        {
            if (BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text == "Insert Maximum")
            {
                BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text = "";
            }
        }
        private void BloodPressureTextBox_DiastolicMaximum_ParameterValue_Leave(object sender, EventArgs e)
        {
            if (BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text == "")
            {
                BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text = "Insert Maximum";
            }
        }

        // Systolic Minimum TextBox \\
        private void BloodPressureTextBox_SystolicMinimum_ParameterValue_MouseDown(object sender, MouseEventArgs e)
        {
            if (BloodPressureTextBox_SystolicMinimum_ParameterValue.Text == "Insert Minimum")
            {
                BloodPressureTextBox_SystolicMinimum_ParameterValue.Text = "";
            }
        }
        private void BloodPressureTextBox_SystolicMinimum_ParameterValue_Leave(object sender, EventArgs e)
        {
            if (BloodPressureTextBox_SystolicMinimum_ParameterValue.Text == "")
            {
                BloodPressureTextBox_SystolicMinimum_ParameterValue.Text = "Insert Minimum";
            }
        }

        // Systolic Maximum TextBox \\
        private void BloodPressureTextBox_SystolicMaximum_ParameterValue_MouseDown(object sender, MouseEventArgs e)
        {
            if (BloodPressureTextBox_SystolicMaximum_ParameterValue.Text == "Insert Maximum")
            {
                BloodPressureTextBox_SystolicMaximum_ParameterValue.Text = "";
            }
        }
        private void BloodPressureTextBox_SystolicMaximum_ParameterValue_Leave(object sender, EventArgs e)
        {
            if (BloodPressureTextBox_SystolicMaximum_ParameterValue.Text == "")
            {
                BloodPressureTextBox_SystolicMaximum_ParameterValue.Text = "Insert Maximum";
            }
        }
        #endregion

        #region TextBox Change effects PULSERATE  -- Dinis & Jorge

        // Pulse Rate Minimum TextBox \\
        private void PulseRate_Minimum_TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (PulseRate_Minimum_TextBox.Text == "Insert Minimum")
            {
                PulseRate_Minimum_TextBox.Text = "";
            }
        }
        private void PulseRate_Minimum_TextBox_Leave(object sender, EventArgs e)
        {
            if (PulseRate_Minimum_TextBox.Text == "")
            {
                PulseRate_Minimum_TextBox.Text = "Insert Minimum";
            }
        }

        // Pulse Rate Maximum TextBox \\
        private void PulseRate_Maximum_TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (PulseRate_Maximum_TextBox.Text == "Insert Maximum")
            {
                PulseRate_Maximum_TextBox.Text = "";
            }
        }
        private void PulseRate_Maximum_TextBox_Leave(object sender, EventArgs e)
        {
            if (PulseRate_Maximum_TextBox.Text == "")
            {
                PulseRate_Maximum_TextBox.Text = "Insert Maximum";
            }
        }
        #endregion

        #region TextBox Change effects BREATHINGRATE  -- Dinis & Jorge

        // Breathing Rate Minimum TextBox \\
        private void BreathingRate_Minimum_TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (BreathingRate_Minimum_TextBox.Text == "Insert Minimum")
            {
                BreathingRate_Minimum_TextBox.Text = "";
            }
        }
        private void BreathingRate_Minimum_TextBox_Leave(object sender, EventArgs e)
        {
            if (BreathingRate_Minimum_TextBox.Text == "")
            {
                BreathingRate_Minimum_TextBox.Text = "Insert Minimum";
            }
        }

        // Breathing Rate Maximum TextBox \\
        private void BreathingRate_Maximum_TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (BreathingRate_Maximum_TextBox.Text == "Insert Maximum")
            {
                BreathingRate_Maximum_TextBox.Text = "";
            }
        }
        private void BreathingRate_Maximum_TextBox_Leave(object sender, EventArgs e)
        {
            if (BreathingRate_Maximum_TextBox.Text == "")
            {
                BreathingRate_Maximum_TextBox.Text = "Insert Maximum";
            }
        }
        #endregion

        #region TextBox Change effects TEMPERATURE  -- Dinis & Jorge

        // Temperature Minimum TextBox \\
        private void Temperature_Minimum_TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Temperature_Minimum_TextBox.Text == "Insert Minimum")
            {
                Temperature_Minimum_TextBox.Text = "";
            }
        }
        private void Temperature_Minimum_TextBox_Leave(object sender, EventArgs e)
        {
            if (Temperature_Minimum_TextBox.Text == "")
            {
                Temperature_Minimum_TextBox.Text = "Insert Minimum";
            }
        }

        // Temperature Maximum TextBox \\
        private void Temperature_Maximum_TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Temperature_Maximum_TextBox.Text == "Insert Maximum")
            {
                Temperature_Maximum_TextBox.Text = "";
            }
        }
        private void Temperature_Maximum_TextBox_Leave(object sender, EventArgs e)
        {
            if (Temperature_Maximum_TextBox.Text == "")
            {
                Temperature_Maximum_TextBox.Text = "Insert Maximum";
            }
        }
        #endregion

        #endregion

        #region Main Button Return  -- Dinis & Jorge

        // Small Icon on the Left Top corner to go back to the AfterLogin form
        private void MainPageButton_Click(object sender, EventArgs e)   // -- Dinis & Jorge
        {
            BedSideView1 bedSideView1 = new BedSideView1();
            bedSideView1.Show();
            bedSideView1.Location = this.Location;
            this.Hide();
        }
        #endregion

        #region Change Main Panel  -- Dinis & Jorge

        /* When we choose another option on the SocketComboBox
        * the panels would be picked and turned visible and the Label invisible
        * If none is picked everything would be invisible
        * and the Label would be visible aswell */
        private void Default_SocketComboBox_TextChanged(object sender, EventArgs e)  // -- Dinis & Jorge
        {

            if (DefaultPanel_SocketComboBox.SelectedIndex < 0)
            {

                DefaultPanel_SelectSocketLabel.Visible = true;
                BloodPressurePanel.Dock = DockStyle.None;
                PulseRatePanel.Dock = DockStyle.None;
                BreathingRatePanel.Dock = DockStyle.None;
                TemperaturePanel.Dock = DockStyle.None;

            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 0)
            {
                BloodPressurePanel.Dock = DockStyle.Fill;
                PulseRatePanel.Dock = DockStyle.Fill;
                BreathingRatePanel.Dock = DockStyle.Fill;
                TemperaturePanel.Dock = DockStyle.Fill;

                BloodPressurePanel.Visible = true;
                PulseRatePanel.Visible = false;
                BreathingRatePanel.Visible = false;
                TemperaturePanel.Visible = false;
                DefaultPanel_SelectSocketLabel.Visible = false;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 1)
            {
                BloodPressurePanel.Dock = DockStyle.Fill;
                PulseRatePanel.Dock = DockStyle.Fill;
                BreathingRatePanel.Dock = DockStyle.Fill;
                TemperaturePanel.Dock = DockStyle.Fill;

                BloodPressurePanel.Visible = false;
                PulseRatePanel.Visible = true;
                BreathingRatePanel.Visible = false;
                TemperaturePanel.Visible = false;
                DefaultPanel_SelectSocketLabel.Visible = false;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 2)
            {
                BloodPressurePanel.Dock = DockStyle.Fill;
                PulseRatePanel.Dock = DockStyle.Fill;
                BreathingRatePanel.Dock = DockStyle.Fill;
                TemperaturePanel.Dock = DockStyle.Fill;

                BloodPressurePanel.Visible = false;
                PulseRatePanel.Visible = false;
                BreathingRatePanel.Visible = true;
                TemperaturePanel.Visible = false;
                DefaultPanel_SelectSocketLabel.Visible = false;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 3)
            {
                BloodPressurePanel.Dock = DockStyle.Fill;
                PulseRatePanel.Dock = DockStyle.Fill;
                BreathingRatePanel.Dock = DockStyle.Fill;
                TemperaturePanel.Dock = DockStyle.Fill;

                BloodPressurePanel.Visible = false;
                PulseRatePanel.Visible = false;
                BreathingRatePanel.Visible = false;
                TemperaturePanel.Visible = true;
                DefaultPanel_SelectSocketLabel.Visible = false;
            }

        }

        #endregion


        private void HideAllSokets()
        {
            BreathingRatePanel.Visible = false;
            PulseRatePanel.Visible = false;
            BloodPressurePanel.Visible = false;
            TemperaturePanel.Visible = false;
        }

        public void AddNamesToSoketComboBox()
        {
            DefaultPanel_SocketComboBox.Items.Add("Blood Pressure");
            DefaultPanel_SocketComboBox.Items.Add("Pulse Rate");
            DefaultPanel_SocketComboBox.Items.Add("Breathing Rate");
            DefaultPanel_SocketComboBox.Items.Add("Temperature");
        }

        // Install Button Configuration
        public void DefaultPanel_InstallButton_Click(object sender, EventArgs e)
        {

            // Blood Pressure Secondary Variables Integer
            int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMinC);
            int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMaxC);
            int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMinC);
            int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMaxC);
            // Pulse Rate Secondary Variables Integer
            int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMinC);
            int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMaxC);
            // Breathing Rate Secondary Variables Integer
            int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMinC);
            int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMaxC);
            // Temperature Secondary Variables Integer
            int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMinC);
            int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMaxC);

            SocketConfiguration socket = new SocketConfiguration();

            if (DefaultPanel_SocketComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please, select a Module to proceed.");
            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 0 && SocketConfiguration.diDiff >= 30 && SocketConfiguration.syDiff >= 20)  // Blood Pressure
            {
                
                if (BedLabel.Text == "Bed 1" && BedSideView1.bloodActive == false)
                {
                    if (BedSideView1.insertClicked1 == 1)
                    {
                        BedSideView1.moduleState1 = 1;
                        BedSideView1.bloodInsert1 = 1;
                        BedSideView1.insertClicked1 = 0;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.moduleState2 = 1;
                        BedSideView1.bloodInsert2 = 1;
                        BedSideView1.insertClicked2 = 0;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.moduleState3 = 1;
                        BedSideView1.bloodInsert3 = 1;
                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.moduleState4 = 1;
                        BedSideView1.bloodInsert4 = 1;
                        BedSideView1.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out BedSideView1.diMin);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out BedSideView1.diMax);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out BedSideView1.syMin);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out BedSideView1.syMax);

                    BedSideView1 bed1 = new BedSideView1();
                    bed1.Show();
                    bed1.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 1" && BedSideView1.bloodActive == true)
                {
                    MessageBox.Show("You already have a Blood Pressure Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 2" && BedSideView2.bloodActive == false)
                {
                    if (BedSideView2.insertClicked1 == 1 && BedSideView2.bloodActive == false)
                    {
                        BedSideView2.bloodInsert1 = 1;
                        BedSideView2.moduleState1 = 1;
                        BedSideView2.insertClicked1 = 0;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.bloodInsert2 = 1;
                        BedSideView2.moduleState2 = 1;
                        BedSideView2.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView2.bloodInsert3 = 1;
                        BedSideView2.moduleState3 = 1;
                        BedSideView2.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView2.bloodInsert4 = 1;
                        BedSideView2.moduleState4 = 1;
                        BedSideView2.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out BedSideView2.diMin);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out BedSideView2.diMax);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out BedSideView2.syMin);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out BedSideView2.syMax);

                    BedSideView2 bed2 = new BedSideView2();
                    bed2.Show();
                    bed2.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 2" && BedSideView2.bloodActive == true)
                {
                    MessageBox.Show("You already have a Blood Pressure Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 3" && BedSideView3.bloodActive == false)
                {
                    if (BedSideView3.insertClicked1 == 1)
                    {
                        BedSideView3.bloodInsert1 = 1;
                        BedSideView3.moduleState1 = 1;
                        BedSideView3.insertClicked1 = 0;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.bloodInsert2 = 1;
                        BedSideView3.moduleState2 = 1;
                        BedSideView3.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.bloodInsert3 = 1;
                        BedSideView3.moduleState3 = 1;
                        BedSideView3.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.bloodInsert4 = 1;
                        BedSideView3.moduleState4 = 1;
                        BedSideView3.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out BedSideView3.diMin);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out BedSideView3.diMax);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out BedSideView3.syMin);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out BedSideView3.syMax);

                    BedSideView3 bed3 = new BedSideView3();
                    bed3.Show();
                    bed3.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 3" && BedSideView3.bloodActive == true)
                {
                    MessageBox.Show("You already have a Blood Pressure Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 4" && BedSideView4.bloodActive == false)
                {
                    if (BedSideView4.insertClicked1 == 1)
                    {
                        BedSideView4.bloodInsert1 = 1;
                        BedSideView4.moduleState1 = 1;
                        BedSideView4.insertClicked1 = 0;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.bloodInsert2 = 1;
                        BedSideView4.moduleState2 = 1;
                        BedSideView4.insertClicked2 = 0;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.bloodInsert3 = 1;
                        BedSideView4.moduleState3 = 1;
                        BedSideView4.insertClicked3 = 0;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.bloodInsert4 = 1;
                        BedSideView4.moduleState4 = 1;
                        BedSideView4.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out BedSideView4.diMin);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out BedSideView4.diMax);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out BedSideView4.syMin);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out BedSideView4.syMax);

                    BedSideView4 bed4 = new BedSideView4();
                    bed4.Show();
                    bed4.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 4" && BedSideView4.bloodActive == true)
                {
                    MessageBox.Show("You already have a Blood Pressure Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 5" && BedSideView5.bloodActive == false)
                {
                    if (BedSideView5.insertClicked1 == 1)
                    {
                        BedSideView5.bloodInsert1 = 1;
                        BedSideView5.moduleState1 = 1;
                        BedSideView5.insertClicked1 = 0;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.bloodInsert2 = 1;
                        BedSideView5.moduleState2 = 1;
                        BedSideView5.insertClicked2 = 0;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.bloodInsert3 = 1;
                        BedSideView5.moduleState3 = 1;
                        BedSideView5.insertClicked3 = 0;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.bloodInsert4 = 1;
                        BedSideView5.moduleState4 = 1;
                        BedSideView5.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out BedSideView5.diMin);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out BedSideView5.diMax);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out BedSideView5.syMin);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out BedSideView5.syMax);

                    BedSideView5 bed5 = new BedSideView5();
                    bed5.Show();
                    bed5.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 5" && BedSideView5.bloodActive == true)
                {
                    MessageBox.Show("You already have a Blood Pressure Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 6" && BedSideView6.bloodActive == false)
                {
                    if (BedSideView6.insertClicked1 == 1)
                    {
                        BedSideView6.bloodInsert1 = 1;
                        BedSideView6.moduleState1 = 1;
                        BedSideView6.insertClicked1 = 0;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.bloodInsert2 = 1;
                        BedSideView6.moduleState2 = 1;
                        BedSideView6.insertClicked2 = 0;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.bloodInsert3 = 1;
                        BedSideView6.moduleState3 = 1;
                        BedSideView6.insertClicked3 = 0;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.bloodInsert4 = 1;
                        BedSideView6.moduleState4 = 1;
                        BedSideView6.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out BedSideView6.diMin);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out BedSideView6.diMax);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out BedSideView6.syMin);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out BedSideView6.syMax);

                    BedSideView6 bed6 = new BedSideView6();
                    bed6.Show();
                    bed6.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 6" && BedSideView6.bloodActive == true)
                {
                    MessageBox.Show("You already have a Blood Pressure Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 7" && BedSideView7.bloodActive == false)
                {
                    if (BedSideView7.insertClicked1 == 1)
                    {
                        BedSideView7.bloodInsert1 = 1;
                        BedSideView7.moduleState1 = 1;
                        BedSideView7.insertClicked1 = 0;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.bloodInsert2 = 1;
                        BedSideView7.moduleState2 = 1;
                        BedSideView7.insertClicked2 = 0;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.bloodInsert3 = 1;
                        BedSideView7.moduleState3 = 1;
                        BedSideView7.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.bloodInsert4 = 1;
                        BedSideView7.moduleState4 = 1;
                        BedSideView7.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out BedSideView7.diMin);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out BedSideView7.diMax);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out BedSideView7.syMin);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out BedSideView7.syMax);

                    BedSideView7 bed7 = new BedSideView7();
                    bed7.Show();
                    bed7.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 7" && BedSideView7.bloodActive == true)
                {
                    MessageBox.Show("You already have a Blood Pressure Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 8" && BedSideView8.bloodActive == false)
                {
                    if (BedSideView8.insertClicked1 == 1)
                    {
                        BedSideView8.bloodInsert1 = 1;
                        BedSideView8.moduleState1 = 1;
                        BedSideView8.insertClicked1 = 0;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.bloodInsert2 = 1;
                        BedSideView8.moduleState2 = 1;
                        BedSideView8.insertClicked2 = 0;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.bloodInsert3 = 1;
                        BedSideView8.moduleState3 = 1;
                        BedSideView8.insertClicked3 = 0;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.bloodInsert4 = 1;
                        BedSideView8.moduleState4 = 1;
                        BedSideView8.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out BedSideView8.diMin);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out BedSideView8.diMax);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out BedSideView8.syMin);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out BedSideView8.syMax);

                    BedSideView8 bed8 = new BedSideView8();
                    bed8.Show();
                    bed8.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 8" && BedSideView8.bloodActive == true)
                {
                    MessageBox.Show("You already have a Blood Pressure Module Active, Eject it first!");
                }
            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 1 && SocketConfiguration.prDiff >= 30)  // Pulse Rate
            {
                if (BedLabel.Text == "Bed 1" && BedSideView1.pulseActive == false)
                {
                    if (BedSideView1.insertClicked1 == 1)
                    {
                        BedSideView1.pulseInsert1 = 1;
                        BedSideView1.moduleState1 = 1;
                        BedSideView1.insertClicked1 = 0;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.pulseInsert2 = 1;
                        BedSideView1.moduleState2 = 1;
                        BedSideView1.insertClicked2 = 0;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.pulseInsert3 = 1;
                        BedSideView1.moduleState3 = 1;
                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.pulseInsert4 = 1;
                        BedSideView1.moduleState4 = 1;
                        BedSideView1.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out BedSideView1.prMin);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out BedSideView1.prMax);

                    BedSideView1 bed1 = new BedSideView1();
                    bed1.Show();
                    bed1.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 1" && BedSideView1.pulseActive == true)
                {
                    MessageBox.Show("You already have a Pulse Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 2" && BedSideView2.pulseActive == false)
                {
                    if (BedSideView2.insertClicked1 == 1)
                    {
                        BedSideView2.pulseInsert1 = 1;
                        BedSideView2.moduleState1 = 1;
                        BedSideView2.insertClicked1 = 0;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.pulseInsert2 = 1;
                        BedSideView2.moduleState2 = 1;
                        BedSideView2.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView2.pulseInsert3 = 1;
                        BedSideView2.moduleState3 = 1;
                        BedSideView2.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView2.pulseInsert4 = 1;
                        BedSideView2.moduleState4 = 1;
                        BedSideView2.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out BedSideView2.prMin);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out BedSideView2.prMax);

                    BedSideView2 bed2 = new BedSideView2();
                    bed2.Show();
                    bed2.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 2" && BedSideView2.pulseActive == true)
                {
                    MessageBox.Show("You already have a Pulse Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 3" && BedSideView3.pulseActive == false)
                {
                    if (BedSideView3.insertClicked1 == 1)
                    {
                        BedSideView3.pulseInsert1 = 1;
                        BedSideView3.moduleState1 = 1;
                        BedSideView3.insertClicked1 = 0;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.pulseInsert2 = 1;
                        BedSideView3.moduleState2 = 1;
                        BedSideView3.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.pulseInsert3 = 1;
                        BedSideView3.moduleState3 = 1;
                        BedSideView3.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.pulseInsert4 = 1;
                        BedSideView3.moduleState4 = 1;
                        BedSideView3.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out BedSideView3.prMin);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out BedSideView3.prMax);

                    BedSideView3 bed3 = new BedSideView3();
                    bed3.Show();
                    bed3.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 3" && BedSideView3.pulseActive == true)
                {
                    MessageBox.Show("You already have a Pulse Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 4" && BedSideView4.pulseActive == false)
                {
                    if (BedSideView4.insertClicked1 == 1)
                    {
                        BedSideView4.pulseInsert1 = 1;
                        BedSideView4.moduleState1 = 1;
                        BedSideView4.insertClicked1 = 0;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.pulseInsert2 = 1;
                        BedSideView4.moduleState2 = 1;
                        BedSideView4.insertClicked2 = 0;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.pulseInsert3 = 1;
                        BedSideView4.moduleState3 = 1;
                        BedSideView4.insertClicked3 = 0;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.pulseInsert4 = 1;
                        BedSideView4.moduleState4 = 1;
                        BedSideView4.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out BedSideView4.prMin);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out BedSideView4.prMax);

                    BedSideView4 bed4 = new BedSideView4();
                    bed4.Show();
                    bed4.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 4" && BedSideView4.pulseActive == true)
                {
                    MessageBox.Show("You already have a Pulse Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 5" && BedSideView5.pulseActive == false)
                {
                    if (BedSideView5.insertClicked1 == 1)
                    {
                        BedSideView5.pulseInsert1 = 1;
                        BedSideView5.moduleState1 = 1;
                        BedSideView5.insertClicked1 = 0;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.pulseInsert2 = 1;
                        BedSideView5.moduleState2 = 1;
                        BedSideView5.insertClicked2 = 0;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.pulseInsert3 = 1;
                        BedSideView5.moduleState3 = 1;
                        BedSideView5.insertClicked3 = 0;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.pulseInsert4 = 1;
                        BedSideView5.moduleState4 = 1;
                        BedSideView5.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out BedSideView5.prMin);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out BedSideView5.prMax);

                    BedSideView5 bed5 = new BedSideView5();
                    bed5.Show();
                    bed5.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 5" && BedSideView5.pulseActive == true)
                {
                    MessageBox.Show("You already have a Pulse Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 6" && BedSideView6.pulseActive == false)
                {
                    if (BedSideView6.insertClicked1 == 1)
                    {
                        BedSideView6.pulseInsert1 = 1;
                        BedSideView6.moduleState1 = 1;
                        BedSideView6.insertClicked1 = 0;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.pulseInsert2 = 1;
                        BedSideView6.moduleState2 = 1;
                        BedSideView6.insertClicked2 = 0;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.pulseInsert3 = 1;
                        BedSideView6.moduleState3 = 1;
                        BedSideView6.insertClicked3 = 0;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.pulseInsert4 = 1;
                        BedSideView6.moduleState4 = 1;
                        BedSideView6.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out BedSideView6.prMin);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out BedSideView6.prMax);

                    BedSideView6 bed6 = new BedSideView6();
                    bed6.Show();
                    bed6.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 6" && BedSideView6.pulseActive == true)
                {
                    MessageBox.Show("You already have a Pulse Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 7" && BedSideView7.pulseActive == false)
                {
                    if (BedSideView7.insertClicked1 == 1)
                    {
                        BedSideView7.pulseInsert1 = 1;
                        BedSideView7.moduleState1 = 1;
                        BedSideView7.insertClicked1 = 0;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.pulseInsert2 = 1;
                        BedSideView7.moduleState2 = 1;
                        BedSideView7.insertClicked2 = 0;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.pulseInsert3 = 1;
                        BedSideView7.moduleState3 = 1;
                        BedSideView7.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.pulseInsert4 = 1;
                        BedSideView7.moduleState4 = 1;
                        BedSideView7.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out BedSideView7.prMin);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out BedSideView7.prMax);

                    BedSideView7 bed7 = new BedSideView7();
                    bed7.Show();
                    bed7.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 7" && BedSideView8.pulseActive == true)
                {
                    MessageBox.Show("You already have a Pulse Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 8" && BedSideView8.pulseActive == false)
                {
                    if (BedSideView8.insertClicked1 == 1)
                    {
                        BedSideView8.pulseInsert1 = 1;
                        BedSideView8.moduleState1 = 1;
                        BedSideView8.insertClicked1 = 0;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.pulseInsert2 = 1;
                        BedSideView8.moduleState2 = 1;
                        BedSideView8.insertClicked2 = 0;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.pulseInsert3 = 1;
                        BedSideView8.moduleState3 = 1;
                        BedSideView8.insertClicked3 = 0;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.pulseInsert4 = 1;
                        BedSideView8.moduleState4 = 1;
                        BedSideView8.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out BedSideView8.prMin);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out BedSideView8.prMax);

                    BedSideView8 bed8 = new BedSideView8();
                    bed8.Show();
                    bed8.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 8" && BedSideView8.pulseActive == true)
                {
                    MessageBox.Show("You already have a Pulse Rate Module Active, Eject it first!");
                }
            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 2 && SocketConfiguration.brDiff >= 5)  // Breathing Rate
            {
                if (BedLabel.Text == "Bed 1" && BedSideView1.breathingActive == false)
                {
                    if (BedSideView1.insertClicked1 == 1)
                    {
                        BedSideView1.breathingInsert1 = 1;
                        BedSideView1.moduleState1 = 1;
                        BedSideView1.insertClicked1 = 0;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.breathingInsert2 = 1;
                        BedSideView1.moduleState2 = 1;
                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.breathingInsert3 = 1;
                        BedSideView1.moduleState3 = 1;
                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.breathingInsert4 = 1;
                        BedSideView1.moduleState4 = 1;
                        BedSideView1.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out BedSideView1.brMin);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out BedSideView1.brMax);

                    BedSideView1 bed1 = new BedSideView1();
                    bed1.Show();
                    bed1.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 1" && BedSideView1.breathingActive == true)
                {
                    MessageBox.Show("You already have a Breathing Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 2" && BedSideView2.breathingActive == false)
                {
                    if (BedSideView2.insertClicked1 == 1)
                    {
                        BedSideView2.breathingInsert1 = 1;
                        BedSideView2.moduleState1 = 1;
                        BedSideView2.insertClicked1 = 0;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.breathingInsert2 = 1;
                        BedSideView2.moduleState2 = 1;
                        BedSideView2.insertClicked2 = 0;
                    }
                    else if (BedSideView2.insertClicked3 == 1)
                    {
                        BedSideView2.breathingInsert3 = 1;
                        BedSideView2.moduleState3 = 1;
                        BedSideView2.insertClicked3 = 0;
                    }
                    else if (BedSideView2.insertClicked4 == 1)
                    {
                        BedSideView2.breathingInsert4 = 1;
                        BedSideView2.moduleState4 = 1;
                        BedSideView2.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out BedSideView2.brMin);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out BedSideView2.brMax);

                    BedSideView2 bed2 = new BedSideView2();
                    bed2.Show();
                    bed2.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 2" && BedSideView2.breathingActive == true)
                {
                    MessageBox.Show("You already have a Breathing Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 3" && BedSideView3.breathingActive == false)
                {
                    if (BedSideView3.insertClicked1 == 1)
                    {
                        BedSideView3.breathingInsert1 = 1;
                        BedSideView3.moduleState1 = 1;
                        BedSideView3.insertClicked1 = 0;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.breathingInsert2 = 1;
                        BedSideView3.moduleState2 = 1;
                        BedSideView3.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.breathingInsert3 = 1;
                        BedSideView3.moduleState3 = 1;
                        BedSideView3.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.breathingInsert4 = 1;
                        BedSideView3.moduleState4 = 1;
                        BedSideView3.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out BedSideView3.brMin);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out BedSideView3.brMax);

                    BedSideView3 bed3 = new BedSideView3();
                    bed3.Show();
                    bed3.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 3" && BedSideView3.breathingActive == true)
                {
                    MessageBox.Show("You already have a Breathing Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 4" && BedSideView4.breathingActive == false)
                {
                    if (BedSideView4.insertClicked1 == 1)
                    {
                        BedSideView4.breathingInsert1 = 1;
                        BedSideView4.moduleState1 = 1;
                        BedSideView4.insertClicked1 = 0;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.breathingInsert2 = 1;
                        BedSideView4.moduleState2 = 1;
                        BedSideView4.insertClicked2 = 0;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.breathingInsert3 = 1;
                        BedSideView4.moduleState3 = 1;
                        BedSideView4.insertClicked3 = 0;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.breathingInsert4 = 1;
                        BedSideView4.moduleState4 = 1;
                        BedSideView4.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out BedSideView4.brMin);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out BedSideView4.brMax);

                    BedSideView4 bed4 = new BedSideView4();
                    bed4.Show();
                    bed4.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 4" && BedSideView4.breathingActive == true)
                {
                    MessageBox.Show("You already have a Breathing Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 5" && BedSideView5.breathingActive == false)
                {
                    if (BedSideView5.insertClicked1 == 1)
                    {
                        BedSideView5.breathingInsert1 = 1;
                        BedSideView5.moduleState1 = 1;
                        BedSideView5.insertClicked1 = 0;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.breathingInsert2 = 1;
                        BedSideView5.moduleState2 = 1;
                        BedSideView5.insertClicked2 = 0;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.breathingInsert3 = 1;
                        BedSideView5.moduleState3 = 1;
                        BedSideView5.insertClicked3 = 0;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.breathingInsert4 = 1;
                        BedSideView5.moduleState4 = 1;
                        BedSideView5.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out BedSideView5.brMin);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out BedSideView5.brMax);

                    BedSideView5 bed5 = new BedSideView5();
                    bed5.Show();
                    bed5.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 5" && BedSideView5.breathingActive == true)
                {
                    MessageBox.Show("You already have a Breathing Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 6" && BedSideView6.breathingActive == false)
                {
                    if (BedSideView6.insertClicked1 == 1)
                    {
                        BedSideView6.breathingInsert1 = 1;
                        BedSideView6.moduleState1 = 1;
                        BedSideView6.insertClicked1 = 0;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.breathingInsert2 = 1;
                        BedSideView6.moduleState2 = 1;
                        BedSideView6.insertClicked2 = 0;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.breathingInsert3 = 1;
                        BedSideView6.moduleState3 = 1;
                        BedSideView6.insertClicked3 = 0;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.breathingInsert4 = 1;
                        BedSideView6.moduleState4 = 1;
                        BedSideView6.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out BedSideView6.brMin);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out BedSideView6.brMax);

                    BedSideView6 bed6 = new BedSideView6();
                    bed6.Show();
                    bed6.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 6" && BedSideView6.breathingActive == true)
                {
                    MessageBox.Show("You already have a Breathing Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 7" && BedSideView7.breathingActive == false)
                {
                    if (BedSideView7.insertClicked1 == 1)
                    {
                        BedSideView7.breathingInsert1 = 1;
                        BedSideView7.moduleState1 = 1;
                        BedSideView7.insertClicked1 = 0;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.breathingInsert2 = 1;
                        BedSideView7.moduleState2 = 1;
                        BedSideView7.insertClicked2 = 0;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.breathingInsert3 = 1;
                        BedSideView7.moduleState3 = 1;
                        BedSideView7.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.breathingInsert4 = 1;
                        BedSideView7.moduleState4 = 1;
                        BedSideView7.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out BedSideView7.brMin);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out BedSideView7.brMax);

                    BedSideView7 bed7 = new BedSideView7();
                    bed7.Show();
                    bed7.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 7" && BedSideView7.breathingActive == true)
                {
                    MessageBox.Show("You already have a Breathing Rate Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 8" && BedSideView8.breathingActive == false)
                {
                    if (BedSideView8.insertClicked1 == 1)
                    {
                        BedSideView8.breathingInsert1 = 1;
                        BedSideView8.moduleState1 = 1;
                        BedSideView8.insertClicked1 = 0;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.breathingInsert2 = 1;
                        BedSideView8.moduleState2 = 1;
                        BedSideView8.insertClicked2 = 0;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.breathingInsert3 = 1;
                        BedSideView8.moduleState3 = 1;
                        BedSideView8.insertClicked3 = 0;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.breathingInsert4 = 1;
                        BedSideView8.moduleState4 = 1;
                        BedSideView8.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out BedSideView8.brMin);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out BedSideView8.brMax);

                    BedSideView8 bed8 = new BedSideView8();
                    bed8.Show();
                    bed8.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 8" && BedSideView8.breathingActive == true)
                {
                    MessageBox.Show("You already have a Breathing Rate Module Active, Eject it first!");
                }
            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 3 && SocketConfiguration.tempDiff >= 1)  // Temperature
            {
                if (BedLabel.Text == "Bed 1" && BedSideView1.tempActive == false)
                {
                    if (BedSideView1.insertClicked1 == 1)
                    {
                        BedSideView1.tempInsert1 = 1;
                        BedSideView1.moduleState1 = 1;
                        BedSideView1.insertClicked1 = 0;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.tempInsert2 = 1;
                        BedSideView1.moduleState2 = 1;
                        BedSideView1.insertClicked2 = 0;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.tempInsert3 = 1;
                        BedSideView1.moduleState3 = 1;
                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.tempInsert4 = 1;
                        BedSideView1.moduleState4 = 1;
                        BedSideView1.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out BedSideView1.tpMin);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out BedSideView1.tpMax);

                    BedSideView1 bed1 = new BedSideView1();
                    bed1.Show();
                    bed1.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 1" && BedSideView1.tempActive == true)
                {
                    MessageBox.Show("You already have a Temperature Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 2" && BedSideView2.tempActive == false)
                {
                    if (BedSideView2.insertClicked1 == 1)
                    {
                        BedSideView2.tempInsert1 = 1;
                        BedSideView2.moduleState1 = 1;
                        BedSideView2.insertClicked1 = 0;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.tempInsert2 = 1;
                        BedSideView2.moduleState2 = 1;
                        BedSideView2.insertClicked2 = 0;
                    }
                    else if (BedSideView2.insertClicked3 == 1)
                    {
                        BedSideView2.tempInsert3 = 1;
                        BedSideView2.moduleState3 = 1;
                        BedSideView2.insertClicked3 = 0;
                    }
                    else if (BedSideView2.insertClicked4 == 1)
                    {
                        BedSideView2.tempInsert4 = 1;
                        BedSideView2.moduleState4 = 1;
                        BedSideView2.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out BedSideView2.tpMin);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out BedSideView2.tpMax);

                    BedSideView2 bed2 = new BedSideView2();
                    bed2.Show();
                    bed2.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 2" && BedSideView2.tempActive == true)
                {
                    MessageBox.Show("You already have a Temperature Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 3" && BedSideView3.tempActive == false)
                {
                    if (BedSideView3.insertClicked1 == 1)
                    {
                        BedSideView3.tempInsert1 = 1;
                        BedSideView3.moduleState1 = 1;
                        BedSideView3.insertClicked1 = 0;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.tempInsert2 = 1;
                        BedSideView3.moduleState2 = 1;
                        BedSideView3.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.tempInsert3 = 1;
                        BedSideView3.moduleState3 = 1;
                        BedSideView3.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.tempInsert4 = 1;
                        BedSideView3.moduleState4 = 1;
                        BedSideView3.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out BedSideView3.tpMin);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out BedSideView3.tpMax);

                    BedSideView3 bed3 = new BedSideView3();
                    bed3.Show();
                    bed3.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 3" && BedSideView3.tempActive == true)
                {
                    MessageBox.Show("You already have a Temperature Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 4" && BedSideView4.tempActive == false)
                {
                    if (BedSideView4.insertClicked1 == 1)
                    {
                        BedSideView4.tempInsert1 = 1;
                        BedSideView4.moduleState1 = 1;
                        BedSideView4.insertClicked1 = 0;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.tempInsert2 = 1;
                        BedSideView4.moduleState2 = 1;
                        BedSideView4.insertClicked2 = 0;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.tempInsert3 = 1;
                        BedSideView4.moduleState3 = 1;
                        BedSideView4.insertClicked3 = 0;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.tempInsert4 = 1;
                        BedSideView4.moduleState4 = 1;
                        BedSideView4.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out BedSideView4.tpMin);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out BedSideView4.tpMax);

                    BedSideView4 bed4 = new BedSideView4();
                    bed4.Show();
                    bed4.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 4" && BedSideView4.tempActive == true)
                {
                    MessageBox.Show("You already have a Temperature Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 5" && BedSideView5.tempActive == false)
                {
                    if (BedSideView5.insertClicked1 == 1)
                    {
                        BedSideView5.tempInsert1 = 1;
                        BedSideView5.moduleState1 = 1;
                        BedSideView5.insertClicked1 = 0;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.tempInsert2 = 1;
                        BedSideView5.moduleState2 = 1;
                        BedSideView5.insertClicked2 = 0;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.tempInsert3 = 1;
                        BedSideView5.moduleState3 = 1;
                        BedSideView5.insertClicked3 = 0;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.tempInsert4 = 1;
                        BedSideView5.moduleState4 = 1;
                        BedSideView5.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out BedSideView5.tpMin);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out BedSideView5.tpMax);

                    BedSideView5 bed5 = new BedSideView5();
                    bed5.Show();
                    bed5.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 5" && BedSideView5.tempActive == true)
                {
                    MessageBox.Show("You already have a Temperature Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 6" && BedSideView6.tempActive == false)
                {
                    if (BedSideView6.insertClicked1 == 1)
                    {
                        BedSideView6.tempInsert1 = 1;
                        BedSideView6.moduleState1 = 1;
                        BedSideView6.insertClicked1 = 0;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.tempInsert2 = 1;
                        BedSideView6.moduleState2 = 1;
                        BedSideView6.insertClicked2 = 0;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.tempInsert3 = 1;
                        BedSideView6.moduleState3 = 1;
                        BedSideView6.insertClicked3 = 0;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.tempInsert4 = 1;
                        BedSideView6.moduleState4 = 1;
                        BedSideView6.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out BedSideView6.tpMin);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out BedSideView6.tpMax);

                    BedSideView6 bed6 = new BedSideView6();
                    bed6.Show();
                    bed6.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 6" && BedSideView6.tempActive == true)
                {
                    MessageBox.Show("You already have a Temperature Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 7" && BedSideView7.tempActive == false)
                {
                    if (BedSideView7.insertClicked1 == 1)
                    {
                        BedSideView7.tempInsert1 = 1;
                        BedSideView7.moduleState1 = 1;
                        BedSideView7.insertClicked1 = 0;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.tempInsert2 = 1;
                        BedSideView7.moduleState2 = 1;
                        BedSideView7.insertClicked2 = 0;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.tempInsert3 = 1;
                        BedSideView7.moduleState3 = 1;
                        BedSideView7.insertClicked3 = 0;
                    }
                    else if (BedSideView7.insertClicked4 == 1)
                    {
                        BedSideView7.tempInsert4 = 1;
                        BedSideView7.moduleState4 = 1;
                        BedSideView7.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out BedSideView7.tpMin);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out BedSideView7.tpMax);

                    BedSideView7 bed7 = new BedSideView7();
                    bed7.Show();
                    bed7.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 7" && BedSideView7.tempActive == true)
                {
                    MessageBox.Show("You already have a Temperature Module Active, Eject it first!");
                }

                if (BedLabel.Text == "Bed 8" && BedSideView8.tempActive == false)
                {
                    if (BedSideView8.insertClicked1 == 1)
                    {
                        BedSideView8.tempInsert1 = 1;
                        BedSideView8.moduleState1 = 1;
                        BedSideView8.insertClicked1 = 0;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.tempInsert2 = 1;
                        BedSideView8.moduleState2 = 1;
                        BedSideView8.insertClicked2 = 0;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.tempInsert3 = 1;
                        BedSideView8.moduleState3 = 1;
                        BedSideView8.insertClicked3 = 0;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.tempInsert4 = 1;
                        BedSideView8.moduleState4 = 1;
                        BedSideView8.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out BedSideView8.tpMin);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out BedSideView8.tpMax);

                    BedSideView8 bed8 = new BedSideView8();
                    bed8.Show();
                    bed8.Location = this.Location;
                    this.Hide();
                }
                else if (BedLabel.Text == "Bed 8" && BedSideView8.tempActive == true)
                {
                    MessageBox.Show("You already have a Temperature Module Active, Eject it first!");
                }
            }

            else
            {
                if ((SocketConfiguration.diDiff < 30 && DefaultPanel_SocketComboBox.SelectedIndex == 0) || (SocketConfiguration.syDiff < 20 && DefaultPanel_SocketComboBox.SelectedIndex == 0))
                {
                    MessageBox.Show("The Diastolic difference must be 30 or greater and the Systolic difference must be 20 or greater");
                }
                if (SocketConfiguration.prDiff < 30 && DefaultPanel_SocketComboBox.SelectedIndex == 1)
                {
                    MessageBox.Show("The Pulse Rate Difference must be 30 or greater");
                }
                if (SocketConfiguration.brDiff < 5 && DefaultPanel_SocketComboBox.SelectedIndex == 2)
                {
                    MessageBox.Show("The Breathing Rate difference must be 5 or greater");
                }
                if (SocketConfiguration.tempDiff < 1 && DefaultPanel_SocketComboBox.SelectedIndex == 3)
                {
                    MessageBox.Show("The temperature difference must be 1 or greater");
                }
            }

        }
    }
}
