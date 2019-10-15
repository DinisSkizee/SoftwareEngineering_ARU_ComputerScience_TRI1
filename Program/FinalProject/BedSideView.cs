using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BedSideView : Form
    {
        public BedSideView()
        {
            InitializeComponent();
        }

        #region Close/Maximize/Minimize Buttons
        // Close Button
        private void CloseButtonBedSideView_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Maximize Button
        private void MaximizeButtonBedSideView_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // Minimize Button
        private void MinimizeButtonBedSideView_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
