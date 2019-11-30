using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace FinalProject
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage("projectsoftware8@gmail.com", textBox1.Text, "your mail subject over here", textBox2.Text);
            SmtpClient mail = new SmtpClient();
            mail.Host = "smtp.gmail.com";
            mail.Port = 587;
            mail.Credentials = new NetworkCredential("projectsoftware8@gmail.com", "maryammodibbo");
            mail.EnableSsl = true;
            mail.Send(msg);
            MessageBox.Show("SHIFT REMINDER HAS BEEN MAILED");
        }
    
    }
}
