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

            // Visible = false to every SocketPanel in the form
            BloodPressurePanel.Visible = true;
            PulseRatePanel.Visible = false;
            BreathingRatePanel.Visible = false;
            TemperaturePanel.Visible = false;
            VO2MaxPanel.Visible = false;
            DetailsPanel.Visible = false;
        }

        #region ScrollBar Configuration  -- Dinis & Jorge
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinuminumParameter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
