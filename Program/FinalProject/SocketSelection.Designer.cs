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
            this.ScrollBarSocketSelection = new System.Windows.Forms.VScrollBar();
            this.MinimizeButtonSocketSelection = new System.Windows.Forms.PictureBox();
            this.CloseButtonSocketSelection = new System.Windows.Forms.PictureBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.MinimizeButtonSocketSelection);
            this.PanelTop.Controls.Add(this.CloseButtonSocketSelection);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(750, 44);
            this.PanelTop.TabIndex = 2;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // ScrollBarSocketSelection
            // 
            this.ScrollBarSocketSelection.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScrollBarSocketSelection.Location = new System.Drawing.Point(729, 44);
            this.ScrollBarSocketSelection.Name = "ScrollBarSocketSelection";
            this.ScrollBarSocketSelection.Size = new System.Drawing.Size(21, 403);
            this.ScrollBarSocketSelection.TabIndex = 3;
            // 
            // MinimizeButtonSocketSelection
            // 
            this.MinimizeButtonSocketSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButtonSocketSelection.Image = global::FinalProject.Properties.Resources.minimize__1_;
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
            this.CloseButtonSocketSelection.Image = global::FinalProject.Properties.Resources.close;
            this.CloseButtonSocketSelection.Location = new System.Drawing.Point(716, 10);
            this.CloseButtonSocketSelection.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButtonSocketSelection.Name = "CloseButtonSocketSelection";
            this.CloseButtonSocketSelection.Size = new System.Drawing.Size(23, 25);
            this.CloseButtonSocketSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonSocketSelection.TabIndex = 1;
            this.CloseButtonSocketSelection.TabStop = false;
            this.CloseButtonSocketSelection.Click += new System.EventHandler(this.CloseButtonSocketSelection_Click);
            // 
            // SocketSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(750, 447);
            this.Controls.Add(this.ScrollBarSocketSelection);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SocketSelection";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonSocketSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonSocketSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox MinimizeButtonSocketSelection;
        private System.Windows.Forms.PictureBox CloseButtonSocketSelection;
        private System.Windows.Forms.VScrollBar ScrollBarSocketSelection;
    }
}