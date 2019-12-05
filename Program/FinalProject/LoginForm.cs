using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public static LoginForm loginsingleton = new LoginForm();

        public LoginForm()
        {
            loginsingleton = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            new BedSideViewConfiguration();
        }


        #region Login Button -- Dinis & Jorge
        /* Username & Password check; Clear to remove bugs and MessageBox to
        let the user know something wrong happened. - Dinis & Jorge */

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "admin" && passwordBox.Text == "admin")
            {
                AfterLogin.aftersingleton.Show();
                AfterLogin.aftersingleton.Location = this.Location;
                this.Hide();
            }
            else
            {
                usernameBox.Clear();
                passwordBox.Clear();
                MessageBox.Show("The Username or Password is incorrect, Please try again.");
            }

            usernameBox.Clear();
            passwordBox.Clear();
        }
        #endregion

        #region Draggable Grey Background Panel  -- Dinis & Jorge
        // Draggable Panel  https://stackoverflow.com/questions/11379209/how-do-i-make-mousedrag-inside-panel-move-form-window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
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

        #region Enter to Click on the Login Button shortcut  -- Dinis & Jorge
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

        #region Close/Minimize Buttons  -- Dinis & Jorge
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
