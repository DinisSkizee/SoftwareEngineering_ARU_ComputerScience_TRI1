using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        #region Login Button
        /* Username & Password check; Clear to remove bugs and MessageBox to
        let the user know something wrong happened. - Dinis & Jorge */

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "admin" && passwordBox.Text == "admin")
            {
                AfterLogin afterLogin = new AfterLogin();
                afterLogin.Show();
                afterLogin.Location = this.Location;
                this.Hide();
            }
            else
            {
                usernameBox.Clear();
                passwordBox.Clear();
                MessageBox.Show("The Username or Password is incorrect, Please try again.");
            }
        }
        #endregion

        #region Draggable Grey Background Panel
        // Draggable Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void GreyBackgroundLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Enter to Click on the Login Button shortcut
        // KeyDown feature for a better user experience on the login form
        // Enter to click the Login Button automatically
        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }
        #endregion

        #region Close/Minimize Buttons
        // Close Button
        private void CloseButtonLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Button
        private void MinimizeButtonLoginForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

    }
}
