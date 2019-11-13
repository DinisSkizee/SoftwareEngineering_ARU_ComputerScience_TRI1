using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BedSideView7 : Form
    {
        public BedSideView7()
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
        private void CloseButtonBedSideView_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Button
        private void MinimizeButtonBedSideView_Click(object sender, EventArgs e)
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

        #region Bed Buttons Click  -- Dinis & Jorge
        private void Bed1_Click(object sender, EventArgs e)
        {
            BedSideView1 bedSideView1 = new BedSideView1();
            bedSideView1.Show();
            bedSideView1.Location = this.Location;
            this.Hide();
        }

        private void Bed2_Click(object sender, EventArgs e)
        {
            BedSideView2 bedSideView2 = new BedSideView2();
            bedSideView2.Show();
            bedSideView2.Location = this.Location;
            this.Hide();
        }

        private void Bed3_Click(object sender, EventArgs e)
        {
            BedSideView3 bedSideView3 = new BedSideView3();
            bedSideView3.Show();
            bedSideView3.Location = this.Location;
            this.Hide();
        }

        private void Bed4_Click(object sender, EventArgs e)
        {
            BedSideView4 bedSideView4 = new BedSideView4();
            bedSideView4.Show();
            bedSideView4.Location = this.Location;
            this.Hide();
        }

        private void Bed5_Click(object sender, EventArgs e)
        {
            BedSideView5 bedSideView5 = new BedSideView5();
            bedSideView5.Show();
            bedSideView5.Location = this.Location;
            this.Hide();
        }

        private void Bed6_Click(object sender, EventArgs e)
        {
            BedSideView6 bedSideView6 = new BedSideView6();
            bedSideView6.Show();
            bedSideView6.Location = this.Location;
            this.Hide();
        }

        private void Bed8_Click(object sender, EventArgs e)
        {
            BedSideView8 bedSideView8 = new BedSideView8();
            bedSideView8.Show();
            bedSideView8.Location = this.Location;
            this.Hide();
        }
        #endregion

        #region InsertButtons Configuration  -- Dinis & Jorge
        private void InsertButton1_Click(object sender, EventArgs e)
        {
            SocketSelection soS = new SocketSelection();

            soS.DefaultPanel_BedComboBox.SelectedItem = "Bed 7";
            soS.Show();
            soS.Location = this.Location;
            this.Hide();
        }

        private void InsertButton2_Click(object sender, EventArgs e)
        {
            SocketSelection soS = new SocketSelection();

            soS.DefaultPanel_BedComboBox.SelectedItem = "Bed 7";
            soS.Show();
            soS.Location = this.Location;
            this.Hide();
        }

        private void InsertButton3_Click(object sender, EventArgs e)
        {
            SocketSelection soS = new SocketSelection();

            soS.DefaultPanel_BedComboBox.SelectedItem = "Bed 7";
            soS.Show();
            soS.Location = this.Location;
            this.Hide();
        }

        private void InsertButton4_Click(object sender, EventArgs e)
        {
            SocketSelection soS = new SocketSelection();

            soS.DefaultPanel_BedComboBox.SelectedItem = "Bed 7";
            soS.Show();
            soS.Location = this.Location;
            this.Hide();
        }
        #endregion

        #region EjectButton Configuration  -- Dinis & Jorge
        private void EjectButton1_Click(object sender, EventArgs e)
        {
            BreathingRatePanelBed1.Visible = false;
            BloodPressurePanelBed1.Visible = false;
            TemperaturePanelBed1.Visible = false;
            PulseRatePanelBed1.Visible = false;
            InsertASocket1.Visible = true;
        }

        private void EjectButton2_Click(object sender, EventArgs e)
        {
            BreathingRatePanelBed1.Visible = false;
            BloodPressurePanelBed1.Visible = false;
            TemperaturePanelBed1.Visible = false;
            PulseRatePanelBed1.Visible = false;
            InsertASocket1.Visible = true;
        }

        private void EjectButton3_Click(object sender, EventArgs e)
        {
            BreathingRatePanelBed1.Visible = false;
            BloodPressurePanelBed1.Visible = false;
            TemperaturePanelBed1.Visible = false;
            PulseRatePanelBed1.Visible = false;
            InsertASocket1.Visible = true;
        }

        private void EjectButton4_Click(object sender, EventArgs e)
        {
            BreathingRatePanelBed1.Visible = false;
            BloodPressurePanelBed1.Visible = false;
            TemperaturePanelBed1.Visible = false;
            PulseRatePanelBed1.Visible = false;
            InsertASocket1.Visible = true;
        }
        #endregion

        private void EjectButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
