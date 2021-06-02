using System.Net.Sockets;

namespace регистрация
{
    partial class RegForm
    {
        private Socket socket;
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
            this.registrationHIDE = new System.Windows.Forms.Button();
            this.registrationEXIT = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.checkPasswordBox = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.Button();
            this.ERRORTEXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBoxBorder = new System.Windows.Forms.PictureBox();
            this.PasswordBoxBorder = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkPasswordBoxBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPasswordBoxBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationHIDE
            // 
            this.registrationHIDE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.registrationHIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registrationHIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationHIDE.FlatAppearance.BorderSize = 0;
            this.registrationHIDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationHIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationHIDE.ForeColor = System.Drawing.SystemColors.Control;
            this.registrationHIDE.Location = new System.Drawing.Point(318, 0);
            this.registrationHIDE.Name = "registrationHIDE";
            this.registrationHIDE.Size = new System.Drawing.Size(56, 37);
            this.registrationHIDE.TabIndex = 12;
            this.registrationHIDE.Text = "-";
            this.registrationHIDE.UseVisualStyleBackColor = false;
            this.registrationHIDE.Click += new System.EventHandler(this.registrationHIDE_Click);
            // 
            // registrationEXIT
            // 
            this.registrationEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.registrationEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationEXIT.FlatAppearance.BorderSize = 0;
            this.registrationEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationEXIT.ForeColor = System.Drawing.SystemColors.Control;
            this.registrationEXIT.Location = new System.Drawing.Point(374, 0);
            this.registrationEXIT.Name = "registrationEXIT";
            this.registrationEXIT.Size = new System.Drawing.Size(56, 37);
            this.registrationEXIT.TabIndex = 11;
            this.registrationEXIT.Text = "х";
            this.registrationEXIT.UseVisualStyleBackColor = false;
            this.registrationEXIT.Click += new System.EventHandler(this.registrationEXIT_Click);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.Font = new System.Drawing.Font("Rostov", 24F);
            this.Enter.ForeColor = System.Drawing.SystemColors.Control;
            this.Enter.Location = new System.Drawing.Point(115, 399);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(200, 51);
            this.Enter.TabIndex = 16;
            this.Enter.Text = "СОЗДАТЬ";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.RegUser_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.passwordBox.Location = new System.Drawing.Point(65, 269);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.MaxLength = 30;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(300, 25);
            this.passwordBox.TabIndex = 15;
            this.passwordBox.Text = " пароль";
            this.passwordBox.Click += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // LoginBox
            // 
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoginBox.Location = new System.Drawing.Point(65, 209);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBox.MaxLength = 30;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(300, 25);
            this.LoginBox.TabIndex = 14;
            this.LoginBox.Text = " логин";
            this.LoginBox.Click += new System.EventHandler(this.LoginBox_TextChanged);
            this.LoginBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // checkPasswordBox
            // 
            this.checkPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkPasswordBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkPasswordBox.Location = new System.Drawing.Point(65, 329);
            this.checkPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkPasswordBox.MaxLength = 30;
            this.checkPasswordBox.Name = "checkPasswordBox";
            this.checkPasswordBox.Size = new System.Drawing.Size(300, 25);
            this.checkPasswordBox.TabIndex = 22;
            this.checkPasswordBox.Text = " повторите пароль";
            this.checkPasswordBox.Click += new System.EventHandler(this.checkPasswordBox_TextChanged);
            this.checkPasswordBox.TextChanged += new System.EventHandler(this.checkPasswordBox_TextChanged);
            this.checkPasswordBox.Leave += new System.EventHandler(this.checkPasswordBox_Leave);
            // 
            // reg
            // 
            this.reg.FlatAppearance.BorderSize = 0;
            this.reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.reg.Location = new System.Drawing.Point(160, 459);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(110, 28);
            this.reg.TabIndex = 24;
            this.reg.Text = "авторизация";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.authFORM_Click);
            // 
            // ERRORTEXT
            // 
            this.ERRORTEXT.AutoSize = true;
            this.ERRORTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ERRORTEXT.ForeColor = System.Drawing.SystemColors.Control;
            this.ERRORTEXT.Location = new System.Drawing.Point(65, 359);
            this.ERRORTEXT.Name = "ERRORTEXT";
            this.ERRORTEXT.Size = new System.Drawing.Size(133, 15);
            this.ERRORTEXT.TabIndex = 25;
            this.ERRORTEXT.Text = "пароли не совпадают";
       
            this.ERRORTEXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ERRORTEXT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ERRORTEXT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rostov", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(72, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 55);
            this.label1.TabIndex = 26;
            this.label1.Text = "РЕГИСТРАЦИЯ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // LoginBoxBorder
            // 
            this.LoginBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoginBoxBorder.Location = new System.Drawing.Point(64, 208);
            this.LoginBoxBorder.Name = "LoginBoxBorder";
            this.LoginBoxBorder.Size = new System.Drawing.Size(302, 27);
            this.LoginBoxBorder.TabIndex = 17;
            this.LoginBoxBorder.TabStop = false;
            // 
            // PasswordBoxBorder
            // 
            this.PasswordBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PasswordBoxBorder.Location = new System.Drawing.Point(64, 268);
            this.PasswordBoxBorder.Name = "PasswordBoxBorder";
            this.PasswordBoxBorder.Size = new System.Drawing.Size(302, 27);
            this.PasswordBoxBorder.TabIndex = 18;
            this.PasswordBoxBorder.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 74);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // checkPasswordBoxBorder
            // 
            this.checkPasswordBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkPasswordBoxBorder.Location = new System.Drawing.Point(64, 328);
            this.checkPasswordBoxBorder.Name = "checkPasswordBoxBorder";
            this.checkPasswordBoxBorder.Size = new System.Drawing.Size(302, 27);
            this.checkPasswordBoxBorder.TabIndex = 23;
            this.checkPasswordBoxBorder.TabStop = false;
            // 
            // regFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ERRORTEXT);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.checkPasswordBox);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginBoxBorder);
            this.Controls.Add(this.PasswordBoxBorder);
            this.Controls.Add(this.registrationHIDE);
            this.Controls.Add(this.registrationEXIT);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkPasswordBoxBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegForm";
            this.Text = "РЕГИСТРАЦИЯ ШАГ 1";
            this.Load += new System.EventHandler(this.regFORM_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.LoginBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPasswordBoxBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrationHIDE;
        private System.Windows.Forms.Button registrationEXIT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.PictureBox LoginBoxBorder;
        private System.Windows.Forms.PictureBox PasswordBoxBorder;
        private System.Windows.Forms.TextBox checkPasswordBox;
        private System.Windows.Forms.PictureBox checkPasswordBoxBorder;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Label ERRORTEXT;
        private System.Windows.Forms.Label label1;
    }
}