using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SocketSelection : Form
    {
        public static SocketSelection socketsingleton = new SocketSelection();

        public SocketSelection()
        {
            socketsingleton = this;
            InitializeComponent();

            HideAllSokets();

            AddNamesToSoketComboBox();

            SocketConfiguration.dockActive = DefaultPanel_SocketComboBox.SelectedIndex;

            #region TextBox Multiline Disable
            BloodPressureTextBox_DiastolicMinimum_ParameterValue.Multiline = false;
            BloodPressureTextBox_DiastolicMaximum_ParameterValue.Multiline = false;
            BloodPressureTextBox_SystolicMinimum_ParameterValue.Multiline = false;
            BloodPressureTextBox_SystolicMaximum_ParameterValue.Multiline = false;
            BreathingRate_Minimum_TextBox.Multiline = false;
            BreathingRate_Maximum_TextBox.Multiline = false;
            PulseRate_Maximum_TextBox.Multiline = false;
            PulseRate_Minimum_TextBox.Multiline = false;
            Temperature_Maximum_TextBox.Multiline = false;
            Temperature_Minimum_TextBox.Multiline = false;
            #endregion

            #region Disable AutoSize
            BloodPressureTextBox_DiastolicMinimum_ParameterValue.AutoSize = false;
            BloodPressureTextBox_DiastolicMaximum_ParameterValue.AutoSize = false;
            BloodPressureTextBox_SystolicMinimum_ParameterValue.AutoSize = false;
            BloodPressureTextBox_SystolicMaximum_ParameterValue.AutoSize = false;
            BreathingRate_Minimum_TextBox.AutoSize = false;
            BreathingRate_Maximum_TextBox.AutoSize = false;
            PulseRate_Maximum_TextBox.AutoSize = false;
            PulseRate_Minimum_TextBox.AutoSize = false;
            Temperature_Maximum_TextBox.AutoSize = false;
            Temperature_Minimum_TextBox.AutoSize = false;
            #endregion

            #region Set the Size of the TextBox
            BloodPressureTextBox_DiastolicMinimum_ParameterValue.Size = new Size(119, 35);
            BloodPressureTextBox_DiastolicMaximum_ParameterValue.Size = new Size(119, 35);
            BloodPressureTextBox_SystolicMinimum_ParameterValue.Size = new Size(119, 35);
            BloodPressureTextBox_SystolicMaximum_ParameterValue.Size = new Size(119, 35);
            BreathingRate_Minimum_TextBox.Size = new Size(249, 32);
            BreathingRate_Maximum_TextBox.Size = new Size(249, 32);
            PulseRate_Maximum_TextBox.Size = new Size(249, 32);
            PulseRate_Minimum_TextBox.Size = new Size(249, 32);
            Temperature_Maximum_TextBox.Size = new Size(249, 32);
            Temperature_Minimum_TextBox.Size = new Size(249, 32);
            #endregion

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
            BedSideView1.bed1singleton.Show();
            BedSideView1.bed1singleton.Location = this.Location;
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

                        BedSideView1.bed1singleton.BloodPressurePanelBed1.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.BloodPressurePanelBed1.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket1.Visible = false;

                        BedSideView1.insertClicked1 = 0;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.moduleState2 = 1;

                        BedSideView1.bed1singleton.BloodPressurePanelBed2.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.BloodPressurePanelBed2.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket2.Visible = false;

                        BedSideView1.insertClicked2 = 0;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.moduleState3 = 1;

                        BedSideView1.bed1singleton.BloodPressurePanelBed3.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.BloodPressurePanelBed3.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket3.Visible = false;

                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.moduleState4 = 1;

                        BedSideView1.bed1singleton.BloodPressurePanelBed4.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.BloodPressurePanelBed4.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket4.Visible = false;

                        BedSideView1.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin1);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax1);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin1);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax1);

                    BedSideView1.bed1singleton.Show();
                    BedSideView1.bed1singleton.Location = this.Location;
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
                        BedSideView2.moduleState1 = 1;

                        BedSideView2.bed2singleton.BloodPressurePanelBed1.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.BloodPressurePanelBed1.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket1.Visible = false;

                        BedSideView2.insertClicked1 = 0;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.moduleState2 = 1;

                        BedSideView2.bed2singleton.BloodPressurePanelBed2.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.BloodPressurePanelBed2.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket2.Visible = false;

                        BedSideView2.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView2.moduleState3 = 1;

                        BedSideView2.bed2singleton.BloodPressurePanelBed3.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.BloodPressurePanelBed3.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket3.Visible = false;

                        BedSideView2.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView2.moduleState4 = 1;

                        BedSideView2.bed2singleton.BloodPressurePanelBed4.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.BloodPressurePanelBed4.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket4.Visible = false;

                        BedSideView2.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin2);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax2);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin2);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax2);

                    BedSideView2.bed2singleton.Show();
                    BedSideView2.bed2singleton.Location = this.Location;
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
                        BedSideView3.moduleState1 = 1;

                        BedSideView3.bed3singleton.BloodPressurePanelBed1.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.BloodPressurePanelBed1.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket1.Visible = false;

                        BedSideView3.insertClicked1 = 0;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.moduleState2 = 1;

                        BedSideView3.bed3singleton.BloodPressurePanelBed2.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.BloodPressurePanelBed2.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket2.Visible = false;

                        BedSideView3.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.moduleState3 = 1;

                        BedSideView3.bed3singleton.BloodPressurePanelBed3.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.BloodPressurePanelBed3.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket3.Visible = false;

                        BedSideView3.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.moduleState4 = 1;

                        BedSideView3.bed3singleton.BloodPressurePanelBed4.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.BloodPressurePanelBed4.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket4.Visible = false;

                        BedSideView3.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin3);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax3);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin3);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax3);

                    BedSideView3.bed3singleton.Show();
                    BedSideView3.bed3singleton.Location = this.Location;
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
                        BedSideView4.moduleState1 = 1;

                        BedSideView4.bed4singleton.BloodPressurePanelBed1.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.BloodPressurePanelBed1.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket1.Visible = false;

                        BedSideView4.insertClicked1 = 0;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.moduleState2 = 1;

                        BedSideView4.bed4singleton.BloodPressurePanelBed2.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.BloodPressurePanelBed2.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket2.Visible = false;

                        BedSideView4.insertClicked2 = 0;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.moduleState3 = 1;

                        BedSideView4.bed4singleton.BloodPressurePanelBed3.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.BloodPressurePanelBed3.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket3.Visible = false;

                        BedSideView4.insertClicked3 = 0;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.moduleState4 = 1;

                        BedSideView4.bed4singleton.BloodPressurePanelBed4.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.BloodPressurePanelBed4.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket4.Visible = false;

                        BedSideView4.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin4);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax4);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin4);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax4);

                    BedSideView4.bed4singleton.Show();
                    BedSideView4.bed4singleton.Location = this.Location;
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
                        BedSideView5.moduleState1 = 1;

                        BedSideView5.bed5singleton.BloodPressurePanelBed1.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.BloodPressurePanelBed1.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket1.Visible = false;

                        BedSideView5.insertClicked1 = 0;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.moduleState2 = 1;

                        BedSideView5.bed5singleton.BloodPressurePanelBed2.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.BloodPressurePanelBed2.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket2.Visible = false;

                        BedSideView5.insertClicked2 = 0;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.moduleState3 = 1;

                        BedSideView5.bed5singleton.BloodPressurePanelBed3.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.BloodPressurePanelBed3.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket3.Visible = false;

                        BedSideView5.insertClicked3 = 0;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.moduleState4 = 1;

                        BedSideView5.bed5singleton.BloodPressurePanelBed4.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.BloodPressurePanelBed4.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket4.Visible = false;

                        BedSideView5.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin5);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax5);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin5);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax5);

                    BedSideView5.bed5singleton.Show();
                    BedSideView5.bed5singleton.Location = this.Location;
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
                        BedSideView6.moduleState1 = 1;

                        BedSideView6.bed6singleton.BloodPressurePanelBed1.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.BloodPressurePanelBed1.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket1.Visible = false;

                        BedSideView6.insertClicked1 = 0;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.moduleState2 = 1;

                        BedSideView6.bed6singleton.BloodPressurePanelBed2.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.BloodPressurePanelBed2.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket2.Visible = false;

                        BedSideView6.insertClicked2 = 0;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.moduleState3 = 1;

                        BedSideView6.bed6singleton.BloodPressurePanelBed3.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.BloodPressurePanelBed3.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket3.Visible = false;

                        BedSideView6.insertClicked3 = 0;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.moduleState4 = 1;

                        BedSideView6.bed6singleton.BloodPressurePanelBed4.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.BloodPressurePanelBed4.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket4.Visible = false;

                        BedSideView6.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin6);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax6);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin6);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax6);

                    BedSideView6.bed6singleton.Show();
                    BedSideView6.bed6singleton.Location = this.Location;
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
                        BedSideView7.moduleState1 = 1;

                        BedSideView7.bed7singleton.BloodPressurePanelBed1.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.BloodPressurePanelBed1.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket1.Visible = false;

                        BedSideView7.insertClicked1 = 0;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.moduleState2 = 1;

                        BedSideView7.bed7singleton.BloodPressurePanelBed2.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.BloodPressurePanelBed2.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket2.Visible = false;

                        BedSideView7.insertClicked2 = 0;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.moduleState3 = 1;

                        BedSideView7.bed7singleton.BloodPressurePanelBed3.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.BloodPressurePanelBed3.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket3.Visible = false;

                        BedSideView7.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.moduleState4 = 1;

                        BedSideView7.bed7singleton.BloodPressurePanelBed4.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.BloodPressurePanelBed4.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket4.Visible = false;

                        BedSideView7.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin7);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax7);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin7);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax7);

                    BedSideView7.bed7singleton.Show();
                    BedSideView7.bed7singleton.Location = this.Location;
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
                        BedSideView8.moduleState1 = 1;

                        BedSideView8.bed8singleton.BloodPressurePanelBed1.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.BloodPressurePanelBed1.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket1.Visible = false;

                        BedSideView8.insertClicked1 = 0;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.moduleState2 = 1;

                        BedSideView8.bed8singleton.BloodPressurePanelBed2.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.BloodPressurePanelBed2.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket2.Visible = false;

                        BedSideView8.insertClicked2 = 0;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.moduleState3 = 1;

                        BedSideView8.bed8singleton.BloodPressurePanelBed3.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.BloodPressurePanelBed3.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket3.Visible = false;

                        BedSideView8.insertClicked3 = 0;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.moduleState4 = 1;

                        BedSideView8.bed8singleton.BloodPressurePanelBed4.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.BloodPressurePanelBed4.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket4.Visible = false;

                        BedSideView8.insertClicked4 = 0;
                    }

                    // Blood Pressure Secondary Variables Integer
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out SocketConfiguration.diMin8);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out SocketConfiguration.diMax8);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out SocketConfiguration.syMin8);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out SocketConfiguration.syMax8);

                    BedSideView8.bed8singleton.Show();
                    BedSideView8.bed8singleton.Location = this.Location;
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
                        BedSideView1.moduleState1 = 1;

                        BedSideView1.bed1singleton.PulseRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.PulseRatePanelBed1.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket1.Visible = false;

                        BedSideView1.insertClicked1 = 0;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.moduleState2 = 1;

                        BedSideView1.bed1singleton.PulseRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.PulseRatePanelBed2.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket2.Visible = false;

                        BedSideView1.insertClicked2 = 0;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.moduleState3 = 1;

                        BedSideView1.bed1singleton.PulseRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.PulseRatePanelBed3.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket3.Visible = false;

                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.moduleState4 = 1;

                        BedSideView1.bed1singleton.PulseRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.PulseRatePanelBed4.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket4.Visible = false;

                        BedSideView1.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin1);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax1);

                    BedSideView1.bed1singleton.Show();
                    BedSideView1.bed1singleton.Location = this.Location;
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
                        BedSideView2.moduleState1 = 1;

                        BedSideView2.bed2singleton.PulseRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.PulseRatePanelBed1.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket1.Visible = false;

                        BedSideView2.insertClicked1 = 0;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.moduleState2 = 1;

                        BedSideView2.bed2singleton.PulseRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.PulseRatePanelBed2.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket2.Visible = false;

                        BedSideView2.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView2.moduleState3 = 1;

                        BedSideView2.bed2singleton.PulseRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.PulseRatePanelBed3.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket3.Visible = false;

                        BedSideView2.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView2.moduleState4 = 1;

                        BedSideView2.bed2singleton.PulseRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.PulseRatePanelBed4.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket4.Visible = false;

                        BedSideView2.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin2);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax2);

                    BedSideView2.bed2singleton.Show();
                    BedSideView2.bed2singleton.Location = this.Location;
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
                        BedSideView3.moduleState1 = 1;

                        BedSideView3.bed3singleton.PulseRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.PulseRatePanelBed1.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket1.Visible = false;

                        BedSideView3.insertClicked1 = 0;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.moduleState2 = 1;

                        BedSideView3.bed3singleton.PulseRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.PulseRatePanelBed2.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket2.Visible = false;

                        BedSideView3.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.moduleState3 = 1;

                        BedSideView3.bed3singleton.PulseRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.PulseRatePanelBed3.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket3.Visible = false;

                        BedSideView3.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.moduleState4 = 1;

                        BedSideView3.bed3singleton.PulseRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.PulseRatePanelBed4.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket4.Visible = false;

                        BedSideView3.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin3);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax3);

                    BedSideView3.bed3singleton.Show();
                    BedSideView3.bed3singleton.Location = this.Location;
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
                        BedSideView4.moduleState1 = 1;

                        BedSideView4.bed4singleton.PulseRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.PulseRatePanelBed1.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket1.Visible = false;

                        BedSideView4.insertClicked1 = 0;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.moduleState2 = 1;

                        BedSideView4.bed4singleton.PulseRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.PulseRatePanelBed2.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket2.Visible = false;

                        BedSideView4.insertClicked2 = 0;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.moduleState3 = 1;

                        BedSideView4.bed4singleton.PulseRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.PulseRatePanelBed3.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket3.Visible = false;

                        BedSideView4.insertClicked3 = 0;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.moduleState4 = 1;

                        BedSideView4.bed4singleton.PulseRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.PulseRatePanelBed4.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket4.Visible = false;

                        BedSideView4.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin4);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax4);

                    BedSideView4.bed4singleton.Show();
                    BedSideView4.bed4singleton.Location = this.Location;
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
                        BedSideView5.moduleState1 = 1;

                        BedSideView5.bed5singleton.PulseRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.PulseRatePanelBed1.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket1.Visible = false;

                        BedSideView5.insertClicked1 = 0;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.moduleState2 = 1;

                        BedSideView5.bed5singleton.PulseRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.PulseRatePanelBed2.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket2.Visible = false;

                        BedSideView5.insertClicked2 = 0;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.moduleState3 = 1;

                        BedSideView5.bed5singleton.PulseRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.PulseRatePanelBed3.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket3.Visible = false;

                        BedSideView5.insertClicked3 = 0;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.moduleState4 = 1;

                        BedSideView5.bed5singleton.PulseRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.PulseRatePanelBed4.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket4.Visible = false;

                        BedSideView5.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin5);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax5);

                    BedSideView5.bed5singleton.Show();
                    BedSideView5.bed5singleton.Location = this.Location;
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
                        BedSideView6.moduleState1 = 1;

                        BedSideView6.bed6singleton.PulseRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.PulseRatePanelBed1.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket1.Visible = false;

                        BedSideView6.insertClicked1 = 0;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.moduleState2 = 1;

                        BedSideView6.bed6singleton.PulseRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.PulseRatePanelBed2.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket2.Visible = false;

                        BedSideView6.insertClicked2 = 0;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.moduleState3 = 1;

                        BedSideView6.bed6singleton.PulseRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.PulseRatePanelBed3.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket3.Visible = false;

                        BedSideView6.insertClicked3 = 0;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.moduleState4 = 1;

                        BedSideView6.bed6singleton.PulseRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.PulseRatePanelBed4.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket4.Visible = false;

                        BedSideView6.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin6);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax6);

                    BedSideView6.bed6singleton.Show();
                    BedSideView6.bed6singleton.Location = this.Location;
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
                        BedSideView7.moduleState1 = 1;

                        BedSideView7.bed7singleton.PulseRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.PulseRatePanelBed1.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket1.Visible = false;

                        BedSideView7.insertClicked1 = 0;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.moduleState2 = 1;

                        BedSideView7.bed7singleton.PulseRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.PulseRatePanelBed2.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket2.Visible = false;

                        BedSideView7.insertClicked2 = 0;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.moduleState3 = 1;

                        BedSideView7.bed7singleton.PulseRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.PulseRatePanelBed3.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket3.Visible = false;

                        BedSideView7.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.moduleState4 = 1;

                        BedSideView7.bed7singleton.PulseRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.PulseRatePanelBed4.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket4.Visible = false;

                        BedSideView7.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin7);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax7);

                    BedSideView7.bed7singleton.Show();
                    BedSideView7.bed7singleton.Location = this.Location;
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
                        BedSideView8.moduleState1 = 1;

                        BedSideView8.bed8singleton.PulseRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.PulseRatePanelBed1.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket1.Visible = false;

                        BedSideView8.insertClicked1 = 0;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.moduleState2 = 1;

                        BedSideView8.bed8singleton.PulseRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.PulseRatePanelBed2.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket2.Visible = false;

                        BedSideView8.insertClicked2 = 0;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.moduleState3 = 1;

                        BedSideView8.bed8singleton.PulseRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.PulseRatePanelBed3.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket3.Visible = false;

                        BedSideView8.insertClicked3 = 0;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.moduleState4 = 1;

                        BedSideView8.bed8singleton.PulseRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.PulseRatePanelBed4.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket4.Visible = false;

                        BedSideView8.insertClicked4 = 0;
                    }

                    // Pulse Rate Secondary Variables Integer
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out SocketConfiguration.prMin8);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out SocketConfiguration.prMax8);

                    BedSideView8.bed8singleton.Show();
                    BedSideView8.bed8singleton.Location = this.Location;
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
                        BedSideView1.moduleState1 = 1;

                        BedSideView1.bed1singleton.BreathingRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.BreathingRatePanelBed1.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket1.Visible = false;

                        BedSideView1.insertClicked1 = 0;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.moduleState2 = 1;

                        BedSideView1.bed1singleton.BreathingRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.BreathingRatePanelBed2.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket2.Visible = false;

                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.moduleState3 = 1;

                        BedSideView1.bed1singleton.BreathingRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.BreathingRatePanelBed3.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket3.Visible = false;

                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.moduleState4 = 1;

                        BedSideView1.bed1singleton.BreathingRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.BreathingRatePanelBed4.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket4.Visible = false;

                        BedSideView1.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin1);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax1);

                    BedSideView1.bed1singleton.Show();
                    BedSideView1.bed1singleton.Location = this.Location;
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
                        BedSideView2.moduleState1 = 1;

                        BedSideView2.bed2singleton.BreathingRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.BreathingRatePanelBed1.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket1.Visible = false;

                        BedSideView2.insertClicked1 = 0;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.moduleState2 = 1;

                        BedSideView2.bed2singleton.BreathingRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.BreathingRatePanelBed2.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket2.Visible = false;

                        BedSideView2.insertClicked2 = 0;
                    }
                    else if (BedSideView2.insertClicked3 == 1)
                    {
                        BedSideView2.moduleState3 = 1;

                        BedSideView2.bed2singleton.BreathingRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.BreathingRatePanelBed3.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket3.Visible = false;

                        BedSideView2.insertClicked3 = 0;
                    }
                    else if (BedSideView2.insertClicked4 == 1)
                    {
                        BedSideView2.moduleState4 = 1;

                        BedSideView2.bed2singleton.BreathingRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.BreathingRatePanelBed4.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket4.Visible = false;

                        BedSideView2.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin2);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax2);

                    BedSideView2.bed2singleton.Show();
                    BedSideView2.bed2singleton.Location = this.Location;
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
                        BedSideView3.moduleState1 = 1;

                        BedSideView3.bed3singleton.BreathingRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.BreathingRatePanelBed1.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket1.Visible = false;

                        BedSideView3.insertClicked1 = 0;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.moduleState2 = 1;

                        BedSideView3.bed3singleton.BreathingRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.BreathingRatePanelBed2.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket2.Visible = false;

                        BedSideView3.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.moduleState3 = 1;

                        BedSideView3.bed3singleton.BreathingRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.BreathingRatePanelBed3.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket3.Visible = false;

                        BedSideView3.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.moduleState4 = 1;

                        BedSideView3.bed3singleton.BreathingRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.BreathingRatePanelBed4.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket4.Visible = false;

                        BedSideView3.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin3);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax3);

                    BedSideView3.bed3singleton.Show();
                    BedSideView3.bed3singleton.Location = this.Location;
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
                        BedSideView4.moduleState1 = 1;

                        BedSideView4.bed4singleton.BreathingRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.BreathingRatePanelBed1.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket1.Visible = false;

                        BedSideView4.insertClicked1 = 0;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.moduleState2 = 1;

                        BedSideView4.bed4singleton.BreathingRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.BreathingRatePanelBed2.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket2.Visible = false;

                        BedSideView4.insertClicked2 = 0;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.moduleState3 = 1;

                        BedSideView4.bed4singleton.BreathingRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.BreathingRatePanelBed3.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket3.Visible = false;

                        BedSideView4.insertClicked3 = 0;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.moduleState4 = 1;

                        BedSideView4.bed4singleton.BreathingRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.BreathingRatePanelBed4.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket4.Visible = false;

                        BedSideView4.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin4);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax4);

                    BedSideView4.bed4singleton.Show();
                    BedSideView4.bed4singleton.Location = this.Location;
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
                        BedSideView5.moduleState1 = 1;

                        BedSideView5.bed5singleton.BreathingRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.BreathingRatePanelBed1.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket1.Visible = false;

                        BedSideView5.insertClicked1 = 0;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.moduleState2 = 1;

                        BedSideView5.bed5singleton.BreathingRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.BreathingRatePanelBed2.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket2.Visible = false;

                        BedSideView5.insertClicked2 = 0;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.moduleState3 = 1;

                        BedSideView5.bed5singleton.BreathingRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.BreathingRatePanelBed3.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket3.Visible = false;

                        BedSideView5.insertClicked3 = 0;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.moduleState4 = 1;

                        BedSideView5.bed5singleton.BreathingRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.BreathingRatePanelBed4.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket4.Visible = false;

                        BedSideView5.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin5);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax5);

                    BedSideView5.bed5singleton.Show();
                    BedSideView5.bed5singleton.Location = this.Location;
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
                        BedSideView6.moduleState1 = 1;

                        BedSideView6.bed6singleton.BreathingRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.BreathingRatePanelBed1.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket1.Visible = false;

                        BedSideView6.insertClicked1 = 0;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.moduleState2 = 1;

                        BedSideView6.bed6singleton.BreathingRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.BreathingRatePanelBed2.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket2.Visible = false;

                        BedSideView6.insertClicked2 = 0;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.moduleState3 = 1;

                        BedSideView6.bed6singleton.BreathingRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.BreathingRatePanelBed3.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket3.Visible = false;

                        BedSideView6.insertClicked3 = 0;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.moduleState4 = 1;

                        BedSideView6.bed6singleton.BreathingRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.BreathingRatePanelBed4.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket4.Visible = false;

                        BedSideView6.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin6);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax6);

                    BedSideView6.bed6singleton.Show();
                    BedSideView6.bed6singleton.Location = this.Location;
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
                        BedSideView7.moduleState1 = 1;

                        BedSideView7.bed7singleton.BreathingRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.BreathingRatePanelBed1.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket1.Visible = false;

                        BedSideView7.insertClicked1 = 0;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.moduleState2 = 1;

                        BedSideView7.bed7singleton.BreathingRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.BreathingRatePanelBed2.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket2.Visible = false;

                        BedSideView7.insertClicked2 = 0;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.moduleState3 = 1;

                        BedSideView7.bed7singleton.BreathingRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.BreathingRatePanelBed3.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket3.Visible = false;

                        BedSideView7.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView7.moduleState4 = 1;

                        BedSideView7.bed7singleton.BreathingRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.BreathingRatePanelBed4.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket4.Visible = false;

                        BedSideView7.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin7);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax7);

                    BedSideView7.bed7singleton.Show();
                    BedSideView7.bed7singleton.Location = this.Location;
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
                        BedSideView8.moduleState1 = 1;

                        BedSideView8.bed8singleton.BreathingRatePanelBed1.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.BreathingRatePanelBed1.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket1.Visible = false;

                        BedSideView8.insertClicked1 = 0;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.moduleState2 = 1;

                        BedSideView8.bed8singleton.BreathingRatePanelBed2.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.BreathingRatePanelBed2.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket2.Visible = false;

                        BedSideView8.insertClicked2 = 0;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.moduleState3 = 1;

                        BedSideView8.bed8singleton.BreathingRatePanelBed3.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.BreathingRatePanelBed3.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket3.Visible = false;

                        BedSideView8.insertClicked3 = 0;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.moduleState4 = 1;

                        BedSideView8.bed8singleton.BreathingRatePanelBed4.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.BreathingRatePanelBed4.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket4.Visible = false;

                        BedSideView8.insertClicked4 = 0;
                    }

                    // Breathing Rate Secondary Variables Integer
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out SocketConfiguration.brMin8);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out SocketConfiguration.brMax8);

                    BedSideView8.bed8singleton.Show();
                    BedSideView8.bed8singleton.Location = this.Location;
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
                        BedSideView1.moduleState1 = 1;

                        BedSideView1.bed1singleton.TemperaturePanelBed1.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.TemperaturePanelBed1.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket1.Visible = false;

                        BedSideView1.insertClicked1 = 0;
                    }
                    else if (BedSideView1.insertClicked2 == 1)
                    {
                        BedSideView1.moduleState2 = 1;

                        BedSideView1.bed1singleton.TemperaturePanelBed2.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.TemperaturePanelBed2.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket2.Visible = false;

                        BedSideView1.insertClicked2 = 0;
                    }
                    else if (BedSideView1.insertClicked3 == 1)
                    {
                        BedSideView1.moduleState3 = 1;

                        BedSideView1.bed1singleton.TemperaturePanelBed3.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.TemperaturePanelBed3.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket3.Visible = false;

                        BedSideView1.insertClicked3 = 0;
                    }
                    else if (BedSideView1.insertClicked4 == 1)
                    {
                        BedSideView1.moduleState4 = 1;

                        BedSideView1.bed1singleton.TemperaturePanelBed4.Dock = DockStyle.Fill;
                        BedSideView1.bed1singleton.TemperaturePanelBed4.Visible = true;
                        BedSideView1.bed1singleton.InsertASocket4.Visible = false;

                        BedSideView1.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin1);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax1);

                    BedSideView1.bed1singleton.Show();
                    BedSideView1.bed1singleton.Location = this.Location;
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
                        BedSideView2.moduleState1 = 1;

                        BedSideView2.bed2singleton.TemperaturePanelBed1.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.TemperaturePanelBed1.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket1.Visible = false;

                        BedSideView2.insertClicked1 = 0;
                    }
                    else if (BedSideView2.insertClicked2 == 1)
                    {
                        BedSideView2.moduleState2 = 1;

                        BedSideView2.bed2singleton.TemperaturePanelBed2.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.TemperaturePanelBed2.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket2.Visible = false;

                        BedSideView2.insertClicked2 = 0;
                    }
                    else if (BedSideView2.insertClicked3 == 1)
                    {
                        BedSideView2.moduleState3 = 1;

                        BedSideView2.bed2singleton.TemperaturePanelBed3.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.TemperaturePanelBed3.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket3.Visible = false;

                        BedSideView2.insertClicked3 = 0;
                    }
                    else if (BedSideView2.insertClicked4 == 1)
                    {
                        BedSideView2.moduleState4 = 1;

                        BedSideView2.bed2singleton.TemperaturePanelBed4.Dock = DockStyle.Fill;
                        BedSideView2.bed2singleton.TemperaturePanelBed4.Visible = true;
                        BedSideView2.bed2singleton.InsertASocket4.Visible = false;

                        BedSideView2.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin2);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax2);

                    BedSideView2.bed2singleton.Show();
                    BedSideView2.bed2singleton.Location = this.Location;
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
                        BedSideView3.moduleState1 = 1;

                        BedSideView3.bed3singleton.TemperaturePanelBed1.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.TemperaturePanelBed1.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket1.Visible = false;

                        BedSideView3.insertClicked1 = 0;
                    }
                    else if (BedSideView3.insertClicked2 == 1)
                    {
                        BedSideView3.moduleState2 = 1;

                        BedSideView3.bed3singleton.TemperaturePanelBed2.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.TemperaturePanelBed2.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket2.Visible = false;

                        BedSideView3.insertClicked2 = 0;
                    }
                    else if (BedSideView3.insertClicked3 == 1)
                    {
                        BedSideView3.moduleState3 = 1;

                        BedSideView3.bed3singleton.TemperaturePanelBed3.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.TemperaturePanelBed3.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket3.Visible = false;

                        BedSideView3.insertClicked3 = 0;
                    }
                    else if (BedSideView3.insertClicked4 == 1)
                    {
                        BedSideView3.moduleState4 = 1;

                        BedSideView3.bed3singleton.TemperaturePanelBed4.Dock = DockStyle.Fill;
                        BedSideView3.bed3singleton.TemperaturePanelBed4.Visible = true;
                        BedSideView3.bed3singleton.InsertASocket4.Visible = false;

                        BedSideView3.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin3);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax3);

                    BedSideView3.bed3singleton.Show();
                    BedSideView3.bed3singleton.Location = this.Location;
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
                        BedSideView4.moduleState1 = 1;

                        BedSideView4.bed4singleton.TemperaturePanelBed1.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.TemperaturePanelBed1.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket1.Visible = false;

                        BedSideView4.insertClicked1 = 0;
                    }
                    else if (BedSideView4.insertClicked2 == 1)
                    {
                        BedSideView4.moduleState2 = 1;

                        BedSideView4.bed4singleton.TemperaturePanelBed2.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.TemperaturePanelBed2.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket2.Visible = false;

                        BedSideView4.insertClicked2 = 0;
                    }
                    else if (BedSideView4.insertClicked3 == 1)
                    {
                        BedSideView4.moduleState3 = 1;

                        BedSideView4.bed4singleton.TemperaturePanelBed3.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.TemperaturePanelBed3.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket3.Visible = false;

                        BedSideView4.insertClicked3 = 0;
                    }
                    else if (BedSideView4.insertClicked4 == 1)
                    {
                        BedSideView4.moduleState4 = 1;

                        BedSideView4.bed4singleton.TemperaturePanelBed4.Dock = DockStyle.Fill;
                        BedSideView4.bed4singleton.TemperaturePanelBed4.Visible = true;
                        BedSideView4.bed4singleton.InsertASocket4.Visible = false;

                        BedSideView4.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin4);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax4);

                    BedSideView4.bed4singleton.Show();
                    BedSideView4.bed4singleton.Location = this.Location;
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
                        BedSideView5.moduleState1 = 1;

                        BedSideView5.bed5singleton.TemperaturePanelBed1.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.TemperaturePanelBed1.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket1.Visible = false;

                        BedSideView5.insertClicked1 = 0;
                    }
                    else if (BedSideView5.insertClicked2 == 1)
                    {
                        BedSideView5.moduleState2 = 1;

                        BedSideView5.bed5singleton.TemperaturePanelBed2.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.TemperaturePanelBed2.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket2.Visible = false;

                        BedSideView5.insertClicked2 = 0;
                    }
                    else if (BedSideView5.insertClicked3 == 1)
                    {
                        BedSideView5.moduleState3 = 1;

                        BedSideView5.bed5singleton.TemperaturePanelBed3.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.TemperaturePanelBed3.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket3.Visible = false;

                        BedSideView5.insertClicked3 = 0;
                    }
                    else if (BedSideView5.insertClicked4 == 1)
                    {
                        BedSideView5.moduleState4 = 1;

                        BedSideView5.bed5singleton.TemperaturePanelBed4.Dock = DockStyle.Fill;
                        BedSideView5.bed5singleton.TemperaturePanelBed4.Visible = true;
                        BedSideView5.bed5singleton.InsertASocket4.Visible = false;

                        BedSideView5.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin5);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax5);

                    BedSideView5.bed5singleton.Show();
                    BedSideView5.bed5singleton.Location = this.Location;
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
                        BedSideView6.moduleState1 = 1;

                        BedSideView6.bed6singleton.TemperaturePanelBed1.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.TemperaturePanelBed1.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket1.Visible = false;

                        BedSideView6.insertClicked1 = 0;
                    }
                    else if (BedSideView6.insertClicked2 == 1)
                    {
                        BedSideView6.moduleState2 = 1;

                        BedSideView6.bed6singleton.TemperaturePanelBed2.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.TemperaturePanelBed2.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket2.Visible = false;

                        BedSideView6.insertClicked2 = 0;
                    }
                    else if (BedSideView6.insertClicked3 == 1)
                    {
                        BedSideView6.moduleState3 = 1;

                        BedSideView6.bed6singleton.TemperaturePanelBed3.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.TemperaturePanelBed3.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket3.Visible = false;

                        BedSideView6.insertClicked3 = 0;
                    }
                    else if (BedSideView6.insertClicked4 == 1)
                    {
                        BedSideView6.moduleState4 = 1;

                        BedSideView6.bed6singleton.TemperaturePanelBed4.Dock = DockStyle.Fill;
                        BedSideView6.bed6singleton.TemperaturePanelBed4.Visible = true;
                        BedSideView6.bed6singleton.InsertASocket4.Visible = false;

                        BedSideView6.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin6);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax6);

                    BedSideView6.bed6singleton.Show();
                    BedSideView6.bed6singleton.Location = this.Location;
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
                        BedSideView7.moduleState1 = 1;

                        BedSideView7.bed7singleton.TemperaturePanelBed1.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.TemperaturePanelBed1.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket1.Visible = false;

                        BedSideView7.insertClicked1 = 0;
                    }
                    else if (BedSideView7.insertClicked2 == 1)
                    {
                        BedSideView7.moduleState2 = 1;

                        BedSideView7.bed7singleton.TemperaturePanelBed2.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.TemperaturePanelBed2.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket2.Visible = false;

                        BedSideView7.insertClicked2 = 0;
                    }
                    else if (BedSideView7.insertClicked3 == 1)
                    {
                        BedSideView7.moduleState3 = 1;

                        BedSideView7.bed7singleton.TemperaturePanelBed3.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.TemperaturePanelBed3.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket3.Visible = false;

                        BedSideView7.insertClicked3 = 0;
                    }
                    else if (BedSideView7.insertClicked4 == 1)
                    {
                        BedSideView7.moduleState4 = 1;

                        BedSideView7.bed7singleton.TemperaturePanelBed4.Dock = DockStyle.Fill;
                        BedSideView7.bed7singleton.TemperaturePanelBed4.Visible = true;
                        BedSideView7.bed7singleton.InsertASocket4.Visible = false;

                        BedSideView7.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin7);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax7);

                    BedSideView7.bed7singleton.Show();
                    BedSideView7.bed7singleton.Location = this.Location;
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
                        BedSideView8.moduleState1 = 1;

                        BedSideView8.bed8singleton.TemperaturePanelBed1.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.TemperaturePanelBed1.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket1.Visible = false;

                        BedSideView8.insertClicked1 = 0;
                    }
                    else if (BedSideView8.insertClicked2 == 1)
                    {
                        BedSideView8.moduleState2 = 1;

                        BedSideView8.bed8singleton.TemperaturePanelBed2.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.TemperaturePanelBed2.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket2.Visible = false;

                        BedSideView8.insertClicked2 = 0;
                    }
                    else if (BedSideView8.insertClicked3 == 1)
                    {
                        BedSideView8.moduleState3 = 1;

                        BedSideView8.bed8singleton.TemperaturePanelBed3.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.TemperaturePanelBed3.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket3.Visible = false;

                        BedSideView8.insertClicked3 = 0;
                    }
                    else if (BedSideView8.insertClicked4 == 1)
                    {
                        BedSideView8.moduleState4 = 1;

                        BedSideView8.bed8singleton.TemperaturePanelBed4.Dock = DockStyle.Fill;
                        BedSideView8.bed8singleton.TemperaturePanelBed4.Visible = true;
                        BedSideView8.bed8singleton.InsertASocket4.Visible = false;

                        BedSideView8.insertClicked4 = 0;
                    }

                    // Temperature Secondary Variables Integer
                    int.TryParse(Temperature_Minimum_TextBox.Text, out SocketConfiguration.tpMin8);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out SocketConfiguration.tpMax8);

                    BedSideView8.bed8singleton.Show();
                    BedSideView8.bed8singleton.Location = this.Location;
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

            #region BedSideView1 TextBox.Text Assignment
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.syMin1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.syMin1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.syMin1.ToString();

            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.syMax1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.syMax1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.syMax1.ToString();

            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.diMin1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.diMin1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.diMin1.ToString();

            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.diMax1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.diMax1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.diMax1.ToString();

            BedSideView1.bed1singleton.BreathingRate_Minimum_Text.Text = SocketConfiguration.brMin1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Minimum_Text2.Text = SocketConfiguration.brMin1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Minimum_Text3.Text = SocketConfiguration.brMin1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Minimum_Text4.Text = SocketConfiguration.brMin1.ToString();

            BedSideView1.bed1singleton.BreathingRate_Maximum_Text.Text = SocketConfiguration.brMax1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Maximum_Text2.Text = SocketConfiguration.brMax1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Maximum_Text3.Text = SocketConfiguration.brMax1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Maximum_Text4.Text = SocketConfiguration.brMax1.ToString();

            BedSideView1.bed1singleton.PulseRate_Minimum_Text.Text = SocketConfiguration.prMin1.ToString();
            BedSideView1.bed1singleton.PulseRate_Minimum_Text2.Text = SocketConfiguration.prMin1.ToString();
            BedSideView1.bed1singleton.PulseRate_Minimum_Text3.Text = SocketConfiguration.prMin1.ToString();
            BedSideView1.bed1singleton.PulseRate_Minimum_Text4.Text = SocketConfiguration.prMin1.ToString();

            BedSideView1.bed1singleton.PulseRate_Maximum_Text.Text = SocketConfiguration.prMax1.ToString();
            BedSideView1.bed1singleton.PulseRate_Maximum_Text2.Text = SocketConfiguration.prMax1.ToString();
            BedSideView1.bed1singleton.PulseRate_Maximum_Text3.Text = SocketConfiguration.prMax1.ToString();
            BedSideView1.bed1singleton.PulseRate_Maximum_Text4.Text = SocketConfiguration.prMax1.ToString();

            BedSideView1.bed1singleton.Temperature_Minimum_Text.Text = SocketConfiguration.tpMin1.ToString();
            BedSideView1.bed1singleton.Temperature_Minimum_Text2.Text = SocketConfiguration.tpMin1.ToString();
            BedSideView1.bed1singleton.Temperature_Minimum_Text3.Text = SocketConfiguration.tpMin1.ToString();
            BedSideView1.bed1singleton.Temperature_Minimum_Text4.Text = SocketConfiguration.tpMin1.ToString();

            BedSideView1.bed1singleton.Temperature_Maximum_Text.Text = SocketConfiguration.tpMax1.ToString();
            BedSideView1.bed1singleton.Temperature_Maximum_Text2.Text = SocketConfiguration.tpMax1.ToString();
            BedSideView1.bed1singleton.Temperature_Maximum_Text3.Text = SocketConfiguration.tpMax1.ToString();
            BedSideView1.bed1singleton.Temperature_Maximum_Text4.Text = SocketConfiguration.tpMax1.ToString();
            #endregion

            #region BedSideView2 TextBox.Text Assignment
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.syMin2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.syMin2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.syMin2.ToString();

            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.syMax2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.syMax2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.syMax2.ToString();

            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.diMin2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.diMin2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.diMin2.ToString();

            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.diMax2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.diMax2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.diMax2.ToString();

            BedSideView2.bed2singleton.BreathingRate_Minimum_Text.Text = SocketConfiguration.brMin2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Minimum_Text2.Text = SocketConfiguration.brMin2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Minimum_Text3.Text = SocketConfiguration.brMin2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Minimum_Text4.Text = SocketConfiguration.brMin2.ToString();

            BedSideView2.bed2singleton.BreathingRate_Maximum_Text.Text = SocketConfiguration.brMax2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Maximum_Text2.Text = SocketConfiguration.brMax2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Maximum_Text3.Text = SocketConfiguration.brMax2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Maximum_Text4.Text = SocketConfiguration.brMax2.ToString();

            BedSideView2.bed2singleton.PulseRate_Minimum_Text.Text = SocketConfiguration.prMin2.ToString();
            BedSideView2.bed2singleton.PulseRate_Minimum_Text2.Text = SocketConfiguration.prMin2.ToString();
            BedSideView2.bed2singleton.PulseRate_Minimum_Text3.Text = SocketConfiguration.prMin2.ToString();
            BedSideView2.bed2singleton.PulseRate_Minimum_Text4.Text = SocketConfiguration.prMin2.ToString();

            BedSideView2.bed2singleton.PulseRate_Maximum_Text.Text = SocketConfiguration.prMax2.ToString();
            BedSideView2.bed2singleton.PulseRate_Maximum_Text2.Text = SocketConfiguration.prMax2.ToString();
            BedSideView2.bed2singleton.PulseRate_Maximum_Text3.Text = SocketConfiguration.prMax2.ToString();
            BedSideView2.bed2singleton.PulseRate_Maximum_Text4.Text = SocketConfiguration.prMax2.ToString();

            BedSideView2.bed2singleton.Temperature_Minimum_Text.Text = SocketConfiguration.tpMin2.ToString();
            BedSideView2.bed2singleton.Temperature_Minimum_Text2.Text = SocketConfiguration.tpMin2.ToString();
            BedSideView2.bed2singleton.Temperature_Minimum_Text3.Text = SocketConfiguration.tpMin2.ToString();
            BedSideView2.bed2singleton.Temperature_Minimum_Text4.Text = SocketConfiguration.tpMin2.ToString();

            BedSideView2.bed2singleton.Temperature_Maximum_Text.Text = SocketConfiguration.tpMax2.ToString();
            BedSideView2.bed2singleton.Temperature_Maximum_Text2.Text = SocketConfiguration.tpMax2.ToString();
            BedSideView2.bed2singleton.Temperature_Maximum_Text3.Text = SocketConfiguration.tpMax2.ToString();
            BedSideView2.bed2singleton.Temperature_Maximum_Text4.Text = SocketConfiguration.tpMax2.ToString();
            #endregion

            #region BedSideView3 TextBox.Text Assignment
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.syMin3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.syMin3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.syMin3.ToString();

            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.syMax3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.syMax3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.syMax3.ToString();

            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.diMin3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.diMin3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.diMin3.ToString();

            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.diMax3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.diMax3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.diMax3.ToString();

            BedSideView3.bed3singleton.BreathingRate_Minimum_Text.Text = SocketConfiguration.brMin3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Minimum_Text2.Text = SocketConfiguration.brMin3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Minimum_Text3.Text = SocketConfiguration.brMin3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Minimum_Text4.Text = SocketConfiguration.brMin3.ToString();

            BedSideView3.bed3singleton.BreathingRate_Maximum_Text.Text = SocketConfiguration.brMax3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Maximum_Text2.Text = SocketConfiguration.brMax3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Maximum_Text3.Text = SocketConfiguration.brMax3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Maximum_Text4.Text = SocketConfiguration.brMax3.ToString();

            BedSideView3.bed3singleton.PulseRate_Minimum_Text.Text = SocketConfiguration.prMin3.ToString();
            BedSideView3.bed3singleton.PulseRate_Minimum_Text2.Text = SocketConfiguration.prMin3.ToString();
            BedSideView3.bed3singleton.PulseRate_Minimum_Text3.Text = SocketConfiguration.prMin3.ToString();
            BedSideView3.bed3singleton.PulseRate_Minimum_Text4.Text = SocketConfiguration.prMin3.ToString();

            BedSideView3.bed3singleton.PulseRate_Maximum_Text.Text = SocketConfiguration.prMax3.ToString();
            BedSideView3.bed3singleton.PulseRate_Maximum_Text2.Text = SocketConfiguration.prMax3.ToString();
            BedSideView3.bed3singleton.PulseRate_Maximum_Text3.Text = SocketConfiguration.prMax3.ToString();
            BedSideView3.bed3singleton.PulseRate_Maximum_Text4.Text = SocketConfiguration.prMax3.ToString();

            BedSideView3.bed3singleton.Temperature_Minimum_Text.Text = SocketConfiguration.tpMin3.ToString();
            BedSideView3.bed3singleton.Temperature_Minimum_Text2.Text = SocketConfiguration.tpMin3.ToString();
            BedSideView3.bed3singleton.Temperature_Minimum_Text3.Text = SocketConfiguration.tpMin3.ToString();
            BedSideView3.bed3singleton.Temperature_Minimum_Text4.Text = SocketConfiguration.tpMin3.ToString();

            BedSideView3.bed3singleton.Temperature_Maximum_Text.Text = SocketConfiguration.tpMax3.ToString();
            BedSideView3.bed3singleton.Temperature_Maximum_Text2.Text = SocketConfiguration.tpMax3.ToString();
            BedSideView3.bed3singleton.Temperature_Maximum_Text3.Text = SocketConfiguration.tpMax3.ToString();
            BedSideView3.bed3singleton.Temperature_Maximum_Text4.Text = SocketConfiguration.tpMax3.ToString();
            #endregion

            #region BedSideView4 TextBox.Text Assignment
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.syMin4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.syMin4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.syMin4.ToString();

            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.syMax4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.syMax4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.syMax4.ToString();

            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.diMin4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.diMin4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.diMin4.ToString();

            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.diMax4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.diMax4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.diMax4.ToString();

            BedSideView4.bed4singleton.BreathingRate_Minimum_Text.Text = SocketConfiguration.brMin4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Minimum_Text2.Text = SocketConfiguration.brMin4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Minimum_Text3.Text = SocketConfiguration.brMin4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Minimum_Text4.Text = SocketConfiguration.brMin4.ToString();

            BedSideView4.bed4singleton.BreathingRate_Maximum_Text.Text = SocketConfiguration.brMax4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Maximum_Text2.Text = SocketConfiguration.brMax4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Maximum_Text3.Text = SocketConfiguration.brMax4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Maximum_Text4.Text = SocketConfiguration.brMax4.ToString();

            BedSideView4.bed4singleton.PulseRate_Minimum_Text.Text = SocketConfiguration.prMin4.ToString();
            BedSideView4.bed4singleton.PulseRate_Minimum_Text2.Text = SocketConfiguration.prMin4.ToString();
            BedSideView4.bed4singleton.PulseRate_Minimum_Text3.Text = SocketConfiguration.prMin4.ToString();
            BedSideView4.bed4singleton.PulseRate_Minimum_Text4.Text = SocketConfiguration.prMin4.ToString();

            BedSideView4.bed4singleton.PulseRate_Maximum_Text.Text = SocketConfiguration.prMax4.ToString();
            BedSideView4.bed4singleton.PulseRate_Maximum_Text2.Text = SocketConfiguration.prMax4.ToString();
            BedSideView4.bed4singleton.PulseRate_Maximum_Text3.Text = SocketConfiguration.prMax4.ToString();
            BedSideView4.bed4singleton.PulseRate_Maximum_Text4.Text = SocketConfiguration.prMax4.ToString();

            BedSideView4.bed4singleton.Temperature_Minimum_Text.Text = SocketConfiguration.tpMin4.ToString();
            BedSideView4.bed4singleton.Temperature_Minimum_Text2.Text = SocketConfiguration.tpMin4.ToString();
            BedSideView4.bed4singleton.Temperature_Minimum_Text3.Text = SocketConfiguration.tpMin4.ToString();
            BedSideView4.bed4singleton.Temperature_Minimum_Text4.Text = SocketConfiguration.tpMin4.ToString();

            BedSideView4.bed4singleton.Temperature_Maximum_Text.Text = SocketConfiguration.tpMax4.ToString();
            BedSideView4.bed4singleton.Temperature_Maximum_Text2.Text = SocketConfiguration.tpMax4.ToString();
            BedSideView4.bed4singleton.Temperature_Maximum_Text3.Text = SocketConfiguration.tpMax4.ToString();
            BedSideView4.bed4singleton.Temperature_Maximum_Text4.Text = SocketConfiguration.tpMax4.ToString();
            #endregion

            #region BedSideView5 TextBox.Text Assignment
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.syMin5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.syMin5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.syMin5.ToString();

            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.syMax5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.syMax5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.syMax5.ToString();

            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.diMin5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.diMin5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.diMin5.ToString();

            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.diMax5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.diMax5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.diMax5.ToString();

            BedSideView5.bed5singleton.BreathingRate_Minimum_Text.Text = SocketConfiguration.brMin5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Minimum_Text2.Text = SocketConfiguration.brMin5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Minimum_Text3.Text = SocketConfiguration.brMin5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Minimum_Text4.Text = SocketConfiguration.brMin5.ToString();

            BedSideView5.bed5singleton.BreathingRate_Maximum_Text.Text = SocketConfiguration.brMax5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Maximum_Text2.Text = SocketConfiguration.brMax5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Maximum_Text3.Text = SocketConfiguration.brMax5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Maximum_Text4.Text = SocketConfiguration.brMax5.ToString();

            BedSideView5.bed5singleton.PulseRate_Minimum_Text.Text = SocketConfiguration.prMin5.ToString();
            BedSideView5.bed5singleton.PulseRate_Minimum_Text2.Text = SocketConfiguration.prMin5.ToString();
            BedSideView5.bed5singleton.PulseRate_Minimum_Text3.Text = SocketConfiguration.prMin5.ToString();
            BedSideView5.bed5singleton.PulseRate_Minimum_Text4.Text = SocketConfiguration.prMin5.ToString();

            BedSideView5.bed5singleton.PulseRate_Maximum_Text.Text = SocketConfiguration.prMax5.ToString();
            BedSideView5.bed5singleton.PulseRate_Maximum_Text2.Text = SocketConfiguration.prMax5.ToString();
            BedSideView5.bed5singleton.PulseRate_Maximum_Text3.Text = SocketConfiguration.prMax5.ToString();
            BedSideView5.bed5singleton.PulseRate_Maximum_Text4.Text = SocketConfiguration.prMax5.ToString();

            BedSideView5.bed5singleton.Temperature_Minimum_Text.Text = SocketConfiguration.tpMin5.ToString();
            BedSideView5.bed5singleton.Temperature_Minimum_Text2.Text = SocketConfiguration.tpMin5.ToString();
            BedSideView5.bed5singleton.Temperature_Minimum_Text3.Text = SocketConfiguration.tpMin5.ToString();
            BedSideView5.bed5singleton.Temperature_Minimum_Text4.Text = SocketConfiguration.tpMin5.ToString();

            BedSideView5.bed5singleton.Temperature_Maximum_Text.Text = SocketConfiguration.tpMax5.ToString();
            BedSideView5.bed5singleton.Temperature_Maximum_Text2.Text = SocketConfiguration.tpMax5.ToString();
            BedSideView5.bed5singleton.Temperature_Maximum_Text3.Text = SocketConfiguration.tpMax5.ToString();
            BedSideView5.bed5singleton.Temperature_Maximum_Text4.Text = SocketConfiguration.tpMax5.ToString();
            #endregion

            #region BedSideView6 TextBox.Text Assignment
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.syMin6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.syMin6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.syMin6.ToString();

            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.syMax6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.syMax6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.syMax6.ToString();

            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.diMin6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.diMin6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.diMin6.ToString();

            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.diMax6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.diMax6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.diMax6.ToString();

            BedSideView6.bed6singleton.BreathingRate_Minimum_Text.Text = SocketConfiguration.brMin6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Minimum_Text2.Text = SocketConfiguration.brMin6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Minimum_Text3.Text = SocketConfiguration.brMin6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Minimum_Text4.Text = SocketConfiguration.brMin6.ToString();

            BedSideView6.bed6singleton.BreathingRate_Maximum_Text.Text = SocketConfiguration.brMax6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Maximum_Text2.Text = SocketConfiguration.brMax6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Maximum_Text3.Text = SocketConfiguration.brMax6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Maximum_Text4.Text = SocketConfiguration.brMax6.ToString();

            BedSideView6.bed6singleton.PulseRate_Minimum_Text.Text = SocketConfiguration.prMin6.ToString();
            BedSideView6.bed6singleton.PulseRate_Minimum_Text2.Text = SocketConfiguration.prMin6.ToString();
            BedSideView6.bed6singleton.PulseRate_Minimum_Text3.Text = SocketConfiguration.prMin6.ToString();
            BedSideView6.bed6singleton.PulseRate_Minimum_Text4.Text = SocketConfiguration.prMin6.ToString();

            BedSideView6.bed6singleton.PulseRate_Maximum_Text.Text = SocketConfiguration.prMax6.ToString();
            BedSideView6.bed6singleton.PulseRate_Maximum_Text2.Text = SocketConfiguration.prMax6.ToString();
            BedSideView6.bed6singleton.PulseRate_Maximum_Text3.Text = SocketConfiguration.prMax6.ToString();
            BedSideView6.bed6singleton.PulseRate_Maximum_Text4.Text = SocketConfiguration.prMax6.ToString();

            BedSideView6.bed6singleton.Temperature_Minimum_Text.Text = SocketConfiguration.tpMin6.ToString();
            BedSideView6.bed6singleton.Temperature_Minimum_Text2.Text = SocketConfiguration.tpMin6.ToString();
            BedSideView6.bed6singleton.Temperature_Minimum_Text3.Text = SocketConfiguration.tpMin6.ToString();
            BedSideView6.bed6singleton.Temperature_Minimum_Text4.Text = SocketConfiguration.tpMin6.ToString();

            BedSideView6.bed6singleton.Temperature_Maximum_Text.Text = SocketConfiguration.tpMax6.ToString();
            BedSideView6.bed6singleton.Temperature_Maximum_Text2.Text = SocketConfiguration.tpMax6.ToString();
            BedSideView6.bed6singleton.Temperature_Maximum_Text3.Text = SocketConfiguration.tpMax6.ToString();
            BedSideView6.bed6singleton.Temperature_Maximum_Text4.Text = SocketConfiguration.tpMax6.ToString();
            #endregion

            #region BedSideView7 TextBox.Text Assignment
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.syMin7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.syMin7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.syMin7.ToString();

            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.syMax7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.syMax7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.syMax7.ToString();

            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.diMin7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.diMin7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.diMin7.ToString();

            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.diMax7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.diMax7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.diMax7.ToString();

            BedSideView7.bed7singleton.BreathingRate_Minimum_Text.Text = SocketConfiguration.brMin7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Minimum_Text2.Text = SocketConfiguration.brMin7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Minimum_Text3.Text = SocketConfiguration.brMin7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Minimum_Text4.Text = SocketConfiguration.brMin7.ToString();

            BedSideView7.bed7singleton.BreathingRate_Maximum_Text.Text = SocketConfiguration.brMax7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Maximum_Text2.Text = SocketConfiguration.brMax7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Maximum_Text3.Text = SocketConfiguration.brMax7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Maximum_Text4.Text = SocketConfiguration.brMax7.ToString();

            BedSideView7.bed7singleton.PulseRate_Minimum_Text.Text = SocketConfiguration.prMin7.ToString();
            BedSideView7.bed7singleton.PulseRate_Minimum_Text2.Text = SocketConfiguration.prMin7.ToString();
            BedSideView7.bed7singleton.PulseRate_Minimum_Text3.Text = SocketConfiguration.prMin7.ToString();
            BedSideView7.bed7singleton.PulseRate_Minimum_Text4.Text = SocketConfiguration.prMin7.ToString();

            BedSideView7.bed7singleton.PulseRate_Maximum_Text.Text = SocketConfiguration.prMax7.ToString();
            BedSideView7.bed7singleton.PulseRate_Maximum_Text2.Text = SocketConfiguration.prMax7.ToString();
            BedSideView7.bed7singleton.PulseRate_Maximum_Text3.Text = SocketConfiguration.prMax7.ToString();
            BedSideView7.bed7singleton.PulseRate_Maximum_Text4.Text = SocketConfiguration.prMax7.ToString();

            BedSideView7.bed7singleton.Temperature_Minimum_Text.Text = SocketConfiguration.tpMin7.ToString();
            BedSideView7.bed7singleton.Temperature_Minimum_Text2.Text = SocketConfiguration.tpMin7.ToString();
            BedSideView7.bed7singleton.Temperature_Minimum_Text3.Text = SocketConfiguration.tpMin7.ToString();
            BedSideView7.bed7singleton.Temperature_Minimum_Text4.Text = SocketConfiguration.tpMin7.ToString();

            BedSideView7.bed7singleton.Temperature_Maximum_Text.Text = SocketConfiguration.tpMax7.ToString();
            BedSideView7.bed7singleton.Temperature_Maximum_Text2.Text = SocketConfiguration.tpMax7.ToString();
            BedSideView7.bed7singleton.Temperature_Maximum_Text3.Text = SocketConfiguration.tpMax7.ToString();
            BedSideView7.bed7singleton.Temperature_Maximum_Text4.Text = SocketConfiguration.tpMax7.ToString();
            #endregion

            #region BedSideView8 TextBox.Text Assignment
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.syMin8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.syMin8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.syMin8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.syMin8.ToString();

            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.syMax8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.syMax8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.syMax8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.syMax8.ToString();

            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Minimum_Text.Text = SocketConfiguration.diMin8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = SocketConfiguration.diMin8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = SocketConfiguration.diMin8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = SocketConfiguration.diMin8.ToString();

            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Maximum_Text.Text = SocketConfiguration.diMax8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = SocketConfiguration.diMax8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = SocketConfiguration.diMax8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = SocketConfiguration.diMax8.ToString();

            BedSideView8.bed8singleton.BreathingRate_Minimum_Text.Text = SocketConfiguration.brMin8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Minimum_Text2.Text = SocketConfiguration.brMin8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Minimum_Text3.Text = SocketConfiguration.brMin8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Minimum_Text4.Text = SocketConfiguration.brMin8.ToString();

            BedSideView8.bed8singleton.BreathingRate_Maximum_Text.Text = SocketConfiguration.brMax8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Maximum_Text2.Text = SocketConfiguration.brMax8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Maximum_Text3.Text = SocketConfiguration.brMax8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Maximum_Text4.Text = SocketConfiguration.brMax8.ToString();

            BedSideView8.bed8singleton.PulseRate_Minimum_Text.Text = SocketConfiguration.prMin8.ToString();
            BedSideView8.bed8singleton.PulseRate_Minimum_Text2.Text = SocketConfiguration.prMin8.ToString();
            BedSideView8.bed8singleton.PulseRate_Minimum_Text3.Text = SocketConfiguration.prMin8.ToString();
            BedSideView8.bed8singleton.PulseRate_Minimum_Text4.Text = SocketConfiguration.prMin8.ToString();

            BedSideView8.bed8singleton.PulseRate_Maximum_Text.Text = SocketConfiguration.prMax8.ToString();
            BedSideView8.bed8singleton.PulseRate_Maximum_Text2.Text = SocketConfiguration.prMax8.ToString();
            BedSideView8.bed8singleton.PulseRate_Maximum_Text3.Text = SocketConfiguration.prMax8.ToString();
            BedSideView8.bed8singleton.PulseRate_Maximum_Text4.Text = SocketConfiguration.prMax8.ToString();

            BedSideView8.bed8singleton.Temperature_Minimum_Text.Text = SocketConfiguration.tpMin8.ToString();
            BedSideView8.bed8singleton.Temperature_Minimum_Text2.Text = SocketConfiguration.tpMin8.ToString();
            BedSideView8.bed8singleton.Temperature_Minimum_Text3.Text = SocketConfiguration.tpMin8.ToString();
            BedSideView8.bed8singleton.Temperature_Minimum_Text4.Text = SocketConfiguration.tpMin8.ToString();

            BedSideView8.bed8singleton.Temperature_Maximum_Text.Text = SocketConfiguration.tpMax8.ToString();
            BedSideView8.bed8singleton.Temperature_Maximum_Text2.Text = SocketConfiguration.tpMax8.ToString();
            BedSideView8.bed8singleton.Temperature_Maximum_Text3.Text = SocketConfiguration.tpMax8.ToString();
            BedSideView8.bed8singleton.Temperature_Maximum_Text4.Text = SocketConfiguration.tpMax8.ToString();
            #endregion


            #region Database Stuff
            if (BedLabel.Text == "Bed 1")
            {
                DBConnection.Instance.recordInDB(BedSideView1.bed1singleton.tbfn.Text, BedSideView1.bed1singleton.tbln.Text,
                    BedSideView1.bed1singleton.tbage.Text, BedSideView1.bed1singleton.tbgender.Text, BedSideView1.bed1singleton.tbheight.Text,
                    BedSideView1.bed1singleton.tbweight.Text, SocketConfiguration.diMin1, SocketConfiguration.diMax1,
                    SocketConfiguration.syMin1, SocketConfiguration.syMax1, SocketConfiguration.prMin1, SocketConfiguration.prMax1,
                    SocketConfiguration.brMin1, SocketConfiguration.brMax1, SocketConfiguration.tpMin1, SocketConfiguration.tpMax1, 1);
            }
            if (BedLabel.Text == "Bed 2")
            {
                DBConnection.Instance.recordInDB(BedSideView2.bed2singleton.tbfn.Text, BedSideView2.bed2singleton.tbln.Text,
                    BedSideView2.bed2singleton.tbage.Text, BedSideView2.bed2singleton.tbgender.Text, BedSideView2.bed2singleton.tbheight.Text,
                    BedSideView2.bed2singleton.tbweight.Text, SocketConfiguration.diMin2, SocketConfiguration.diMax2,
                    SocketConfiguration.syMin2, SocketConfiguration.syMax2, SocketConfiguration.prMin2, SocketConfiguration.prMax2,
                    SocketConfiguration.brMin2, SocketConfiguration.brMax2, SocketConfiguration.tpMin2, SocketConfiguration.tpMax2, 2);
            }
            if (BedLabel.Text == "Bed 3")
            {
                DBConnection.Instance.recordInDB(BedSideView3.bed3singleton.tbfn.Text, BedSideView3.bed3singleton.tbln.Text,
                    BedSideView3.bed3singleton.tbage.Text, BedSideView3.bed3singleton.tbgender.Text, BedSideView3.bed3singleton.tbheight.Text,
                    BedSideView3.bed3singleton.tbweight.Text, SocketConfiguration.diMin3, SocketConfiguration.diMax3,
                    SocketConfiguration.syMin3, SocketConfiguration.syMax3, SocketConfiguration.prMin3, SocketConfiguration.prMax3,
                    SocketConfiguration.brMin3, SocketConfiguration.brMax3, SocketConfiguration.tpMin3, SocketConfiguration.tpMax3, 3);
            }
            if (BedLabel.Text == "Bed 4")
            {
                DBConnection.Instance.recordInDB(BedSideView4.bed4singleton.tbfn.Text, BedSideView4.bed4singleton.tbln.Text,
                    BedSideView4.bed4singleton.tbage.Text, BedSideView4.bed4singleton.tbgender.Text, BedSideView4.bed4singleton.tbheight.Text,
                    BedSideView4.bed4singleton.tbweight.Text, SocketConfiguration.diMin4, SocketConfiguration.diMax4,
                    SocketConfiguration.syMin4, SocketConfiguration.syMax4, SocketConfiguration.prMin4, SocketConfiguration.prMax4,
                    SocketConfiguration.brMin4, SocketConfiguration.brMax4, SocketConfiguration.tpMin4, SocketConfiguration.tpMax4, 4);
            }
            if (BedLabel.Text == "Bed 5")
            {
                DBConnection.Instance.recordInDB(BedSideView5.bed5singleton.tbfn.Text, BedSideView5.bed5singleton.tbln.Text,
                    BedSideView5.bed5singleton.tbage.Text, BedSideView5.bed5singleton.tbgender.Text, BedSideView5.bed5singleton.tbheight.Text,
                    BedSideView5.bed5singleton.tbweight.Text, SocketConfiguration.diMin5, SocketConfiguration.diMax5,
                    SocketConfiguration.syMin5, SocketConfiguration.syMax5, SocketConfiguration.prMin5, SocketConfiguration.prMax5,
                    SocketConfiguration.brMin5, SocketConfiguration.brMax5, SocketConfiguration.tpMin5, SocketConfiguration.tpMax5, 5);
            }
            if (BedLabel.Text == "Bed 6")
            {
                DBConnection.Instance.recordInDB(BedSideView6.bed6singleton.tbfn.Text, BedSideView6.bed6singleton.tbln.Text,
                    BedSideView6.bed6singleton.tbage.Text, BedSideView6.bed6singleton.tbgender.Text, BedSideView6.bed6singleton.tbheight.Text,
                    BedSideView6.bed6singleton.tbweight.Text, SocketConfiguration.diMin6, SocketConfiguration.diMax6,
                    SocketConfiguration.syMin6, SocketConfiguration.syMax6, SocketConfiguration.prMin6, SocketConfiguration.prMax6,
                    SocketConfiguration.brMin6, SocketConfiguration.brMax6, SocketConfiguration.tpMin6, SocketConfiguration.tpMax6, 6);
            }
            if (BedLabel.Text == "Bed 7")
            {
                DBConnection.Instance.recordInDB(BedSideView7.bed7singleton.tbfn.Text, BedSideView7.bed7singleton.tbln.Text,
                    BedSideView7.bed7singleton.tbage.Text, BedSideView7.bed7singleton.tbgender.Text, BedSideView7.bed7singleton.tbheight.Text,
                    BedSideView7.bed7singleton.tbweight.Text, SocketConfiguration.diMin7, SocketConfiguration.diMax7,
                    SocketConfiguration.syMin7, SocketConfiguration.syMax7, SocketConfiguration.prMin7, SocketConfiguration.prMax7,
                    SocketConfiguration.brMin7, SocketConfiguration.brMax7, SocketConfiguration.tpMin7, SocketConfiguration.tpMax7, 7);
            }
            if (BedLabel.Text == "Bed 8")
            {
                DBConnection.Instance.recordInDB(BedSideView8.bed8singleton.tbfn.Text, BedSideView8.bed8singleton.tbln.Text,
                    BedSideView8.bed8singleton.tbage.Text, BedSideView8.bed8singleton.tbgender.Text, BedSideView8.bed8singleton.tbheight.Text,
                    BedSideView8.bed8singleton.tbweight.Text, SocketConfiguration.diMin8, SocketConfiguration.diMax8,
                    SocketConfiguration.syMin8, SocketConfiguration.syMax8, SocketConfiguration.prMin8, SocketConfiguration.prMax8,
                    SocketConfiguration.brMin8, SocketConfiguration.brMax8, SocketConfiguration.tpMin8, SocketConfiguration.tpMax8, 1);
            }
            #endregion

            BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text = "Insert Minimum";
            BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text = "Insert Maximum";
            BloodPressureTextBox_SystolicMinimum_ParameterValue.Text = "Insert Minimum";
            BloodPressureTextBox_SystolicMaximum_ParameterValue.Text = "Insert Maximum";
            PulseRate_Minimum_TextBox.Text = "Insert Minimum";
            PulseRate_Maximum_TextBox.Text = "Insert Maximum";
            BreathingRate_Minimum_TextBox.Text = "Insert Minimum";
            BreathingRate_Maximum_TextBox.Text = "Insert Maximum";
            Temperature_Minimum_TextBox.Text = "Insert Minimum";
            Temperature_Maximum_TextBox.Text = "Insert Maximum";
        }
    }
}
