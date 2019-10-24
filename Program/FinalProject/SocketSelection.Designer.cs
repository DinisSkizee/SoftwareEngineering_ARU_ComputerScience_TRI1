namespace FinalProject
{
    partial class SocketSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTop = new System.Windows.Forms.Panel();
            this.MainPageButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButtonSocketSelection = new System.Windows.Forms.PictureBox();
            this.CloseButtonSocketSelection = new System.Windows.Forms.PictureBox();
            this.InstallButton = new System.Windows.Forms.Button();
            this.BedComboBox = new System.Windows.Forms.ComboBox();
            this.BloodPressurePanel = new System.Windows.Forms.Panel();
            this.SocketComboBox = new System.Windows.Forms.ComboBox();
            this.PulseRatePanel = new System.Windows.Forms.Panel();
            this.BreathingRatePanel = new System.Windows.Forms.Panel();
            this.TemperaturePanel = new System.Windows.Forms.Panel();
            this.VO2MaxPanel = new System.Windows.Forms.Panel();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.SelectModuleLabel = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.MainPageButton);
            this.PanelTop.Controls.Add(this.MinimizeButtonSocketSelection);
            this.PanelTop.Controls.Add(this.CloseButtonSocketSelection);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1000, 54);
            this.PanelTop.TabIndex = 2;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // MainPageButton
            // 
            this.MainPageButton.Image = global::FinalProject.Properties.Resources.heart;
            this.MainPageButton.Location = new System.Drawing.Point(9, 9);
            this.MainPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(40, 37);
            this.MainPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPageButton.TabIndex = 5;
            this.MainPageButton.TabStop = false;
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
            // 
            // MinimizeButtonSocketSelection
            // 
            this.MinimizeButtonSocketSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButtonSocketSelection.Image = global::FinalProject.Properties.Resources.minimizewhite;
            this.MinimizeButtonSocketSelection.Location = new System.Drawing.Point(908, 12);
            this.MinimizeButtonSocketSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeButtonSocketSelection.Name = "MinimizeButtonSocketSelection";
            this.MinimizeButtonSocketSelection.Size = new System.Drawing.Size(31, 31);
            this.MinimizeButtonSocketSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButtonSocketSelection.TabIndex = 2;
            this.MinimizeButtonSocketSelection.TabStop = false;
            this.MinimizeButtonSocketSelection.Click += new System.EventHandler(this.MinimizeButtonSocketSelection_Click);
            // 
            // CloseButtonSocketSelection
            // 
            this.CloseButtonSocketSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonSocketSelection.Image = global::FinalProject.Properties.Resources.closewhite;
            this.CloseButtonSocketSelection.Location = new System.Drawing.Point(955, 12);
            this.CloseButtonSocketSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButtonSocketSelection.Name = "CloseButtonSocketSelection";
            this.CloseButtonSocketSelection.Size = new System.Drawing.Size(31, 31);
            this.CloseButtonSocketSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonSocketSelection.TabIndex = 1;
            this.CloseButtonSocketSelection.TabStop = false;
            this.CloseButtonSocketSelection.Click += new System.EventHandler(this.CloseButtonSocketSelection_Click);
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.InstallButton.ForeColor = System.Drawing.Color.White;
            this.InstallButton.Location = new System.Drawing.Point(572, 75);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(290, 38);
            this.InstallButton.TabIndex = 4;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = false;
            // 
            // BedComboBox
            // 
            this.BedComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BedComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BedComboBox.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BedComboBox.ForeColor = System.Drawing.Color.White;
            this.BedComboBox.FormattingEnabled = true;
            this.BedComboBox.Location = new System.Drawing.Point(420, 74);
            this.BedComboBox.Name = "BedComboBox";
            this.BedComboBox.Size = new System.Drawing.Size(121, 38);
            this.BedComboBox.TabIndex = 5;
            // 
            // BloodPressurePanel
            // 
            this.BloodPressurePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BloodPressurePanel.Location = new System.Drawing.Point(0, 136);
            this.BloodPressurePanel.Name = "BloodPressurePanel";
            this.BloodPressurePanel.Size = new System.Drawing.Size(1000, 415);
            this.BloodPressurePanel.TabIndex = 6;
            // 
            // SocketComboBox
            // 
            this.SocketComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SocketComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SocketComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SocketComboBox.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.SocketComboBox.ForeColor = System.Drawing.Color.White;
            this.SocketComboBox.FormattingEnabled = true;
            this.SocketComboBox.Location = new System.Drawing.Point(139, 75);
            this.SocketComboBox.Name = "SocketComboBox";
            this.SocketComboBox.Size = new System.Drawing.Size(250, 38);
            this.SocketComboBox.TabIndex = 7;
            this.SocketComboBox.TextChanged += new System.EventHandler(this.SocketComboBox_TextChanged);
            // 
            // PulseRatePanel
            // 
            this.PulseRatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PulseRatePanel.Location = new System.Drawing.Point(0, 136);
            this.PulseRatePanel.Name = "PulseRatePanel";
            this.PulseRatePanel.Size = new System.Drawing.Size(1000, 415);
            this.PulseRatePanel.TabIndex = 8;
            // 
            // BreathingRatePanel
            // 
            this.BreathingRatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BreathingRatePanel.Location = new System.Drawing.Point(0, 136);
            this.BreathingRatePanel.Name = "BreathingRatePanel";
            this.BreathingRatePanel.Size = new System.Drawing.Size(1000, 415);
            this.BreathingRatePanel.TabIndex = 9;
            // 
            // TemperaturePanel
            // 
            this.TemperaturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TemperaturePanel.Location = new System.Drawing.Point(0, 136);
            this.TemperaturePanel.Name = "TemperaturePanel";
            this.TemperaturePanel.Size = new System.Drawing.Size(1000, 415);
            this.TemperaturePanel.TabIndex = 10;
            // 
            // VO2MaxPanel
            // 
            this.VO2MaxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VO2MaxPanel.Location = new System.Drawing.Point(0, 136);
            this.VO2MaxPanel.Name = "VO2MaxPanel";
            this.VO2MaxPanel.Size = new System.Drawing.Size(1000, 415);
            this.VO2MaxPanel.TabIndex = 11;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DetailsPanel.Location = new System.Drawing.Point(0, 136);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(1000, 415);
            this.DetailsPanel.TabIndex = 12;
            // 
            // SelectModuleLabel
            // 
            this.SelectModuleLabel.AutoSize = true;
            this.SelectModuleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectModuleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SelectModuleLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SelectModuleLabel.Location = new System.Drawing.Point(160, 80);
            this.SelectModuleLabel.Name = "SelectModuleLabel";
            this.SelectModuleLabel.Size = new System.Drawing.Size(182, 28);
            this.SelectModuleLabel.TabIndex = 13;
            this.SelectModuleLabel.Text = "Select your Module";
            this.SelectModuleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SocketSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.SelectModuleLabel);
            this.Controls.Add(this.SocketComboBox);
            this.Controls.Add(this.BloodPressurePanel);
            this.Controls.Add(this.BedComboBox);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.VO2MaxPanel);
            this.Controls.Add(this.TemperaturePanel);
            this.Controls.Add(this.BreathingRatePanel);
            this.Controls.Add(this.PulseRatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SocketSelection";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox MinimizeButtonSocketSelection;
        private System.Windows.Forms.PictureBox CloseButtonSocketSelection;
        private System.Windows.Forms.PictureBox MainPageButton;
        private System.Windows.Forms.Button InstallButton;
        public System.Windows.Forms.ComboBox BedComboBox;
        private System.Windows.Forms.Panel BloodPressurePanel;
        private System.Windows.Forms.ComboBox SocketComboBox;
        private System.Windows.Forms.Panel PulseRatePanel;
        private System.Windows.Forms.Panel BreathingRatePanel;
        private System.Windows.Forms.Panel TemperaturePanel;
        private System.Windows.Forms.Panel VO2MaxPanel;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label SelectModuleLabel;
    }
}