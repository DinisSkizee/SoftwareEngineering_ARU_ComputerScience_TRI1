﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CentralStation : Form
    {
        public CentralStation()
        {
            InitializeComponent();
        }

        #region Draggable Top Panel
        // Draggable Top Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
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

        #region Close/Minimize Buttons
        private void CloseButtonCentralStation_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButtonCentralStation_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
