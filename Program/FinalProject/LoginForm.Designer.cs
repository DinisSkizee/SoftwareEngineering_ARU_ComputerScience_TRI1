using System;
using System.Windows.Forms;

namespace FinalProject
{
    partial class LoginForm
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
            this.GreyBackgroundLogin = new System.Windows.Forms.Panel();
            this.WelcomeTextBox = new System.Windows.Forms.TextBox();
            this.WhitePanelLogin = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.CloseButtonLoginForm = new System.Windows.Forms.PictureBox();
            this.MinimizeButtonLoginForm = new System.Windows.Forms.PictureBox();
            this.GreyBackgroundLogin.SuspendLayout();
            this.WhitePanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonLoginForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonLoginForm)).BeginInit();
            this.SuspendLayout();
            // 
            // GreyBackgroundLogin
            // 
            this.GreyBackgroundLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GreyBackgroundLogin.Controls.Add(this.CloseButtonLoginForm);
            this.GreyBackgroundLogin.Controls.Add(this.MinimizeButtonLoginForm);
            this.GreyBackgroundLogin.Controls.Add(this.WelcomeTextBox);
            this.GreyBackgroundLogin.Controls.Add(this.WhitePanelLogin);
            this.GreyBackgroundLogin.Location = new System.Drawing.Point(0, 0);
            this.GreyBackgroundLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GreyBackgroundLogin.Name = "GreyBackgroundLogin";
            this.GreyBackgroundLogin.Size = new System.Drawing.Size(750, 447);
            this.GreyBackgroundLogin.TabIndex = 0;
            this.GreyBackgroundLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GreyBackgroundLogin_MouseMove);
            // 
            // WelcomeTextBox
            // 
            this.WelcomeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WelcomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeTextBox.Enabled = false;
            this.WelcomeTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeTextBox.ForeColor = System.Drawing.Color.White;
            this.WelcomeTextBox.Location = new System.Drawing.Point(139, 34);
            this.WelcomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WelcomeTextBox.Name = "WelcomeTextBox";
            this.WelcomeTextBox.ReadOnly = true;
            this.WelcomeTextBox.Size = new System.Drawing.Size(473, 36);
            this.WelcomeTextBox.TabIndex = 10;
            this.WelcomeTextBox.TabStop = false;
            this.WelcomeTextBox.Text = "Welcome to Eastern Anglia Hospital Trust";
            this.WelcomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WhitePanelLogin
            // 
            this.WhitePanelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WhitePanelLogin.BackColor = System.Drawing.Color.White;
            this.WhitePanelLogin.Controls.Add(this.passwordBox);
            this.WhitePanelLogin.Controls.Add(this.PasswordTextBox);
            this.WhitePanelLogin.Controls.Add(this.UsernameTextBox);
            this.WhitePanelLogin.Controls.Add(this.LoginButton);
            this.WhitePanelLogin.Controls.Add(this.usernameBox);
            this.WhitePanelLogin.Location = new System.Drawing.Point(211, 116);
            this.WhitePanelLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WhitePanelLogin.Name = "WhitePanelLogin";
            this.WhitePanelLogin.Size = new System.Drawing.Size(328, 214);
            this.WhitePanelLogin.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordBox.Location = new System.Drawing.Point(51, 93);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(226, 36);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(52, 70);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ReadOnly = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(225, 18);
            this.PasswordTextBox.TabIndex = 10;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Enabled = false;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(51, 8);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(226, 18);
            this.UsernameTextBox.TabIndex = 10;
            this.UsernameTextBox.TabStop = false;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(51, 145);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(226, 36);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usernameBox.Location = new System.Drawing.Point(51, 29);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameBox.Multiline = true;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(226, 36);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyDown);
            // 
            // CloseButtonLoginForm
            // 
            this.CloseButtonLoginForm.Image = global::FinalProject.Properties.Resources.close;
            this.CloseButtonLoginForm.Location = new System.Drawing.Point(716, 10);
            this.CloseButtonLoginForm.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButtonLoginForm.Name = "CloseButtonLoginForm";
            this.CloseButtonLoginForm.Size = new System.Drawing.Size(23, 25);
            this.CloseButtonLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButtonLoginForm.TabIndex = 12;
            this.CloseButtonLoginForm.TabStop = false;
            this.CloseButtonLoginForm.Click += new System.EventHandler(this.CloseButtonLoginForm_Click);
            // 
            // MinimizeButtonLoginForm
            // 
            this.MinimizeButtonLoginForm.Image = global::FinalProject.Properties.Resources.minimize__1_;
            this.MinimizeButtonLoginForm.Location = new System.Drawing.Point(681, 10);
            this.MinimizeButtonLoginForm.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButtonLoginForm.Name = "MinimizeButtonLoginForm";
            this.MinimizeButtonLoginForm.Size = new System.Drawing.Size(23, 25);
            this.MinimizeButtonLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButtonLoginForm.TabIndex = 11;
            this.MinimizeButtonLoginForm.TabStop = false;
            this.MinimizeButtonLoginForm.Click += new System.EventHandler(this.MinimizeButtonLoginForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(750, 447);
            this.Controls.Add(this.GreyBackgroundLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.GreyBackgroundLogin.ResumeLayout(false);
            this.GreyBackgroundLogin.PerformLayout();
            this.WhitePanelLogin.ResumeLayout(false);
            this.WhitePanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonLoginForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButtonLoginForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GreyBackgroundLogin;
        private System.Windows.Forms.Panel WhitePanelLogin;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox WelcomeTextBox;
        private System.Windows.Forms.TextBox passwordBox;
        private PictureBox CloseButtonLoginForm;
        private PictureBox MinimizeButtonLoginForm;
    }
}

