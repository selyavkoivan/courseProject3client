using System.Net;
using System.Net.Sockets;


namespace регистрация
{
    partial class AuthForm
    {


        Socket socket;
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
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Button();
            this.authorizationEXIT = new System.Windows.Forms.Button();
            this.authorizationHIDE = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginBoxBorder = new System.Windows.Forms.PictureBox();
            this.PasswordBoxBorder = new System.Windows.Forms.PictureBox();
            this.ERRORTEXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBoxBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoginBox.Location = new System.Drawing.Point(65, 240);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBox.MaxLength = 30;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(300, 25);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = " логин";
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_TextChanged);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.passwordBox.Location = new System.Drawing.Point(65, 300);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.MaxLength = 30;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(300, 25);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TabStop = false;
            this.passwordBox.Text = " пароль";
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.Font = new System.Drawing.Font("Rostov", 24F);
            this.Enter.ForeColor = System.Drawing.SystemColors.Control;
            this.Enter.Location = new System.Drawing.Point(134, 370);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(162, 51);
            this.Enter.TabIndex = 6;
            this.Enter.TabStop = false;
            this.Enter.Text = "ВОЙТИ";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // reg
            // 
            this.reg.FlatAppearance.BorderSize = 0;
            this.reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.reg.Location = new System.Drawing.Point(165, 430);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(100, 28);
            this.reg.TabIndex = 7;
            this.reg.TabStop = false;
            this.reg.Text = "регистрация";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // authorizationEXIT
            // 
            this.authorizationEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.authorizationEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationEXIT.FlatAppearance.BorderSize = 0;
            this.authorizationEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorizationEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationEXIT.ForeColor = System.Drawing.SystemColors.Control;
            this.authorizationEXIT.Location = new System.Drawing.Point(374, 0);
            this.authorizationEXIT.Name = "authorizationEXIT";
            this.authorizationEXIT.Size = new System.Drawing.Size(56, 37);
            this.authorizationEXIT.TabIndex = 8;
            this.authorizationEXIT.TabStop = false;
            this.authorizationEXIT.Text = "х";
            this.authorizationEXIT.UseVisualStyleBackColor = false;
            this.authorizationEXIT.Click += new System.EventHandler(this.authorizationEXIT_Click);
            // 
            // authorizationHIDE
            // 
            this.authorizationHIDE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.authorizationHIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.authorizationHIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationHIDE.FlatAppearance.BorderSize = 0;
            this.authorizationHIDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorizationHIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationHIDE.ForeColor = System.Drawing.SystemColors.Control;
            this.authorizationHIDE.Location = new System.Drawing.Point(318, 0);
            this.authorizationHIDE.Name = "authorizationHIDE";
            this.authorizationHIDE.Size = new System.Drawing.Size(56, 37);
            this.authorizationHIDE.TabIndex = 9;
            this.authorizationHIDE.TabStop = false;
            this.authorizationHIDE.Text = "-";
            this.authorizationHIDE.UseVisualStyleBackColor = false;
            this.authorizationHIDE.Click += new System.EventHandler(this.authorizationHIDE_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 74);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseUp);
            // 
            // LoginBoxBorder
            // 
            this.LoginBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoginBoxBorder.Location = new System.Drawing.Point(64, 239);
            this.LoginBoxBorder.Name = "LoginBoxBorder";
            this.LoginBoxBorder.Size = new System.Drawing.Size(302, 27);
            this.LoginBoxBorder.TabIndex = 11;
            this.LoginBoxBorder.TabStop = false;
            // 
            // PasswordBoxBorder
            // 
            this.PasswordBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PasswordBoxBorder.Location = new System.Drawing.Point(64, 299);
            this.PasswordBoxBorder.Name = "PasswordBoxBorder";
            this.PasswordBoxBorder.Size = new System.Drawing.Size(302, 27);
            this.PasswordBoxBorder.TabIndex = 12;
            this.PasswordBoxBorder.TabStop = false;
            // 
            // ERRORTEXT
            // 
            this.ERRORTEXT.AutoSize = true;
            this.ERRORTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ERRORTEXT.ForeColor = System.Drawing.SystemColors.Control;
            this.ERRORTEXT.Location = new System.Drawing.Point(65, 330);
            this.ERRORTEXT.Name = "ERRORTEXT";
            this.ERRORTEXT.Size = new System.Drawing.Size(206, 15);
            this.ERRORTEXT.TabIndex = 26;
            this.ERRORTEXT.Text = "неверно введен логин или пароль";
            this.ERRORTEXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseDown);
            this.ERRORTEXT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseMove);
            this.ERRORTEXT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rostov", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(59, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 55);
            this.label1.TabIndex = 27;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseUp);
            // 
            // authFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(430, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ERRORTEXT);
            this.Controls.Add(this.authorizationHIDE);
            this.Controls.Add(this.authorizationEXIT);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginBoxBorder);
            this.Controls.Add(this.PasswordBoxBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AuthForm";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.authForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBoxBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Button authorizationEXIT;
        private System.Windows.Forms.Button authorizationHIDE;
        private System.Windows.Forms.PictureBox LoginBoxBorder;
        private System.Windows.Forms.PictureBox PasswordBoxBorder;
        private System.Windows.Forms.Label ERRORTEXT;
        private System.Windows.Forms.Label label1;
    }
}