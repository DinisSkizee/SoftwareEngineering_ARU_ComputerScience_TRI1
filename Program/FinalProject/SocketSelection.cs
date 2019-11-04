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
            PanelVO2Max.Visible = false;
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


        // Small Icon on the Left Top corner to go back to the AfterLogin form
        private void MainPageButton_Click(object sender, EventArgs e)   // -- Dinis & Jorge
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            afterlogin.Location = this.Location;
            this.Hide();
        }

        private void Default_SocketComboBox_TextChanged(object sender, EventArgs e)  // -- Dinis & Jorge
        {
            if (DefaultPanel_SocketComboBox.SelectedIndex < 0)
            {
                DefaultPanel_SelectSocketLabel.Visible = true; ;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 0)
            {
                PanelTemperature.Dock = DockStyle.None;
                PanelTemperature.Visible = false;
                BreathingRatePanel.Dock = DockStyle.None;
                BreathingRatePanel.Visible = false;
                PanelPulseRate.Dock = DockStyle.None;
                PanelPulseRate.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                BloodPressurePanel.Dock = DockStyle.Fill;
                BloodPressurePanel.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 1)
            {
                PanelTemperature.Dock = DockStyle.None;
                PanelTemperature.Visible = false;
                BreathingRatePanel.Dock = DockStyle.None;
                BreathingRatePanel.Visible = false;
                BloodPressurePanel.Dock = DockStyle.None;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                PanelPulseRate.Dock = DockStyle.Fill;
                PanelPulseRate.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 2)
            {
                PanelPulseRate.Dock = DockStyle.None;
                PanelPulseRate.Visible = false;
                PanelTemperature.Dock = DockStyle.None;
                PanelTemperature.Visible = false;
                BloodPressurePanel.Dock = DockStyle.None;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                BreathingRatePanel.Dock = DockStyle.Fill;
                BreathingRatePanel.Visible = true;
            }
            else if (DefaultPanel_SocketComboBox.SelectedIndex == 3)
            {
                PanelPulseRate.Dock = DockStyle.None;
                PanelPulseRate.Visible = false;
                BreathingRatePanel.Dock = DockStyle.None;
                BreathingRatePanel.Visible = false;
                BloodPressurePanel.Dock = DockStyle.None;
                BloodPressurePanel.Visible = false;

                DefaultPanel_SelectSocketLabel.Visible = false;

                PanelTemperature.Dock = DockStyle.Fill;
                PanelTemperature.Visible = true;
            }
        }

    }
}
