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
            PanelPulseRate.Visible = false;
            BloodPressurePanel.Visible = false;
            PanelTemperature.Visible = false;
            #endregion

            #region BedComboBox Items  -- Dinis & Jorge
            DefaultPanel_BedComboBox.Items.Add("Bed 1");
            DefaultPanel_BedComboBox.Items.Add("Bed 2");
            DefaultPanel_BedComboBox.Items.Add("Bed 3");
            DefaultPanel_BedComboBox.Items.Add("Bed 4");
            DefaultPanel_BedComboBox.Items.Add("Bed 5");
            DefaultPanel_BedComboBox.Items.Add("Bed 6");
            DefaultPanel_BedComboBox.Items.Add("Bed 7");
            DefaultPanel_BedComboBox.Items.Add("Bed 8");
            #endregion

            #region SocketComboBox Items  -- Dinis & Jorge
            DefaultPanel_SocketComboBox.Items.Add("Blood Pressure");
            DefaultPanel_SocketComboBox.Items.Add("Pulse Rate");
            DefaultPanel_SocketComboBox.Items.Add("Breathing Rate");
            DefaultPanel_SocketComboBox.Items.Add("Temperature");
            #endregion

        }

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

        #region TextBox Change effects  -- Dinis & Jorge

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
                PanelTemperature.Dock = DockStyle.None;
                PanelPulseRate.Dock = DockStyle.None;

                BreathingRatePanel.Visible = false;
                PanelTemperature.Visible = false;
                PanelPulseRate.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                BloodPressurePanel.Dock = DockStyle.Fill;
                BloodPressurePanel.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 1)
            {
                BreathingRatePanel.Dock = DockStyle.None;
                PanelTemperature.Dock = DockStyle.None;
                BloodPressurePanel.Dock = DockStyle.None;

                BreathingRatePanel.Visible = false;
                PanelTemperature.Visible = false;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                PanelPulseRate.Dock = DockStyle.Fill;
                PanelPulseRate.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 2)
            {
                PanelPulseRate.Dock = DockStyle.None;
                PanelTemperature.Dock = DockStyle.None;
                BloodPressurePanel.Dock = DockStyle.None;

                PanelPulseRate.Visible = false;
                PanelTemperature.Visible = false;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                BreathingRatePanel.Dock = DockStyle.Fill;
                BreathingRatePanel.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 3)
            {
                PanelPulseRate.Dock = DockStyle.None;
                BreathingRatePanel.Dock = DockStyle.None;
                BloodPressurePanel.Dock = DockStyle.None;

                PanelPulseRate.Visible = false;
                BreathingRatePanel.Visible = false;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                PanelTemperature.Dock = DockStyle.Fill;
                PanelTemperature.Visible = true;
            }
        }

        public void DefaultPanel_InstallButton_Click(object sender, EventArgs e)
        {

            #region Variable Declaration  -- Dinis & Jorge
            // Blood Pressure Panel Variables
            string diMin = BloodPressureTextBox_DiastolicMinimum_ParameterValue.Text;
            string diMax = BloodPressureTextBox_DiastolicMaximum_ParameterValue.Text;
            string syMin = BloodPressureTextBox_SystolicMinimum_ParameterValue.Text;
            string syMax = BloodPressureTextBox_SystolicMaximum_ParameterValue.Text;

            // Parameters Verification
            int bpParameters = 0;
            bool dMi = IsNumeric(diMin);
            bool dMa = IsNumeric(diMax);
            bool sMi = IsNumeric(syMin);
            bool sMa = IsNumeric(syMax);
            #endregion

            // Check if the string has a numeric value
            bool IsNumeric(string s)
            {
                int Result;
                return int.TryParse(s, out Result);
            }

            // Check if every textbox has input
            if (dMi == true && dMa == true && sMi == true && sMa == true)
            {
                bpParameters = 1;
            }
            else { bpParameters = 0; }

            if (DefaultPanel_SocketComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please, select a Module.");
            }

            else if (DefaultPanel_SocketComboBox.SelectedIndex == 0 && bpParameters == 1)
            {
                // ADD CODE
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 0 && bpParameters == 0)
            {
                MessageBox.Show("Please verify the input values, it must be numbers only.");
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 1)
            {
                // ADD CODE
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 2)
            {
                // ADD CODE
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 3)
            {
                // ADD CODE
            }
        }
    }
}
