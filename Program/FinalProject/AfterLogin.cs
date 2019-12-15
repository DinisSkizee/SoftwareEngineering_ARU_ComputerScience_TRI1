using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AfterLogin : Form
    {
        // Creating singleton object for the Form
        public static AfterLogin aftersingleton = new AfterLogin();

        public AfterLogin()
        {
            // Assigning the singleton to this object
            aftersingleton = this;
            InitializeComponent();
        }

        // Draggable Panel Configuration
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

        // Close and Minimize buttons configuration
        #region Close/Minimize Buttons
        // Close Button
        private void CloseButtonAfterLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Button
        private void MinimizeButtonAfterLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        // Logout button to return to the LoginForm
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm.loginsingleton.Show();
            LoginForm.loginsingleton.Location = this.Location;
            this.Hide();
        }

        /* 4 Button Configuration, Open, Show and this.Hide()
         * Beds
         * Central Station
         * Management
         * Logs
         */

        #region 4 Buttons Click Properties
        private void BedsButton_Click(object sender, EventArgs e)
        {
            BedSideView1.bed1singleton.Show();
            BedSideView1.bed1singleton.Location = this.Location;
            this.Hide();
        }

        private void CentralStationButton_Click(object sender, EventArgs e)
        {
            CentralStation.centralsingleton.Show();
            CentralStation.centralsingleton.Location = this.Location;
            this.Hide();
        }

        // Added this button that leads to Management/Logs bit (Priyanka)
        private void ManagementButton_Click(object sender, EventArgs e)
        {
            managerments managerments = new managerments();
            managerments.Show();
            managerments.Location = this.Location;
            this.Hide();

        }
        // Added this button that leads to Management/Logs bit (Priyanka)
        private void LogsButton_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            logs.Location = this.Location;
            this.Hide();
        }
        #endregion

    }
}

