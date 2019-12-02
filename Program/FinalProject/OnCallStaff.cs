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
    public partial class OnCallStaff : Form
    {


        public OnCallStaff()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void OnCallStaff_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            table.Columns.Add("staff id", typeof(string));
            table.Columns.Add("shift id", typeof(int));
            table.Columns.Add("Date time begin", typeof(DateTime));
            table.Columns.Add("Date time End", typeof(DateTime));
            table.Columns.Add("Shift status", typeof(string));

            dataGridView1.DataSource = table;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
            dataGridView1.DataSource = table;

        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            AfterLogin afterlogin = new AfterLogin();
            afterlogin.Show();
            afterlogin.Location = this.Location;
            this.Hide();
        }

        private void BackButtonmanagements_Click(object sender, EventArgs e)
        {
            managerments managerments = new managerments();
            managerments.Show();
            managerments.Location = this.Location;
            this.Hide();
        }
    }
}
        
      
    