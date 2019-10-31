using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management4
{
    public partial class AlarmLogss : Form
    {
        public AlarmLogss()
        {
            InitializeComponent();
        }

        private void alarm_LogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alarm_LogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alarmlogsDataSet1);

        }

        private void AlarmLogss_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alarmlogsDataSet1.Alarm_Logs' table. You can move, or remove it, as needed.
            this.alarm_LogsTableAdapter.Fill(this.alarmlogsDataSet1.Alarm_Logs);

        }
    }
}
