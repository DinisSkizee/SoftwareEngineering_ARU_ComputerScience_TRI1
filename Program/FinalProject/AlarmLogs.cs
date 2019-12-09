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
{
    public partial class AlarmLogs : Form
    {
        public AlarmLogs()
        {
            InitializeComponent();
        }
        //to minimize the page
        private void MinimizeButtonAlarmLogs_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        // to exit the page
        private void CloseButtonAlarmLogs_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        /* to call the database connection 
        * declaring the varriable name
        */

        SqlConnection CON = new SqlConnection("Data Source=.;Initial Catalog=Datainfo;Integrated Security=True;Pooling=False");
        // backbutton leads the page back to Logs page




        private void BackButton_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            logs.Location = this.Location;
            this.Hide();
        }
        // saves data entered
        private void AlarmLogsSaveButton_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("INSERT INTO ALARMLOGS (ID,DATE,FIRSTALARM,ALARMRECTIFIED,COMMENTS) VALUES ('" + IDBox.Text + "','" + DateBox.Text + "', '" + time1
                .Text + "', '" + time2
                .Text + "','" + CommentsBox.Text + "')", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("Saved");
        }
        // to view data entered 
        private void AlarmLogsView_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM ALARMLOGS", CON);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            dataGridView1.DataSource = DATA;
            CON.Close();
        }

        private void AlarmDeleteButton_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("DELETE FROM ALARMLOGS WHERE ID='" + IDBox.Text + "'", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("Deleted");
        }
    }
   

       
    }

    
    

 

        
 