using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BedSideView6 : Form
    {
        public static BedSideView6 bed6singleton = new BedSideView6();

        public BedSideView6()
        {
            bed6singleton = this;
            InitializeComponent();
            new CentralStation();
            new BedSideViewConfiguration();

            BedSideViewConfiguration.timer.Tick += UpdateTextBox;
            BedSideViewConfiguration.timer.Tick += ActiveCheck;
            BedSideViewConfiguration.timer.Tick += UpdateCentralStation;
            BedSideViewConfiguration.timer.Tick += UpdateColor;

            #region moduleState[i] Variable Assign
            if ((BreathingRatePanelBed1.Dock == DockStyle.Fill) || (BloodPressurePanelBed1.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed1.Dock == DockStyle.Fill) || (PulseRatePanelBed1.Dock == DockStyle.Fill)) { moduleState1 = 1; }

            if ((BreathingRatePanelBed2.Dock == DockStyle.Fill) || (BloodPressurePanelBed2.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed2.Dock == DockStyle.Fill) || (PulseRatePanelBed2.Dock == DockStyle.Fill)) { moduleState2 = 1; }

            if ((BreathingRatePanelBed3.Dock == DockStyle.Fill) || (BloodPressurePanelBed3.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed3.Dock == DockStyle.Fill) || (PulseRatePanelBed3.Dock == DockStyle.Fill)) { moduleState3 = 1; }

            if ((BreathingRatePanelBed4.Dock == DockStyle.Fill) || (BloodPressurePanelBed4.Dock == DockStyle.Fill) ||
                (TemperaturePanelBed4.Dock == DockStyle.Fill) || (PulseRatePanelBed4.Dock == DockStyle.Fill)) { moduleState4 = 1; }
            #endregion

            #region TextBox Multiline Disable
            tbfn.Multiline = false;
            tbgender.Multiline = false;
            tbage.Multiline = false;
            tbln.Multiline = false;
            tbheight.Multiline = false;
            tbweight.Multiline = false;
            BreathingRate_Actual_Text.Multiline = false;
            BreathingRate_Actual_Text2.Multiline = false;
            BreathingRate_Actual_Text3.Multiline = false;
            BreathingRate_Actual_Text4.Multiline = false;
            BreathingRate_Minimum_Text.Multiline = false;
            BreathingRate_Minimum_Text2.Multiline = false;
            BreathingRate_Minimum_Text3.Multiline = false;
            BreathingRate_Minimum_Text4.Multiline = false;
            BreathingRate_Maximum_Text.Multiline = false;
            BreathingRate_Maximum_Text2.Multiline = false;
            BreathingRate_Maximum_Text3.Multiline = false;
            BreathingRate_Maximum_Text4.Multiline = false;
            DiBloodPressurePanelBed_Actual_Text.Multiline = false;
            DiBloodPressurePanelBed_Actual_Text2.Multiline = false;
            DiBloodPressurePanelBed_Actual_Text3.Multiline = false;
            DiBloodPressurePanelBed_Actual_Text4.Multiline = false;
            DiBloodPressurePanelBed_Maximum_Text.Multiline = false;
            DiBloodPressurePanelBed_Maximum_Text2.Multiline = false;
            DiBloodPressurePanelBed_Maximum_Text3.Multiline = false;
            DiBloodPressurePanelBed_Maximum_Text4.Multiline = false;
            DiBloodPressurePanelBed_Minimum_Text.Multiline = false;
            DiBloodPressurePanelBed_Minimum_Text2.Multiline = false;
            DiBloodPressurePanelBed_Minimum_Text3.Multiline = false;
            DiBloodPressurePanelBed_Minimum_Text4.Multiline = false;
            PulseRate_Actual_Text.Multiline = false;
            PulseRate_Actual_Text2.Multiline = false;
            PulseRate_Actual_Text3.Multiline = false;
            PulseRate_Actual_Text4.Multiline = false;
            PulseRate_Maximum_Text.Multiline = false;
            PulseRate_Maximum_Text2.Multiline = false;
            PulseRate_Maximum_Text3.Multiline = false;
            PulseRate_Maximum_Text4.Multiline = false;
            PulseRate_Minimum_Text.Multiline = false;
            PulseRate_Minimum_Text2.Multiline = false;
            PulseRate_Minimum_Text3.Multiline = false;
            PulseRate_Minimum_Text4.Multiline = false;
            SyBloodPressurePanelBed_Actual_Text.Multiline = false;
            SyBloodPressurePanelBed_Actual_Text2.Multiline = false;
            SyBloodPressurePanelBed_Actual_Text3.Multiline = false;
            SyBloodPressurePanelBed_Actual_Text4.Multiline = false;
            SyBloodPressurePanelBed_Maximum_Text.Multiline = false;
            SyBloodPressurePanelBed_Maximum_Text2.Multiline = false;
            SyBloodPressurePanelBed_Maximum_Text3.Multiline = false;
            SyBloodPressurePanelBed_Maximum_Text4.Multiline = false;
            SyBloodPressurePanelBed_Minimum_Text.Multiline = false;
            SyBloodPressurePanelBed_Minimum_Text2.Multiline = false;
            SyBloodPressurePanelBed_Minimum_Text3.Multiline = false;
            SyBloodPressurePanelBed_Minimum_Text4.Multiline = false;
            Temperature_Actual_Text.Multiline = false;
            Temperature_Actual_Text2.Multiline = false;
            Temperature_Actual_Text3.Multiline = false;
            Temperature_Actual_Text4.Multiline = false;
            Temperature_Maximum_Text.Multiline = false;
            Temperature_Maximum_Text2.Multiline = false;
            Temperature_Maximum_Text3.Multiline = false;
            Temperature_Maximum_Text4.Multiline = false;
            Temperature_Minimum_Text.Multiline = false;
            Temperature_Minimum_Text2.Multiline = false;
            Temperature_Minimum_Text3.Multiline = false;
            Temperature_Minimum_Text4.Multiline = false;

            #endregion

            #region AutoSize False
            tbfn.AutoSize = false;
            tbgender.AutoSize = false;
            tbage.AutoSize = false;
            tbln.AutoSize = false;
            tbheight.AutoSize = false;
            tbweight.AutoSize = false;
            BreathingRate_Actual_Text.AutoSize = false;
            BreathingRate_Actual_Text2.AutoSize = false;
            BreathingRate_Actual_Text3.AutoSize = false;
            BreathingRate_Actual_Text4.AutoSize = false;
            BreathingRate_Minimum_Text.AutoSize = false;
            BreathingRate_Minimum_Text2.AutoSize = false;
            BreathingRate_Minimum_Text3.AutoSize = false;
            BreathingRate_Minimum_Text4.AutoSize = false;
            BreathingRate_Maximum_Text.AutoSize = false;
            BreathingRate_Maximum_Text2.AutoSize = false;
            BreathingRate_Maximum_Text3.AutoSize = false;
            BreathingRate_Maximum_Text4.AutoSize = false;
            DiBloodPressurePanelBed_Actual_Text.AutoSize = false;
            DiBloodPressurePanelBed_Actual_Text2.AutoSize = false;
            DiBloodPressurePanelBed_Actual_Text3.AutoSize = false;
            DiBloodPressurePanelBed_Actual_Text4.AutoSize = false;
            DiBloodPressurePanelBed_Maximum_Text.AutoSize = false;
            DiBloodPressurePanelBed_Maximum_Text2.AutoSize = false;
            DiBloodPressurePanelBed_Maximum_Text3.AutoSize = false;
            DiBloodPressurePanelBed_Maximum_Text4.AutoSize = false;
            DiBloodPressurePanelBed_Minimum_Text.AutoSize = false;
            DiBloodPressurePanelBed_Minimum_Text2.AutoSize = false;
            DiBloodPressurePanelBed_Minimum_Text3.AutoSize = false;
            DiBloodPressurePanelBed_Minimum_Text4.AutoSize = false;
            PulseRate_Actual_Text.AutoSize = false;
            PulseRate_Actual_Text2.AutoSize = false;
            PulseRate_Actual_Text3.AutoSize = false;
            PulseRate_Actual_Text4.AutoSize = false;
            PulseRate_Maximum_Text.AutoSize = false;
            PulseRate_Maximum_Text2.AutoSize = false;
            PulseRate_Maximum_Text3.AutoSize = false;
            PulseRate_Maximum_Text4.AutoSize = false;
            PulseRate_Minimum_Text.AutoSize = false;
            PulseRate_Minimum_Text2.AutoSize = false;
            PulseRate_Minimum_Text3.AutoSize = false;
            PulseRate_Minimum_Text4.AutoSize = false;
            SyBloodPressurePanelBed_Actual_Text.AutoSize = false;
            SyBloodPressurePanelBed_Actual_Text2.AutoSize = false;
            SyBloodPressurePanelBed_Actual_Text3.AutoSize = false;
            SyBloodPressurePanelBed_Actual_Text4.AutoSize = false;
            SyBloodPressurePanelBed_Maximum_Text.AutoSize = false;
            SyBloodPressurePanelBed_Maximum_Text2.AutoSize = false;
            SyBloodPressurePanelBed_Maximum_Text3.AutoSize = false;
            SyBloodPressurePanelBed_Maximum_Text4.AutoSize = false;
            SyBloodPressurePanelBed_Minimum_Text.AutoSize = false;
            SyBloodPressurePanelBed_Minimum_Text2.AutoSize = false;
            SyBloodPressurePanelBed_Minimum_Text3.AutoSize = false;
            SyBloodPressurePanelBed_Minimum_Text4.AutoSize = false;
            Temperature_Actual_Text.AutoSize = false;
            Temperature_Actual_Text2.AutoSize = false;
            Temperature_Actual_Text3.AutoSize = false;
            Temperature_Actual_Text4.AutoSize = false;
            Temperature_Maximum_Text.AutoSize = false;
            Temperature_Maximum_Text2.AutoSize = false;
            Temperature_Maximum_Text3.AutoSize = false;
            Temperature_Maximum_Text4.AutoSize = false;
            Temperature_Minimum_Text.AutoSize = false;
            Temperature_Minimum_Text2.AutoSize = false;
            Temperature_Minimum_Text3.AutoSize = false;
            Temperature_Minimum_Text4.AutoSize = false;
            #endregion

            #region TextBox Size
            tbfn.Size = new Size(151, 36);
            tbgender.Size = new Size(151, 36);
            tbage.Size = new Size(151, 36);
            tbln.Size = new Size(151, 36);
            tbheight.Size = new Size(151, 36);
            tbweight.Size = new Size(151, 36);
            BreathingRate_Actual_Text.Size = new Size(65, 20);
            BreathingRate_Actual_Text2.Size = new Size(65, 20);
            BreathingRate_Actual_Text3.Size = new Size(65, 20);
            BreathingRate_Actual_Text4.Size = new Size(65, 20);
            BreathingRate_Minimum_Text.Size = new Size(65, 20);
            BreathingRate_Minimum_Text2.Size = new Size(65, 20);
            BreathingRate_Minimum_Text3.Size = new Size(65, 20);
            BreathingRate_Minimum_Text4.Size = new Size(65, 20);
            BreathingRate_Maximum_Text.Size = new Size(65, 20);
            BreathingRate_Maximum_Text2.Size = new Size(65, 20);
            BreathingRate_Maximum_Text3.Size = new Size(65, 20);
            BreathingRate_Maximum_Text4.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Actual_Text.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Actual_Text2.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Actual_Text3.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Actual_Text4.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Maximum_Text.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Maximum_Text2.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Maximum_Text3.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Maximum_Text4.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Minimum_Text.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Minimum_Text2.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Minimum_Text3.Size = new Size(65, 20);
            DiBloodPressurePanelBed_Minimum_Text4.Size = new Size(65, 20);
            PulseRate_Actual_Text.Size = new Size(65, 20);
            PulseRate_Actual_Text2.Size = new Size(65, 20);
            PulseRate_Actual_Text3.Size = new Size(65, 20);
            PulseRate_Actual_Text4.Size = new Size(65, 20);
            PulseRate_Maximum_Text.Size = new Size(65, 20);
            PulseRate_Maximum_Text2.Size = new Size(65, 20);
            PulseRate_Maximum_Text3.Size = new Size(65, 20);
            PulseRate_Maximum_Text4.Size = new Size(65, 20);
            PulseRate_Minimum_Text.Size = new Size(65, 20);
            PulseRate_Minimum_Text2.Size = new Size(65, 20);
            PulseRate_Minimum_Text3.Size = new Size(65, 20);
            PulseRate_Minimum_Text4.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Actual_Text.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Actual_Text2.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Actual_Text3.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Actual_Text4.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Maximum_Text.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Maximum_Text2.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Maximum_Text3.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Maximum_Text4.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Minimum_Text.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Minimum_Text2.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Minimum_Text3.Size = new Size(65, 20);
            SyBloodPressurePanelBed_Minimum_Text4.Size = new Size(65, 20);
            Temperature_Actual_Text.Size = new Size(65, 20);
            Temperature_Actual_Text2.Size = new Size(65, 20);
            Temperature_Actual_Text3.Size = new Size(65, 20);
            Temperature_Actual_Text4.Size = new Size(65, 20);
            Temperature_Maximum_Text.Size = new Size(65, 20);
            Temperature_Maximum_Text2.Size = new Size(65, 20);
            Temperature_Maximum_Text3.Size = new Size(65, 20);
            Temperature_Maximum_Text4.Size = new Size(65, 20);
            Temperature_Minimum_Text.Size = new Size(65, 20);
            Temperature_Minimum_Text2.Size = new Size(65, 20);
            Temperature_Minimum_Text3.Size = new Size(65, 20);
            Temperature_Minimum_Text4.Size = new Size(65, 20);
            #endregion

            #region TextBox ReadOnly
            tbfn.ReadOnly = true;
            tbgender.ReadOnly = true;
            tbage.ReadOnly = true;
            tbln.ReadOnly = true;
            tbheight.ReadOnly = true;
            tbweight.ReadOnly = true;
            BreathingRate_Actual_Text.ReadOnly = true;
            BreathingRate_Actual_Text2.ReadOnly = true;
            BreathingRate_Actual_Text3.ReadOnly = true;
            BreathingRate_Actual_Text4.ReadOnly = true;
            BreathingRate_Minimum_Text.ReadOnly = true;
            BreathingRate_Minimum_Text2.ReadOnly = true;
            BreathingRate_Minimum_Text3.ReadOnly = true;
            BreathingRate_Minimum_Text4.ReadOnly = true;
            BreathingRate_Maximum_Text.ReadOnly = true;
            BreathingRate_Maximum_Text2.ReadOnly = true;
            BreathingRate_Maximum_Text3.ReadOnly = true;
            BreathingRate_Maximum_Text4.ReadOnly = true;
            DiBloodPressurePanelBed_Actual_Text.ReadOnly = true;
            DiBloodPressurePanelBed_Actual_Text2.ReadOnly = true;
            DiBloodPressurePanelBed_Actual_Text3.ReadOnly = true;
            DiBloodPressurePanelBed_Actual_Text4.ReadOnly = true;
            DiBloodPressurePanelBed_Maximum_Text.ReadOnly = true;
            DiBloodPressurePanelBed_Maximum_Text2.ReadOnly = true;
            DiBloodPressurePanelBed_Maximum_Text3.ReadOnly = true;
            DiBloodPressurePanelBed_Maximum_Text4.ReadOnly = true;
            DiBloodPressurePanelBed_Minimum_Text.ReadOnly = true;
            DiBloodPressurePanelBed_Minimum_Text2.ReadOnly = true;
            DiBloodPressurePanelBed_Minimum_Text3.ReadOnly = true;
            DiBloodPressurePanelBed_Minimum_Text4.ReadOnly = true;
            PulseRate_Actual_Text.ReadOnly = true;
            PulseRate_Actual_Text2.ReadOnly = true;
            PulseRate_Actual_Text3.ReadOnly = true;
            PulseRate_Actual_Text4.ReadOnly = true;
            PulseRate_Maximum_Text.ReadOnly = true;
            PulseRate_Maximum_Text2.ReadOnly = true;
            PulseRate_Maximum_Text3.ReadOnly = true;
            PulseRate_Maximum_Text4.ReadOnly = true;
            PulseRate_Minimum_Text.ReadOnly = true;
            PulseRate_Minimum_Text2.ReadOnly = true;
            PulseRate_Minimum_Text3.ReadOnly = true;
            PulseRate_Minimum_Text4.ReadOnly = true;
            SyBloodPressurePanelBed_Actual_Text.ReadOnly = true;
            SyBloodPressurePanelBed_Actual_Text2.ReadOnly = true;
            SyBloodPressurePanelBed_Actual_Text3.ReadOnly = true;
            SyBloodPressurePanelBed_Actual_Text4.ReadOnly = true;
            SyBloodPressurePanelBed_Maximum_Text.ReadOnly = true;
            SyBloodPressurePanelBed_Maximum_Text2.ReadOnly = true;
            SyBloodPressurePanelBed_Maximum_Text3.ReadOnly = true;
            SyBloodPressurePanelBed_Maximum_Text4.ReadOnly = true;
            SyBloodPressurePanelBed_Minimum_Text.ReadOnly = true;
            SyBloodPressurePanelBed_Minimum_Text2.ReadOnly = true;
            SyBloodPressurePanelBed_Minimum_Text3.ReadOnly = true;
            SyBloodPressurePanelBed_Minimum_Text4.ReadOnly = true;
            Temperature_Actual_Text.ReadOnly = true;
            Temperature_Actual_Text2.ReadOnly = true;
            Temperature_Actual_Text3.ReadOnly = true;
            Temperature_Actual_Text4.ReadOnly = true;
            Temperature_Maximum_Text.ReadOnly = true;
            Temperature_Maximum_Text2.ReadOnly = true;
            Temperature_Maximum_Text3.ReadOnly = true;
            Temperature_Maximum_Text4.ReadOnly = true;
            Temperature_Minimum_Text.ReadOnly = true;
            Temperature_Minimum_Text2.ReadOnly = true;
            Temperature_Minimum_Text3.ReadOnly = true;
            Temperature_Minimum_Text4.ReadOnly = true;
            #endregion

        }

        public static int ditext, sytext, prtext, brtext, tptext;
        public void UpdateColor(object sender, EventArgs e)
        {
            // Passing textbox.text to variable
            int.TryParse(CentralStation.centralsingleton.tbdi6.Text, out ditext); // Diastolic Value
            int.TryParse(CentralStation.centralsingleton.tbsy6.Text, out sytext); // Systolic Value
            int.TryParse(CentralStation.centralsingleton.tbpr6.Text, out prtext); // Pulse Value
            int.TryParse(CentralStation.centralsingleton.tbbr6.Text, out brtext); // Breathing Value
            int.TryParse(CentralStation.centralsingleton.tbtp6.Text, out tptext); // Temperature Value

            #region Textbox Color
            // Diastolic TextBox Color
            if (ditext < SocketSelection.diMin6 || ditext > SocketSelection.diMax6)
            {
                CentralStation.centralsingleton.tbdi6.BackColor = Color.Red;
            }
            else if (ditext > SocketSelection.diMin6 && ditext < SocketSelection.diMax6)
            {
                CentralStation.centralsingleton.tbdi6.BackColor = Color.FromArgb(105, 105, 105);
            }

            // Systolic TextBox Color
            if (sytext < SocketSelection.syMin6 || sytext > SocketSelection.syMax6)
            {
                CentralStation.centralsingleton.tbsy6.BackColor = Color.Red;
            }
            else if (sytext > SocketSelection.syMin6 && sytext < SocketSelection.syMax6)
            {
                CentralStation.centralsingleton.tbsy6.BackColor = Color.FromArgb(105, 105, 105);
            }

            // Pulse Textbox Color
            if (prtext < SocketSelection.prMin6 || prtext > SocketSelection.prMax6)
            {
                CentralStation.centralsingleton.tbpr6.BackColor = Color.Red;
            }
            else if (prtext > SocketSelection.prMin6 && prtext < SocketSelection.prMax6)
            {
                CentralStation.centralsingleton.tbpr6.BackColor = Color.FromArgb(105, 105, 105);
            }

            // Breathing Textbox Color
            if (brtext < SocketSelection.brMin6 || brtext > SocketSelection.brMax6)
            {
                CentralStation.centralsingleton.tbbr6.BackColor = Color.Red;
            }
            else if (brtext > SocketSelection.brMin6 && brtext < SocketSelection.brMax6)
            {
                CentralStation.centralsingleton.tbbr6.BackColor = Color.FromArgb(105, 105, 105);
            }

            // Temperature Textbox Color
            if (tptext < SocketSelection.tpMin6 || tptext < SocketSelection.tpMax6)
            {
                CentralStation.centralsingleton.tbtp6.BackColor = Color.Red;
            }
            else if (tptext > SocketSelection.tpMin6 && tptext > SocketSelection.tpMax6)
            {
                CentralStation.centralsingleton.tbtp6.BackColor = Color.FromArgb(105, 105, 105);
            }
            #endregion

        }

        public void UpdateTextBox(object sender, EventArgs e)
        {
            DiBloodPressurePanelBed_Actual_Text.Text = DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text2.Text = DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text3.Text = DiastolicValueRandom();
            DiBloodPressurePanelBed_Actual_Text4.Text = DiastolicValueRandom();

            SyBloodPressurePanelBed_Actual_Text.Text = SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text2.Text = SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text3.Text = SystolicValueRandom();
            SyBloodPressurePanelBed_Actual_Text4.Text = SystolicValueRandom();

            PulseRate_Actual_Text.Text = PulseValueRandom();
            PulseRate_Actual_Text2.Text = PulseValueRandom();
            PulseRate_Actual_Text3.Text = PulseValueRandom();
            PulseRate_Actual_Text4.Text = PulseValueRandom();

            BreathingRate_Actual_Text.Text = BreathingValueRandom();
            BreathingRate_Actual_Text2.Text = BreathingValueRandom();
            BreathingRate_Actual_Text3.Text = BreathingValueRandom();
            BreathingRate_Actual_Text4.Text = BreathingValueRandom();

            Temperature_Actual_Text.Text = TemperatureValueRandom();
            Temperature_Actual_Text2.Text = TemperatureValueRandom();
            Temperature_Actual_Text3.Text = TemperatureValueRandom();
            Temperature_Actual_Text4.Text = TemperatureValueRandom();

        }

        public void UpdateCentralStation(object sender, EventArgs e)
        {
            if (bloodActive == true)
            {
                CentralStation.centralsingleton.tbdi6.Text = DiastolicValueRandom();
                CentralStation.centralsingleton.tbsy6.Text = SystolicValueRandom();
            }
            else
            {
                CentralStation.centralsingleton.tbdi6.Text = "";
                CentralStation.centralsingleton.tbsy6.Text = "";
            }

            if (breathingActive == true)
            {
                CentralStation.centralsingleton.tbbr6.Text = BreathingValueRandom();
            }
            else { CentralStation.centralsingleton.tbbr6.Text = ""; }

            if (pulseActive == true)
            {
                CentralStation.centralsingleton.tbpr6.Text = PulseValueRandom();
            }
            else { CentralStation.centralsingleton.tbpr6.Text = ""; }

            if (tempActive == true)
            {
                CentralStation.centralsingleton.tbtp6.Text = TemperatureValueRandom();
            }
            else { CentralStation.centralsingleton.tbtp6.Text = ""; }

        }

        // Variables
        #region Variables
        // How the module is, if it's active or not
        public static int moduleState1, moduleState2, moduleState3, moduleState4;

        // What Insert was Clicked
        public static int insertClicked1, insertClicked2, insertClicked3, insertClicked4;

        // If the panel is visible
        public static bool bloodActive, pulseActive, breathingActive, tempActive;

        // TextBox Values
        public static int syValue, diValue, prValue, brValue;
        public static double tempValue;
        #endregion

        private void CentralStationPic_Click(object sender, EventArgs e)
        {
            CentralStation.centralsingleton.Show();
            CentralStation.centralsingleton.Location = this.Location;
            this.Hide();
        }

        #region Draggable Top Panel  -- Dinis & Jorge
        // Draggable Top Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Close/Minimize Buttons  -- Dinis & Jorge
        // Close Button
        private void CloseButtonBedSideView_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Button
        private void MinimizeButtonBedSideView_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        // Small Icon on the Left Top corner to go back to the AfterLogin form
        private void MainPageButton_Click(object sender, EventArgs e)   // -- Dinis & Jorge
        {
            AfterLogin.aftersingleton.Show();
            AfterLogin.aftersingleton.Location = this.Location;
            this.Hide();
        }

        #region Bed Buttons Click  -- Dinis & Jorge
        private void Bed1_Click(object sender, EventArgs e)
        {
            BedSideView1.bed1singleton.Show();
            BedSideView1.bed1singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed2_Click(object sender, EventArgs e)
        {
            BedSideView2.bed2singleton.Show();
            BedSideView2.bed2singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed3_Click(object sender, EventArgs e)
        {
            BedSideView3.bed3singleton.Show();
            BedSideView3.bed3singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed4_Click(object sender, EventArgs e)
        {
            BedSideView4.bed4singleton.Show();
            BedSideView4.bed4singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed5_Click(object sender, EventArgs e)
        {
            BedSideView5.bed5singleton.Show();
            BedSideView5.bed5singleton.Location = this.Location;
            this.Hide();
        }

        private void Bed7_Click(object sender, EventArgs e)
        {
            BedSideView7.bed7singleton.Show();
            BedSideView7.bed7singleton.Location = this.Location;
            this.Hide();
        }

        private void BedPicture_Click(object sender, EventArgs e)
        {
            if (tbfn.Text == "")
            {
                SocketConfiguration.RandomGenUserValues();
                tbweight.Text = SocketConfiguration.weight.ToString() + " Kg";
                tbheight.Text = SocketConfiguration.height.ToString() + " Centimeters";
                tbage.Text = SocketConfiguration.age.ToString();

                SocketConfiguration.RandomNameGenerator();
                tbfn.Text = SocketConfiguration.firstName;
                tbln.Text = SocketConfiguration.lastName;

                if (SocketConfiguration.firstNameNumber <= 11)
                {
                    tbgender.Text = "Male";
                }
                else { tbgender.Text = "Female"; }
            }
            else { MessageBox.Show("You already have a person assigned to this Bed"); }
        }

        private void Bed8_Click(object sender, EventArgs e)
        {
            BedSideView8.bed8singleton.Show();
            BedSideView8.bed8singleton.Location = this.Location;
            this.Hide();
        }
        #endregion

        #region InsertButtons Configuration  -- Dinis & Jorge
        private void InsertButton1_Click(object sender, EventArgs e)
        {

            if (moduleState1 == 0)
            {
                if (tbfn.Text != "")
                {
                    insertClicked1 = 1;

                    SocketSelection.socketsingleton.BedLabel.Text = "Bed 6";
                    SocketSelection.socketsingleton.Show();
                    SocketSelection.socketsingleton.Location = this.Location;
                    this.Hide();
                }
                else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
            }
            else { MessageBox.Show("Please Click on the Bed Picture to Add a Person to this bed"); }
        }

        private void InsertButton2_Click(object sender, EventArgs e)
        {
            if (tbfn.Text != "")
            {
                if (moduleState2 == 0)
                {
                    insertClicked2 = 1;

                    SocketSelection.socketsingleton.BedLabel.Text = "Bed 6";
                    SocketSelection.socketsingleton.Show();
                    SocketSelection.socketsingleton.Location = this.Location;
                    this.Hide();
                }
                else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
            }
            else { MessageBox.Show("Please Click on the Bed Picture to Add a Person to this bed"); }
        }

        private void InsertButton3_Click(object sender, EventArgs e)
        {
            if (tbfn.Text != "")
            {
                if (moduleState3 == 0)
                {
                    insertClicked3 = 1;

                    SocketSelection.socketsingleton.BedLabel.Text = "Bed 6";
                    SocketSelection.socketsingleton.Show();
                    SocketSelection.socketsingleton.Location = this.Location;
                    this.Hide();
                }
                else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
            }
            else { MessageBox.Show("Please Click on the Bed Picture to Add a Person to this bed"); }
        }

        private void InsertButton4_Click(object sender, EventArgs e)
        {
            if (tbfn.Text != "")
            {
                if (moduleState4 == 0)
                {
                    insertClicked4 = 1;

                    SocketSelection.socketsingleton.BedLabel.Text = "Bed 6";
                    SocketSelection.socketsingleton.Show();
                    SocketSelection.socketsingleton.Location = this.Location;
                    this.Hide();
                }
                else { MessageBox.Show("Please Eject the Module first before you Insert another one!"); }
            }
            else { MessageBox.Show("Please Click on the Bed Picture to Add a Person to this bed"); }
        }
        #endregion

        #region EjectButton Configuration  -- Dinis & Jorge
        private void EjectButton1_Click(object sender, EventArgs e)
        {
            moduleState1 = 0;

            BreathingRatePanelBed1.Dock = DockStyle.None;
            BloodPressurePanelBed1.Dock = DockStyle.None;
            TemperaturePanelBed1.Dock = DockStyle.None;
            PulseRatePanelBed1.Dock = DockStyle.None;

            BreathingRatePanelBed1.Visible = false;
            BloodPressurePanelBed1.Visible = false;
            TemperaturePanelBed1.Visible = false;
            PulseRatePanelBed1.Visible = false;
            InsertASocket1.Visible = true;
        }

        private void EjectButton2_Click(object sender, EventArgs e)
        {
            moduleState2 = 0;

            BreathingRatePanelBed2.Dock = DockStyle.None;
            BloodPressurePanelBed2.Dock = DockStyle.None;
            TemperaturePanelBed2.Dock = DockStyle.None;
            PulseRatePanelBed2.Dock = DockStyle.None;

            BreathingRatePanelBed2.Visible = false;
            BloodPressurePanelBed2.Visible = false;
            TemperaturePanelBed2.Visible = false;
            PulseRatePanelBed2.Visible = false;
            InsertASocket2.Visible = true;
        }

        private void EjectButton3_Click(object sender, EventArgs e)
        {
            moduleState3 = 0;

            BreathingRatePanelBed3.Dock = DockStyle.None;
            BloodPressurePanelBed3.Dock = DockStyle.None;
            TemperaturePanelBed3.Dock = DockStyle.None;
            PulseRatePanelBed3.Dock = DockStyle.None;

            BreathingRatePanelBed3.Visible = false;
            BloodPressurePanelBed3.Visible = false;
            TemperaturePanelBed3.Visible = false;
            PulseRatePanelBed3.Visible = false;
            InsertASocket3.Visible = true;
        }

        private void EjectButton4_Click(object sender, EventArgs e)
        {
            moduleState4 = 0;

            BreathingRatePanelBed4.Dock = DockStyle.None;
            BloodPressurePanelBed4.Dock = DockStyle.None;
            TemperaturePanelBed4.Dock = DockStyle.None;
            PulseRatePanelBed4.Dock = DockStyle.None;

            BreathingRatePanelBed4.Visible = false;
            BloodPressurePanelBed4.Visible = false;
            TemperaturePanelBed4.Visible = false;
            PulseRatePanelBed4.Visible = false;
            InsertASocket4.Visible = true;
        }
        #endregion

        // Variables for the Randomizers below
        public static int randomizerSy, randomizerDi, randomizerPR, randomizerBR, randomizerTemp;

        public static string SystolicValueRandom() // Returns syValue
        {
            randomizerSy = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerSy <= 5)
            {
                syValue = SocketConfiguration.randomizer.Next(SocketSelection.syMin6 - 20, SocketSelection.syMin6 - 1);
            }
            else if ((randomizerSy > 5) && (randomizerSy < 95))
            {
                syValue = SocketConfiguration.randomizer.Next(SocketSelection.syMin6, SocketSelection.syMax6);
            }
            else if (randomizerSy >= 95)
            {
                syValue = SocketConfiguration.randomizer.Next(SocketSelection.syMax6 + 1, SocketSelection.syMax6 + 20);
            }

            return syValue.ToString();
        }

        public static string DiastolicValueRandom() // Returns diValue
        {
            randomizerDi = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerDi <= 5)
            {
                diValue = SocketConfiguration.randomizer.Next(SocketSelection.diMin6 - 20, SocketSelection.diMin6 - 1);
            }
            else if ((randomizerDi > 5) && (randomizerDi < 95))
            {
                diValue = SocketConfiguration.randomizer.Next(SocketSelection.diMin6, SocketSelection.diMax6);
            }
            else if (randomizerDi >= 95)
            {
                diValue = SocketConfiguration.randomizer.Next(SocketSelection.diMin6 + 1, SocketSelection.diMax6 + 20);
            }

            return diValue.ToString();
        }

        public static string PulseValueRandom()
        {
            randomizerPR = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerPR <= 5)
            {
                prValue = SocketConfiguration.randomizer.Next(SocketSelection.prMin6 - 20, SocketSelection.prMin6 - 1);
            }
            else if ((randomizerPR > 5) && (randomizerPR < 95))
            {
                prValue = SocketConfiguration.randomizer.Next(SocketSelection.prMin6, SocketSelection.prMax6);
            }
            else if (randomizerPR >= 95)
            {
                prValue = SocketConfiguration.randomizer.Next(SocketSelection.prMax6 + 1, SocketSelection.prMax6 + 20);
            }

            return prValue.ToString();
        } // Returns prValue

        public static string BreathingValueRandom()
        {
            randomizerBR = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerBR <= 5)
            {
                brValue = SocketConfiguration.randomizer.Next(SocketSelection.brMin6 - 5, SocketSelection.brMin6 - 1);
            }
            else if ((randomizerBR > 5) && (randomizerBR < 95))
            {
                brValue = SocketConfiguration.randomizer.Next(SocketSelection.brMin6, SocketSelection.brMax6);
            }
            else if (randomizerBR >= 95)
            {
                brValue = SocketConfiguration.randomizer.Next(SocketSelection.brMax6 + 1, SocketSelection.brMax6 + 50);
            }

            return brValue.ToString();
        } // Returns brValue

        public static string TemperatureValueRandom()
        {
            randomizerTemp = SocketConfiguration.randomizer.Next(0, 100);

            if (randomizerTemp <= 25)
            {
                tempValue = SocketConfiguration.randomizer.Next(SocketSelection.tpMin6 - 25, SocketSelection.tpMin6 - 1);
            }
            else if ((randomizerTemp > 25) && (randomizerTemp < 75))
            {
                tempValue = SocketConfiguration.randomizer.Next(SocketSelection.tpMin6, SocketSelection.tpMax6);
            }
            else if (randomizerTemp >= 75)
            {
                tempValue = SocketConfiguration.randomizer.Next(SocketSelection.tpMax6 + 1, SocketSelection.tpMax6 + 45);
            }

            return tempValue.ToString();
        } // Returns tempValue

        public void ActiveCheck(object sender, EventArgs e)
        {
            if (BloodPressurePanelBed1.Dock == DockStyle.Fill || BloodPressurePanelBed2.Dock == DockStyle.Fill ||
                BloodPressurePanelBed3.Dock == DockStyle.Fill || BloodPressurePanelBed4.Dock == DockStyle.Fill)
            {
                bloodActive = true;
            }
            else { bloodActive = false; }

            if (PulseRatePanelBed1.Dock == DockStyle.Fill || PulseRatePanelBed2.Dock == DockStyle.Fill ||
                PulseRatePanelBed3.Dock == DockStyle.Fill || PulseRatePanelBed4.Dock == DockStyle.Fill)
            {
                pulseActive = true;
            }
            else { pulseActive = false; }

            if (BreathingRatePanelBed1.Dock == DockStyle.Fill || BreathingRatePanelBed2.Dock == DockStyle.Fill ||
                BreathingRatePanelBed3.Dock == DockStyle.Fill || BreathingRatePanelBed4.Dock == DockStyle.Fill)
            {
                breathingActive = true;
            }
            else { breathingActive = false; }

            if (TemperaturePanelBed1.Dock == DockStyle.Fill || TemperaturePanelBed2.Dock == DockStyle.Fill ||
                TemperaturePanelBed3.Dock == DockStyle.Fill || TemperaturePanelBed4.Dock == DockStyle.Fill)
            {
                tempActive = true;
            }
            else { tempActive = false; }

        }

    }
}
