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

            #region Panel Visibility  -- Dinis & Jorge
            // Visible = false to every SocketPanel in the form
            BreathingRatePanel.Visible = false;
            PulseRatePanel.Visible = false;
            BloodPressurePanel.Visible = false;
            TemperaturePanel.Visible = false;
            #endregion

            #region SocketComboBox Items  -- Dinis & Jorge
            DefaultPanel_SocketComboBox.Items.Add("Blood Pressure");
            DefaultPanel_SocketComboBox.Items.Add("Pulse Rate");
            DefaultPanel_SocketComboBox.Items.Add("Breathing Rate");
            DefaultPanel_SocketComboBox.Items.Add("Temperature");
            #endregion

            SocketConfiguration.dockActive = DefaultPanel_SocketComboBox.SelectedIndex;
        }

        // Variables
        string bedActive;

        #region ScrollBar Configuration  -- Dinis & Jorge  /  ITS EXTRA
        /* just in case we need it
        // Add ScrollBar with scroll up/down event
        VScrollBar vScroll = new VScrollBar();
        private void HandleScroll(Object sender, ScrollEventArgs e)
        {
            int x;
            int y;

            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                x = e.NewValue;
                y = vScroll.Value;
            }
            else //e.ScrollOrientation == ScrollOrientation.VerticalScroll
            {
                y = e.NewValue;
                x = vScroll.Value;
            }
            BloodPresurePanel.AutoScroll = true;
        } */
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
        private void CloseButtonSocketSelection_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButtonSocketSelection_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region TextBox Change effects BLOODPRESSURE  -- Dinis & Jorge

        // Diastolic Minimum TextBox \\
        // On Mouse Down and the text is "Insert Minimum" it will clear the textbox
        private void BloodPressureTextBox_DiastolicMinimum_ParameterValue_MouseDown(object sender, MouseEventArgs e)
        {
            if (BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text == "Insert Minimum")
            {
                BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text = "";
            }
        }
        /* When is not being Selected/Focused and there's no input it would return to the normal "Insert Minimum"
           If there's any input it would stay in the textbox */
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

        // Small Icon on the Left Top corner to go back to the AfterLogin form
        private void MainPageButton_Click(object sender, EventArgs e)   // -- Dinis & Jorge
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            afterlogin.Location = this.Location;
            this.Hide();
        }

        /* When we choose another option on the SocketComboBox
        * the panels would be picked and turned visible and the Label invisible
        * If none is picked everything would be invisible
        * and the Label would be visible aswell */
        private void Default_SocketComboBox_TextChanged(object sender, EventArgs e)  // -- Dinis & Jorge
        {
            if (DefaultPanel_SocketComboBox.SelectedIndex < 0)
            {
                DefaultPanel_SelectSocketLabel.Visible = true; ;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 0)
            {
                BreathingRatePanel.Dock = DockStyle.None;
                TemperaturePanel.Dock = DockStyle.None;
                PulseRatePanel.Dock = DockStyle.None;

                BreathingRatePanel.Visible = false;
                TemperaturePanel.Visible = false;
                PulseRatePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                BloodPressurePanel.Dock = DockStyle.Fill;
                BloodPressurePanel.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 1)
            {
                BreathingRatePanel.Dock = DockStyle.None;
                TemperaturePanel.Dock = DockStyle.None;
                BloodPressurePanel.Dock = DockStyle.None;

                BreathingRatePanel.Visible = false;
                TemperaturePanel.Visible = false;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                PulseRatePanel.Dock = DockStyle.Fill;
                PulseRatePanel.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 2)
            {
                PulseRatePanel.Dock = DockStyle.None;
                TemperaturePanel.Dock = DockStyle.None;
                BloodPressurePanel.Dock = DockStyle.None;

                PulseRatePanel.Visible = false;
                TemperaturePanel.Visible = false;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                BreathingRatePanel.Dock = DockStyle.Fill;
                BreathingRatePanel.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 3)
            {
                PulseRatePanel.Dock = DockStyle.None;
                BreathingRatePanel.Dock = DockStyle.None;
                BloodPressurePanel.Dock = DockStyle.None;

                PulseRatePanel.Visible = false;
                BreathingRatePanel.Visible = false;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                TemperaturePanel.Dock = DockStyle.Fill;
                TemperaturePanel.Visible = true;
            }
        }

        // Install Button Configuration
        public void DefaultPanel_InstallButton_Click(object sender, EventArgs e)
        {
            #region Giving Variables to the TextBoxes
            // Blood Pressure Secondary Variables Integer
            int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin);
            int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax);
            int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin);
            int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax);

            // Pulse Rate Secondary Variables Integer
            int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin);
            int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax);

            // Breathing Rate Secondary Variables Integer
            int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin);
            int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax);

            // Temperature Secondary Variables Integer
            int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin);
            int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax);
            #endregion

            bedActive = BedLabel.Text;

            SocketConfiguration socket = new SocketConfiguration();

            #region Button Configuration
            if (DefaultPanel_SocketComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please, select a Module to proceed.");
            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 0 && SocketConfiguration.bpParameters == 1 && SocketConfiguration.diDiff >= 30 && SocketConfiguration.syDiff >= 20)  // Blood Pressure
            {
                if (bedActive == "Bed 1")
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

                    BedSideView1 bed1 = new BedSideView1();
                    bed1.Show();
                    bed1.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 2")
                {
                    if (BedSideView2.insertClicked1 == 1)
                    {
                        BedSideView2.bloodInsert1 = 1;
                        BedSideView2.moduleState1 = 1;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.bloodInsert2 = 1;
                        BedSideView2.moduleState2 = 1;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView2.bloodInsert3 = 1;
                        BedSideView2.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView2.bloodInsert4 = 1;
                        BedSideView2.moduleState4 = 1;
                    }

                    BedSideView2 bed2 = new BedSideView2();
                    bed2.Show();
                    bed2.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 3")
                {
                    if (BedSideView3.insertClicked1 == 1)
                    {
                        BedSideView3.bloodInsert1 = 1;
                        BedSideView3.moduleState1 = 1;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.bloodInsert2 = 1;
                        BedSideView3.moduleState2 = 1;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.bloodInsert3 = 1;
                        BedSideView3.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.bloodInsert4 = 1;
                        BedSideView3.moduleState4 = 1;
                    }

                    BedSideView3 bed3 = new BedSideView3();
                    bed3.Show();
                    bed3.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 4")
                {
                    if (BedSideView4.insertClicked1 == 1)
                    {
                        BedSideView4.bloodInsert1 = 1;
                        BedSideView4.moduleState1 = 1;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.bloodInsert2 = 1;
                        BedSideView4.moduleState2 = 1;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.bloodInsert3 = 1;
                        BedSideView4.moduleState3 = 1;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.bloodInsert4 = 1;
                        BedSideView4.moduleState4 = 1;
                    }

                    BedSideView4 bed4 = new BedSideView4();
                    bed4.Show();
                    bed4.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 5")
                {
                    if (BedSideView5.insertClicked1 == 1)
                    {
                        BedSideView5.bloodInsert1 = 1;
                        BedSideView5.moduleState1 = 1;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.bloodInsert2 = 1;
                        BedSideView5.moduleState2 = 1;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.bloodInsert3 = 1;
                        BedSideView5.moduleState3 = 1;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.bloodInsert4 = 1;
                        BedSideView5.moduleState4 = 1;
                    }

                    BedSideView5 bed5 = new BedSideView5();
                    bed5.Show();
                    bed5.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 6")
                {
                    if (BedSideView6.insertClicked1 == 1)
                    {
                        BedSideView6.bloodInsert1 = 1;
                        BedSideView6.moduleState1 = 1;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.bloodInsert2 = 1;
                        BedSideView6.moduleState2 = 1;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.bloodInsert3 = 1;
                        BedSideView6.moduleState3 = 1;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.bloodInsert4 = 1;
                        BedSideView6.moduleState4 = 1;
                    }

                    BedSideView6 bed6 = new BedSideView6();
                    bed6.Show();
                    bed6.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 7")
                {
                    if (BedSideView7.insertClicked1 == 1)
                    {
                        BedSideView7.bloodInsert1 = 1;
                        BedSideView7.moduleState1 = 1;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.bloodInsert2 = 1;
                        BedSideView7.moduleState2 = 1;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.bloodInsert3 = 1;
                        BedSideView7.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.bloodInsert4 = 1;
                        BedSideView7.moduleState4 = 1;
                    }

                    BedSideView7 bed7 = new BedSideView7();
                    bed7.Show();
                    bed7.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 8")
                {
                    if (BedSideView8.insertClicked1 == 1)
                    {
                        BedSideView8.bloodInsert1 = 1;
                        BedSideView8.moduleState1 = 1;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.bloodInsert2 = 1;
                        BedSideView8.moduleState2 = 1;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.bloodInsert3 = 1;
                        BedSideView8.moduleState3 = 1;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.bloodInsert4 = 1;
                        BedSideView8.moduleState4 = 1;
                    }

                    BedSideView8 bed8 = new BedSideView8();
                    bed8.Show();
                    bed8.Location = this.Location;
                    this.Hide();
                }

            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 1 && SocketConfiguration.prParameters == 1 && SocketConfiguration.prDiff >= 30)  // Pulse Rate
            {
                if (bedActive == "Bed 1")
                {
                    if (BedSideView1.insertClicked1 == 1)
                    {
                        BedSideView1.pulseInsert1 = 1;
                        BedSideView1.moduleState1 = 1;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.pulseInsert2 = 1;
                        BedSideView1.moduleState2 = 1;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.pulseInsert3 = 1;
                        BedSideView1.moduleState3 = 1;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.pulseInsert4 = 1;
                        BedSideView1.moduleState4 = 1;
                    }

                    BedSideView1 bed1 = new BedSideView1();
                    bed1.Show();
                    bed1.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 2")
                {
                    if (BedSideView2.insertClicked1 == 1)
                    {
                        BedSideView2.pulseInsert1 = 1;
                        BedSideView2.moduleState1 = 1;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.pulseInsert2 = 1;
                        BedSideView2.moduleState2 = 1;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView2.pulseInsert3 = 1;
                        BedSideView2.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView2.pulseInsert4 = 1;
                        BedSideView2.moduleState4 = 1;
                    }

                    BedSideView2 bed2 = new BedSideView2();
                    bed2.Show();
                    bed2.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 3")
                {
                    if (BedSideView3.insertClicked1 == 1)
                    {
                        BedSideView3.pulseInsert1 = 1;
                        BedSideView3.moduleState1 = 1;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.pulseInsert2 = 1;
                        BedSideView3.moduleState2 = 1;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.pulseInsert3 = 1;
                        BedSideView3.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.pulseInsert4 = 1;
                        BedSideView3.moduleState4 = 1;
                    }

                    BedSideView3 bed3 = new BedSideView3();
                    bed3.Show();
                    bed3.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 4")
                {
                    if (BedSideView4.insertClicked1 == 1)
                    {
                        BedSideView4.pulseInsert1 = 1;
                        BedSideView4.moduleState1 = 1;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.pulseInsert2 = 1;
                        BedSideView4.moduleState2 = 1;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.pulseInsert3 = 1;
                        BedSideView4.moduleState3 = 1;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.pulseInsert4 = 1;
                        BedSideView4.moduleState4 = 1;
                    }

                    BedSideView4 bed4 = new BedSideView4();
                    bed4.Show();
                    bed4.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 5")
                {
                    if (BedSideView5.insertClicked1 == 1)
                    {
                        BedSideView5.pulseInsert1 = 1;
                        BedSideView5.moduleState1 = 1;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.pulseInsert2 = 1;
                        BedSideView5.moduleState2 = 1;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.pulseInsert3 = 1;
                        BedSideView5.moduleState3 = 1;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.pulseInsert4 = 1;
                        BedSideView5.moduleState4 = 1;
                    }

                    BedSideView5 bed5 = new BedSideView5();
                    bed5.Show();
                    bed5.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 6")
                {
                    if (BedSideView6.insertClicked1 == 1)
                    {
                        BedSideView6.pulseInsert1 = 1;
                        BedSideView6.moduleState1 = 1;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.pulseInsert2 = 1;
                        BedSideView6.moduleState2 = 1;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.pulseInsert3 = 1;
                        BedSideView6.moduleState3 = 1;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.pulseInsert4 = 1;
                        BedSideView6.moduleState4 = 1;
                    }

                    BedSideView6 bed6 = new BedSideView6();
                    bed6.Show();
                    bed6.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 7")
                {
                    if (BedSideView7.insertClicked1 == 1)
                    {
                        BedSideView7.pulseInsert1 = 1;
                        BedSideView7.moduleState1 = 1;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.pulseInsert2 = 1;
                        BedSideView7.moduleState2 = 1;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.pulseInsert3 = 1;
                        BedSideView7.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.pulseInsert4 = 1;
                        BedSideView7.moduleState4 = 1;
                    }

                    BedSideView7 bed7 = new BedSideView7();
                    bed7.Show();
                    bed7.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 8")
                {
                    if (BedSideView8.insertClicked1 == 1)
                    {
                        BedSideView8.pulseInsert1 = 1;
                        BedSideView8.moduleState1 = 1;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.pulseInsert2 = 1;
                        BedSideView8.moduleState2 = 1;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.pulseInsert3 = 1;
                        BedSideView8.moduleState3 = 1;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.pulseInsert4 = 1;
                        BedSideView8.moduleState4 = 1;
                    }

                    BedSideView8 bed8 = new BedSideView8();
                    bed8.Show();
                    bed8.Location = this.Location;
                    this.Hide();
                }
            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 2 && SocketConfiguration.brParameters == 1 && SocketConfiguration.brDiff >= 5)  // Breathing Rate
            {
                if (bedActive == "Bed 1")
                {
                    if (BedSideView1.insertClicked1 == 1)
                    {
                        BedSideView1.breathingInsert1 = 1;
                        BedSideView1.moduleState1 = 1;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.breathingInsert2 = 1;
                        BedSideView1.moduleState2 = 1;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.breathingInsert3 = 1;
                        BedSideView1.moduleState3 = 1;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.breathingInsert4 = 1;
                        BedSideView1.moduleState4 = 1;
                    }

                    BedSideView1 bed1 = new BedSideView1();
                    bed1.Show();
                    bed1.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 2")
                {
                    if (BedSideView2.insertClicked1 == 1)
                    {
                        BedSideView2.breathingInsert1 = 1;
                        BedSideView2.moduleState1 = 1;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.breathingInsert2 = 1;
                        BedSideView2.moduleState2 = 1;
                    }
                    else if (BedSideView2.insertClicked3 == 1)
                    {
                        BedSideView2.breathingInsert3 = 1;
                        BedSideView2.moduleState3 = 1;
                    }
                    else if (BedSideView2.insertClicked4 == 1)
                    {
                        BedSideView2.breathingInsert4 = 1;
                        BedSideView2.moduleState4 = 1;
                    }

                    BedSideView2 bed2 = new BedSideView2();
                    bed2.Show();
                    bed2.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 3")
                {
                    if (BedSideView3.insertClicked1 == 1)
                    {
                        BedSideView3.breathingInsert1 = 1;
                        BedSideView3.moduleState1 = 1;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.breathingInsert2 = 1;
                        BedSideView3.moduleState2 = 1;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.breathingInsert3 = 1;
                        BedSideView3.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.breathingInsert4 = 1;
                        BedSideView3.moduleState4 = 1;
                    }

                    BedSideView3 bed3 = new BedSideView3();
                    bed3.Show();
                    bed3.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 4")
                {
                    if (BedSideView4.insertClicked1 == 1)
                    {
                        BedSideView4.breathingInsert1 = 1;
                        BedSideView4.moduleState1 = 1;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.breathingInsert2 = 1;
                        BedSideView4.moduleState2 = 1;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.breathingInsert3 = 1;
                        BedSideView4.moduleState3 = 1;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.breathingInsert4 = 1;
                        BedSideView4.moduleState4 = 1;
                    }

                    BedSideView4 bed4 = new BedSideView4();
                    bed4.Show();
                    bed4.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 5")
                {
                    if (BedSideView5.insertClicked1 == 1)
                    {
                        BedSideView5.breathingInsert1 = 1;
                        BedSideView5.moduleState1 = 1;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.breathingInsert2 = 1;
                        BedSideView5.moduleState2 = 1;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.breathingInsert3 = 1;
                        BedSideView5.moduleState3 = 1;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.breathingInsert4 = 1;
                        BedSideView5.moduleState4 = 1;
                    }

                    BedSideView5 bed5 = new BedSideView5();
                    bed5.Show();
                    bed5.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 6")
                {
                    if (BedSideView6.insertClicked1 == 1)
                    {
                        BedSideView6.breathingInsert1 = 1;
                        BedSideView6.moduleState1 = 1;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.breathingInsert2 = 1;
                        BedSideView6.moduleState2 = 1;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.breathingInsert3 = 1;
                        BedSideView6.moduleState3 = 1;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.breathingInsert4 = 1;
                        BedSideView6.moduleState4 = 1;
                    }

                    BedSideView6 bed6 = new BedSideView6();
                    bed6.Show();
                    bed6.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 7")
                {
                    if (BedSideView7.insertClicked1 == 1)
                    {
                        BedSideView7.breathingInsert1 = 1;
                        BedSideView7.moduleState1 = 1;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.breathingInsert2 = 1;
                        BedSideView7.moduleState2 = 1;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.breathingInsert3 = 1;
                        BedSideView7.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.breathingInsert4 = 1;
                        BedSideView7.moduleState4 = 1;
                    }

                    BedSideView7 bed7 = new BedSideView7();
                    bed7.Show();
                    bed7.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 8")
                {
                    if (BedSideView8.insertClicked1 == 1)
                    {
                        BedSideView8.breathingInsert1 = 1;
                        BedSideView8.moduleState1 = 1;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.breathingInsert2 = 1;
                        BedSideView8.moduleState2 = 1;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.breathingInsert3 = 1;
                        BedSideView8.moduleState3 = 1;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.breathingInsert4 = 1;
                        BedSideView8.moduleState4 = 1;
                    }

                    BedSideView8 bed8 = new BedSideView8();
                    bed8.Show();
                    bed8.Location = this.Location;
                    this.Hide();
                }
            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 3 && SocketConfiguration.tpParameters == 1 && SocketConfiguration.tempDiff >= 1)  // Temperature
            {
                if (bedActive == "Bed 1")
                {
                    if (BedSideView1.insertClicked1 == 1)
                    {
                        BedSideView1.tempInsert1 = 1;
                        BedSideView1.moduleState1 = 1;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.tempInsert2 = 1;
                        BedSideView1.moduleState2 = 1;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.tempInsert3 = 1;
                        BedSideView1.moduleState3 = 1;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.tempInsert4 = 1;
                        BedSideView1.moduleState4 = 1;
                    }

                    BedSideView1 bed1 = new BedSideView1();
                    bed1.Show();
                    bed1.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 2")
                {
                    if (BedSideView2.insertClicked1 == 1)
                    {
                        BedSideView2.tempInsert1 = 1;
                        BedSideView2.moduleState1 = 1;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.tempInsert2 = 1;
                        BedSideView2.moduleState2 = 1;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView2.tempInsert3 = 1;
                        BedSideView2.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView2.tempInsert4 = 1;
                        BedSideView2.moduleState4 = 1;
                    }

                    BedSideView2 bed2 = new BedSideView2();
                    bed2.Show();
                    bed2.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 3")
                {
                    if (BedSideView3.insertClicked1 == 1)
                    {
                        BedSideView3.tempInsert1 = 1;
                        BedSideView3.moduleState1 = 1;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.tempInsert2 = 1;
                        BedSideView3.moduleState2 = 1;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.tempInsert3 = 1;
                        BedSideView3.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.tempInsert4 = 1;
                        BedSideView3.moduleState4 = 1;
                    }

                    BedSideView3 bed3 = new BedSideView3();
                    bed3.Show();
                    bed3.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 4")
                {
                    if (BedSideView4.insertClicked1 == 1)
                    {
                        BedSideView4.tempInsert1 = 1;
                        BedSideView4.moduleState1 = 1;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.tempInsert2 = 1;
                        BedSideView4.moduleState2 = 1;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.tempInsert3 = 1;
                        BedSideView4.moduleState3 = 1;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.tempInsert4 = 1;
                        BedSideView4.moduleState4 = 1;
                    }

                    BedSideView4 bed4 = new BedSideView4();
                    bed4.Show();
                    bed4.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 5")
                {
                    if (BedSideView5.insertClicked1 == 1)
                    {
                        BedSideView5.tempInsert1 = 1;
                        BedSideView5.moduleState1 = 1;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.tempInsert2 = 1;
                        BedSideView5.moduleState2 = 1;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.tempInsert3 = 1;
                        BedSideView5.moduleState3 = 1;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.tempInsert4 = 1;
                        BedSideView5.moduleState4 = 1;
                    }

                    BedSideView5 bed5 = new BedSideView5();
                    bed5.Show();
                    bed5.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 6")
                {
                    if (BedSideView6.insertClicked1 == 1)
                    {
                        BedSideView6.tempInsert1 = 1;
                        BedSideView6.moduleState1 = 1;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.tempInsert2 = 1;
                        BedSideView6.moduleState2 = 1;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.tempInsert3 = 1;
                        BedSideView6.moduleState3 = 1;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.tempInsert4 = 1;
                        BedSideView6.moduleState4 = 1;
                    }

                    BedSideView6 bed6 = new BedSideView6();
                    bed6.Show();
                    bed6.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 7")
                {
                    if (BedSideView7.insertClicked1 == 1)
                    {
                        BedSideView7.tempInsert1 = 1;
                        BedSideView7.moduleState1 = 1;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.tempInsert2 = 1;
                        BedSideView7.moduleState2 = 1;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.tempInsert3 = 1;
                        BedSideView7.moduleState3 = 1;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.tempInsert4 = 1;
                        BedSideView7.moduleState4 = 1;
                    }

                    BedSideView7 bed7 = new BedSideView7();
                    bed7.Show();
                    bed7.Location = this.Location;
                    this.Hide();
                }

                else if (bedActive == "Bed 8")
                {
                    if (BedSideView8.insertClicked1 == 1)
                    {
                        BedSideView8.tempInsert1 = 1;
                        BedSideView8.moduleState1 = 1;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.tempInsert2 = 1;
                        BedSideView8.moduleState2 = 1;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.tempInsert3 = 1;
                        BedSideView8.moduleState3 = 1;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.tempInsert4 = 1;
                        BedSideView8.moduleState4 = 1;
                    }

                    BedSideView8 bed8 = new BedSideView8();
                    bed8.Show();
                    bed8.Location = this.Location;
                    this.Hide();
                }
            }
            else
            {
                if (SocketConfiguration.bpParameters == 0)
                {
                    MessageBox.Show("Make sure the input is numeric ONLY");
                }
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
            #endregion
        }

        private void SocketSelection_Load(object sender, EventArgs e)
        {
            SocketConfiguration socket = new SocketConfiguration();
        }
    }
}
