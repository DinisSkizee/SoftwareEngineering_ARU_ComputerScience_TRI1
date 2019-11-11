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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlarmLogs alarmlogs = new AlarmLogs();
            alarmlogs.Show();
            alarmlogs.Location = this.Location;
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReDeregisterLogs registerlogs = new ReDeregisterLogs();
            rederegisterlogs.Show();
            registerlogs.Location = this.Location;
            this.Hide();

        }


        }
    }
}
