using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace FinalProject

    // RD(REGISTER/DEREGISTER) LOGS BY PRIYANKA 
{
    public partial class RDLogs : Form
    {
        public RDLogs()
        {
            InitializeComponent();
        }
        //the button in the top left corner which returns back to Logs page upon clicking
        private void BackButtonRDLogs_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            logs.Location = this.Location;
            this.Hide();
        }
        //to minimize (in the right corner next to exit button)
        private void MinimizeButtonRDLogs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //to exit (in the right top corner)
        private void CloseButtonRDLogs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* to call the database connection 
         * declaring the varriable name
         */

        SqlConnection CON = new SqlConnection("Data Source=.;Initial Catalog=Datainfo;Integrated Security=True;Pooling=False");
        
        // inorder for the save button to save the data entered 
        private void SAVEBUTTON_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO RDLOGS (ID,DATE,ACTION) VALUES ('" + IDTextBox.Text + "','" + dateTimePicker1.Text + "', '" + ActionComboBox.Text + "')", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("Saved");
        }
        /*upon clicking the view button, the saved data will show up
         * in order to do that the following was done */
        private void VIEWBUTTON_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM RDLOGS", CON);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            dataGridView1.DataSource = DATA;
            CON.Close();
        }
        // to be able to delete data saved
        private void DELETEBUTTON_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM RDLOGS WHERE ID='" + IDTextBox.Text + "'", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("Deleted");
        }
    }


}
