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
        // leads to Alarm Logs page
        private void button4_Click(object sender, EventArgs e)
        {
          
            AlarmLogs alarmlogs = new AlarmLogs();
            alarmlogs.Show();
            alarmlogs.Location = this.Location;
            this.Hide();
        }


       

        private void RDLogs_Click(object sender, EventArgs e)
        {
            RDLogs rdlogs = new RDLogs();
            rdlogs.Show();
            rdlogs.Location = this.Location;
            this.Hide();
        }
        
        // to close/exit 
        private void CloseButtonLogs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // to minimize the page 
        private void MinimizeButtonLogs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        //heart icon on the top left corner leads back to AfterLogin Pagelogs
        private void MainPageButton_Click_1(object sender, EventArgs e)
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            afterlogin.Location = this.Location;
            this.Hide();
        }
    }
    
    }
   