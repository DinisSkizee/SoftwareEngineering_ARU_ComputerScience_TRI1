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
            this.MaximizeButtonSocketSelection = new System.Windows.Forms.PictureBox();
            this.MinimizeButtonSocketSelection = new System.Windows.Forms.PictureBox();
            this.CloseButtonSocketSelection = new System.Windows.Forms.PictureBox();
            this.ScrollBarSocketSelection = new System.Windows.Forms.VScrollBar();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButtonSocketSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.MaximizeButtonSocketSelection);
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
            // MaximizeButtonSocketSelection
            // 
            this.MaximizeButtonSocketSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButtonSocketSelection.Image = global::FinalProject.Properties.Resources.maximize_size_option;
            this.MaximizeButtonSocketSelection.Location = new System.Drawing.Point(917, 10);
            this.MaximizeButtonSocketSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeButtonSocketSelection.Name = "MaximizeButtonSocketSelection";
            this.MaximizeButtonSocketSelection.Size = new System.Drawing.Size(31, 31);
            this.MaximizeButtonSocketSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButtonSocketSelection.TabIndex = 1;
            this.MaximizeButtonSocketSelection.TabStop = false;
            this.MaximizeButtonSocketSelection.Click += new System.EventHandler(this.MaximizeButtonSocketSelection_Click);
            // 
            // MinimizeButtonSocketSelection
            // 
            this.MinimizeButtonSocketSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButtonSocketSelection.Image = global::FinalProject.Properties.Resources.minimize__1_;
            this.MinimizeButtonSocketSelection.Location = new System.Drawing.Point(876, 10);
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
            this.CloseButtonSocketSelection.Image = global::FinalProject.Properties.Resources.close;
            this.CloseButtonSocketSelection.Location = new System.Drawing.Point(957, 10);
            this.CloseButtonSocketSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButtonSocketSelection.Name = "CloseButtonSocketSelection";
            this.CloseButtonSocketSelection.Size = new System.Drawing.Size(31, 31);
            this.CloseButtonSocketSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonSocketSelection.TabIndex = 1;
            this.CloseButtonSocketSelection.TabStop = false;
            this.CloseButtonSocketSelection.Click += new System.EventHandler(this.CloseButtonSocketSelection_Click);
            // 
            // ScrollBarSocketSelection
            // 
            this.ScrollBarSocketSelection.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScrollBarSocketSelection.Location = new System.Drawing.Point(979, 54);
            this.ScrollBarSocketSelection.Name = "ScrollBarSocketSelection";
            this.ScrollBarSocketSelection.Size = new System.Drawing.Size(21, 496);
            this.ScrollBarSocketSelection.TabIndex = 3;
            // 
            // SocketSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.ScrollBarSocketSelection);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SocketSelection";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButtonSocketSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox MaximizeButtonSocketSelection;
        private System.Windows.Forms.PictureBox MinimizeButtonSocketSelection;
        private System.Windows.Forms.PictureBox CloseButtonSocketSelection;
        private System.Windows.Forms.VScrollBar ScrollBarSocketSelection;
    }
}