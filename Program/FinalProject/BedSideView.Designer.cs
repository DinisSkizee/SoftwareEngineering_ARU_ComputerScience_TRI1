namespace FinalProject
{
    partial class BedSideView
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
            this.MaximizeButtonBedSideView = new System.Windows.Forms.PictureBox();
            this.MinimizeButtonBedSideView = new System.Windows.Forms.PictureBox();
            this.CloseButtonBedSideView = new System.Windows.Forms.PictureBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButtonBedSideView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonBedSideView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonBedSideView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.MaximizeButtonBedSideView);
            this.PanelTop.Controls.Add(this.MinimizeButtonBedSideView);
            this.PanelTop.Controls.Add(this.CloseButtonBedSideView);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(750, 44);
            this.PanelTop.TabIndex = 1;
            // 
            // MaximizeButtonBedSideView
            // 
            this.MaximizeButtonBedSideView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButtonBedSideView.Image = global::FinalProject.Properties.Resources.maximize_size_option;
            this.MaximizeButtonBedSideView.Location = new System.Drawing.Point(688, 8);
            this.MaximizeButtonBedSideView.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeButtonBedSideView.Name = "MaximizeButtonBedSideView";
            this.MaximizeButtonBedSideView.Size = new System.Drawing.Size(23, 25);
            this.MaximizeButtonBedSideView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButtonBedSideView.TabIndex = 1;
            this.MaximizeButtonBedSideView.TabStop = false;
            this.MaximizeButtonBedSideView.Click += new System.EventHandler(this.MaximizeButtonBedSideView_Click);
            // 
            // MinimizeButtonBedSideView
            // 
            this.MinimizeButtonBedSideView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButtonBedSideView.Image = global::FinalProject.Properties.Resources.minimize__1_;
            this.MinimizeButtonBedSideView.Location = new System.Drawing.Point(657, 8);
            this.MinimizeButtonBedSideView.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButtonBedSideView.Name = "MinimizeButtonBedSideView";
            this.MinimizeButtonBedSideView.Size = new System.Drawing.Size(23, 25);
            this.MinimizeButtonBedSideView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButtonBedSideView.TabIndex = 2;
            this.MinimizeButtonBedSideView.TabStop = false;
            this.MinimizeButtonBedSideView.Click += new System.EventHandler(this.MinimizeButtonBedSideView_Click);
            // 
            // CloseButtonBedSideView
            // 
            this.CloseButtonBedSideView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonBedSideView.Image = global::FinalProject.Properties.Resources.close;
            this.CloseButtonBedSideView.Location = new System.Drawing.Point(718, 8);
            this.CloseButtonBedSideView.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButtonBedSideView.Name = "CloseButtonBedSideView";
            this.CloseButtonBedSideView.Size = new System.Drawing.Size(23, 25);
            this.CloseButtonBedSideView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonBedSideView.TabIndex = 1;
            this.CloseButtonBedSideView.TabStop = false;
            this.CloseButtonBedSideView.Click += new System.EventHandler(this.CloseButtonBedSideView_Click);
            // 
            // BedSideView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(750, 447);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BedSideView";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButtonBedSideView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonBedSideView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonBedSideView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox MaximizeButtonBedSideView;
        private System.Windows.Forms.PictureBox MinimizeButtonBedSideView;
        private System.Windows.Forms.PictureBox CloseButtonBedSideView;
    }
}