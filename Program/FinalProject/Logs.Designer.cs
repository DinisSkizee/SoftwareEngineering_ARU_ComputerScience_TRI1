namespace FinalProject
{
    partial class Logs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPageButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButtonLogs = new System.Windows.Forms.PictureBox();
            this.CloseButtonLogs = new System.Windows.Forms.PictureBox();
            this.RDLogs = new System.Windows.Forms.Button();
            this.AlarmLogs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.MainPageButton);
            this.panel1.Controls.Add(this.MinimizeButtonLogs);
            this.panel1.Controls.Add(this.CloseButtonLogs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 44);
            this.panel1.TabIndex = 0;
            // 
            // MainPageButton
            // 
            this.MainPageButton.Image = global::FinalProject.Properties.Resources.heart;
            this.MainPageButton.Location = new System.Drawing.Point(12, 8);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(30, 30);
            this.MainPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPageButton.TabIndex = 3;
            this.MainPageButton.TabStop = false;
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click_1);
            // 
            // MinimizeButtonLogs
            // 
            this.MinimizeButtonLogs.Image = global::FinalProject.Properties.Resources.minimizewhite;
            this.MinimizeButtonLogs.Location = new System.Drawing.Point(695, 8);
            this.MinimizeButtonLogs.Name = "MinimizeButtonLogs";
            this.MinimizeButtonLogs.Size = new System.Drawing.Size(23, 25);
            this.MinimizeButtonLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButtonLogs.TabIndex = 4;
            this.MinimizeButtonLogs.TabStop = false;
            this.MinimizeButtonLogs.Click += new System.EventHandler(this.MinimizeButtonLogs_Click);
            // 
            // CloseButtonLogs
            // 
            this.CloseButtonLogs.Image = global::FinalProject.Properties.Resources.closewhite;
            this.CloseButtonLogs.Location = new System.Drawing.Point(724, 8);
            this.CloseButtonLogs.Name = "CloseButtonLogs";
            this.CloseButtonLogs.Size = new System.Drawing.Size(23, 25);
            this.CloseButtonLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonLogs.TabIndex = 5;
            this.CloseButtonLogs.TabStop = false;
            this.CloseButtonLogs.Click += new System.EventHandler(this.CloseButtonLogs_Click);
            // 
            // RDLogs
            // 
            this.RDLogs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDLogs.Location = new System.Drawing.Point(432, 195);
            this.RDLogs.Name = "RDLogs";
            this.RDLogs.Size = new System.Drawing.Size(200, 100);
            this.RDLogs.TabIndex = 1;
            this.RDLogs.Text = "Register/Deregister Logs";
            this.RDLogs.UseVisualStyleBackColor = true;
            this.RDLogs.Click += new System.EventHandler(this.RDLogs_Click);
            // 
            // AlarmLogs
            // 
            this.AlarmLogs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmLogs.Location = new System.Drawing.Point(118, 195);
            this.AlarmLogs.Name = "AlarmLogs";
            this.AlarmLogs.Size = new System.Drawing.Size(200, 100);
            this.AlarmLogs.TabIndex = 2;
            this.AlarmLogs.Text = "Alarm Logs";
            this.AlarmLogs.UseVisualStyleBackColor = true;
            this.AlarmLogs.Click += new System.EventHandler(this.button4_Click);
            // 
            // Logs
            // 
            this.ClientSize = new System.Drawing.Size(754, 378);
            this.Controls.Add(this.AlarmLogs);
            this.Controls.Add(this.RDLogs);
            this.Controls.Add(this.panel1);
            this.Name = "Logs";

            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.PictureBox MinimizeButtonAfterLogin;
        private System.Windows.Forms.PictureBox CloseButtonAfterLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RDLogs;
        private System.Windows.Forms.Button AlarmLogs;
        private System.Windows.Forms.PictureBox MinimizeButtonLogs;
        private System.Windows.Forms.PictureBox CloseButtonLogs;
        private System.Windows.Forms.PictureBox MainPageButton;
    }
}