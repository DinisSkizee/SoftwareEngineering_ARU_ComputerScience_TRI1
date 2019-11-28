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
    public partial class RDLogs : Form
    {
        public RDLogs()
        {
            InitializeComponent();
        }
        //returns to previous page
        private void BackButtonRDLogs_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            logs.Location = this.Location;
            this.Hide();
        }
        //to minimize
        private void MinimizeButtonRDLogs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //to exit 
        private void CloseButtonRDLogs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
