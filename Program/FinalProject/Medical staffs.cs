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
    public partial class Medical_staffs : Form
    {
        private object table;

        public Medical_staffs()
        {
            InitializeComponent();
        }

        private DataTable table = new DataTable();
        
        public int selectedRow { get; private set; }


        private void button2_Click(object sender, EventArgs e)
        {

            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            newDataRow.Cells[0].Value = textBox1.Text;
            newDataRow.Cells[1].Value = textBox2.Text;
            newDataRow.Cells[2].Value = textBox3.Text;
            newDataRow.Cells[3].Value = textBox4.Text;
            newDataRow.Cells[4].Value = textBox5.Text;
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }
    }
}
