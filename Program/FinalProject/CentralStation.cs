using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CentralStation : Form
    {
        public static CentralStation centralsingleton;

        public CentralStation()
        {
            centralsingleton = this;
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
        private void CloseButtonCentralStation_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButtonCentralStation_Click(object sender, EventArgs e)
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

        private void BedButton1_Click(object sender, EventArgs e)
        {
            BedSideView1 bed1 = new BedSideView1();
            bed1.Show();
            bed1.Location = this.Location;
            this.Hide();
        }

        private void BedButton2_Click(object sender, EventArgs e)
        {
            BedSideView2 bed2 = new BedSideView2();
            bed2.Show();
            bed2.Location = this.Location;
            this.Hide();
        }

        private void BedButton3_Click(object sender, EventArgs e)
        {
            BedSideView3 bed3 = new BedSideView3();
            bed3.Show();
            bed3.Location = this.Location;
            this.Hide();
        }

        private void BedButton4_Click(object sender, EventArgs e)
        {
            BedSideView4 bed4 = new BedSideView4();
            bed4.Show();
            bed4.Location = this.Location;
            this.Hide();
        }

        private void BedButton5_Click(object sender, EventArgs e)
        {
            BedSideView5 bed5 = new BedSideView5();
            bed5.Show();
            bed5.Location = this.Location;
            this.Hide();
        }

        private void BedButton6_Click(object sender, EventArgs e)
        {
            BedSideView6 bed6 = new BedSideView6();
            bed6.Show();
            bed6.Location = this.Location;
            this.Hide();
        }

        private void BedButton7_Click(object sender, EventArgs e)
        {
            BedSideView7 bed7 = new BedSideView7();
            bed7.Show();
            bed7.Location = this.Location;
            this.Hide();
        }

        private void BedButton8_Click(object sender, EventArgs e)
        {
            BedSideView8 bed8 = new BedSideView8();
            bed8.Show();
            bed8.Location = this.Location;
            this.Hide();
        }
    }
}
