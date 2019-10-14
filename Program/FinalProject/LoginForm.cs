using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        // Draggable Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // End  (continues in the **) - Dinis & Jorge


        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


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
        private void GreyBackgroundLogin_MouseMove(object sender, MouseEventArgs e)
        {
            // ** Draggable Panel1  - Dinis & Jorge
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // KeyDown feature for a better user experience on the login form
        // Enter to click the Login Button automatically - Dinis & Jorge
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

        // Just a regular close button - Dinis & Jorge
        private void CloseButtonLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButtonLoginForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
