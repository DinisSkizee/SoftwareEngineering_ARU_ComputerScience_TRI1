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
            this.BackgroundPanelSocketSelection = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).BeginInit();
            this.BackgroundPanelSocketSelection.SuspendLayout();
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
            this.MainPageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // BackgroundPanelSocketSelection
            // 
            this.BackgroundPanelSocketSelection.AutoScroll = true;
            this.BackgroundPanelSocketSelection.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.BackgroundPanelSocketSelection.Controls.Add(this.panel1);
            this.BackgroundPanelSocketSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanelSocketSelection.Location = new System.Drawing.Point(0, 54);
            this.BackgroundPanelSocketSelection.Name = "BackgroundPanelSocketSelection";
            this.BackgroundPanelSocketSelection.Size = new System.Drawing.Size(1000, 496);
            this.BackgroundPanelSocketSelection.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(397, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 187);
            this.panel1.TabIndex = 4;
            // 
            // SocketSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.BackgroundPanelSocketSelection);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SocketSelection";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).EndInit();
            this.BackgroundPanelSocketSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox MinimizeButtonSocketSelection;
        private System.Windows.Forms.PictureBox CloseButtonSocketSelection;
        private System.Windows.Forms.PictureBox MainPageButton;
        private System.Windows.Forms.Panel BackgroundPanelSocketSelection;
        private System.Windows.Forms.Panel panel1;
    }
}