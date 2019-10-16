namespace FinalProject
{
    partial class CentralStation
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
            this.MinimizeButtonCentralStation = new System.Windows.Forms.PictureBox();
            this.CloseButtonCentralStation = new System.Windows.Forms.PictureBox();
            this.MainPageButton = new System.Windows.Forms.PictureBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonCentralStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonCentralStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.MainPageButton);
            this.PanelTop.Controls.Add(this.MinimizeButtonCentralStation);
            this.PanelTop.Controls.Add(this.CloseButtonCentralStation);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(750, 44);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // MinimizeButtonCentralStation
            // 
            this.MinimizeButtonCentralStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButtonCentralStation.Image = global::FinalProject.Properties.Resources.minimizewhite;
            this.MinimizeButtonCentralStation.Location = new System.Drawing.Point(681, 10);
            this.MinimizeButtonCentralStation.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButtonCentralStation.Name = "MinimizeButtonCentralStation";
            this.MinimizeButtonCentralStation.Size = new System.Drawing.Size(23, 25);
            this.MinimizeButtonCentralStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButtonCentralStation.TabIndex = 2;
            this.MinimizeButtonCentralStation.TabStop = false;
            this.MinimizeButtonCentralStation.Click += new System.EventHandler(this.MinimizeButtonCentralStation_Click);
            // 
            // CloseButtonCentralStation
            // 
            this.CloseButtonCentralStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonCentralStation.Image = global::FinalProject.Properties.Resources.closewhite;
            this.CloseButtonCentralStation.Location = new System.Drawing.Point(716, 10);
            this.CloseButtonCentralStation.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButtonCentralStation.Name = "CloseButtonCentralStation";
            this.CloseButtonCentralStation.Size = new System.Drawing.Size(23, 25);
            this.CloseButtonCentralStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonCentralStation.TabIndex = 1;
            this.CloseButtonCentralStation.TabStop = false;
            this.CloseButtonCentralStation.Click += new System.EventHandler(this.CloseButtonCentralStation_Click);
            // 
            // MainPageButton
            // 
            this.MainPageButton.Image = global::FinalProject.Properties.Resources.heart;
            this.MainPageButton.Location = new System.Drawing.Point(7, 7);
            this.MainPageButton.Name = "MainPageButton";
            this.MainPageButton.Size = new System.Drawing.Size(30, 30);
            this.MainPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPageButton.TabIndex = 4;
            this.MainPageButton.TabStop = false;
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
            // 
            // CentralStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(750, 447);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CentralStation";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonCentralStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonCentralStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox MinimizeButtonCentralStation;
        private System.Windows.Forms.PictureBox CloseButtonCentralStation;
        private System.Windows.Forms.PictureBox MainPageButton;
    }
}