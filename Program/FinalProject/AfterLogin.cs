using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AfterLogin : Form
    {

        public AfterLogin()
        {
            InitializeComponent();
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

        #region 2 Buttons  -- Dinis & Jorge
        private void BedsButton_Click(object sender, EventArgs e)
        {
            BedSideView1 bedsideview = new BedSideView1();
            bedsideview.Show();
            bedsideview.Location = this.Location;
            this.Hide();
        }

        private void CentralStationButton_Click(object sender, EventArgs e)
        {
            CentralStation centralstation = new CentralStation();
            centralstation.Show();
            centralstation.Location = this.Location;
            this.Hide();
        }
        #endregion

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.Location = this.Location;
            this.Hide();
        }

        private void ManagementButton_Click(object sender, EventArgs e)
        {
            Management management = new Management();
            management.Show();
            management.Location = this.Location;
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

        
       
    }
    }

