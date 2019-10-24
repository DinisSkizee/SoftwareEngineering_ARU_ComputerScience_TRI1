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
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.SocketComboBox = new System.Windows.Forms.ComboBox();
            this.PulseRatePanel = new System.Windows.Forms.Panel();
            this.BreathingRatePanel = new System.Windows.Forms.Panel();
            this.TemperaturePanel = new System.Windows.Forms.Panel();
            this.DiastolicTextBox = new System.Windows.Forms.TextBox();
            this.SystolicTextBox = new System.Windows.Forms.TextBox();
            this.MaximunParameterValueFieldDi = new System.Windows.Forms.TextBox();
            this.MinuminumParameterValueFieldDi = new System.Windows.Forms.TextBox();
            this.MaximonParameterDi = new System.Windows.Forms.TextBox();
            this.MinuminumParameterDi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MaximunParameterValueFieldSy = new System.Windows.Forms.TextBox();
            this.MinuminumParameterValueFieldSy = new System.Windows.Forms.TextBox();
            this.MaximumParameterSy = new System.Windows.Forms.TextBox();
            this.MinuminumParameterSy = new System.Windows.Forms.TextBox();
            this.HeartImageModule = new System.Windows.Forms.Panel();
            this.VO2MaxPanel = new System.Windows.Forms.Panel();
            this.SelectModuleLabel = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).BeginInit();
            this.BloodPressurePanel.SuspendLayout();
            this.TemperaturePanel.SuspendLayout();
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
            this.PanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(750, 44);
            this.PanelTop.TabIndex = 2;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // MainPageButton
            // 
            this.MainPageButton.Image = global::FinalProject.Properties.Resources.heart;
            this.MainPageButton.Location = new System.Drawing.Point(7, 7);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(30, 30);
            this.MainPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPageButton.TabIndex = 5;
            this.MainPageButton.TabStop = false;
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
            // 
            // MinimizeButtonSocketSelection
            // 
            this.MinimizeButtonSocketSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButtonSocketSelection.Image = global::FinalProject.Properties.Resources.minimizewhite;
            this.MinimizeButtonSocketSelection.Location = new System.Drawing.Point(681, 10);
            this.MinimizeButtonSocketSelection.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButtonSocketSelection.Name = "MinimizeButtonSocketSelection";
            this.MinimizeButtonSocketSelection.Size = new System.Drawing.Size(23, 25);
            this.MinimizeButtonSocketSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButtonSocketSelection.TabIndex = 2;
            this.MinimizeButtonSocketSelection.TabStop = false;
            this.MinimizeButtonSocketSelection.Click += new System.EventHandler(this.MinimizeButtonSocketSelection_Click);
            // 
            // CloseButtonSocketSelection
            // 
            this.CloseButtonSocketSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonSocketSelection.Image = global::FinalProject.Properties.Resources.closewhite;
            this.CloseButtonSocketSelection.Location = new System.Drawing.Point(716, 10);
            this.CloseButtonSocketSelection.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButtonSocketSelection.Name = "CloseButtonSocketSelection";
            this.CloseButtonSocketSelection.Size = new System.Drawing.Size(23, 25);
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
            this.InstallButton.Location = new System.Drawing.Point(429, 61);
            this.InstallButton.Margin = new System.Windows.Forms.Padding(2);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(218, 31);
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
            this.BedComboBox.Items.AddRange(new object[] {
            "Bed 1",
            "Bed 2",
            "Bed 3",
            "Bed 4",
            "Bed 5",
            "Bed 6",
            "Bed 7",
            "Bed 8"});
            this.BedComboBox.Location = new System.Drawing.Point(315, 60);
            this.BedComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.BedComboBox.Name = "BedComboBox";
            this.BedComboBox.Size = new System.Drawing.Size(92, 31);
            this.BedComboBox.TabIndex = 5;
            // 
            // BloodPressurePanel
            // 
            this.BloodPressurePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BloodPressurePanel.Controls.Add(this.DetailsPanel);
            this.BloodPressurePanel.Location = new System.Drawing.Point(0, 110);
            this.BloodPressurePanel.Margin = new System.Windows.Forms.Padding(2);
            this.BloodPressurePanel.Name = "BloodPressurePanel";
            this.BloodPressurePanel.Size = new System.Drawing.Size(750, 337);
            this.BloodPressurePanel.TabIndex = 6;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.DetailsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(750, 337);
            this.DetailsPanel.TabIndex = 12;
            // 
            // SocketComboBox
            // 
            this.SocketComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SocketComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SocketComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SocketComboBox.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.SocketComboBox.ForeColor = System.Drawing.Color.White;
            this.SocketComboBox.FormattingEnabled = true;
            this.SocketComboBox.Items.AddRange(new object[] {
            "Blood Presure",
            "Pulse Rate",
            "Breathing Rate",
            "Temperature",
            "VO2 Max",
            "General Details"});
            this.SocketComboBox.Location = new System.Drawing.Point(104, 61);
            this.SocketComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SocketComboBox.Name = "SocketComboBox";
            this.SocketComboBox.Size = new System.Drawing.Size(188, 31);
            this.SocketComboBox.TabIndex = 7;
            // 
            // PulseRatePanel
            // 
            this.PulseRatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PulseRatePanel.Location = new System.Drawing.Point(0, 110);
            this.PulseRatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.PulseRatePanel.Name = "PulseRatePanel";
            this.PulseRatePanel.Size = new System.Drawing.Size(750, 337);
            this.PulseRatePanel.TabIndex = 8;
            // 
            // BreathingRatePanel
            // 
            this.BreathingRatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BreathingRatePanel.Location = new System.Drawing.Point(0, 110);
            this.BreathingRatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.BreathingRatePanel.Name = "BreathingRatePanel";
            this.BreathingRatePanel.Size = new System.Drawing.Size(750, 337);
            this.BreathingRatePanel.TabIndex = 9;
            // 
            // TemperaturePanel
            // 
            this.TemperaturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TemperaturePanel.Controls.Add(this.DiastolicTextBox);
            this.TemperaturePanel.Controls.Add(this.SystolicTextBox);
            this.TemperaturePanel.Controls.Add(this.MaximunParameterValueFieldDi);
            this.TemperaturePanel.Controls.Add(this.MinuminumParameterValueFieldDi);
            this.TemperaturePanel.Controls.Add(this.MaximonParameterDi);
            this.TemperaturePanel.Controls.Add(this.MinuminumParameterDi);
            this.TemperaturePanel.Controls.Add(this.textBox1);
            this.TemperaturePanel.Controls.Add(this.MaximunParameterValueFieldSy);
            this.TemperaturePanel.Controls.Add(this.MinuminumParameterValueFieldSy);
            this.TemperaturePanel.Controls.Add(this.MaximumParameterSy);
            this.TemperaturePanel.Controls.Add(this.MinuminumParameterSy);
            this.TemperaturePanel.Controls.Add(this.HeartImageModule);
            this.TemperaturePanel.Location = new System.Drawing.Point(0, 110);
            this.TemperaturePanel.Margin = new System.Windows.Forms.Padding(2);
            this.TemperaturePanel.Name = "TemperaturePanel";
            this.TemperaturePanel.Size = new System.Drawing.Size(750, 337);
            this.TemperaturePanel.TabIndex = 10;
            // 
            // DiastolicTextBox
            // 
            this.DiastolicTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiastolicTextBox.Location = new System.Drawing.Point(477, 30);
            this.DiastolicTextBox.Name = "DiastolicTextBox";
            this.DiastolicTextBox.ReadOnly = true;
            this.DiastolicTextBox.Size = new System.Drawing.Size(250, 22);
            this.DiastolicTextBox.TabIndex = 11;
            this.DiastolicTextBox.Text = "Diastolic";
            this.DiastolicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SystolicTextBox
            // 
            this.SystolicTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystolicTextBox.Location = new System.Drawing.Point(195, 30);
            this.SystolicTextBox.Name = "SystolicTextBox";
            this.SystolicTextBox.ReadOnly = true;
            this.SystolicTextBox.Size = new System.Drawing.Size(250, 22);
            this.SystolicTextBox.TabIndex = 10;
            this.SystolicTextBox.Text = "Systolic";
            this.SystolicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaximunParameterValueFieldDi
            // 
            this.MaximunParameterValueFieldDi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MaximunParameterValueFieldDi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaximunParameterValueFieldDi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximunParameterValueFieldDi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MaximunParameterValueFieldDi.Location = new System.Drawing.Point(607, 90);
            this.MaximunParameterValueFieldDi.Margin = new System.Windows.Forms.Padding(2);
            this.MaximunParameterValueFieldDi.Multiline = true;
            this.MaximunParameterValueFieldDi.Name = "MaximunParameterValueFieldDi";
            this.MaximunParameterValueFieldDi.Size = new System.Drawing.Size(120, 35);
            this.MaximunParameterValueFieldDi.TabIndex = 9;
            // 
            // MinuminumParameterValueFieldDi
            // 
            this.MinuminumParameterValueFieldDi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MinuminumParameterValueFieldDi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinuminumParameterValueFieldDi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuminumParameterValueFieldDi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MinuminumParameterValueFieldDi.Location = new System.Drawing.Point(477, 90);
            this.MinuminumParameterValueFieldDi.Margin = new System.Windows.Forms.Padding(2);
            this.MinuminumParameterValueFieldDi.Multiline = true;
            this.MinuminumParameterValueFieldDi.Name = "MinuminumParameterValueFieldDi";
            this.MinuminumParameterValueFieldDi.Size = new System.Drawing.Size(120, 35);
            this.MinuminumParameterValueFieldDi.TabIndex = 8;
            // 
            // MaximonParameterDi
            // 
            this.MaximonParameterDi.Location = new System.Drawing.Point(606, 60);
            this.MaximonParameterDi.Name = "MaximonParameterDi";
            this.MaximonParameterDi.ReadOnly = true;
            this.MaximonParameterDi.Size = new System.Drawing.Size(120, 20);
            this.MaximonParameterDi.TabIndex = 7;
            this.MaximonParameterDi.Text = "Maximunm";
            this.MaximonParameterDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinuminumParameterDi
            // 
            this.MinuminumParameterDi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuminumParameterDi.Location = new System.Drawing.Point(477, 60);
            this.MinuminumParameterDi.Name = "MinuminumParameterDi";
            this.MinuminumParameterDi.ReadOnly = true;
            this.MinuminumParameterDi.Size = new System.Drawing.Size(120, 22);
            this.MinuminumParameterDi.TabIndex = 6;
            this.MinuminumParameterDi.Text = "Minumum";
            this.MinuminumParameterDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 20);
            this.textBox1.TabIndex = 5;
            // 
            // MaximunParameterValueFieldSy
            // 
            this.MaximunParameterValueFieldSy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MaximunParameterValueFieldSy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaximunParameterValueFieldSy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximunParameterValueFieldSy.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MaximunParameterValueFieldSy.Location = new System.Drawing.Point(325, 90);
            this.MaximunParameterValueFieldSy.Margin = new System.Windows.Forms.Padding(2);
            this.MaximunParameterValueFieldSy.Multiline = true;
            this.MaximunParameterValueFieldSy.Name = "MaximunParameterValueFieldSy";
            this.MaximunParameterValueFieldSy.Size = new System.Drawing.Size(120, 35);
            this.MaximunParameterValueFieldSy.TabIndex = 4;
            // 
            // MinuminumParameterValueFieldSy
            // 
            this.MinuminumParameterValueFieldSy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MinuminumParameterValueFieldSy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinuminumParameterValueFieldSy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuminumParameterValueFieldSy.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MinuminumParameterValueFieldSy.Location = new System.Drawing.Point(195, 90);
            this.MinuminumParameterValueFieldSy.Margin = new System.Windows.Forms.Padding(2);
            this.MinuminumParameterValueFieldSy.Multiline = true;
            this.MinuminumParameterValueFieldSy.Name = "MinuminumParameterValueFieldSy";
            this.MinuminumParameterValueFieldSy.Size = new System.Drawing.Size(120, 35);
            this.MinuminumParameterValueFieldSy.TabIndex = 3;
            // 
            // MaximumParameterSy
            // 
            this.MaximumParameterSy.Location = new System.Drawing.Point(325, 60);
            this.MaximumParameterSy.Name = "MaximumParameterSy";
            this.MaximumParameterSy.ReadOnly = true;
            this.MaximumParameterSy.Size = new System.Drawing.Size(120, 20);
            this.MaximumParameterSy.TabIndex = 2;
            this.MaximumParameterSy.Text = "Maximunm";
            this.MaximumParameterSy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinuminumParameterSy
            // 
            this.MinuminumParameterSy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuminumParameterSy.Location = new System.Drawing.Point(195, 60);
            this.MinuminumParameterSy.Name = "MinuminumParameterSy";
            this.MinuminumParameterSy.ReadOnly = true;
            this.MinuminumParameterSy.Size = new System.Drawing.Size(120, 22);
            this.MinuminumParameterSy.TabIndex = 1;
            this.MinuminumParameterSy.Text = "Minumum";
            this.MinuminumParameterSy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeartImageModule
            // 
            this.HeartImageModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.HeartImageModule.Location = new System.Drawing.Point(28, 30);
            this.HeartImageModule.Name = "HeartImageModule";
            this.HeartImageModule.Size = new System.Drawing.Size(150, 150);
            this.HeartImageModule.TabIndex = 0;
            // 
            // VO2MaxPanel
            // 
            this.VO2MaxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VO2MaxPanel.Location = new System.Drawing.Point(0, 110);
            this.VO2MaxPanel.Margin = new System.Windows.Forms.Padding(2);
            this.VO2MaxPanel.Name = "VO2MaxPanel";
            this.VO2MaxPanel.Size = new System.Drawing.Size(750, 337);
            this.VO2MaxPanel.TabIndex = 11;
            // 
            // SelectModuleLabel
            // 
            this.SelectModuleLabel.AutoSize = true;
            this.SelectModuleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectModuleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SelectModuleLabel.ForeColor = System.Drawing.Color.White;
            this.SelectModuleLabel.Location = new System.Drawing.Point(117, 66);
            this.SelectModuleLabel.Name = "SelectModuleLabel";
            this.SelectModuleLabel.Size = new System.Drawing.Size(144, 21);
            this.SelectModuleLabel.TabIndex = 12;
            this.SelectModuleLabel.Text = "Select your Module";
            // 
            // SocketSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(750, 447);
            this.Controls.Add(this.SelectModuleLabel);
            this.Controls.Add(this.TemperaturePanel);
            this.Controls.Add(this.SocketComboBox);
            this.Controls.Add(this.BloodPressurePanel);
            this.Controls.Add(this.BedComboBox);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.VO2MaxPanel);
            this.Controls.Add(this.BreathingRatePanel);
            this.Controls.Add(this.PulseRatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SocketSelection";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).EndInit();
            this.BloodPressurePanel.ResumeLayout(false);
            this.TemperaturePanel.ResumeLayout(false);
            this.TemperaturePanel.PerformLayout();
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
        private System.Windows.Forms.Panel HeartImageModule;
        private System.Windows.Forms.TextBox MaximumParameterSy;
        private System.Windows.Forms.TextBox MinuminumParameterSy;
        private System.Windows.Forms.TextBox MaximunParameterValueFieldSy;
        private System.Windows.Forms.TextBox MinuminumParameterValueFieldSy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox MaximunParameterValueFieldDi;
        private System.Windows.Forms.TextBox MinuminumParameterValueFieldDi;
        private System.Windows.Forms.TextBox MaximonParameterDi;
        private System.Windows.Forms.TextBox MinuminumParameterDi;
        private System.Windows.Forms.TextBox DiastolicTextBox;
        private System.Windows.Forms.TextBox SystolicTextBox;
        private System.Windows.Forms.Label SelectModuleLabel;
    }
}