namespace medical_staff
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "On call staffs";
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(48, 312);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(135, 37);
            this.BtnAddNew.TabIndex = 1;
            this.BtnAddNew.Text = "Add new record";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(255, 313);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(119, 36);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete selected Record";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(467, 315);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(104, 33);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "Close Fom";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Patient Monitoring";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
    }
}

