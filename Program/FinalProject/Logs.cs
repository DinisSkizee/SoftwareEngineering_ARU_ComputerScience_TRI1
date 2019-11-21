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

        private void Logs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AlarmLogs alarmlogs = new AlarmLogs();
            alarmlogs.Show();
            alarmlogs.Location = this.Location;
            this.Hide();
        }

        
private void LogoutButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            AlarmLogs alarmlogs = new AlarmLogs();
            alarmlogs.Show();
            alarmlogs.Location = this.Location;
            this.Hide();
        }

        private void Logs_Load_1(object sender, EventArgs e)
        {

        }

       

        private void RDLogs_Click(object sender, EventArgs e)
        {

        }
        // heart icon in the top left corner leads to AfterLogin page 
       

        private void CloseButtonLogs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButtonLogs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void MainPageButton_Click_1(object sender, EventArgs e)
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            afterlogin.Location = this.Location;
            this.Hide();
        }
    }
    
    }
   