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
        private object dtpDateTimeBegin;
        private string myDateTimeBegin;
        private string myDateTimeEnd;
        private object dtpDateTimeEnd;
        private string myStaffID;
        private object txtAction;
        private object frm;

        public object Frm { get; private set; }

        public OnCallStaff()
        {
            InitializeComponent();
        }

        private void OnCallStaff_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            myDateTimeBegin = Convert.ToDateTime(dtpDateTimeBegin.Text).ToString("yyy-MM-dd");
            myDateTimeEnd = Convert.ToDateTime(dtpDateTimeEnd.Text).ToString("yyy-MM-dd");
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow myRow = dataGridView1.CurrentRow;
                myStaffID = myRow.Cells[0].Value.ToString();
                txtAction.Text = "Edit" + myStaffID + ";";
                //MessageBox.Show(txtAction.Text);
                del(this.txtAction);
                //frm.show();
                DialogResult dr = Frm.ShowDialog();
                if (dr == DialogResult.OK) //or whatever it is
                {
                    PopulateDataGrid();
                    frm.ShowDialog();
                }
            }
        }
        catch private void PopulateDataGrid()
        {
            throw new NotImplementedException();
        }

        private void del(object txtAction)
        {
            throw new NotImplementedException();
        }

        (Exception ex)
       }
    }
}
