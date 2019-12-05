using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CentralStation : Form
    {
        public static CentralStation centralsingleton = new CentralStation();

        public CentralStation()
        {
            centralsingleton = this;
            InitializeComponent();

            #region Disable Multiline
            tbdi1.Multiline = false;
            tbdi2.Multiline = false;
            tbdi3.Multiline = false;
            tbdi4.Multiline = false;
            tbdi5.Multiline = false;
            tbdi6.Multiline = false;
            tbdi7.Multiline = false;
            tbdi8.Multiline = false;
            tbsy1.Multiline = false;
            tbsy2.Multiline = false;
            tbsy3.Multiline = false;
            tbsy4.Multiline = false;
            tbsy5.Multiline = false;
            tbsy6.Multiline = false;
            tbsy7.Multiline = false;
            tbsy8.Multiline = false;
            tbpr1.Multiline = false;
            tbpr2.Multiline = false;
            tbpr3.Multiline = false;
            tbpr4.Multiline = false;
            tbpr5.Multiline = false;
            tbpr6.Multiline = false;
            tbpr7.Multiline = false;
            tbpr8.Multiline = false;
            tbbr1.Multiline = false;
            tbbr2.Multiline = false;
            tbbr3.Multiline = false;
            tbbr4.Multiline = false;
            tbbr5.Multiline = false;
            tbbr6.Multiline = false;
            tbbr7.Multiline = false;
            tbbr8.Multiline = false;
            tbtp1.Multiline = false;
            tbtp2.Multiline = false;
            tbtp3.Multiline = false;
            tbtp4.Multiline = false;
            tbtp5.Multiline = false;
            tbtp6.Multiline = false;
            tbtp7.Multiline = false;
            tbtp8.Multiline = false;
            #endregion

            #region Disable AutoSize
            tbdi1.AutoSize = false;
            tbdi2.AutoSize = false;
            tbdi3.AutoSize = false;
            tbdi4.AutoSize = false;
            tbdi5.AutoSize = false;
            tbdi6.AutoSize = false;
            tbdi7.AutoSize = false;
            tbdi8.AutoSize = false;
            tbsy1.AutoSize = false;
            tbsy2.AutoSize = false;
            tbsy3.AutoSize = false;
            tbsy4.AutoSize = false;
            tbsy5.AutoSize = false;
            tbsy6.AutoSize = false;
            tbsy7.AutoSize = false;
            tbsy8.AutoSize = false;
            tbpr1.AutoSize = false;
            tbpr2.AutoSize = false;
            tbpr3.AutoSize = false;
            tbpr4.AutoSize = false;
            tbpr5.AutoSize = false;
            tbpr6.AutoSize = false;
            tbpr7.AutoSize = false;
            tbpr8.AutoSize = false;
            tbbr1.AutoSize = false;
            tbbr2.AutoSize = false;
            tbbr3.AutoSize = false;
            tbbr4.AutoSize = false;
            tbbr5.AutoSize = false;
            tbbr6.AutoSize = false;
            tbbr7.AutoSize = false;
            tbbr8.AutoSize = false;
            tbtp1.AutoSize = false;
            tbtp2.AutoSize = false;
            tbtp3.AutoSize = false;
            tbtp4.AutoSize = false;
            tbtp5.AutoSize = false;
            tbtp6.AutoSize = false;
            tbtp7.AutoSize = false;
            tbtp8.AutoSize = false;
            #endregion

            #region TextBox Size
            tbdi1.Size = new Size(83, 25);
            tbdi2.Size = new Size(83, 25);
            tbdi3.Size = new Size(83, 25);
            tbdi4.Size = new Size(83, 25);
            tbdi5.Size = new Size(83, 25);
            tbdi6.Size = new Size(83, 25);
            tbdi7.Size = new Size(83, 25);
            tbdi8.Size = new Size(83, 25);
            tbsy1.Size = new Size(83, 25);
            tbsy2.Size = new Size(83, 25);
            tbsy3.Size = new Size(83, 25);
            tbsy4.Size = new Size(83, 25);
            tbsy5.Size = new Size(83, 25);
            tbsy6.Size = new Size(83, 25);
            tbsy7.Size = new Size(83, 25);
            tbsy8.Size = new Size(83, 25);
            tbpr1.Size = new Size(174, 25);
            tbpr2.Size = new Size(174, 25);
            tbpr3.Size = new Size(174, 25);
            tbpr4.Size = new Size(174, 25);
            tbpr5.Size = new Size(174, 25);
            tbpr6.Size = new Size(174, 25);
            tbpr7.Size = new Size(174, 25);
            tbpr8.Size = new Size(174, 25);
            tbbr1.Size = new Size(174, 25);
            tbbr2.Size = new Size(174, 25);
            tbbr3.Size = new Size(174, 25);
            tbbr4.Size = new Size(174, 25);
            tbbr5.Size = new Size(174, 25);
            tbbr6.Size = new Size(174, 25);
            tbbr7.Size = new Size(174, 25);
            tbbr8.Size = new Size(174, 25);
            tbtp1.Size = new Size(174, 25);
            tbtp2.Size = new Size(174, 25);
            tbtp3.Size = new Size(174, 25);
            tbtp4.Size = new Size(174, 25);
            tbtp5.Size = new Size(174, 25);
            tbtp6.Size = new Size(174, 25);
            tbtp7.Size = new Size(174, 25);
            tbtp8.Size = new Size(174, 25);
            #endregion

            #region TextBox ReadOnly
            tbdi1.ReadOnly = true;
            tbdi2.ReadOnly = true;
            tbdi3.ReadOnly = true;
            tbdi4.ReadOnly = true;
            tbdi5.ReadOnly = true;
            tbdi6.ReadOnly = true;
            tbdi7.ReadOnly = true;
            tbdi8.ReadOnly = true;
            tbsy1.ReadOnly = true;
            tbsy2.ReadOnly = true;
            tbsy3.ReadOnly = true;
            tbsy4.ReadOnly = true;
            tbsy5.ReadOnly = true;
            tbsy6.ReadOnly = true;
            tbsy7.ReadOnly = true;
            tbsy8.ReadOnly = true;
            tbpr1.ReadOnly = true;
            tbpr2.ReadOnly = true;
            tbpr3.ReadOnly = true;
            tbpr4.ReadOnly = true;
            tbpr5.ReadOnly = true;
            tbpr6.ReadOnly = true;
            tbpr7.ReadOnly = true;
            tbpr8.ReadOnly = true;
            tbbr1.ReadOnly = true;
            tbbr2.ReadOnly = true;
            tbbr3.ReadOnly = true;
            tbbr4.ReadOnly = true;
            tbbr5.ReadOnly = true;
            tbbr6.ReadOnly = true;
            tbbr7.ReadOnly = true;
            tbbr8.ReadOnly = true;
            tbtp1.ReadOnly = true;
            tbtp2.ReadOnly = true;
            tbtp3.ReadOnly = true;
            tbtp4.ReadOnly = true;
            tbtp5.ReadOnly = true;
            tbtp6.ReadOnly = true;
            tbtp7.ReadOnly = true;
            tbtp8.ReadOnly = true;
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
        private void MainPageButton_Click(object sender, EventArgs e)
        {
            AfterLogin.aftersingleton.Show();
            AfterLogin.aftersingleton.Location = this.Location;
            this.Hide();
        }

        private void BedButton1_Click(object sender, EventArgs e)
        {
            BedSideView1.bed1singleton.Show();
            BedSideView1.bed1singleton.Location = this.Location;
            this.Hide();
        }

        private void BedButton2_Click(object sender, EventArgs e)
        {
            BedSideView2.bed2singleton.Show();
            BedSideView2.bed2singleton.Location = this.Location;
            this.Hide();
        }

        private void BedButton3_Click(object sender, EventArgs e)
        {
            BedSideView3.bed3singleton.Show();
            BedSideView3.bed3singleton.Location = this.Location;
            this.Hide();
        }

        private void BedButton4_Click(object sender, EventArgs e)
        {
            BedSideView4.bed4singleton.Show();
            BedSideView4.bed4singleton.Location = this.Location;
            this.Hide();
        }

        private void BedButton5_Click(object sender, EventArgs e)
        {
            BedSideView5.bed5singleton.Show();
            BedSideView5.bed5singleton.Location = this.Location;
            this.Hide();
        }

        private void BedButton6_Click(object sender, EventArgs e)
        {
            BedSideView6.bed6singleton.Show();
            BedSideView6.bed6singleton.Location = this.Location;
            this.Hide();
        }

        private void BedButton7_Click(object sender, EventArgs e)
        {
            BedSideView7.bed7singleton.Show();
            BedSideView7.bed7singleton.Location = this.Location;
            this.Hide();
        }

        private void BedButton8_Click(object sender, EventArgs e)
        {
            BedSideView8.bed8singleton.Show();
            BedSideView8.bed8singleton.Location = this.Location;
            this.Hide();
        }

    }
}
