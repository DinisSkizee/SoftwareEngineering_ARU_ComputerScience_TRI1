namespace FinalProject
{
    partial class managerments
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
            this.seniorDoc = new System.Windows.Forms.Button();
            this.Regstff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPageButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButtonLogs = new System.Windows.Forms.PictureBox();
            this.CloseButtonLogs = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // seniorDoc
            // 
            this.seniorDoc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorDoc.Location = new System.Drawing.Point(143, 231);
            this.seniorDoc.Name = "seniorDoc";
            this.seniorDoc.Size = new System.Drawing.Size(200, 100);
            this.seniorDoc.TabIndex = 6;
            this.seniorDoc.Text = "Senior Doctors";
            this.seniorDoc.UseVisualStyleBackColor = true;
            this.seniorDoc.Click += new System.EventHandler(this.SeniorDoc_Click);
            // 
            // Regstff
            // 
            this.Regstff.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regstff.Location = new System.Drawing.Point(457, 231);
            this.Regstff.Name = "Regstff";
            this.Regstff.Size = new System.Drawing.Size(200, 100);
            this.Regstff.TabIndex = 5;
            this.Regstff.Text = "Register On call staffs";
            this.Regstff.UseVisualStyleBackColor = true;
            this.Regstff.Click += new System.EventHandler(this.Regstff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.MainPageButton);
            this.panel1.Controls.Add(this.MinimizeButtonLogs);
            this.panel1.Controls.Add(this.CloseButtonLogs);
            this.panel1.Location = new System.Drawing.Point(25, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 44);
            this.panel1.TabIndex = 4;
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
            this.MainPageButton.Click += new System.EventHandler(this.MainPageButton_Click);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 394);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seniorDoc);
            this.Controls.Add(this.Regstff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "management";
            this.Text = "management";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seniorDoc;
        private System.Windows.Forms.Button Regstff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MainPageButton;
        private System.Windows.Forms.PictureBox MinimizeButtonLogs;
        private System.Windows.Forms.PictureBox CloseButtonLogs;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}