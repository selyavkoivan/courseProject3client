using System.Net.Sockets;
namespace регистрация
{
    partial class RegDataForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Enter = new System.Windows.Forms.Button();
            this.backToReg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SurmaneBoxBorder = new System.Windows.Forms.PictureBox();
            this.ERRORTEXTSurname = new System.Windows.Forms.Label();
            this.NameBoxBorder = new System.Windows.Forms.PictureBox();
            this.PatronymicBoxBorder = new System.Windows.Forms.PictureBox();
            this.ERRORTEXTName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurmaneBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatronymicBoxBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Rostov", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "РЕГИСТРАЦИЯ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
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
            // SurnameBox
            // 
            this.SurnameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SurnameBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SurnameBox.Location = new System.Drawing.Point(65, 120);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameBox.MaxLength = 20;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(300, 25);
            this.SurnameBox.TabIndex = 8;
            this.SurnameBox.Text = " фамилия";
            this.SurnameBox.Click += new System.EventHandler(this.SurnameBox_TextChanged);
            this.SurnameBox.TextChanged += new System.EventHandler(this.SurnameBox_TextChanged);
            this.SurnameBox.Leave += new System.EventHandler(this.SurnameBox_Leave);
            // 
            // patronymicBox
            // 
            this.patronymicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patronymicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.patronymicBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.patronymicBox.Location = new System.Drawing.Point(65, 240);
            this.patronymicBox.Margin = new System.Windows.Forms.Padding(2);
            this.patronymicBox.MaxLength = 15;
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(300, 25);
            this.patronymicBox.TabIndex = 7;
            this.patronymicBox.Text = " отчество";
            this.patronymicBox.Click += new System.EventHandler(this.patronymicBox_TextChanged);
            this.patronymicBox.TextChanged += new System.EventHandler(this.patronymicBox_TextChanged);
            this.patronymicBox.Leave += new System.EventHandler(this.patronymicBox_Leave);
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NameBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.NameBox.Location = new System.Drawing.Point(65, 180);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.MaxLength = 15;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(300, 25);
            this.NameBox.TabIndex = 6;
            this.NameBox.Text = " имя";
            this.NameBox.Click += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BirthdayDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BirthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(65, 330);
            this.BirthdayDateTimePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.BirthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(300, 25);
            this.BirthdayDateTimePicker.TabIndex = 5;
            this.BirthdayDateTimePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
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
            this.Enter.TabIndex = 4;
            this.Enter.Text = "СОЗДАТЬ";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // backToReg
            // 
            this.backToReg.FlatAppearance.BorderSize = 0;
            this.backToReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backToReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.backToReg.Location = new System.Drawing.Point(160, 459);
            this.backToReg.Name = "backToReg";
            this.backToReg.Size = new System.Drawing.Size(110, 28);
            this.backToReg.TabIndex = 3;
            this.backToReg.Text = "авторизация";
            this.backToReg.UseVisualStyleBackColor = true;
            this.backToReg.Click += new System.EventHandler(this.backToAuth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(65, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // SurmaneBoxBorder
            // 
            this.SurmaneBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SurmaneBoxBorder.Location = new System.Drawing.Point(64, 119);
            this.SurmaneBoxBorder.Name = "SurmaneBoxBorder";
            this.SurmaneBoxBorder.Size = new System.Drawing.Size(302, 27);
            this.SurmaneBoxBorder.TabIndex = 11;
            this.SurmaneBoxBorder.TabStop = false;
            // 
            // ERRORTEXTSurname
            // 
            this.ERRORTEXTSurname.AutoSize = true;
            this.ERRORTEXTSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ERRORTEXTSurname.ForeColor = System.Drawing.SystemColors.Control;
            this.ERRORTEXTSurname.Location = new System.Drawing.Point(65, 150);
            this.ERRORTEXTSurname.Name = "ERRORTEXTSurname";
            this.ERRORTEXTSurname.Size = new System.Drawing.Size(137, 15);
            this.ERRORTEXTSurname.TabIndex = 1;
            this.ERRORTEXTSurname.Text = "это поле обязательно";
            this.ERRORTEXTSurname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ERRORTEXTSurname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ERRORTEXTSurname.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // NameBoxBorder
            // 
            this.NameBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NameBoxBorder.Location = new System.Drawing.Point(64, 179);
            this.NameBoxBorder.Name = "NameBoxBorder";
            this.NameBoxBorder.Size = new System.Drawing.Size(302, 27);
            this.NameBoxBorder.TabIndex = 12;
            this.NameBoxBorder.TabStop = false;
            // 
            // PatronymicBoxBorder
            // 
            this.PatronymicBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PatronymicBoxBorder.Location = new System.Drawing.Point(64, 239);
            this.PatronymicBoxBorder.Name = "PatronymicBoxBorder";
            this.PatronymicBoxBorder.Size = new System.Drawing.Size(302, 27);
            this.PatronymicBoxBorder.TabIndex = 13;
            this.PatronymicBoxBorder.TabStop = false;
            // 
            // ERRORTEXTName
            // 
            this.ERRORTEXTName.AutoSize = true;
            this.ERRORTEXTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ERRORTEXTName.ForeColor = System.Drawing.SystemColors.Control;
            this.ERRORTEXTName.Location = new System.Drawing.Point(65, 210);
            this.ERRORTEXTName.Name = "ERRORTEXTName";
            this.ERRORTEXTName.Size = new System.Drawing.Size(137, 15);
            this.ERRORTEXTName.TabIndex = 0;
            this.ERRORTEXTName.Text = "это поле обязательно";
            this.ERRORTEXTName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ERRORTEXTName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ERRORTEXTName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // regDataFORM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(430, 500);
            this.Controls.Add(this.ERRORTEXTName);
            this.Controls.Add(this.ERRORTEXTSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backToReg);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SurmaneBoxBorder);
            this.Controls.Add(this.NameBoxBorder);
            this.Controls.Add(this.PatronymicBoxBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegDataForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.regDataFORM_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurmaneBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatronymicBoxBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button backToReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox SurmaneBoxBorder;
        private System.Windows.Forms.Label ERRORTEXTSurname;
        private System.Windows.Forms.PictureBox NameBoxBorder;
        private System.Windows.Forms.PictureBox PatronymicBoxBorder;
        private System.Windows.Forms.Label ERRORTEXTName;
    }
}