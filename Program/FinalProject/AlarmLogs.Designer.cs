namespace FinalProject
{
    partial class AlarmLogs
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
            this.CloseButtonAlarmLogs = new System.Windows.Forms.PictureBox();
            this.MinimizeButtonAlarmLogs = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.CommentsBox = new System.Windows.Forms.TextBox();
            this.AlarmLogsView = new System.Windows.Forms.Button();
            this.LastBox = new System.Windows.Forms.TextBox();
            this.AlarmLogsSaveButton = new System.Windows.Forms.Button();
            this.FirstBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AlarmDeleteButton = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonAlarmLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonAlarmLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.CloseButtonAlarmLogs);
            this.PanelTop.Controls.Add(this.MinimizeButtonAlarmLogs);
            this.PanelTop.Controls.Add(this.BackButton);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(846, 44);
            this.PanelTop.TabIndex = 6;
            // 
            // CloseButtonAlarmLogs
            // 
            this.CloseButtonAlarmLogs.Image = global::FinalProject.Properties.Resources.closewhite;
            this.CloseButtonAlarmLogs.Location = new System.Drawing.Point(811, 8);
            this.CloseButtonAlarmLogs.Name = "CloseButtonAlarmLogs";
            this.CloseButtonAlarmLogs.Size = new System.Drawing.Size(23, 25);
            this.CloseButtonAlarmLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonAlarmLogs.TabIndex = 5;
            this.CloseButtonAlarmLogs.TabStop = false;
            this.CloseButtonAlarmLogs.Click += new System.EventHandler(this.CloseButtonAlarmLogs_Click);
            // 
            // MinimizeButtonAlarmLogs
            // 
            this.MinimizeButtonAlarmLogs.Image = global::FinalProject.Properties.Resources.minimizewhite;
            this.MinimizeButtonAlarmLogs.Location = new System.Drawing.Point(782, 8);
            this.MinimizeButtonAlarmLogs.Name = "MinimizeButtonAlarmLogs";
            this.MinimizeButtonAlarmLogs.Size = new System.Drawing.Size(23, 25);
            this.MinimizeButtonAlarmLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButtonAlarmLogs.TabIndex = 4;
            this.MinimizeButtonAlarmLogs.TabStop = false;
            this.MinimizeButtonAlarmLogs.Click += new System.EventHandler(this.MinimizeButtonAlarmLogs_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = global::FinalProject.Properties.Resources._8B7gpJyx_400x400;
            this.BackButton.Location = new System.Drawing.Point(2, 8);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 28);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackButton.TabIndex = 3;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 415);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.AlarmDeleteButton);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Controls.Add(this.CommentsBox);
            this.groupBox1.Controls.Add(this.AlarmLogsView);
            this.groupBox1.Controls.Add(this.LastBox);
            this.groupBox1.Controls.Add(this.AlarmLogsSaveButton);
            this.groupBox1.Controls.Add(this.FirstBox);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(129, 82);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(138, 20);
            this.DateBox.TabIndex = 7;
            // 
            // CommentsBox
            // 
            this.CommentsBox.Location = new System.Drawing.Point(129, 207);
            this.CommentsBox.Name = "CommentsBox";
            this.CommentsBox.Size = new System.Drawing.Size(138, 20);
            this.CommentsBox.TabIndex = 6;
            // 
            // AlarmLogsView
            // 
            this.AlarmLogsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AlarmLogsView.Location = new System.Drawing.Point(129, 249);
            this.AlarmLogsView.Name = "AlarmLogsView";
            this.AlarmLogsView.Size = new System.Drawing.Size(75, 23);
            this.AlarmLogsView.TabIndex = 2;
            this.AlarmLogsView.Text = "View Logs";
            this.AlarmLogsView.UseVisualStyleBackColor = false;
            this.AlarmLogsView.Click += new System.EventHandler(this.AlarmLogsView_Click);
            // 
            // LastBox
            // 
            this.LastBox.Location = new System.Drawing.Point(129, 168);
            this.LastBox.Name = "LastBox";
            this.LastBox.Size = new System.Drawing.Size(138, 20);
            this.LastBox.TabIndex = 1;
            // 
            // AlarmLogsSaveButton
            // 
            this.AlarmLogsSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AlarmLogsSaveButton.Location = new System.Drawing.Point(48, 249);
            this.AlarmLogsSaveButton.Name = "AlarmLogsSaveButton";
            this.AlarmLogsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AlarmLogsSaveButton.TabIndex = 0;
            this.AlarmLogsSaveButton.Text = "Save";
            this.AlarmLogsSaveButton.UseVisualStyleBackColor = false;
            this.AlarmLogsSaveButton.Click += new System.EventHandler(this.AlarmLogsSaveButton_Click);
            // 
            // FirstBox
            // 
            this.FirstBox.Location = new System.Drawing.Point(129, 128);
            this.FirstBox.Name = "FirstBox";
            this.FirstBox.Size = new System.Drawing.Size(138, 20);
            this.FirstBox.TabIndex = 3;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(129, 40);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(138, 20);
            this.IDBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALARM RECTIFIED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FIRST ALARM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "COMMENTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID";
            // 
            // AlarmDeleteButton
            // 
            this.AlarmDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AlarmDeleteButton.Location = new System.Drawing.Point(207, 249);
            this.AlarmDeleteButton.Name = "AlarmDeleteButton";
            this.AlarmDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.AlarmDeleteButton.TabIndex = 8;
            this.AlarmDeleteButton.Text = "Delete";
            this.AlarmDeleteButton.UseVisualStyleBackColor = false;
            this.AlarmDeleteButton.Click += new System.EventHandler(this.AlarmDeleteButton_Click);
            // 
            // AlarmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlarmLogs";
            this.Text = "AlarmLogs";
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonAlarmLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonAlarmLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CommentsBox;
        private System.Windows.Forms.Button AlarmLogsView;
        private System.Windows.Forms.TextBox LastBox;
        private System.Windows.Forms.Button AlarmLogsSaveButton;
        private System.Windows.Forms.TextBox FirstBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.PictureBox CloseButtonAlarmLogs;
        private System.Windows.Forms.PictureBox MinimizeButtonAlarmLogs;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Button AlarmDeleteButton;
    }
}