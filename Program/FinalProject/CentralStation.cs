using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CentralStation : Form
    {
        public CentralStation()
        {
            InitializeComponent();
        }

        #region Close/Maximize/Minimize Button
        private void CloseButtonCentralStation_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeButtonCentralStation_Click(object sender, EventArgs e)
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

        private void MinimizeButtonCentralStation_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

    }
}
