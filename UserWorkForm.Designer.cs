using System.Net.Sockets;
using System.Collections.Generic;
using System.Windows.Forms;
namespace регистрация
{
    partial class UserWorkForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        /// 
        private List<CustomsControlPoint> points;

        private List<Vote> votes;

        private Socket socket;
        private int myUserID;


        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workFormHIDE = new System.Windows.Forms.Button();
            this.workFormEXIT = new System.Windows.Forms.Button();
            this.ТАМОЖНЯ = new System.Windows.Forms.Label();
            this.РЕСПУБЛИКИ = new System.Windows.Forms.Label();
            this.БЕЛАРУСЬ = new System.Windows.Forms.Label();
            this.выдатьПрава = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MyDataTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.ERRORName = new System.Windows.Forms.Label();
            this.ERRORLogin = new System.Windows.Forms.Label();
            this.NewNameSend = new System.Windows.Forms.Button();
            this.SendBirthday = new System.Windows.Forms.Button();
            this.NewLoginSend = new System.Windows.Forms.Button();
            this.LoginPasswordLable = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.NewBirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.newSurnameTextBox = new System.Windows.Forms.TextBox();
            this.NewLoginTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newLoginTextBoxBorder = new System.Windows.Forms.PictureBox();
            this.newPasswordTextBoxBorder = new System.Windows.Forms.PictureBox();
            this.newSurnameTextBoxBorder = new System.Windows.Forms.PictureBox();
            this.newNameTextBoxBorder = new System.Windows.Forms.PictureBox();
            this.newPatronymicTextBoxBorder = new System.Windows.Forms.PictureBox();
            this.VoteTabPage = new System.Windows.Forms.TabPage();
            this.itsPoint = new System.Windows.Forms.PictureBox();
            this.backBUTTON = new System.Windows.Forms.Button();
            this.ERRORVote2 = new System.Windows.Forms.Label();
            this.ERRORVote1 = new System.Windows.Forms.Label();
            this.pointsVoteDataGrid = new System.Windows.Forms.DataGridView();
            this.sendPriorityButton = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.TabControl();
            this.customsTabPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.PointsDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.voteButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.MyDataBUTTON = new System.Windows.Forms.Button();
            this.pictureBoxЗЕМЛЯ = new System.Windows.Forms.PictureBox();
            this.pictureBoxАГОНЬ = new System.Windows.Forms.PictureBox();
            this.AREAButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newLoginTextBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSurnameTextBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNameTextBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPatronymicTextBoxBorder)).BeginInit();
            this.VoteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itsPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsVoteDataGrid)).BeginInit();
            this.Point.SuspendLayout();
            this.customsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxЗЕМЛЯ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxАГОНЬ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AREAButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // workFormHIDE
            // 
            this.workFormHIDE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.workFormHIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.workFormHIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workFormHIDE.FlatAppearance.BorderSize = 0;
            this.workFormHIDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workFormHIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workFormHIDE.ForeColor = System.Drawing.SystemColors.Control;
            this.workFormHIDE.Location = new System.Drawing.Point(863, 0);
            this.workFormHIDE.Name = "workFormHIDE";
            this.workFormHIDE.Size = new System.Drawing.Size(56, 37);
            this.workFormHIDE.TabIndex = 26;
            this.workFormHIDE.Text = "-";
            this.workFormHIDE.UseVisualStyleBackColor = false;
            this.workFormHIDE.Click += new System.EventHandler(this.workFormHIDE_Click);
            // 
            // workFormEXIT
            // 
            this.workFormEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.workFormEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workFormEXIT.FlatAppearance.BorderSize = 0;
            this.workFormEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workFormEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workFormEXIT.ForeColor = System.Drawing.SystemColors.Control;
            this.workFormEXIT.Location = new System.Drawing.Point(919, 0);
            this.workFormEXIT.Name = "workFormEXIT";
            this.workFormEXIT.Size = new System.Drawing.Size(56, 37);
            this.workFormEXIT.TabIndex = 27;
            this.workFormEXIT.Text = "х";
            this.workFormEXIT.UseVisualStyleBackColor = false;
            this.workFormEXIT.Click += new System.EventHandler(this.workFormEXIT_Click);
            // 
            // ТАМОЖНЯ
            // 
            this.ТАМОЖНЯ.AutoSize = true;
            this.ТАМОЖНЯ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ТАМОЖНЯ.Font = new System.Drawing.Font("Rostov", 36F);
            this.ТАМОЖНЯ.ForeColor = System.Drawing.SystemColors.Control;
            this.ТАМОЖНЯ.Location = new System.Drawing.Point(302, 4);
            this.ТАМОЖНЯ.Name = "ТАМОЖНЯ";
            this.ТАМОЖНЯ.Size = new System.Drawing.Size(266, 66);
            this.ТАМОЖНЯ.TabIndex = 16;
            this.ТАМОЖНЯ.Text = "ТАМОЖНЯ";
            this.ТАМОЖНЯ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ТАМОЖНЯ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ТАМОЖНЯ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // РЕСПУБЛИКИ
            // 
            this.РЕСПУБЛИКИ.AutoSize = true;
            this.РЕСПУБЛИКИ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.РЕСПУБЛИКИ.Font = new System.Drawing.Font("Rostov", 18F);
            this.РЕСПУБЛИКИ.ForeColor = System.Drawing.SystemColors.Control;
            this.РЕСПУБЛИКИ.Location = new System.Drawing.Point(568, 4);
            this.РЕСПУБЛИКИ.Name = "РЕСПУБЛИКИ";
            this.РЕСПУБЛИКИ.Size = new System.Drawing.Size(162, 33);
            this.РЕСПУБЛИКИ.TabIndex = 17;
            this.РЕСПУБЛИКИ.Text = "РЕСПУБЛИКИ";
            this.РЕСПУБЛИКИ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.РЕСПУБЛИКИ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.РЕСПУБЛИКИ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // БЕЛАРУСЬ
            // 
            this.БЕЛАРУСЬ.AutoSize = true;
            this.БЕЛАРУСЬ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.БЕЛАРУСЬ.Font = new System.Drawing.Font("Rostov", 18F);
            this.БЕЛАРУСЬ.ForeColor = System.Drawing.SystemColors.Control;
            this.БЕЛАРУСЬ.Location = new System.Drawing.Point(568, 37);
            this.БЕЛАРУСЬ.Name = "БЕЛАРУСЬ";
            this.БЕЛАРУСЬ.Size = new System.Drawing.Size(126, 33);
            this.БЕЛАРУСЬ.TabIndex = 18;
            this.БЕЛАРУСЬ.Text = "БЕЛАРУСЬ";
            this.БЕЛАРУСЬ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.БЕЛАРУСЬ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.БЕЛАРУСЬ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // выдатьПрава
            // 
            this.выдатьПрава.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.выдатьПрава.Name = "выдатьПрава";
            this.выдатьПрава.Size = new System.Drawing.Size(180, 22);
            this.выдатьПрава.Text = "выдать права";
            // 
            // priorityContextMenuStrip
            // 
            this.priorityContextMenuStrip.Name = "priorityContextMenuStrip";
            this.priorityContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.priorityContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.priorityContextMenuStrip_ItemClicked);
            // 
            // MyDataTabPage
            // 
            this.MyDataTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyDataTabPage.Controls.Add(this.pictureBox1);
            this.MyDataTabPage.Controls.Add(this.changeLabel);
            this.MyDataTabPage.Controls.Add(this.ERRORName);
            this.MyDataTabPage.Controls.Add(this.ERRORLogin);
            this.MyDataTabPage.Controls.Add(this.NewNameSend);
            this.MyDataTabPage.Controls.Add(this.SendBirthday);
            this.MyDataTabPage.Controls.Add(this.NewLoginSend);
            this.MyDataTabPage.Controls.Add(this.LoginPasswordLable);
            this.MyDataTabPage.Controls.Add(this.BirthdayLabel);
            this.MyDataTabPage.Controls.Add(this.NameLable);
            this.MyDataTabPage.Controls.Add(this.NewBirthdayDateTimePicker);
            this.MyDataTabPage.Controls.Add(this.newPatronymicTextBox);
            this.MyDataTabPage.Controls.Add(this.newNameTextBox);
            this.MyDataTabPage.Controls.Add(this.newSurnameTextBox);
            this.MyDataTabPage.Controls.Add(this.NewLoginTextBox);
            this.MyDataTabPage.Controls.Add(this.NewPasswordTextBox);
            this.MyDataTabPage.Controls.Add(this.richTextBox2);
            this.MyDataTabPage.Controls.Add(this.richTextBox1);
            this.MyDataTabPage.Controls.Add(this.label3);
            this.MyDataTabPage.Controls.Add(this.newLoginTextBoxBorder);
            this.MyDataTabPage.Controls.Add(this.newPasswordTextBoxBorder);
            this.MyDataTabPage.Controls.Add(this.newSurnameTextBoxBorder);
            this.MyDataTabPage.Controls.Add(this.newNameTextBoxBorder);
            this.MyDataTabPage.Controls.Add(this.newPatronymicTextBoxBorder);
            this.MyDataTabPage.Location = new System.Drawing.Point(4, 25);
            this.MyDataTabPage.Name = "MyDataTabPage";
            this.MyDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MyDataTabPage.Size = new System.Drawing.Size(799, 568);
            this.MyDataTabPage.TabIndex = 1;
            this.MyDataTabPage.Text = "MyData";
            this.MyDataTabPage.UseVisualStyleBackColor = true;
            this.MyDataTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MyDataTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MyDataTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Location = new System.Drawing.Point(550, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 518);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.changeLabel.Location = new System.Drawing.Point(568, 40);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(215, 24);
            this.changeLabel.TabIndex = 40;
            this.changeLabel.Text = "ИЗМЕНЕНИЕ ДАННЫХ";
            this.changeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.changeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.changeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // ERRORName
            // 
            this.ERRORName.AutoSize = true;
            this.ERRORName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ERRORName.ForeColor = System.Drawing.SystemColors.Control;
            this.ERRORName.Location = new System.Drawing.Point(580, 350);
            this.ERRORName.Name = "ERRORName";
            this.ERRORName.Size = new System.Drawing.Size(119, 13);
            this.ERRORName.TabIndex = 39;
            this.ERRORName.Text = "это поле обязательно";
            this.ERRORName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ERRORName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ERRORName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // ERRORLogin
            // 
            this.ERRORLogin.AutoSize = true;
            this.ERRORLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ERRORLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.ERRORLogin.Location = new System.Drawing.Point(580, 180);
            this.ERRORLogin.Name = "ERRORLogin";
            this.ERRORLogin.Size = new System.Drawing.Size(119, 13);
            this.ERRORLogin.TabIndex = 38;
            this.ERRORLogin.Text = "это поле обязательно";
            this.ERRORLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ERRORLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ERRORLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // NewNameSend
            // 
            this.NewNameSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewNameSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewNameSend.ForeColor = System.Drawing.SystemColors.Control;
            this.NewNameSend.Location = new System.Drawing.Point(632, 370);
            this.NewNameSend.Name = "NewNameSend";
            this.NewNameSend.Size = new System.Drawing.Size(86, 23);
            this.NewNameSend.TabIndex = 37;
            this.NewNameSend.Text = "ОТПРАВИТЬ";
            this.NewNameSend.UseVisualStyleBackColor = false;
            this.NewNameSend.Click += new System.EventHandler(this.NewNameSend_Click);
            // 
            // SendBirthday
            // 
            this.SendBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SendBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendBirthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBirthday.ForeColor = System.Drawing.SystemColors.Control;
            this.SendBirthday.Location = new System.Drawing.Point(632, 470);
            this.SendBirthday.Name = "SendBirthday";
            this.SendBirthday.Size = new System.Drawing.Size(86, 23);
            this.SendBirthday.TabIndex = 36;
            this.SendBirthday.Text = "ОТПРАВИТЬ";
            this.SendBirthday.UseVisualStyleBackColor = false;
            this.SendBirthday.Click += new System.EventHandler(this.SendBirthday_Click);
            // 
            // NewLoginSend
            // 
            this.NewLoginSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewLoginSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewLoginSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewLoginSend.ForeColor = System.Drawing.SystemColors.Control;
            this.NewLoginSend.Location = new System.Drawing.Point(632, 200);
            this.NewLoginSend.Name = "NewLoginSend";
            this.NewLoginSend.Size = new System.Drawing.Size(86, 23);
            this.NewLoginSend.TabIndex = 35;
            this.NewLoginSend.Text = "ОТПРАВИТЬ";
            this.NewLoginSend.UseVisualStyleBackColor = false;
            this.NewLoginSend.Click += new System.EventHandler(this.NewLoginSend_Click);
            // 
            // LoginPasswordLable
            // 
            this.LoginPasswordLable.AutoSize = true;
            this.LoginPasswordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginPasswordLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LoginPasswordLable.Location = new System.Drawing.Point(587, 90);
            this.LoginPasswordLable.Name = "LoginPasswordLable";
            this.LoginPasswordLable.Size = new System.Drawing.Size(177, 24);
            this.LoginPasswordLable.TabIndex = 34;
            this.LoginPasswordLable.Text = "ЛОГИН И ПАРОЛЬ";
            this.LoginPasswordLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.LoginPasswordLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.LoginPasswordLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BirthdayLabel.Location = new System.Drawing.Point(586, 400);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(178, 24);
            this.BirthdayLabel.TabIndex = 33;
            this.BirthdayLabel.Text = "ДАТА РОЖДЕНИЯ";
            this.BirthdayLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.BirthdayLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.BirthdayLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NameLable.Location = new System.Drawing.Point(648, 230);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(54, 24);
            this.NameLable.TabIndex = 32;
            this.NameLable.Text = "ИМЯ";
            this.NameLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.NameLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.NameLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // NewBirthdayDateTimePicker
            // 
            this.NewBirthdayDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NewBirthdayDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewBirthdayDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBirthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NewBirthdayDateTimePicker.Location = new System.Drawing.Point(580, 440);
            this.NewBirthdayDateTimePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.NewBirthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.NewBirthdayDateTimePicker.Name = "NewBirthdayDateTimePicker";
            this.NewBirthdayDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.NewBirthdayDateTimePicker.TabIndex = 26;
            this.NewBirthdayDateTimePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // newPatronymicTextBox
            // 
            this.newPatronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newPatronymicTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.newPatronymicTextBox.Location = new System.Drawing.Point(580, 330);
            this.newPatronymicTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPatronymicTextBox.MaxLength = 15;
            this.newPatronymicTextBox.Name = "newPatronymicTextBox";
            this.newPatronymicTextBox.Size = new System.Drawing.Size(190, 16);
            this.newPatronymicTextBox.TabIndex = 25;
            this.newPatronymicTextBox.Text = " отчество";
            this.newPatronymicTextBox.TextChanged += new System.EventHandler(this.newPatronymicTextBox_TextChanged);
            this.newPatronymicTextBox.Enter += new System.EventHandler(this.newPatronymicTextBox_TextChanged);
            this.newPatronymicTextBox.Leave += new System.EventHandler(this.newPatronymicTextBox_Leave);
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newNameTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.newNameTextBox.Location = new System.Drawing.Point(580, 300);
            this.newNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newNameTextBox.MaxLength = 15;
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(190, 16);
            this.newNameTextBox.TabIndex = 24;
            this.newNameTextBox.Text = " имя";
            this.newNameTextBox.TextChanged += new System.EventHandler(this.newNameTextBox_TextChanged);
            this.newNameTextBox.Enter += new System.EventHandler(this.newNameTextBox_TextChanged);
            this.newNameTextBox.Leave += new System.EventHandler(this.newNameTextBox_Leave);
            // 
            // newSurnameTextBox
            // 
            this.newSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newSurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newSurnameTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.newSurnameTextBox.Location = new System.Drawing.Point(580, 270);
            this.newSurnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newSurnameTextBox.MaxLength = 20;
            this.newSurnameTextBox.Name = "newSurnameTextBox";
            this.newSurnameTextBox.Size = new System.Drawing.Size(190, 16);
            this.newSurnameTextBox.TabIndex = 23;
            this.newSurnameTextBox.Text = " фамилия";
            this.newSurnameTextBox.TextChanged += new System.EventHandler(this.newSurnameTextBox_TextChanged);
            this.newSurnameTextBox.Enter += new System.EventHandler(this.newSurnameTextBox_TextChanged);
            this.newSurnameTextBox.Leave += new System.EventHandler(this.newSurnameTextBox_Leave);
            // 
            // NewLoginTextBox
            // 
            this.NewLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewLoginTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.NewLoginTextBox.Location = new System.Drawing.Point(580, 130);
            this.NewLoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewLoginTextBox.MaxLength = 30;
            this.NewLoginTextBox.Name = "NewLoginTextBox";
            this.NewLoginTextBox.Size = new System.Drawing.Size(190, 16);
            this.NewLoginTextBox.TabIndex = 22;
            this.NewLoginTextBox.Text = " логин";
            this.NewLoginTextBox.TextChanged += new System.EventHandler(this.LoginBox_TextChanged);
            this.NewLoginTextBox.Enter += new System.EventHandler(this.LoginBox_TextChanged);
            this.NewLoginTextBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewPasswordTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(580, 160);
            this.NewPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewPasswordTextBox.MaxLength = 30;
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(190, 16);
            this.NewPasswordTextBox.TabIndex = 18;
            this.NewPasswordTextBox.Text = " пароль";
            this.NewPasswordTextBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.NewPasswordTextBox.Enter += new System.EventHandler(this.passwordBox_TextChanged);
            this.NewPasswordTextBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBox2.Location = new System.Drawing.Point(210, 150);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(340, 260);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.richTextBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.richTextBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBox1.Location = new System.Drawing.Point(50, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 260);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Логин\n\nПароль\n\nФамилия\n\nИмя\n\nОтчество\n\nДата рождения";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.richTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(70, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "МОИ ДАННЫЕ";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // newLoginTextBoxBorder
            // 
            this.newLoginTextBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newLoginTextBoxBorder.Location = new System.Drawing.Point(579, 129);
            this.newLoginTextBoxBorder.Name = "newLoginTextBoxBorder";
            this.newLoginTextBoxBorder.Size = new System.Drawing.Size(192, 18);
            this.newLoginTextBoxBorder.TabIndex = 27;
            this.newLoginTextBoxBorder.TabStop = false;
            // 
            // newPasswordTextBoxBorder
            // 
            this.newPasswordTextBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newPasswordTextBoxBorder.Location = new System.Drawing.Point(579, 159);
            this.newPasswordTextBoxBorder.Name = "newPasswordTextBoxBorder";
            this.newPasswordTextBoxBorder.Size = new System.Drawing.Size(192, 18);
            this.newPasswordTextBoxBorder.TabIndex = 31;
            this.newPasswordTextBoxBorder.TabStop = false;
            // 
            // newSurnameTextBoxBorder
            // 
            this.newSurnameTextBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newSurnameTextBoxBorder.Location = new System.Drawing.Point(579, 269);
            this.newSurnameTextBoxBorder.Name = "newSurnameTextBoxBorder";
            this.newSurnameTextBoxBorder.Size = new System.Drawing.Size(192, 18);
            this.newSurnameTextBoxBorder.TabIndex = 30;
            this.newSurnameTextBoxBorder.TabStop = false;
            // 
            // newNameTextBoxBorder
            // 
            this.newNameTextBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newNameTextBoxBorder.Location = new System.Drawing.Point(579, 299);
            this.newNameTextBoxBorder.Name = "newNameTextBoxBorder";
            this.newNameTextBoxBorder.Size = new System.Drawing.Size(192, 18);
            this.newNameTextBoxBorder.TabIndex = 29;
            this.newNameTextBoxBorder.TabStop = false;
            // 
            // newPatronymicTextBoxBorder
            // 
            this.newPatronymicTextBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newPatronymicTextBoxBorder.Location = new System.Drawing.Point(579, 329);
            this.newPatronymicTextBoxBorder.Name = "newPatronymicTextBoxBorder";
            this.newPatronymicTextBoxBorder.Size = new System.Drawing.Size(192, 18);
            this.newPatronymicTextBoxBorder.TabIndex = 28;
            this.newPatronymicTextBoxBorder.TabStop = false;
            // 
            // VoteTabPage
            // 
            this.VoteTabPage.Controls.Add(this.itsPoint);
            this.VoteTabPage.Controls.Add(this.backBUTTON);
            this.VoteTabPage.Controls.Add(this.ERRORVote2);
            this.VoteTabPage.Controls.Add(this.ERRORVote1);
            this.VoteTabPage.Controls.Add(this.pointsVoteDataGrid);
            this.VoteTabPage.Controls.Add(this.sendPriorityButton);
            this.VoteTabPage.Location = new System.Drawing.Point(4, 25);
            this.VoteTabPage.Name = "VoteTabPage";
            this.VoteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VoteTabPage.Size = new System.Drawing.Size(799, 568);
            this.VoteTabPage.TabIndex = 4;
            this.VoteTabPage.Text = "vote";
            this.VoteTabPage.UseVisualStyleBackColor = true;
            this.VoteTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.VoteTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.VoteTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // itsPoint
            // 
            this.itsPoint.BackgroundImage = global::регистрация.Properties.Resources.еж2;
            this.itsPoint.Location = new System.Drawing.Point(726, 353);
            this.itsPoint.Name = "itsPoint";
            this.itsPoint.Size = new System.Drawing.Size(50, 50);
            this.itsPoint.TabIndex = 81;
            this.itsPoint.TabStop = false;
            this.itsPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.itsPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.itsPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // backBUTTON
            // 
            this.backBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.backBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBUTTON.ForeColor = System.Drawing.SystemColors.Control;
            this.backBUTTON.Location = new System.Drawing.Point(475, 524);
            this.backBUTTON.Name = "backBUTTON";
            this.backBUTTON.Size = new System.Drawing.Size(83, 23);
            this.backBUTTON.TabIndex = 80;
            this.backBUTTON.Text = "ОТМЕНА";
            this.backBUTTON.UseVisualStyleBackColor = false;
            this.backBUTTON.Click += new System.EventHandler(this.backBUTTON_Click);
            // 
            // ERRORVote2
            // 
            this.ERRORVote2.AutoSize = true;
            this.ERRORVote2.Font = new System.Drawing.Font("Rostov", 26.25F);
            this.ERRORVote2.ForeColor = System.Drawing.SystemColors.Control;
            this.ERRORVote2.Location = new System.Drawing.Point(734, 68);
            this.ERRORVote2.Name = "ERRORVote2";
            this.ERRORVote2.Size = new System.Drawing.Size(50, 432);
            this.ERRORVote2.TabIndex = 79;
            this.ERRORVote2.Text = "Д\r\nА\r\nН\r\nН\r\nЫ\r\nЕ\r\n\r\nН\r\nЕ";
            this.ERRORVote2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ERRORVote2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ERRORVote2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // ERRORVote1
            // 
            this.ERRORVote1.AutoSize = true;
            this.ERRORVote1.Font = new System.Drawing.Font("Rostov", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ERRORVote1.ForeColor = System.Drawing.SystemColors.Control;
            this.ERRORVote1.Location = new System.Drawing.Point(664, 116);
            this.ERRORVote1.Name = "ERRORVote1";
            this.ERRORVote1.Size = new System.Drawing.Size(50, 336);
            this.ERRORVote1.TabIndex = 78;
            this.ERRORVote1.Text = "В\r\nВ\r\nЕ\r\nД\r\nЕ\r\nН\r\nЫ";
            this.ERRORVote1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.ERRORVote1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ERRORVote1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pointsVoteDataGrid
            // 
            this.pointsVoteDataGrid.AllowUserToAddRows = false;
            this.pointsVoteDataGrid.AllowUserToDeleteRows = false;
            this.pointsVoteDataGrid.AllowUserToResizeColumns = false;
            this.pointsVoteDataGrid.AllowUserToResizeRows = false;
            this.pointsVoteDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pointsVoteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsVoteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.priorityColumn});
            this.pointsVoteDataGrid.Location = new System.Drawing.Point(50, 50);
            this.pointsVoteDataGrid.Name = "pointsVoteDataGrid";
            this.pointsVoteDataGrid.RowHeadersVisible = false;
            this.pointsVoteDataGrid.RowHeadersWidth = 51;
            this.pointsVoteDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pointsVoteDataGrid.Size = new System.Drawing.Size(599, 468);
            this.pointsVoteDataGrid.TabIndex = 23;
            this.pointsVoteDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pointsVoteDataGrid_CellClick);
            // 
            // sendPriorityButton
            // 
            this.sendPriorityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sendPriorityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendPriorityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendPriorityButton.ForeColor = System.Drawing.SystemColors.Control;
            this.sendPriorityButton.Location = new System.Drawing.Point(566, 524);
            this.sendPriorityButton.Name = "sendPriorityButton";
            this.sendPriorityButton.Size = new System.Drawing.Size(83, 23);
            this.sendPriorityButton.TabIndex = 76;
            this.sendPriorityButton.Text = "ОТПРАВИТЬ";
            this.sendPriorityButton.UseVisualStyleBackColor = false;
            this.sendPriorityButton.Click += new System.EventHandler(this.sendPriorityButton_Click);
            // 
            // Point
            // 
            this.Point.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Point.Controls.Add(this.MyDataTabPage);
            this.Point.Controls.Add(this.customsTabPage);
            this.Point.Controls.Add(this.VoteTabPage);
            this.Point.Location = new System.Drawing.Point(168, 53);
            this.Point.Name = "Point";
            this.Point.SelectedIndex = 0;
            this.Point.Size = new System.Drawing.Size(807, 597);
            this.Point.TabIndex = 22;
            this.Point.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Point.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.Point.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // customsTabPage
            // 
            this.customsTabPage.Controls.Add(this.button3);
            this.customsTabPage.Controls.Add(this.PointsDataGrid);
            this.customsTabPage.Location = new System.Drawing.Point(4, 25);
            this.customsTabPage.Name = "customsTabPage";
            this.customsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customsTabPage.Size = new System.Drawing.Size(799, 568);
            this.customsTabPage.TabIndex = 2;
            this.customsTabPage.Text = "customs";
            this.customsTabPage.UseVisualStyleBackColor = true;
            this.customsTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.customsTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.customsTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(566, 524);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 77;
            this.button3.Text = "ГРАФИК";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // PointsDataGrid
            // 
            this.PointsDataGrid.AllowUserToResizeColumns = false;
            this.PointsDataGrid.AllowUserToResizeRows = false;
            this.PointsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PointsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.PointsDataGrid.Location = new System.Drawing.Point(50, 50);
            this.PointsDataGrid.Name = "PointsDataGrid";
            this.PointsDataGrid.RowHeadersVisible = false;
            this.PointsDataGrid.RowHeadersWidth = 51;
            this.PointsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PointsDataGrid.Size = new System.Drawing.Size(650, 468);
            this.PointsDataGrid.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Страна";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Область";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Район";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Расписание";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.BackgroundImage = global::регистрация.Properties.Resources.выход;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rostov", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(10, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 60);
            this.button1.TabIndex = 32;
            this.button1.Text = "        НАЗАД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // voteButton
            // 
            this.voteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.voteButton.BackgroundImage = global::регистрация.Properties.Resources.vote;
            this.voteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voteButton.FlatAppearance.BorderSize = 0;
            this.voteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voteButton.Font = new System.Drawing.Font("Rostov", 9F);
            this.voteButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.voteButton.Location = new System.Drawing.Point(10, 360);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(148, 60);
            this.voteButton.TabIndex = 31;
            this.voteButton.Text = "        ОЦЕНКА\r\n        ПУНКТОВ";
            this.voteButton.UseVisualStyleBackColor = false;
            this.voteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customButton.BackgroundImage = global::регистрация.Properties.Resources.ТаможняЛОГО9;
            this.customButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton.FlatAppearance.BorderSize = 0;
            this.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton.Font = new System.Drawing.Font("Rostov", 9F);
            this.customButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.customButton.Location = new System.Drawing.Point(10, 280);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(148, 60);
            this.customButton.TabIndex = 30;
            this.customButton.Text = "        ТАМОЖНЯ";
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // MyDataBUTTON
            // 
            this.MyDataBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MyDataBUTTON.BackgroundImage = global::регистрация.Properties.Resources.пользовательФОН1;
            this.MyDataBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyDataBUTTON.FlatAppearance.BorderSize = 0;
            this.MyDataBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyDataBUTTON.Font = new System.Drawing.Font("Rostov", 9F);
            this.MyDataBUTTON.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MyDataBUTTON.Location = new System.Drawing.Point(10, 200);
            this.MyDataBUTTON.Name = "MyDataBUTTON";
            this.MyDataBUTTON.Size = new System.Drawing.Size(148, 60);
            this.MyDataBUTTON.TabIndex = 23;
            this.MyDataBUTTON.Text = "        УЧЕТНАЯ ЗАПИСЬ";
            this.MyDataBUTTON.UseVisualStyleBackColor = false;
            this.MyDataBUTTON.Click += new System.EventHandler(this.accountBUTTON_Click_1);
            // 
            // pictureBoxЗЕМЛЯ
            // 
            this.pictureBoxЗЕМЛЯ.BackgroundImage = global::регистрация.Properties.Resources.зямля;
            this.pictureBoxЗЕМЛЯ.Location = new System.Drawing.Point(84, 0);
            this.pictureBoxЗЕМЛЯ.Name = "pictureBoxЗЕМЛЯ";
            this.pictureBoxЗЕМЛЯ.Size = new System.Drawing.Size(74, 74);
            this.pictureBoxЗЕМЛЯ.TabIndex = 24;
            this.pictureBoxЗЕМЛЯ.TabStop = false;
            this.pictureBoxЗЕМЛЯ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBoxЗЕМЛЯ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBoxЗЕМЛЯ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBoxАГОНЬ
            // 
            this.pictureBoxАГОНЬ.BackgroundImage = global::регистрация.Properties.Resources.агонь;
            this.pictureBoxАГОНЬ.Location = new System.Drawing.Point(10, 0);
            this.pictureBoxАГОНЬ.Name = "pictureBoxАГОНЬ";
            this.pictureBoxАГОНЬ.Size = new System.Drawing.Size(74, 74);
            this.pictureBoxАГОНЬ.TabIndex = 25;
            this.pictureBoxАГОНЬ.TabStop = false;
            this.pictureBoxАГОНЬ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBoxАГОНЬ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBoxАГОНЬ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // AREAButton
            // 
            this.AREAButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AREAButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AREAButton.Location = new System.Drawing.Point(0, 74);
            this.AREAButton.Name = "AREAButton";
            this.AREAButton.Size = new System.Drawing.Size(168, 576);
            this.AREAButton.TabIndex = 28;
            this.AREAButton.TabStop = false;
            this.AREAButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.AREAButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.AREAButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(975, 74);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Область";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 99;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Район";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 99;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Расписание";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // priorityColumn
            // 
            this.priorityColumn.HeaderText = "Приоритет";
            this.priorityColumn.Name = "priorityColumn";
            this.priorityColumn.ReadOnly = true;
            this.priorityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priorityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(975, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.MyDataBUTTON);
            this.Controls.Add(this.РЕСПУБЛИКИ);
            this.Controls.Add(this.pictureBoxЗЕМЛЯ);
            this.Controls.Add(this.pictureBoxАГОНЬ);
            this.Controls.Add(this.workFormHIDE);
            this.Controls.Add(this.workFormEXIT);
            this.Controls.Add(this.AREAButton);
            this.Controls.Add(this.БЕЛАРУСЬ);
            this.Controls.Add(this.ТАМОЖНЯ);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserWorkForm";
            this.Text = "startWorkFORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.MyDataTabPage.ResumeLayout(false);
            this.MyDataTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newLoginTextBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSurnameTextBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNameTextBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPatronymicTextBoxBorder)).EndInit();
            this.VoteTabPage.ResumeLayout(false);
            this.VoteTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itsPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsVoteDataGrid)).EndInit();
            this.Point.ResumeLayout(false);
            this.customsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxЗЕМЛЯ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxАГОНЬ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AREAButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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


        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button workFormHIDE;
        private System.Windows.Forms.Button workFormEXIT;
        private System.Windows.Forms.PictureBox AREAButton;
        private System.Windows.Forms.PictureBox pictureBoxАГОНЬ;
        private System.Windows.Forms.PictureBox pictureBoxЗЕМЛЯ;
        private System.Windows.Forms.Label ТАМОЖНЯ;
        private System.Windows.Forms.Label РЕСПУБЛИКИ;
        private System.Windows.Forms.Label БЕЛАРУСЬ;
        protected System.Windows.Forms.Button MyDataBUTTON;
        private System.Windows.Forms.ToolStripMenuItem выдатьПрава;
        protected Button customButton;
        protected Button voteButton;
        private ContextMenuStrip priorityContextMenuStrip;
        private TabPage MyDataTabPage;
        private PictureBox pictureBox1;
        private Label changeLabel;
        private Label ERRORName;
        private Label ERRORLogin;
        private Button NewNameSend;
        private Button SendBirthday;
        private Button NewLoginSend;
        private Label LoginPasswordLable;
        private Label BirthdayLabel;
        private Label NameLable;
        private DateTimePicker NewBirthdayDateTimePicker;
        private TextBox newPatronymicTextBox;
        private TextBox newNameTextBox;
        private TextBox newSurnameTextBox;
        private TextBox NewLoginTextBox;
        private TextBox NewPasswordTextBox;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label label3;
        private PictureBox newLoginTextBoxBorder;
        private PictureBox newPasswordTextBoxBorder;
        private PictureBox newSurnameTextBoxBorder;
        private PictureBox newNameTextBoxBorder;
        private PictureBox newPatronymicTextBoxBorder;
        private TabPage VoteTabPage;
        private PictureBox itsPoint;
        private Button backBUTTON;
        private Label ERRORVote2;
        private Label ERRORVote1;
        private DataGridView pointsVoteDataGrid;
        private Button sendPriorityButton;
        private TabControl Point;
        private TabPage customsTabPage;
        private Button button3;
        private DataGridView PointsDataGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        protected Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn priorityColumn;
    }
}

