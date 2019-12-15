using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class LoginForm : Form
    {
        // Create the singleton object for the LoginForm
        public static LoginForm loginsingleton = new LoginForm();

        public LoginForm()
        {
            // Assigning the singleton to the actual object
            loginsingleton = this;
            // Starting position of the program will be in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            // Open the BedSideViewConfiguration Class
            new BedSideViewConfiguration();
        }

        //              Username & Password check
        //                Clear to remove bugs
        // MessageBox to let the user know something wrong happened
        
        // username: admin
        // password: admin

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

        // Top Panel Drag properties
        #region Draggable Grey Background Panel
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

        // Allow the user to click enter instead of clicking the button for a shortcut and better user experience
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

        // Close and minimize buttons configuration
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
