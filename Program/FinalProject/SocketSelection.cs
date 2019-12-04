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

        public static int diMin1, diMax1, syMin1, syMax1, prMin1, prMax1, brMin1, brMax1, tpMin1, tpMax1;
        public static int diMin2, diMax2, syMin2, syMax2, prMin2, prMax2, brMin2, brMax2, tpMin2, tpMax2;
        public static int diMin3, diMax3, syMin3, syMax3, prMin3, prMax3, brMin3, brMax3, tpMin3, tpMax3;
        public static int diMin4, diMax4, syMin4, syMax4, prMin4, prMax4, brMin4, brMax4, tpMin4, tpMax4;
        public static int diMin5, diMax5, syMin5, syMax5, prMin5, prMax5, brMin5, brMax5, tpMin5, tpMax5;
        public static int diMin6, diMax6, syMin6, syMax6, prMin6, prMax6, brMin6, brMax6, tpMin6, tpMax6;
        public static int diMin7, diMax7, syMin7, syMax7, prMin7, prMax7, brMin7, brMax7, tpMin7, tpMax7;
        public static int diMin8, diMax8, syMin8, syMax8, prMin8, prMax8, brMin8, brMax8, tpMin8, tpMax8;
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
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out diMin1);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out diMax1);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out syMin1);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out syMax1);

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
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out diMin2);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out diMax2);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out syMin2);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out syMax2);

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
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out diMin3);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out diMax3);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out syMin3);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out syMax3);

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
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out diMin4);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out diMax4);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out syMin4);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out syMax4);

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
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out diMin5);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out diMax5);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out syMin5);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out syMax5);

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
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out diMin6);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out diMax6);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out syMin6);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out syMax6);

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
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out diMin7);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out diMax7);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out syMin7);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out syMax7);

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
                    int.TryParse(BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text, out diMin8);
                    int.TryParse(BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text, out diMax8);
                    int.TryParse(BloodPressureTextBox_SystolicMinimum_ParameterValue.Text, out syMin8);
                    int.TryParse(BloodPressureTextBox_SystolicMaximum_ParameterValue.Text, out syMax8);

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
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out prMin1);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out prMax1);

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
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out prMin2);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out prMax2);

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
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out prMin3);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out prMax3);

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
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out prMin4);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out prMax4);

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
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out prMin5);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out prMax5);

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
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out prMin6);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out prMax6);

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
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out prMin7);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out prMax7);

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
                    int.TryParse(PulseRate_Minimum_TextBox.Text, out prMin8);
                    int.TryParse(PulseRate_Maximum_TextBox.Text, out prMax8);

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
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out brMin1);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out brMax1);

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
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out brMin2);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out brMax2);

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
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out brMin3);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out brMax3);

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
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out brMin4);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out brMax4);

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
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out brMin5);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out brMax5);

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
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out brMin6);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out brMax6);

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
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out brMin7);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out brMax7);

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
                    int.TryParse(BreathingRate_Minimum_TextBox.Text, out brMin8);
                    int.TryParse(BreathingRate_Maximum_TextBox.Text, out brMax8);

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
                    int.TryParse(Temperature_Minimum_TextBox.Text, out tpMin1);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out tpMax1);

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
                    int.TryParse(Temperature_Minimum_TextBox.Text, out tpMin2);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out tpMax2);

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
                    int.TryParse(Temperature_Minimum_TextBox.Text, out tpMin3);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out tpMax3);

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
                    int.TryParse(Temperature_Minimum_TextBox.Text, out tpMin4);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out tpMax4);

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
                    int.TryParse(Temperature_Minimum_TextBox.Text, out tpMin5);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out tpMax5);

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
                    int.TryParse(Temperature_Minimum_TextBox.Text, out tpMin6);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out tpMax6);

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
                    int.TryParse(Temperature_Minimum_TextBox.Text, out tpMin7);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out tpMax7);

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
                    int.TryParse(Temperature_Minimum_TextBox.Text, out tpMin8);
                    int.TryParse(Temperature_Maximum_TextBox.Text, out tpMax8);

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
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Minimum_Text.Text = syMin1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = syMin1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = syMin1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = syMin1.ToString();

            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Maximum_Text.Text = syMax1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = syMax1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = syMax1.ToString();
            BedSideView1.bed1singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = syMax1.ToString();

            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Minimum_Text.Text = diMin1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = diMin1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = diMin1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = diMin1.ToString();

            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Maximum_Text.Text = diMax1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = diMax1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = diMax1.ToString();
            BedSideView1.bed1singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = diMax1.ToString();

            BedSideView1.bed1singleton.BreathingRate_Minimum_Text.Text = brMin1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Minimum_Text2.Text = brMin1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Minimum_Text3.Text = brMin1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Minimum_Text4.Text = brMin1.ToString();

            BedSideView1.bed1singleton.BreathingRate_Maximum_Text.Text = brMax1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Maximum_Text2.Text = brMax1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Maximum_Text3.Text = brMax1.ToString();
            BedSideView1.bed1singleton.BreathingRate_Maximum_Text4.Text = brMax1.ToString();

            BedSideView1.bed1singleton.PulseRate_Minimum_Text.Text = prMin1.ToString();
            BedSideView1.bed1singleton.PulseRate_Minimum_Text2.Text = prMin1.ToString();
            BedSideView1.bed1singleton.PulseRate_Minimum_Text3.Text = prMin1.ToString();
            BedSideView1.bed1singleton.PulseRate_Minimum_Text4.Text = prMin1.ToString();

            BedSideView1.bed1singleton.PulseRate_Maximum_Text.Text = prMax1.ToString();
            BedSideView1.bed1singleton.PulseRate_Maximum_Text2.Text = prMax1.ToString();
            BedSideView1.bed1singleton.PulseRate_Maximum_Text3.Text = prMax1.ToString();
            BedSideView1.bed1singleton.PulseRate_Maximum_Text4.Text = prMax1.ToString();

            BedSideView1.bed1singleton.Temperature_Minimum_Text.Text = tpMin1.ToString();
            BedSideView1.bed1singleton.Temperature_Minimum_Text2.Text = tpMin1.ToString();
            BedSideView1.bed1singleton.Temperature_Minimum_Text3.Text = tpMin1.ToString();
            BedSideView1.bed1singleton.Temperature_Minimum_Text4.Text = tpMin1.ToString();

            BedSideView1.bed1singleton.Temperature_Maximum_Text.Text = tpMax1.ToString();
            BedSideView1.bed1singleton.Temperature_Maximum_Text2.Text = tpMax1.ToString();
            BedSideView1.bed1singleton.Temperature_Maximum_Text3.Text = tpMax1.ToString();
            BedSideView1.bed1singleton.Temperature_Maximum_Text4.Text = tpMax1.ToString();
            #endregion

            #region BedSideView2 TextBox.Text Assignment
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Minimum_Text.Text = syMin2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = syMin2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = syMin2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = syMin2.ToString();

            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Maximum_Text.Text = syMax2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = syMax2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = syMax2.ToString();
            BedSideView2.bed2singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = syMax2.ToString();

            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Minimum_Text.Text = diMin2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = diMin2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = diMin2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = diMin2.ToString();

            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Maximum_Text.Text = diMax2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = diMax2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = diMax2.ToString();
            BedSideView2.bed2singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = diMax2.ToString();

            BedSideView2.bed2singleton.BreathingRate_Minimum_Text.Text = brMin2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Minimum_Text2.Text = brMin2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Minimum_Text3.Text = brMin2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Minimum_Text4.Text = brMin2.ToString();

            BedSideView2.bed2singleton.BreathingRate_Maximum_Text.Text = brMax2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Maximum_Text2.Text = brMax2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Maximum_Text3.Text = brMax2.ToString();
            BedSideView2.bed2singleton.BreathingRate_Maximum_Text4.Text = brMax2.ToString();

            BedSideView2.bed2singleton.PulseRate_Minimum_Text.Text = prMin2.ToString();
            BedSideView2.bed2singleton.PulseRate_Minimum_Text2.Text = prMin2.ToString();
            BedSideView2.bed2singleton.PulseRate_Minimum_Text3.Text = prMin2.ToString();
            BedSideView2.bed2singleton.PulseRate_Minimum_Text4.Text = prMin2.ToString();

            BedSideView2.bed2singleton.PulseRate_Maximum_Text.Text = prMax2.ToString();
            BedSideView2.bed2singleton.PulseRate_Maximum_Text2.Text = prMax2.ToString();
            BedSideView2.bed2singleton.PulseRate_Maximum_Text3.Text = prMax2.ToString();
            BedSideView2.bed2singleton.PulseRate_Maximum_Text4.Text = prMax2.ToString();

            BedSideView2.bed2singleton.Temperature_Minimum_Text.Text = tpMin2.ToString();
            BedSideView2.bed2singleton.Temperature_Minimum_Text2.Text = tpMin2.ToString();
            BedSideView2.bed2singleton.Temperature_Minimum_Text3.Text = tpMin2.ToString();
            BedSideView2.bed2singleton.Temperature_Minimum_Text4.Text = tpMin2.ToString();

            BedSideView2.bed2singleton.Temperature_Maximum_Text.Text = tpMax2.ToString();
            BedSideView2.bed2singleton.Temperature_Maximum_Text2.Text = tpMax2.ToString();
            BedSideView2.bed2singleton.Temperature_Maximum_Text3.Text = tpMax2.ToString();
            BedSideView2.bed2singleton.Temperature_Maximum_Text4.Text = tpMax2.ToString();
            #endregion

            #region BedSideView3 TextBox.Text Assignment
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Minimum_Text.Text = syMin3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = syMin3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = syMin3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = syMin3.ToString();

            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Maximum_Text.Text = syMax3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = syMax3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = syMax3.ToString();
            BedSideView3.bed3singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = syMax3.ToString();

            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Minimum_Text.Text = diMin3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = diMin3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = diMin3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = diMin3.ToString();

            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Maximum_Text.Text = diMax3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = diMax3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = diMax3.ToString();
            BedSideView3.bed3singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = diMax3.ToString();

            BedSideView3.bed3singleton.BreathingRate_Minimum_Text.Text = brMin3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Minimum_Text2.Text = brMin3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Minimum_Text3.Text = brMin3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Minimum_Text4.Text = brMin3.ToString();

            BedSideView3.bed3singleton.BreathingRate_Maximum_Text.Text = brMax3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Maximum_Text2.Text = brMax3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Maximum_Text3.Text = brMax3.ToString();
            BedSideView3.bed3singleton.BreathingRate_Maximum_Text4.Text = brMax3.ToString();

            BedSideView3.bed3singleton.PulseRate_Minimum_Text.Text = prMin3.ToString();
            BedSideView3.bed3singleton.PulseRate_Minimum_Text2.Text = prMin3.ToString();
            BedSideView3.bed3singleton.PulseRate_Minimum_Text3.Text = prMin3.ToString();
            BedSideView3.bed3singleton.PulseRate_Minimum_Text4.Text = prMin3.ToString();

            BedSideView3.bed3singleton.PulseRate_Maximum_Text.Text = prMax3.ToString();
            BedSideView3.bed3singleton.PulseRate_Maximum_Text2.Text = prMax3.ToString();
            BedSideView3.bed3singleton.PulseRate_Maximum_Text3.Text = prMax3.ToString();
            BedSideView3.bed3singleton.PulseRate_Maximum_Text4.Text = prMax3.ToString();

            BedSideView3.bed3singleton.Temperature_Minimum_Text.Text = tpMin3.ToString();
            BedSideView3.bed3singleton.Temperature_Minimum_Text2.Text = tpMin3.ToString();
            BedSideView3.bed3singleton.Temperature_Minimum_Text3.Text = tpMin3.ToString();
            BedSideView3.bed3singleton.Temperature_Minimum_Text4.Text = tpMin3.ToString();

            BedSideView3.bed3singleton.Temperature_Maximum_Text.Text = tpMax3.ToString();
            BedSideView3.bed3singleton.Temperature_Maximum_Text2.Text = tpMax3.ToString();
            BedSideView3.bed3singleton.Temperature_Maximum_Text3.Text = tpMax3.ToString();
            BedSideView3.bed3singleton.Temperature_Maximum_Text4.Text = tpMax3.ToString();
            #endregion

            #region BedSideView4 TextBox.Text Assignment
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Minimum_Text.Text = syMin4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = syMin4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = syMin4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = syMin4.ToString();

            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Maximum_Text.Text = syMax4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = syMax4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = syMax4.ToString();
            BedSideView4.bed4singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = syMax4.ToString();

            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Minimum_Text.Text = diMin4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = diMin4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = diMin4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = diMin4.ToString();

            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Maximum_Text.Text = diMax4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = diMax4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = diMax4.ToString();
            BedSideView4.bed4singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = diMax4.ToString();

            BedSideView4.bed4singleton.BreathingRate_Minimum_Text.Text = brMin4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Minimum_Text2.Text = brMin4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Minimum_Text3.Text = brMin4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Minimum_Text4.Text = brMin4.ToString();

            BedSideView4.bed4singleton.BreathingRate_Maximum_Text.Text = brMax4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Maximum_Text2.Text = brMax4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Maximum_Text3.Text = brMax4.ToString();
            BedSideView4.bed4singleton.BreathingRate_Maximum_Text4.Text = brMax4.ToString();

            BedSideView4.bed4singleton.PulseRate_Minimum_Text.Text = prMin4.ToString();
            BedSideView4.bed4singleton.PulseRate_Minimum_Text2.Text = prMin4.ToString();
            BedSideView4.bed4singleton.PulseRate_Minimum_Text3.Text = prMin4.ToString();
            BedSideView4.bed4singleton.PulseRate_Minimum_Text4.Text = prMin4.ToString();

            BedSideView4.bed4singleton.PulseRate_Maximum_Text.Text = prMax4.ToString();
            BedSideView4.bed4singleton.PulseRate_Maximum_Text2.Text = prMax4.ToString();
            BedSideView4.bed4singleton.PulseRate_Maximum_Text3.Text = prMax4.ToString();
            BedSideView4.bed4singleton.PulseRate_Maximum_Text4.Text = prMax4.ToString();

            BedSideView4.bed4singleton.Temperature_Minimum_Text.Text = tpMin4.ToString();
            BedSideView4.bed4singleton.Temperature_Minimum_Text2.Text = tpMin4.ToString();
            BedSideView4.bed4singleton.Temperature_Minimum_Text3.Text = tpMin4.ToString();
            BedSideView4.bed4singleton.Temperature_Minimum_Text4.Text = tpMin4.ToString();

            BedSideView4.bed4singleton.Temperature_Maximum_Text.Text = tpMax4.ToString();
            BedSideView4.bed4singleton.Temperature_Maximum_Text2.Text = tpMax4.ToString();
            BedSideView4.bed4singleton.Temperature_Maximum_Text3.Text = tpMax4.ToString();
            BedSideView4.bed4singleton.Temperature_Maximum_Text4.Text = tpMax4.ToString();
            #endregion

            #region BedSideView5 TextBox.Text Assignment
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Minimum_Text.Text = syMin5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = syMin5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = syMin5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = syMin5.ToString();

            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Maximum_Text.Text = syMax5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = syMax5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = syMax5.ToString();
            BedSideView5.bed5singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = syMax5.ToString();

            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Minimum_Text.Text = diMin5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = diMin5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = diMin5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = diMin5.ToString();

            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Maximum_Text.Text = diMax5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = diMax5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = diMax5.ToString();
            BedSideView5.bed5singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = diMax5.ToString();

            BedSideView5.bed5singleton.BreathingRate_Minimum_Text.Text = brMin5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Minimum_Text2.Text = brMin5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Minimum_Text3.Text = brMin5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Minimum_Text4.Text = brMin5.ToString();

            BedSideView5.bed5singleton.BreathingRate_Maximum_Text.Text = brMax5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Maximum_Text2.Text = brMax5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Maximum_Text3.Text = brMax5.ToString();
            BedSideView5.bed5singleton.BreathingRate_Maximum_Text4.Text = brMax5.ToString();

            BedSideView5.bed5singleton.PulseRate_Minimum_Text.Text = prMin5.ToString();
            BedSideView5.bed5singleton.PulseRate_Minimum_Text2.Text = prMin5.ToString();
            BedSideView5.bed5singleton.PulseRate_Minimum_Text3.Text = prMin5.ToString();
            BedSideView5.bed5singleton.PulseRate_Minimum_Text4.Text = prMin5.ToString();

            BedSideView5.bed5singleton.PulseRate_Maximum_Text.Text = prMax5.ToString();
            BedSideView5.bed5singleton.PulseRate_Maximum_Text2.Text = prMax5.ToString();
            BedSideView5.bed5singleton.PulseRate_Maximum_Text3.Text = prMax5.ToString();
            BedSideView5.bed5singleton.PulseRate_Maximum_Text4.Text = prMax5.ToString();

            BedSideView5.bed5singleton.Temperature_Minimum_Text.Text = tpMin5.ToString();
            BedSideView5.bed5singleton.Temperature_Minimum_Text2.Text = tpMin5.ToString();
            BedSideView5.bed5singleton.Temperature_Minimum_Text3.Text = tpMin5.ToString();
            BedSideView5.bed5singleton.Temperature_Minimum_Text4.Text = tpMin5.ToString();

            BedSideView5.bed5singleton.Temperature_Maximum_Text.Text = tpMax5.ToString();
            BedSideView5.bed5singleton.Temperature_Maximum_Text2.Text = tpMax5.ToString();
            BedSideView5.bed5singleton.Temperature_Maximum_Text3.Text = tpMax5.ToString();
            BedSideView5.bed5singleton.Temperature_Maximum_Text4.Text = tpMax5.ToString();
            #endregion

            #region BedSideView6 TextBox.Text Assignment
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Minimum_Text.Text = syMin6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = syMin6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = syMin6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = syMin6.ToString();

            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Maximum_Text.Text = syMax6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = syMax6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = syMax6.ToString();
            BedSideView6.bed6singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = syMax6.ToString();

            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Minimum_Text.Text = diMin6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = diMin6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = diMin6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = diMin6.ToString();

            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Maximum_Text.Text = diMax6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = diMax6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = diMax6.ToString();
            BedSideView6.bed6singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = diMax6.ToString();

            BedSideView6.bed6singleton.BreathingRate_Minimum_Text.Text = brMin6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Minimum_Text2.Text = brMin6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Minimum_Text3.Text = brMin6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Minimum_Text4.Text = brMin6.ToString();

            BedSideView6.bed6singleton.BreathingRate_Maximum_Text.Text = brMax6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Maximum_Text2.Text = brMax6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Maximum_Text3.Text = brMax6.ToString();
            BedSideView6.bed6singleton.BreathingRate_Maximum_Text4.Text = brMax6.ToString();

            BedSideView6.bed6singleton.PulseRate_Minimum_Text.Text = prMin6.ToString();
            BedSideView6.bed6singleton.PulseRate_Minimum_Text2.Text = prMin6.ToString();
            BedSideView6.bed6singleton.PulseRate_Minimum_Text3.Text = prMin6.ToString();
            BedSideView6.bed6singleton.PulseRate_Minimum_Text4.Text = prMin6.ToString();

            BedSideView6.bed6singleton.PulseRate_Maximum_Text.Text = prMax6.ToString();
            BedSideView6.bed6singleton.PulseRate_Maximum_Text2.Text = prMax6.ToString();
            BedSideView6.bed6singleton.PulseRate_Maximum_Text3.Text = prMax6.ToString();
            BedSideView6.bed6singleton.PulseRate_Maximum_Text4.Text = prMax6.ToString();

            BedSideView6.bed6singleton.Temperature_Minimum_Text.Text = tpMin6.ToString();
            BedSideView6.bed6singleton.Temperature_Minimum_Text2.Text = tpMin6.ToString();
            BedSideView6.bed6singleton.Temperature_Minimum_Text3.Text = tpMin6.ToString();
            BedSideView6.bed6singleton.Temperature_Minimum_Text4.Text = tpMin6.ToString();

            BedSideView6.bed6singleton.Temperature_Maximum_Text.Text = tpMax6.ToString();
            BedSideView6.bed6singleton.Temperature_Maximum_Text2.Text = tpMax6.ToString();
            BedSideView6.bed6singleton.Temperature_Maximum_Text3.Text = tpMax6.ToString();
            BedSideView6.bed6singleton.Temperature_Maximum_Text4.Text = tpMax6.ToString();
            #endregion

            #region BedSideView7 TextBox.Text Assignment
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Minimum_Text.Text = syMin7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = syMin7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = syMin7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = syMin7.ToString();

            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Maximum_Text.Text = syMax7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = syMax7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = syMax7.ToString();
            BedSideView7.bed7singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = syMax7.ToString();

            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Minimum_Text.Text = diMin7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = diMin7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = diMin7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = diMin7.ToString();

            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Maximum_Text.Text = diMax7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = diMax7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = diMax7.ToString();
            BedSideView7.bed7singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = diMax7.ToString();

            BedSideView7.bed7singleton.BreathingRate_Minimum_Text.Text = brMin7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Minimum_Text2.Text = brMin7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Minimum_Text3.Text = brMin7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Minimum_Text4.Text = brMin7.ToString();

            BedSideView7.bed7singleton.BreathingRate_Maximum_Text.Text = brMax7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Maximum_Text2.Text = brMax7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Maximum_Text3.Text = brMax7.ToString();
            BedSideView7.bed7singleton.BreathingRate_Maximum_Text4.Text = brMax7.ToString();

            BedSideView7.bed7singleton.PulseRate_Minimum_Text.Text = prMin7.ToString();
            BedSideView7.bed7singleton.PulseRate_Minimum_Text2.Text = prMin7.ToString();
            BedSideView7.bed7singleton.PulseRate_Minimum_Text3.Text = prMin7.ToString();
            BedSideView7.bed7singleton.PulseRate_Minimum_Text4.Text = prMin7.ToString();

            BedSideView7.bed7singleton.PulseRate_Maximum_Text.Text = prMax7.ToString();
            BedSideView7.bed7singleton.PulseRate_Maximum_Text2.Text = prMax7.ToString();
            BedSideView7.bed7singleton.PulseRate_Maximum_Text3.Text = prMax7.ToString();
            BedSideView7.bed7singleton.PulseRate_Maximum_Text4.Text = prMax7.ToString();

            BedSideView7.bed7singleton.Temperature_Minimum_Text.Text = tpMin7.ToString();
            BedSideView7.bed7singleton.Temperature_Minimum_Text2.Text = tpMin7.ToString();
            BedSideView7.bed7singleton.Temperature_Minimum_Text3.Text = tpMin7.ToString();
            BedSideView7.bed7singleton.Temperature_Minimum_Text4.Text = tpMin7.ToString();

            BedSideView7.bed7singleton.Temperature_Maximum_Text.Text = tpMax7.ToString();
            BedSideView7.bed7singleton.Temperature_Maximum_Text2.Text = tpMax7.ToString();
            BedSideView7.bed7singleton.Temperature_Maximum_Text3.Text = tpMax7.ToString();
            BedSideView7.bed7singleton.Temperature_Maximum_Text4.Text = tpMax7.ToString();
            #endregion

            #region BedSideView8 TextBox.Text Assignment
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Minimum_Text.Text = syMin8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Minimum_Text2.Text = syMin8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Minimum_Text3.Text = syMin8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Minimum_Text4.Text = syMin8.ToString();

            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Maximum_Text.Text = syMax8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Maximum_Text2.Text = syMax8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Maximum_Text3.Text = syMax8.ToString();
            BedSideView8.bed8singleton.SyBloodPressurePanelBed_Maximum_Text4.Text = syMax8.ToString();

            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Minimum_Text.Text = diMin8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Minimum_Text2.Text = diMin8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Minimum_Text3.Text = diMin8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Minimum_Text4.Text = diMin8.ToString();

            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Maximum_Text.Text = diMax8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Maximum_Text2.Text = diMax8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Maximum_Text3.Text = diMax8.ToString();
            BedSideView8.bed8singleton.DiBloodPressurePanelBed_Maximum_Text4.Text = diMax8.ToString();

            BedSideView8.bed8singleton.BreathingRate_Minimum_Text.Text = brMin8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Minimum_Text2.Text = brMin8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Minimum_Text3.Text = brMin8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Minimum_Text4.Text = brMin8.ToString();

            BedSideView8.bed8singleton.BreathingRate_Maximum_Text.Text = brMax8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Maximum_Text2.Text = brMax8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Maximum_Text3.Text = brMax8.ToString();
            BedSideView8.bed8singleton.BreathingRate_Maximum_Text4.Text = brMax8.ToString();

            BedSideView8.bed8singleton.PulseRate_Minimum_Text.Text = prMin8.ToString();
            BedSideView8.bed8singleton.PulseRate_Minimum_Text2.Text = prMin8.ToString();
            BedSideView8.bed8singleton.PulseRate_Minimum_Text3.Text = prMin8.ToString();
            BedSideView8.bed8singleton.PulseRate_Minimum_Text4.Text = prMin8.ToString();

            BedSideView8.bed8singleton.PulseRate_Maximum_Text.Text = prMax8.ToString();
            BedSideView8.bed8singleton.PulseRate_Maximum_Text2.Text = prMax8.ToString();
            BedSideView8.bed8singleton.PulseRate_Maximum_Text3.Text = prMax8.ToString();
            BedSideView8.bed8singleton.PulseRate_Maximum_Text4.Text = prMax8.ToString();

            BedSideView8.bed8singleton.Temperature_Minimum_Text.Text = tpMin8.ToString();
            BedSideView8.bed8singleton.Temperature_Minimum_Text2.Text = tpMin8.ToString();
            BedSideView8.bed8singleton.Temperature_Minimum_Text3.Text = tpMin8.ToString();
            BedSideView8.bed8singleton.Temperature_Minimum_Text4.Text = tpMin8.ToString();

            BedSideView8.bed8singleton.Temperature_Maximum_Text.Text = tpMax8.ToString();
            BedSideView8.bed8singleton.Temperature_Maximum_Text2.Text = tpMax8.ToString();
            BedSideView8.bed8singleton.Temperature_Maximum_Text3.Text = tpMax8.ToString();
            BedSideView8.bed8singleton.Temperature_Maximum_Text4.Text = tpMax8.ToString();
            #endregion
        }

    }
}
