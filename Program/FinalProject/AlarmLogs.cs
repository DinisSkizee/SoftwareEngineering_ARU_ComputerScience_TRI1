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
    public partial class AlarmLogs : Form
    {
        public AlarmLogs()
        {
            InitializeComponent();
        }

        private void MinimizeButtonAlarmLogs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void CloseButtonAlarmLogs_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        // backbutton leads the page back to Logs page
        private void BackButton_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            logs.Location = this.Location;
            this.Hide();
        }
    }
   

       
    }

    
    

 

        
 