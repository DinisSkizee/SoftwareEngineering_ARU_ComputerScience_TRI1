using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Maryam M.R

namespace FinalProject
{
    public partial class managerments : Form
    {
        private object regstff;

        public managerments()
        {
            InitializeComponent();
        }

        //heart icon on the top left corner leads back to AfterLogin page
        private void MainPageButton_Click(object sender, EventArgs e)
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            afterlogin.Location = this.Location;
            this.Hide();
        }
         //minimize the page
        private void MinimizeButtonLogs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
         //close the page
        private void CloseButtonLogs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         //leads to register onCall staffs
        private void Regstff_Click(object sender, EventArgs e)
        {
            Regstff regstff = new Regstff();
            regstff.Show();
            regstff.Location = this.Location;
            this.Hide();

        }

        private void SeniorDoc_Click(object sender, EventArgs e)
        {
            SeniorDoc_Click seniordoc = new SeniorDoc_Click();
            seniorDoc.Show();
            seniorDoc.Location = this.Location;
            this.Hide();
        }
    }
}
