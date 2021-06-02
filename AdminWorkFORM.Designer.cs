using System.Net.Sockets;
using System.Collections.Generic;
using System.Windows.Forms;
namespace регистрация
{
        partial class AdminWorkForm
        {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        /// 
            private List<CustomsControlPoint> points;
            private List<Location> locations;
            private List<User> users;
            private List<Vote> votes;
            private List<CustomControlPointNewTime> newPoints;
            private Socket socket;
            private int myUserID;
            private int myAdminID;
            private int pointNumber;

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.components = new System.ComponentModel.Container();
                System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
                System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
                this.workFormHIDE = new System.Windows.Forms.Button();
                this.workFormEXIT = new System.Windows.Forms.Button();
                this.ТАМОЖНЯ = new System.Windows.Forms.Label();
                this.РЕСПУБЛИКИ = new System.Windows.Forms.Label();
                this.БЕЛАРУСЬ = new System.Windows.Forms.Label();
                this.Point = new System.Windows.Forms.TabControl();
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
                this.USERSTabPage = new System.Windows.Forms.TabPage();
                this.HideUserDataBox = new System.Windows.Forms.PictureBox();
                this.searchTextBox = new System.Windows.Forms.TextBox();
                this.myBirthday = new System.Windows.Forms.Label();
                this.birthday = new System.Windows.Forms.Label();
                this.button2 = new System.Windows.Forms.Button();
                this.myPatronymic = new System.Windows.Forms.Label();
                this.giveRightsTextBox = new System.Windows.Forms.TextBox();
                this.Patronymic = new System.Windows.Forms.Label();
                this.EnterPosition = new System.Windows.Forms.Label();
                this.MyName = new System.Windows.Forms.Label();
                this.name = new System.Windows.Forms.Label();
                this.MySurname = new System.Windows.Forms.Label();
                this.Surname = new System.Windows.Forms.Label();
                this.myLogin = new System.Windows.Forms.Label();
                this.ЛОГИН = new System.Windows.Forms.Label();
                this.ПОЛЬЗОВАТЕЛИ = new System.Windows.Forms.Label();
                this.USERSdataGrid = new System.Windows.Forms.DataGridView();
                this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.pictureBox3 = new System.Windows.Forms.PictureBox();
                this.GiveRightsTextBoxBorder = new System.Windows.Forms.PictureBox();
                this.searchTextBoxBorder = new System.Windows.Forms.PictureBox();
                this.customsTabPage = new System.Windows.Forms.TabPage();
                this.button3 = new System.Windows.Forms.Button();
                this.label6 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.District = new System.Windows.Forms.ComboBox();
                this.Region = new System.Windows.Forms.ComboBox();
                this.Country = new System.Windows.Forms.ComboBox();
                this.ERRORPlace = new System.Windows.Forms.Label();
                this.ERRORPointName = new System.Windows.Forms.Label();
                this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
                this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
                this.label2 = new System.Windows.Forms.Label();
                this.button6 = new System.Windows.Forms.Button();
                this.customControlName = new System.Windows.Forms.TextBox();
                this.label1 = new System.Windows.Forms.Label();
                this.PointsDataGrid = new System.Windows.Forms.DataGridView();
                this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.customControlNameBorder = new System.Windows.Forms.PictureBox();
                this.pointDataTabPage = new System.Windows.Forms.TabPage();
                this.button1 = new System.Windows.Forms.Button();
                this.deleteButton = new System.Windows.Forms.Button();
                this.dateTimePickerNewEnd = new System.Windows.Forms.DateTimePicker();
                this.dateTimePickerNewStart = new System.Windows.Forms.DateTimePicker();
                this.newTimeLable = new System.Windows.Forms.Label();
                this.newTimeButton = new System.Windows.Forms.Button();
                this.newNameButton = new System.Windows.Forms.Button();
                this.ERRORNewNamePoint = new System.Windows.Forms.Label();
                this.newPointName = new System.Windows.Forms.TextBox();
                this.newPointNameLable = new System.Windows.Forms.Label();
                this.pointData = new System.Windows.Forms.RichTextBox();
                this.pointAreas = new System.Windows.Forms.RichTextBox();
                this.pointLable = new System.Windows.Forms.Label();
                this.newPointNameBorder = new System.Windows.Forms.PictureBox();
                this.pictureBox4 = new System.Windows.Forms.PictureBox();
                this.VoteTabPage = new System.Windows.Forms.TabPage();
                this.itsPoint = new System.Windows.Forms.PictureBox();
                this.backBUTTON = new System.Windows.Forms.Button();
                this.ERRORVote2 = new System.Windows.Forms.Label();
                this.ERRORVote1 = new System.Windows.Forms.Label();
                this.pointsVoteDataGrid = new System.Windows.Forms.DataGridView();
                this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.priorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.sendPriorityButton = new System.Windows.Forms.Button();
                this.voteMathTabPage = new System.Windows.Forms.TabPage();
                this.reportTabControl = new System.Windows.Forms.TabControl();
                this.thereIsNoReportTabPage = new System.Windows.Forms.TabPage();
                this.thereIsNoReport = new System.Windows.Forms.Label();
                this.report2tabPage = new System.Windows.Forms.TabPage();
                this.thereIsNoNewTime = new System.Windows.Forms.Button();
                this.button7 = new System.Windows.Forms.Button();
                this.label7 = new System.Windows.Forms.Label();
                this.endTimePicker = new System.Windows.Forms.DateTimePicker();
                this.startTimePicker = new System.Windows.Forms.DateTimePicker();
                this.newTimedataGridView = new System.Windows.Forms.DataGridView();
                this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.report1tabPage = new System.Windows.Forms.TabPage();
                this.removeButton = new System.Windows.Forms.Button();
                this.saveButton = new System.Windows.Forms.Button();
                this.report1part1 = new System.Windows.Forms.RichTextBox();
                this.report1part2 = new System.Windows.Forms.RichTextBox();
                this.VotedataGridView = new System.Windows.Forms.DataGridView();
                this.priorityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.nameTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.newTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.report22TabPage = new System.Windows.Forms.TabPage();
                this.report2part2 = new System.Windows.Forms.RichTextBox();
                this.button8 = new System.Windows.Forms.Button();
                this.button9 = new System.Windows.Forms.Button();
                this.report2part1 = new System.Windows.Forms.RichTextBox();
                this.myLastdataGrid = new System.Windows.Forms.DataGridView();
                this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.button5 = new System.Windows.Forms.Button();
                this.button4 = new System.Windows.Forms.Button();
                this.VoteCount = new System.Windows.Forms.Label();
                this.VoteCountLable = new System.Windows.Forms.Label();
                this.выдатьПрава = new System.Windows.Forms.ToolStripMenuItem();
                this.priorityContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
                this.VoteMathButton = new System.Windows.Forms.Button();
                this.voteButton = new System.Windows.Forms.Button();
                this.customButton = new System.Windows.Forms.Button();
                this.MyDataBUTTON = new System.Windows.Forms.Button();
                this.pictureBoxЗЕМЛЯ = new System.Windows.Forms.PictureBox();
                this.pictureBoxАГОНЬ = new System.Windows.Forms.PictureBox();
                this.usersBUTTON = new System.Windows.Forms.Button();
                this.AREAButton = new System.Windows.Forms.PictureBox();
                this.pictureBox2 = new System.Windows.Forms.PictureBox();
                this.button10 = new System.Windows.Forms.Button();
                this.Point.SuspendLayout();
                this.MyDataTabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.newLoginTextBoxBorder)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.newPasswordTextBoxBorder)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.newSurnameTextBoxBorder)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.newNameTextBoxBorder)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.newPatronymicTextBoxBorder)).BeginInit();
                this.USERSTabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize) (this.HideUserDataBox)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.USERSdataGrid)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.GiveRightsTextBoxBorder)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.searchTextBoxBorder)).BeginInit();
                this.customsTabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize) (this.PointsDataGrid)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.customControlNameBorder)).BeginInit();
                this.pointDataTabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize) (this.newPointNameBorder)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
                this.VoteTabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize) (this.itsPoint)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.pointsVoteDataGrid)).BeginInit();
                this.voteMathTabPage.SuspendLayout();
                this.reportTabControl.SuspendLayout();
                this.thereIsNoReportTabPage.SuspendLayout();
                this.report2tabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize) (this.newTimedataGridView)).BeginInit();
                this.report1tabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize) (this.VotedataGridView)).BeginInit();
                this.report22TabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize) (this.myLastdataGrid)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBoxЗЕМЛЯ)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBoxАГОНЬ)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.AREAButton)).BeginInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
                this.SuspendLayout();
                // 
                // workFormHIDE
                // 
                this.workFormHIDE.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.workFormHIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                this.workFormHIDE.Cursor = System.Windows.Forms.Cursors.Hand;
                this.workFormHIDE.FlatAppearance.BorderSize = 0;
                this.workFormHIDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.workFormHIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
                this.workFormEXIT.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.workFormEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
                this.workFormEXIT.FlatAppearance.BorderSize = 0;
                this.workFormEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.workFormEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
                this.ТАМОЖНЯ.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.РЕСПУБЛИКИ.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.БЕЛАРУСЬ.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                // Point
                // 
                this.Point.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
                this.Point.Controls.Add(this.MyDataTabPage);
                this.Point.Controls.Add(this.USERSTabPage);
                this.Point.Controls.Add(this.customsTabPage);
                this.Point.Controls.Add(this.pointDataTabPage);
                this.Point.Controls.Add(this.VoteTabPage);
                this.Point.Controls.Add(this.voteMathTabPage);
                this.Point.Location = new System.Drawing.Point(168, 53);
                this.Point.Name = "Point";
                this.Point.SelectedIndex = 0;
                this.Point.Size = new System.Drawing.Size(807, 597);
                this.Point.TabIndex = 22;
                this.Point.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.Point.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.Point.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
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
                this.MyDataTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
                this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.changeLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.NewNameSend.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.SendBirthday.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.NewLoginSend.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.LoginPasswordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.LoginPasswordLable.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.BirthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.NameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.NameLable.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.NewBirthdayDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.newPatronymicTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
                this.newNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
                this.newSurnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
                this.NewLoginTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
                this.NewPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
                this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.richTextBox1.Location = new System.Drawing.Point(50, 150);
                this.richTextBox1.Name = "richTextBox1";
                this.richTextBox1.Size = new System.Drawing.Size(150, 260);
                this.richTextBox1.TabIndex = 7;
                this.richTextBox1.Text = "Логин\n\nПароль\n\nФамилия\n\nИмя\n\nОтчество\n\nДата рождения\n\nДолжность";
                this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.richTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                // USERSTabPage
                // 
                this.USERSTabPage.Controls.Add(this.HideUserDataBox);
                this.USERSTabPage.Controls.Add(this.searchTextBox);
                this.USERSTabPage.Controls.Add(this.myBirthday);
                this.USERSTabPage.Controls.Add(this.birthday);
                this.USERSTabPage.Controls.Add(this.button2);
                this.USERSTabPage.Controls.Add(this.myPatronymic);
                this.USERSTabPage.Controls.Add(this.giveRightsTextBox);
                this.USERSTabPage.Controls.Add(this.Patronymic);
                this.USERSTabPage.Controls.Add(this.EnterPosition);
                this.USERSTabPage.Controls.Add(this.MyName);
                this.USERSTabPage.Controls.Add(this.name);
                this.USERSTabPage.Controls.Add(this.MySurname);
                this.USERSTabPage.Controls.Add(this.Surname);
                this.USERSTabPage.Controls.Add(this.myLogin);
                this.USERSTabPage.Controls.Add(this.ЛОГИН);
                this.USERSTabPage.Controls.Add(this.ПОЛЬЗОВАТЕЛИ);
                this.USERSTabPage.Controls.Add(this.USERSdataGrid);
                this.USERSTabPage.Controls.Add(this.pictureBox3);
                this.USERSTabPage.Controls.Add(this.GiveRightsTextBoxBorder);
                this.USERSTabPage.Controls.Add(this.searchTextBoxBorder);
                this.USERSTabPage.Location = new System.Drawing.Point(4, 25);
                this.USERSTabPage.Name = "USERSTabPage";
                this.USERSTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
                this.USERSTabPage.Size = new System.Drawing.Size(799, 568);
                this.USERSTabPage.TabIndex = 0;
                this.USERSTabPage.Text = "Users";
                this.USERSTabPage.UseVisualStyleBackColor = true;
                this.USERSTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.USERSTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.USERSTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // HideUserDataBox
                // 
                this.HideUserDataBox.Location = new System.Drawing.Point(519, 50);
                this.HideUserDataBox.Name = "HideUserDataBox";
                this.HideUserDataBox.Size = new System.Drawing.Size(260, 423);
                this.HideUserDataBox.TabIndex = 65;
                this.HideUserDataBox.TabStop = false;
                this.HideUserDataBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.HideUserDataBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.HideUserDataBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // searchTextBox
                // 
                this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.searchTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.searchTextBox.Location = new System.Drawing.Point(272, 15);
                this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                this.searchTextBox.MaxLength = 30;
                this.searchTextBox.Name = "searchTextBox";
                this.searchTextBox.Size = new System.Drawing.Size(226, 19);
                this.searchTextBox.TabIndex = 69;
                this.searchTextBox.Text = " поиск";
                this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
                this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_TextChanged);
                this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
                // 
                // myBirthday
                // 
                this.myBirthday.AutoSize = true;
                this.myBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.myBirthday.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.myBirthday.Location = new System.Drawing.Point(519, 350);
                this.myBirthday.Name = "myBirthday";
                this.myBirthday.Size = new System.Drawing.Size(149, 20);
                this.myBirthday.TabIndex = 67;
                this.myBirthday.Text = "ДАТА РОЖДЕНИЯ";
                this.myBirthday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.myBirthday.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.myBirthday.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // birthday
                // 
                this.birthday.AutoSize = true;
                this.birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                this.birthday.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.birthday.Location = new System.Drawing.Point(519, 320);
                this.birthday.Name = "birthday";
                this.birthday.Size = new System.Drawing.Size(162, 20);
                this.birthday.TabIndex = 66;
                this.birthday.Text = "ДАТА РОЖДЕНИЯ";
                this.birthday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.birthday.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.birthday.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // button2
                // 
                this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button2.ForeColor = System.Drawing.SystemColors.Control;
                this.button2.Location = new System.Drawing.Point(607, 450);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(83, 23);
                this.button2.TabIndex = 64;
                this.button2.Text = "ОТПРАВИТЬ";
                this.button2.UseVisualStyleBackColor = false;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                // 
                // myPatronymic
                // 
                this.myPatronymic.AutoSize = true;
                this.myPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.myPatronymic.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.myPatronymic.Location = new System.Drawing.Point(519, 290);
                this.myPatronymic.Name = "myPatronymic";
                this.myPatronymic.Size = new System.Drawing.Size(96, 20);
                this.myPatronymic.TabIndex = 59;
                this.myPatronymic.Text = "ОТЧЕСТВО";
                this.myPatronymic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.myPatronymic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.myPatronymic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // giveRightsTextBox
                // 
                this.giveRightsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.giveRightsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                this.giveRightsTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.giveRightsTextBox.Location = new System.Drawing.Point(554, 420);
                this.giveRightsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                this.giveRightsTextBox.MaxLength = 30;
                this.giveRightsTextBox.Name = "giveRightsTextBox";
                this.giveRightsTextBox.Size = new System.Drawing.Size(190, 16);
                this.giveRightsTextBox.TabIndex = 63;
                this.giveRightsTextBox.Text = " должность";
                this.giveRightsTextBox.TextChanged += new System.EventHandler(this.giveRightsTextBox_TextChanged);
                this.giveRightsTextBox.Enter += new System.EventHandler(this.giveRightsTextBox_TextChanged);
                this.giveRightsTextBox.Leave += new System.EventHandler(this.giveRightsTextBox_Leave);
                // 
                // Patronymic
                // 
                this.Patronymic.AutoSize = true;
                this.Patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                this.Patronymic.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.Patronymic.Location = new System.Drawing.Point(519, 260);
                this.Patronymic.Name = "Patronymic";
                this.Patronymic.Size = new System.Drawing.Size(104, 20);
                this.Patronymic.TabIndex = 58;
                this.Patronymic.Text = "ОТЧЕСТВО";
                this.Patronymic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.Patronymic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.Patronymic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // EnterPosition
                // 
                this.EnterPosition.AutoSize = true;
                this.EnterPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.EnterPosition.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.EnterPosition.Location = new System.Drawing.Point(544, 390);
                this.EnterPosition.Name = "EnterPosition";
                this.EnterPosition.Size = new System.Drawing.Size(209, 20);
                this.EnterPosition.TabIndex = 62;
                this.EnterPosition.Text = "ВВЕДИТЕ ДОЛЖНОСТЬ";
                this.EnterPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.EnterPosition.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.EnterPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // MyName
                // 
                this.MyName.AutoSize = true;
                this.MyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.MyName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.MyName.Location = new System.Drawing.Point(519, 230);
                this.MyName.Name = "MyName";
                this.MyName.Size = new System.Drawing.Size(45, 20);
                this.MyName.TabIndex = 57;
                this.MyName.Text = "ИМЯ";
                this.MyName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.MyName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.MyName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // name
                // 
                this.name.AutoSize = true;
                this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                this.name.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.name.Location = new System.Drawing.Point(519, 200);
                this.name.Name = "name";
                this.name.Size = new System.Drawing.Size(48, 20);
                this.name.TabIndex = 56;
                this.name.Text = "ИМЯ";
                this.name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // MySurname
                // 
                this.MySurname.AutoSize = true;
                this.MySurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.MySurname.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.MySurname.Location = new System.Drawing.Point(519, 170);
                this.MySurname.Name = "MySurname";
                this.MySurname.Size = new System.Drawing.Size(94, 20);
                this.MySurname.TabIndex = 55;
                this.MySurname.Text = "ФАМИЛИЯ";
                this.MySurname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.MySurname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.MySurname.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // Surname
                // 
                this.Surname.AutoSize = true;
                this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                this.Surname.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.Surname.Location = new System.Drawing.Point(519, 140);
                this.Surname.Name = "Surname";
                this.Surname.Size = new System.Drawing.Size(101, 20);
                this.Surname.TabIndex = 54;
                this.Surname.Text = "ФАМИЛИЯ";
                this.Surname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.Surname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.Surname.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // myLogin
                // 
                this.myLogin.AutoSize = true;
                this.myLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.myLogin.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.myLogin.Location = new System.Drawing.Point(519, 110);
                this.myLogin.Name = "myLogin";
                this.myLogin.Size = new System.Drawing.Size(65, 20);
                this.myLogin.TabIndex = 53;
                this.myLogin.Text = "ЛОГИН";
                this.myLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.myLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.myLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // ЛОГИН
                // 
                this.ЛОГИН.AutoSize = true;
                this.ЛОГИН.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.ЛОГИН.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.ЛОГИН.Location = new System.Drawing.Point(519, 80);
                this.ЛОГИН.Name = "ЛОГИН";
                this.ЛОГИН.Size = new System.Drawing.Size(70, 20);
                this.ЛОГИН.TabIndex = 52;
                this.ЛОГИН.Text = "ЛОГИН";
                this.ЛОГИН.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.ЛОГИН.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.ЛОГИН.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // ПОЛЬЗОВАТЕЛИ
                // 
                this.ПОЛЬЗОВАТЕЛИ.AutoSize = true;
                this.ПОЛЬЗОВАТЕЛИ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.ПОЛЬЗОВАТЕЛИ.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.ПОЛЬЗОВАТЕЛИ.Location = new System.Drawing.Point(572, 50);
                this.ПОЛЬЗОВАТЕЛИ.Name = "ПОЛЬЗОВАТЕЛИ";
                this.ПОЛЬЗОВАТЕЛИ.Size = new System.Drawing.Size(154, 20);
                this.ПОЛЬЗОВАТЕЛИ.TabIndex = 51;
                this.ПОЛЬЗОВАТЕЛИ.Text = "ПОЛЬЗОВАТЕЛЬ";
                this.ПОЛЬЗОВАТЕЛИ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.ПОЛЬЗОВАТЕЛИ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.ПОЛЬЗОВАТЕЛИ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // USERSdataGrid
                // 
                this.USERSdataGrid.AllowUserToAddRows = false;
                this.USERSdataGrid.AllowUserToDeleteRows = false;
                this.USERSdataGrid.AllowUserToResizeColumns = false;
                this.USERSdataGrid.AllowUserToResizeRows = false;
                this.USERSdataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
                this.USERSdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.USERSdataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.login, this.password});
                this.USERSdataGrid.Location = new System.Drawing.Point(50, 50);
                this.USERSdataGrid.Name = "USERSdataGrid";
                this.USERSdataGrid.RowHeadersVisible = false;
                this.USERSdataGrid.RowHeadersWidth = 51;
                this.USERSdataGrid.Size = new System.Drawing.Size(449, 468);
                this.USERSdataGrid.TabIndex = 21;
                this.USERSdataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersDataGrid_CellMouseDoubleClick);
                // 
                // login
                // 
                dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.login.DefaultCellStyle = dataGridViewCellStyle1;
                this.login.Frozen = true;
                this.login.HeaderText = "ЛОГИН";
                this.login.MinimumWidth = 6;
                this.login.Name = "login";
                this.login.ReadOnly = true;
                this.login.Width = 224;
                // 
                // password
                // 
                dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.password.DefaultCellStyle = dataGridViewCellStyle2;
                this.password.Frozen = true;
                this.password.HeaderText = "ПАРОЛЬ";
                this.password.MinimumWidth = 6;
                this.password.Name = "password";
                this.password.ReadOnly = true;
                this.password.Width = 224;
                // 
                // pictureBox3
                // 
                this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.pictureBox3.Location = new System.Drawing.Point(509, 25);
                this.pictureBox3.Name = "pictureBox3";
                this.pictureBox3.Size = new System.Drawing.Size(2, 518);
                this.pictureBox3.TabIndex = 68;
                this.pictureBox3.TabStop = false;
                this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // GiveRightsTextBoxBorder
                // 
                this.GiveRightsTextBoxBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
                this.GiveRightsTextBoxBorder.Location = new System.Drawing.Point(553, 419);
                this.GiveRightsTextBoxBorder.Name = "GiveRightsTextBoxBorder";
                this.GiveRightsTextBoxBorder.Size = new System.Drawing.Size(192, 18);
                this.GiveRightsTextBoxBorder.TabIndex = 62;
                this.GiveRightsTextBoxBorder.TabStop = false;
                // 
                // searchTextBoxBorder
                // 
                this.searchTextBoxBorder.BackColor = System.Drawing.SystemColors.ControlDark;
                this.searchTextBoxBorder.Location = new System.Drawing.Point(271, 14);
                this.searchTextBoxBorder.Name = "searchTextBoxBorder";
                this.searchTextBoxBorder.Size = new System.Drawing.Size(228, 21);
                this.searchTextBoxBorder.TabIndex = 70;
                this.searchTextBoxBorder.TabStop = false;
                // 
                // customsTabPage
                // 
                this.customsTabPage.Controls.Add(this.button3);
                this.customsTabPage.Controls.Add(this.label6);
                this.customsTabPage.Controls.Add(this.label5);
                this.customsTabPage.Controls.Add(this.label4);
                this.customsTabPage.Controls.Add(this.District);
                this.customsTabPage.Controls.Add(this.Region);
                this.customsTabPage.Controls.Add(this.Country);
                this.customsTabPage.Controls.Add(this.ERRORPlace);
                this.customsTabPage.Controls.Add(this.ERRORPointName);
                this.customsTabPage.Controls.Add(this.dateTimePickerEnd);
                this.customsTabPage.Controls.Add(this.dateTimePickerStart);
                this.customsTabPage.Controls.Add(this.label2);
                this.customsTabPage.Controls.Add(this.button6);
                this.customsTabPage.Controls.Add(this.customControlName);
                this.customsTabPage.Controls.Add(this.label1);
                this.customsTabPage.Controls.Add(this.PointsDataGrid);
                this.customsTabPage.Controls.Add(this.customControlNameBorder);
                this.customsTabPage.Location = new System.Drawing.Point(4, 25);
                this.customsTabPage.Name = "customsTabPage";
                this.customsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
                this.button3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button3.ForeColor = System.Drawing.SystemColors.Control;
                this.button3.Location = new System.Drawing.Point(466, 524);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(83, 23);
                this.button3.TabIndex = 77;
                this.button3.Text = "ГРАФИК";
                this.button3.UseVisualStyleBackColor = false;
                this.button3.Click += new System.EventHandler(this.button3_Click_2);
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.label6.Location = new System.Drawing.Point(579, 260);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(56, 16);
                this.label6.TabIndex = 76;
                this.label6.Text = "РАЙОН";
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.label5.Location = new System.Drawing.Point(579, 200);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(72, 16);
                this.label5.TabIndex = 75;
                this.label5.Text = "ОБЛАСТЬ";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.label4.Location = new System.Drawing.Point(579, 140);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(83, 16);
                this.label4.TabIndex = 74;
                this.label4.Text = "ГРАНИЦА С";
                // 
                // District
                // 
                this.District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.District.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                this.District.FormattingEnabled = true;
                this.District.Location = new System.Drawing.Point(579, 280);
                this.District.Name = "District";
                this.District.Size = new System.Drawing.Size(190, 28);
                this.District.TabIndex = 73;
                this.District.SelectedIndexChanged += new System.EventHandler(this.District_SelectedIndexChanged_1);
                this.District.Click += new System.EventHandler(this.District_SelectedIndexChanged);
                this.District.Enter += new System.EventHandler(this.District_SelectedIndexChanged);
                // 
                // Region
                // 
                this.Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                this.Region.FormattingEnabled = true;
                this.Region.Location = new System.Drawing.Point(579, 220);
                this.Region.Name = "Region";
                this.Region.Size = new System.Drawing.Size(190, 28);
                this.Region.TabIndex = 72;
                this.Region.SelectionChangeCommitted += new System.EventHandler(this.Region_SelectionChangeCommitted);
                this.Region.Click += new System.EventHandler(this.Region_SelectedIndexChanged);
                this.Region.Enter += new System.EventHandler(this.Region_SelectedIndexChanged);
                // 
                // Country
                // 
                this.Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                this.Country.FormattingEnabled = true;
                this.Country.Location = new System.Drawing.Point(579, 160);
                this.Country.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
                this.Country.Name = "Country";
                this.Country.Size = new System.Drawing.Size(190, 28);
                this.Country.TabIndex = 71;
                this.Country.SelectionChangeCommitted += new System.EventHandler(this.Country_SelectionChangeCommitted);
                this.Country.Click += new System.EventHandler(this.Country_SelectedIndexChanged);
                this.Country.Enter += new System.EventHandler(this.Country_SelectedIndexChanged);
                // 
                // ERRORPlace
                // 
                this.ERRORPlace.AutoSize = true;
                this.ERRORPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                this.ERRORPlace.ForeColor = System.Drawing.SystemColors.Control;
                this.ERRORPlace.Location = new System.Drawing.Point(579, 310);
                this.ERRORPlace.Name = "ERRORPlace";
                this.ERRORPlace.Size = new System.Drawing.Size(107, 13);
                this.ERRORPlace.TabIndex = 70;
                this.ERRORPlace.Text = "данные не введены";
                this.ERRORPlace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.ERRORPlace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.ERRORPlace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // ERRORPointName
                // 
                this.ERRORPointName.AutoSize = true;
                this.ERRORPointName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                this.ERRORPointName.ForeColor = System.Drawing.SystemColors.Control;
                this.ERRORPointName.Location = new System.Drawing.Point(579, 120);
                this.ERRORPointName.Name = "ERRORPointName";
                this.ERRORPointName.Size = new System.Drawing.Size(107, 13);
                this.ERRORPointName.TabIndex = 69;
                this.ERRORPointName.Text = "данные не введены";
                this.ERRORPointName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.ERRORPointName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.ERRORPointName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // dateTimePickerEnd
                // 
                this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                this.dateTimePickerEnd.Location = new System.Drawing.Point(689, 370);
                this.dateTimePickerEnd.MaxDate = new System.DateTime(2021, 5, 9, 23, 23, 5, 0);
                this.dateTimePickerEnd.Name = "dateTimePickerEnd";
                this.dateTimePickerEnd.ShowUpDown = true;
                this.dateTimePickerEnd.Size = new System.Drawing.Size(80, 20);
                this.dateTimePickerEnd.TabIndex = 68;
                this.dateTimePickerEnd.Value = new System.DateTime(2021, 5, 9, 0, 0, 0, 0);
                // 
                // dateTimePickerStart
                // 
                this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                this.dateTimePickerStart.Location = new System.Drawing.Point(579, 370);
                this.dateTimePickerStart.MaxDate = new System.DateTime(2021, 5, 9, 23, 23, 5, 0);
                this.dateTimePickerStart.Name = "dateTimePickerStart";
                this.dateTimePickerStart.ShowUpDown = true;
                this.dateTimePickerStart.Size = new System.Drawing.Size(80, 20);
                this.dateTimePickerStart.TabIndex = 67;
                this.dateTimePickerStart.Value = new System.DateTime(2021, 5, 9, 0, 0, 0, 0);
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.label2.Location = new System.Drawing.Point(604, 330);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(139, 24);
                this.label2.TabIndex = 66;
                this.label2.Text = "РАСПИСАНИЕ";
                this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // button6
                // 
                this.button6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button6.ForeColor = System.Drawing.SystemColors.Control;
                this.button6.Location = new System.Drawing.Point(630, 410);
                this.button6.Name = "button6";
                this.button6.Size = new System.Drawing.Size(83, 23);
                this.button6.TabIndex = 65;
                this.button6.Text = "ОТПРАВИТЬ";
                this.button6.UseVisualStyleBackColor = false;
                this.button6.Click += new System.EventHandler(this.button6_Click);
                // 
                // customControlName
                // 
                this.customControlName.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.customControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.customControlName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.customControlName.Location = new System.Drawing.Point(579, 100);
                this.customControlName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                this.customControlName.MaxLength = 30;
                this.customControlName.Name = "customControlName";
                this.customControlName.Size = new System.Drawing.Size(190, 19);
                this.customControlName.TabIndex = 26;
                this.customControlName.Text = " название";
                this.customControlName.Click += new System.EventHandler(this.customControlName_TextChanged);
                this.customControlName.TextChanged += new System.EventHandler(this.customControlName_TextChanged);
                this.customControlName.Enter += new System.EventHandler(this.customControlName_TextChanged);
                this.customControlName.Leave += new System.EventHandler(this.customControlName_Leave);
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
                this.label1.Location = new System.Drawing.Point(563, 50);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(221, 24);
                this.label1.TabIndex = 23;
                this.label1.Text = "ДОБАВЛЕНИЕ ПУНКТА";
                this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // PointsDataGrid
                // 
                this.PointsDataGrid.AllowUserToResizeColumns = false;
                this.PointsDataGrid.AllowUserToResizeRows = false;
                this.PointsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
                this.PointsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.PointsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Column1, this.Column5, this.Column2, this.Column3, this.Column4});
                this.PointsDataGrid.Location = new System.Drawing.Point(50, 50);
                this.PointsDataGrid.Name = "PointsDataGrid";
                this.PointsDataGrid.RowHeadersVisible = false;
                this.PointsDataGrid.RowHeadersWidth = 51;
                this.PointsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.PointsDataGrid.Size = new System.Drawing.Size(499, 468);
                this.PointsDataGrid.TabIndex = 22;
                this.PointsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
                this.PointsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
                // 
                // Column1
                // 
                this.Column1.HeaderText = "Название";
                this.Column1.MinimumWidth = 6;
                this.Column1.Name = "Column1";
                this.Column1.ReadOnly = true;
                // 
                // Column5
                // 
                this.Column5.HeaderText = "Страна";
                this.Column5.MinimumWidth = 6;
                this.Column5.Name = "Column5";
                this.Column5.ReadOnly = true;
                this.Column5.Width = 99;
                // 
                // Column2
                // 
                this.Column2.HeaderText = "Область";
                this.Column2.MinimumWidth = 6;
                this.Column2.Name = "Column2";
                this.Column2.ReadOnly = true;
                this.Column2.Width = 99;
                // 
                // Column3
                // 
                this.Column3.HeaderText = "Район";
                this.Column3.MinimumWidth = 6;
                this.Column3.Name = "Column3";
                this.Column3.ReadOnly = true;
                this.Column3.Width = 99;
                // 
                // Column4
                // 
                this.Column4.HeaderText = "Расписание";
                this.Column4.MinimumWidth = 6;
                this.Column4.Name = "Column4";
                this.Column4.ReadOnly = true;
                this.Column4.Width = 125;
                // 
                // customControlNameBorder
                // 
                this.customControlNameBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
                this.customControlNameBorder.Location = new System.Drawing.Point(578, 99);
                this.customControlNameBorder.Name = "customControlNameBorder";
                this.customControlNameBorder.Size = new System.Drawing.Size(192, 21);
                this.customControlNameBorder.TabIndex = 27;
                this.customControlNameBorder.TabStop = false;
                // 
                // pointDataTabPage
                // 
                this.pointDataTabPage.Controls.Add(this.button1);
                this.pointDataTabPage.Controls.Add(this.deleteButton);
                this.pointDataTabPage.Controls.Add(this.dateTimePickerNewEnd);
                this.pointDataTabPage.Controls.Add(this.dateTimePickerNewStart);
                this.pointDataTabPage.Controls.Add(this.newTimeLable);
                this.pointDataTabPage.Controls.Add(this.newTimeButton);
                this.pointDataTabPage.Controls.Add(this.newNameButton);
                this.pointDataTabPage.Controls.Add(this.ERRORNewNamePoint);
                this.pointDataTabPage.Controls.Add(this.newPointName);
                this.pointDataTabPage.Controls.Add(this.newPointNameLable);
                this.pointDataTabPage.Controls.Add(this.pointData);
                this.pointDataTabPage.Controls.Add(this.pointAreas);
                this.pointDataTabPage.Controls.Add(this.pointLable);
                this.pointDataTabPage.Controls.Add(this.newPointNameBorder);
                this.pointDataTabPage.Controls.Add(this.pictureBox4);
                this.pointDataTabPage.Location = new System.Drawing.Point(4, 25);
                this.pointDataTabPage.Name = "pointDataTabPage";
                this.pointDataTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
                this.pointDataTabPage.Size = new System.Drawing.Size(799, 568);
                this.pointDataTabPage.TabIndex = 3;
                this.pointDataTabPage.Text = "newPoint";
                this.pointDataTabPage.UseVisualStyleBackColor = true;
                this.pointDataTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.pointDataTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.pointDataTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // button1
                // 
                this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button1.FlatAppearance.BorderSize = 0;
                this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button1.Font = new System.Drawing.Font("Rostov", 9F);
                this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.button1.Location = new System.Drawing.Point(601, 458);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(148, 60);
                this.button1.TabIndex = 31;
                this.button1.UseVisualStyleBackColor = false;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // deleteButton
                // 
                this.deleteButton.FlatAppearance.BorderSize = 0;
                this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.deleteButton.Location = new System.Drawing.Point(630, 330);
                this.deleteButton.Name = "deleteButton";
                this.deleteButton.Size = new System.Drawing.Size(83, 23);
                this.deleteButton.TabIndex = 79;
                this.deleteButton.Text = "Удалить";
                this.deleteButton.UseVisualStyleBackColor = true;
                this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
                // 
                // dateTimePickerNewEnd
                // 
                this.dateTimePickerNewEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                this.dateTimePickerNewEnd.Location = new System.Drawing.Point(689, 260);
                this.dateTimePickerNewEnd.MaxDate = new System.DateTime(2021, 5, 9, 23, 23, 5, 0);
                this.dateTimePickerNewEnd.Name = "dateTimePickerNewEnd";
                this.dateTimePickerNewEnd.ShowUpDown = true;
                this.dateTimePickerNewEnd.Size = new System.Drawing.Size(80, 20);
                this.dateTimePickerNewEnd.TabIndex = 78;
                this.dateTimePickerNewEnd.Value = new System.DateTime(2021, 5, 9, 0, 0, 0, 0);
                // 
                // dateTimePickerNewStart
                // 
                this.dateTimePickerNewStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                this.dateTimePickerNewStart.Location = new System.Drawing.Point(579, 260);
                this.dateTimePickerNewStart.MaxDate = new System.DateTime(2021, 5, 9, 23, 23, 5, 0);
                this.dateTimePickerNewStart.Name = "dateTimePickerNewStart";
                this.dateTimePickerNewStart.ShowUpDown = true;
                this.dateTimePickerNewStart.Size = new System.Drawing.Size(80, 20);
                this.dateTimePickerNewStart.TabIndex = 77;
                this.dateTimePickerNewStart.Value = new System.DateTime(2021, 5, 9, 0, 0, 0, 0);
                // 
                // newTimeLable
                // 
                this.newTimeLable.AutoSize = true;
                this.newTimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.newTimeLable.ForeColor = System.Drawing.SystemColors.ControlText;
                this.newTimeLable.Location = new System.Drawing.Point(569, 220);
                this.newTimeLable.Name = "newTimeLable";
                this.newTimeLable.Size = new System.Drawing.Size(212, 24);
                this.newTimeLable.TabIndex = 76;
                this.newTimeLable.Text = "НОВОЕ РАСПИСАНИЕ";
                this.newTimeLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.newTimeLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.newTimeLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // newTimeButton
                // 
                this.newTimeButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.newTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
                this.newTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.newTimeButton.ForeColor = System.Drawing.SystemColors.Control;
                this.newTimeButton.Location = new System.Drawing.Point(630, 300);
                this.newTimeButton.Name = "newTimeButton";
                this.newTimeButton.Size = new System.Drawing.Size(83, 23);
                this.newTimeButton.TabIndex = 75;
                this.newTimeButton.Text = "ОТПРАВИТЬ";
                this.newTimeButton.UseVisualStyleBackColor = false;
                this.newTimeButton.Click += new System.EventHandler(this.newTimeButton_Click);
                // 
                // newNameButton
                // 
                this.newNameButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.newNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
                this.newNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.newNameButton.ForeColor = System.Drawing.SystemColors.Control;
                this.newNameButton.Location = new System.Drawing.Point(630, 170);
                this.newNameButton.Name = "newNameButton";
                this.newNameButton.Size = new System.Drawing.Size(83, 23);
                this.newNameButton.TabIndex = 74;
                this.newNameButton.Text = "ОТПРАВИТЬ";
                this.newNameButton.UseVisualStyleBackColor = false;
                this.newNameButton.Click += new System.EventHandler(this.newNameButton_Click);
                // 
                // ERRORNewNamePoint
                // 
                this.ERRORNewNamePoint.AutoSize = true;
                this.ERRORNewNamePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                this.ERRORNewNamePoint.ForeColor = System.Drawing.SystemColors.Control;
                this.ERRORNewNamePoint.Location = new System.Drawing.Point(579, 150);
                this.ERRORNewNamePoint.Name = "ERRORNewNamePoint";
                this.ERRORNewNamePoint.Size = new System.Drawing.Size(107, 13);
                this.ERRORNewNamePoint.TabIndex = 73;
                this.ERRORNewNamePoint.Text = "данные не введены";
                // 
                // newPointName
                // 
                this.newPointName.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.newPointName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.newPointName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.newPointName.Location = new System.Drawing.Point(579, 130);
                this.newPointName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                this.newPointName.MaxLength = 30;
                this.newPointName.Name = "newPointName";
                this.newPointName.Size = new System.Drawing.Size(190, 19);
                this.newPointName.TabIndex = 71;
                this.newPointName.Text = " название";
                this.newPointName.TextChanged += new System.EventHandler(this.newPointName_TextChanged);
                this.newPointName.Enter += new System.EventHandler(this.newPointName_TextChanged);
                this.newPointName.Leave += new System.EventHandler(this.newPointName_Leave);
                // 
                // newPointNameLable
                // 
                this.newPointNameLable.AutoSize = true;
                this.newPointNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
                this.newPointNameLable.Location = new System.Drawing.Point(556, 90);
                this.newPointNameLable.Name = "newPointNameLable";
                this.newPointNameLable.Size = new System.Drawing.Size(240, 24);
                this.newPointNameLable.TabIndex = 70;
                this.newPointNameLable.Text = "ИЗМЕНЕНИЕ НАЗВАНИЯ";
                this.newPointNameLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.newPointNameLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.newPointNameLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                // 
                // pointData
                // 
                this.pointData.BackColor = System.Drawing.SystemColors.Control;
                this.pointData.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.pointData.Enabled = false;
                this.pointData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.pointData.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.pointData.Location = new System.Drawing.Point(210, 150);
                this.pointData.Name = "pointData";
                this.pointData.Size = new System.Drawing.Size(340, 260);
                this.pointData.TabIndex = 11;
                this.pointData.Text = "";
                this.pointData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.pointData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.pointData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // pointAreas
                // 
                this.pointAreas.BackColor = System.Drawing.SystemColors.Control;
                this.pointAreas.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.pointAreas.Enabled = false;
                this.pointAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.pointAreas.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.pointAreas.Location = new System.Drawing.Point(50, 150);
                this.pointAreas.Name = "pointAreas";
                this.pointAreas.Size = new System.Drawing.Size(150, 260);
                this.pointAreas.TabIndex = 10;
                this.pointAreas.Text = "Название\n\nРасписание\n\nСтрана\n\nОбласть\n\nРегион";
                this.pointAreas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.pointAreas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.pointAreas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // pointLable
                // 
                this.pointLable.AutoSize = true;
                this.pointLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.pointLable.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.pointLable.Location = new System.Drawing.Point(70, 90);
                this.pointLable.Name = "pointLable";
                this.pointLable.Size = new System.Drawing.Size(340, 24);
                this.pointLable.TabIndex = 9;
                this.pointLable.Text = "ПУНКТ ТАМОЖЕННОГО КОНТРОЛЯ";
                this.pointLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.pointLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.pointLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // newPointNameBorder
                // 
                this.newPointNameBorder.BackColor = System.Drawing.SystemColors.AppWorkspace;
                this.newPointNameBorder.Location = new System.Drawing.Point(578, 129);
                this.newPointNameBorder.Name = "newPointNameBorder";
                this.newPointNameBorder.Size = new System.Drawing.Size(192, 21);
                this.newPointNameBorder.TabIndex = 72;
                this.newPointNameBorder.TabStop = false;
                // 
                // pictureBox4
                // 
                this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.pictureBox4.Location = new System.Drawing.Point(550, 25);
                this.pictureBox4.Name = "pictureBox4";
                this.pictureBox4.Size = new System.Drawing.Size(2, 518);
                this.pictureBox4.TabIndex = 42;
                this.pictureBox4.TabStop = false;
                this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
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
                this.VoteTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
                this.backBUTTON.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.ERRORVote1.Font = new System.Drawing.Font("Rostov", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
                this.pointsVoteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4, this.dataGridViewTextBoxColumn5, this.priorityColumn});
                this.pointsVoteDataGrid.Location = new System.Drawing.Point(50, 50);
                this.pointsVoteDataGrid.Name = "pointsVoteDataGrid";
                this.pointsVoteDataGrid.RowHeadersVisible = false;
                this.pointsVoteDataGrid.RowHeadersWidth = 51;
                this.pointsVoteDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.pointsVoteDataGrid.Size = new System.Drawing.Size(599, 468);
                this.pointsVoteDataGrid.TabIndex = 23;
                this.pointsVoteDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pointsVoteDataGrid_CellClick);
                // 
                // dataGridViewTextBoxColumn1
                // 
                this.dataGridViewTextBoxColumn1.HeaderText = "Название";
                this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
                this.dataGridViewTextBoxColumn1.ReadOnly = true;
                // 
                // dataGridViewTextBoxColumn2
                // 
                this.dataGridViewTextBoxColumn2.HeaderText = "Страна";
                this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
                this.dataGridViewTextBoxColumn2.ReadOnly = true;
                this.dataGridViewTextBoxColumn2.Width = 99;
                // 
                // dataGridViewTextBoxColumn3
                // 
                this.dataGridViewTextBoxColumn3.HeaderText = "Область";
                this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
                this.dataGridViewTextBoxColumn3.ReadOnly = true;
                this.dataGridViewTextBoxColumn3.Width = 99;
                // 
                // dataGridViewTextBoxColumn4
                // 
                this.dataGridViewTextBoxColumn4.HeaderText = "Район";
                this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
                this.dataGridViewTextBoxColumn4.ReadOnly = true;
                this.dataGridViewTextBoxColumn4.Width = 99;
                // 
                // dataGridViewTextBoxColumn5
                // 
                this.dataGridViewTextBoxColumn5.HeaderText = "Расписание";
                this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
                this.dataGridViewTextBoxColumn5.ReadOnly = true;
                // 
                // priorityColumn
                // 
                this.priorityColumn.HeaderText = "Приоритет";
                this.priorityColumn.MinimumWidth = 6;
                this.priorityColumn.Name = "priorityColumn";
                this.priorityColumn.ReadOnly = true;
                this.priorityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
                this.priorityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                this.priorityColumn.Width = 125;
                // 
                // sendPriorityButton
                // 
                this.sendPriorityButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                // voteMathTabPage
                // 
                this.voteMathTabPage.Controls.Add(this.reportTabControl);
                this.voteMathTabPage.Controls.Add(this.button5);
                this.voteMathTabPage.Controls.Add(this.button4);
                this.voteMathTabPage.Controls.Add(this.VoteCount);
                this.voteMathTabPage.Controls.Add(this.VoteCountLable);
                this.voteMathTabPage.Location = new System.Drawing.Point(4, 25);
                this.voteMathTabPage.Name = "voteMathTabPage";
                this.voteMathTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
                this.voteMathTabPage.Size = new System.Drawing.Size(799, 568);
                this.voteMathTabPage.TabIndex = 5;
                this.voteMathTabPage.Text = "voteMath";
                this.voteMathTabPage.UseVisualStyleBackColor = true;
                this.voteMathTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.voteMathTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.voteMathTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // reportTabControl
                // 
                this.reportTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
                this.reportTabControl.Controls.Add(this.thereIsNoReportTabPage);
                this.reportTabControl.Controls.Add(this.report2tabPage);
                this.reportTabControl.Controls.Add(this.report1tabPage);
                this.reportTabControl.Controls.Add(this.report22TabPage);
                this.reportTabControl.Location = new System.Drawing.Point(200, -21);
                this.reportTabControl.Name = "reportTabControl";
                this.reportTabControl.SelectedIndex = 0;
                this.reportTabControl.Size = new System.Drawing.Size(599, 589);
                this.reportTabControl.TabIndex = 79;
                this.reportTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.reportTabControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.reportTabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // thereIsNoReportTabPage
                // 
                this.thereIsNoReportTabPage.Controls.Add(this.thereIsNoReport);
                this.thereIsNoReportTabPage.Location = new System.Drawing.Point(4, 25);
                this.thereIsNoReportTabPage.Name = "thereIsNoReportTabPage";
                this.thereIsNoReportTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
                this.thereIsNoReportTabPage.Size = new System.Drawing.Size(591, 560);
                this.thereIsNoReportTabPage.TabIndex = 2;
                this.thereIsNoReportTabPage.Text = "thereIsNoReportTabPage";
                this.thereIsNoReportTabPage.UseVisualStyleBackColor = true;
                this.thereIsNoReportTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.thereIsNoReportTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.thereIsNoReportTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // thereIsNoReport
                // 
                this.thereIsNoReport.AutoSize = true;
                this.thereIsNoReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.thereIsNoReport.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.thereIsNoReport.Location = new System.Drawing.Point(166, 243);
                this.thereIsNoReport.Name = "thereIsNoReport";
                this.thereIsNoReport.Size = new System.Drawing.Size(259, 24);
                this.thereIsNoReport.TabIndex = 0;
                this.thereIsNoReport.Text = "место для будущего отчета";
                this.thereIsNoReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.thereIsNoReport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.thereIsNoReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // report2tabPage
                // 
                this.report2tabPage.BackColor = System.Drawing.SystemColors.Control;
                this.report2tabPage.Controls.Add(this.thereIsNoNewTime);
                this.report2tabPage.Controls.Add(this.button7);
                this.report2tabPage.Controls.Add(this.label7);
                this.report2tabPage.Controls.Add(this.endTimePicker);
                this.report2tabPage.Controls.Add(this.startTimePicker);
                this.report2tabPage.Controls.Add(this.newTimedataGridView);
                this.report2tabPage.Location = new System.Drawing.Point(4, 25);
                this.report2tabPage.Name = "report2tabPage";
                this.report2tabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
                this.report2tabPage.Size = new System.Drawing.Size(591, 560);
                this.report2tabPage.TabIndex = 1;
                this.report2tabPage.Text = "report2tabPage";
                this.report2tabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.report2tabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.report2tabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // thereIsNoNewTime
                // 
                this.thereIsNoNewTime.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.thereIsNoNewTime.Cursor = System.Windows.Forms.Cursors.Hand;
                this.thereIsNoNewTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.thereIsNoNewTime.ForeColor = System.Drawing.SystemColors.Control;
                this.thereIsNoNewTime.Location = new System.Drawing.Point(230, 50);
                this.thereIsNoNewTime.Name = "thereIsNoNewTime";
                this.thereIsNoNewTime.Size = new System.Drawing.Size(80, 23);
                this.thereIsNoNewTime.TabIndex = 80;
                this.thereIsNoNewTime.Text = "ОТМЕНА";
                this.thereIsNoNewTime.UseVisualStyleBackColor = false;
                this.thereIsNoNewTime.Click += new System.EventHandler(this.thereIsNoNewTime_Click);
                // 
                // button7
                // 
                this.button7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button7.ForeColor = System.Drawing.SystemColors.Control;
                this.button7.Location = new System.Drawing.Point(449, 510);
                this.button7.Name = "button7";
                this.button7.Size = new System.Drawing.Size(101, 23);
                this.button7.TabIndex = 80;
                this.button7.Text = "ПОДТВЕРДИТЬ";
                this.button7.UseVisualStyleBackColor = false;
                this.button7.Click += new System.EventHandler(this.button7_Click);
                // 
                // label7
                // 
                this.label7.AutoSize = true;
                this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.label7.Location = new System.Drawing.Point(350, 25);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(153, 20);
                this.label7.TabIndex = 86;
                this.label7.Text = "Начало          Конец";
                this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // endTimePicker
                // 
                this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                this.endTimePicker.Location = new System.Drawing.Point(450, 50);
                this.endTimePicker.Name = "endTimePicker";
                this.endTimePicker.ShowUpDown = true;
                this.endTimePicker.Size = new System.Drawing.Size(80, 20);
                this.endTimePicker.TabIndex = 85;
                this.endTimePicker.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
                this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
                this.endTimePicker.Enter += new System.EventHandler(this.endTimePicker_ValueChanged);
                // 
                // startTimePicker
                // 
                this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                this.startTimePicker.Location = new System.Drawing.Point(340, 50);
                this.startTimePicker.Name = "startTimePicker";
                this.startTimePicker.ShowUpDown = true;
                this.startTimePicker.Size = new System.Drawing.Size(80, 20);
                this.startTimePicker.TabIndex = 84;
                this.startTimePicker.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
                this.startTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
                this.startTimePicker.Enter += new System.EventHandler(this.dateTimePicker1_ValueChanged);
                // 
                // newTimedataGridView
                // 
                this.newTimedataGridView.AllowUserToResizeColumns = false;
                this.newTimedataGridView.AllowUserToResizeRows = false;
                this.newTimedataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
                this.newTimedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.newTimedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn7, this.dataGridViewTextBoxColumn8, this.start, this.end});
                this.newTimedataGridView.Location = new System.Drawing.Point(40, 90);
                this.newTimedataGridView.Name = "newTimedataGridView";
                this.newTimedataGridView.RowHeadersVisible = false;
                this.newTimedataGridView.RowHeadersWidth = 51;
                this.newTimedataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.newTimedataGridView.Size = new System.Drawing.Size(511, 400);
                this.newTimedataGridView.TabIndex = 83;
                this.newTimedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
                // 
                // dataGridViewTextBoxColumn7
                // 
                this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                this.dataGridViewTextBoxColumn7.HeaderText = "Наименование";
                this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
                this.dataGridViewTextBoxColumn7.ReadOnly = true;
                this.dataGridViewTextBoxColumn7.Width = 170;
                // 
                // dataGridViewTextBoxColumn8
                // 
                this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                this.dataGridViewTextBoxColumn8.HeaderText = "Итоги опроса";
                this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
                this.dataGridViewTextBoxColumn8.ReadOnly = true;
                this.dataGridViewTextBoxColumn8.Width = 120;
                // 
                // start
                // 
                this.start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                this.start.HeaderText = "Начало измененное";
                this.start.MinimumWidth = 6;
                this.start.Name = "start";
                this.start.ReadOnly = true;
                this.start.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                this.start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                this.start.Width = 125;
                // 
                // end
                // 
                this.end.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                this.end.HeaderText = "Конец измененный";
                this.end.MinimumWidth = 6;
                this.end.Name = "end";
                this.end.ReadOnly = true;
                this.end.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                this.end.Width = 120;
                // 
                // report1tabPage
                // 
                this.report1tabPage.BackColor = System.Drawing.SystemColors.Control;
                this.report1tabPage.Controls.Add(this.removeButton);
                this.report1tabPage.Controls.Add(this.saveButton);
                this.report1tabPage.Controls.Add(this.report1part1);
                this.report1tabPage.Controls.Add(this.report1part2);
                this.report1tabPage.Controls.Add(this.VotedataGridView);
                this.report1tabPage.Location = new System.Drawing.Point(4, 25);
                this.report1tabPage.Name = "report1tabPage";
                this.report1tabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
                this.report1tabPage.Size = new System.Drawing.Size(591, 560);
                this.report1tabPage.TabIndex = 0;
                this.report1tabPage.Text = "report1tabPage";
                this.report1tabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.report1tabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.report1tabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // removeButton
                // 
                this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
                this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.removeButton.ForeColor = System.Drawing.SystemColors.Control;
                this.removeButton.Location = new System.Drawing.Point(368, 525);
                this.removeButton.Name = "removeButton";
                this.removeButton.Size = new System.Drawing.Size(83, 23);
                this.removeButton.TabIndex = 85;
                this.removeButton.Text = "УДАЛИТЬ";
                this.removeButton.UseVisualStyleBackColor = false;
                this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
                // 
                // saveButton
                // 
                this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
                this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.saveButton.ForeColor = System.Drawing.SystemColors.Control;
                this.saveButton.Location = new System.Drawing.Point(468, 525);
                this.saveButton.Name = "saveButton";
                this.saveButton.Size = new System.Drawing.Size(83, 23);
                this.saveButton.TabIndex = 84;
                this.saveButton.Text = "СОХРАНИТЬ";
                this.saveButton.UseVisualStyleBackColor = false;
                this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
                // 
                // report1part1
                // 
                this.report1part1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.report1part1.Cursor = System.Windows.Forms.Cursors.Arrow;
                this.report1part1.Enabled = false;
                this.report1part1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.report1part1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.report1part1.Location = new System.Drawing.Point(0, 0);
                this.report1part1.Name = "report1part1";
                this.report1part1.Size = new System.Drawing.Size(591, 200);
                this.report1part1.TabIndex = 81;
                this.report1part1.Text = "";
                this.report1part1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.report1part1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.report1part1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // report1part2
                // 
                this.report1part2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.report1part2.Cursor = System.Windows.Forms.Cursors.Arrow;
                this.report1part2.Enabled = false;
                this.report1part2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.report1part2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.report1part2.Location = new System.Drawing.Point(0, 420);
                this.report1part2.Name = "report1part2";
                this.report1part2.ReadOnly = true;
                this.report1part2.Size = new System.Drawing.Size(591, 93);
                this.report1part2.TabIndex = 83;
                this.report1part2.Text = "";
                this.report1part2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.report1part2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.report1part2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // VotedataGridView
                // 
                this.VotedataGridView.AllowUserToResizeColumns = false;
                this.VotedataGridView.AllowUserToResizeRows = false;
                this.VotedataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
                this.VotedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.VotedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.priorityNumber, this.nameTIME, this.newTimeColumn, this.percent});
                this.VotedataGridView.Location = new System.Drawing.Point(40, 210);
                this.VotedataGridView.Name = "VotedataGridView";
                this.VotedataGridView.RowHeadersVisible = false;
                this.VotedataGridView.RowHeadersWidth = 51;
                this.VotedataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.VotedataGridView.Size = new System.Drawing.Size(511, 200);
                this.VotedataGridView.TabIndex = 82;
                this.VotedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VoteDataGridView_CellClick);
                // 
                // priorityNumber
                // 
                this.priorityNumber.HeaderText = "№ приоритета";
                this.priorityNumber.MinimumWidth = 6;
                this.priorityNumber.Name = "priorityNumber";
                this.priorityNumber.ReadOnly = true;
                this.priorityNumber.Width = 125;
                // 
                // nameTIME
                // 
                this.nameTIME.HeaderText = "Наименование";
                this.nameTIME.MinimumWidth = 6;
                this.nameTIME.Name = "nameTIME";
                this.nameTIME.ReadOnly = true;
                this.nameTIME.Width = 170;
                // 
                // newTimeColumn
                // 
                this.newTimeColumn.HeaderText = "Итоги опроса";
                this.newTimeColumn.MinimumWidth = 6;
                this.newTimeColumn.Name = "newTimeColumn";
                this.newTimeColumn.ReadOnly = true;
                this.newTimeColumn.Width = 120;
                // 
                // percent
                // 
                this.percent.HeaderText = "Предполагаемая нагрузка, %";
                this.percent.MinimumWidth = 6;
                this.percent.Name = "percent";
                this.percent.ReadOnly = true;
                this.percent.Width = 121;
                // 
                // report22TabPage
                // 
                this.report22TabPage.Controls.Add(this.report2part2);
                this.report22TabPage.Controls.Add(this.button8);
                this.report22TabPage.Controls.Add(this.button9);
                this.report22TabPage.Controls.Add(this.report2part1);
                this.report22TabPage.Controls.Add(this.myLastdataGrid);
                this.report22TabPage.Location = new System.Drawing.Point(4, 25);
                this.report22TabPage.Name = "report22TabPage";
                this.report22TabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
                this.report22TabPage.Size = new System.Drawing.Size(591, 560);
                this.report22TabPage.TabIndex = 3;
                this.report22TabPage.Text = "report2TabPage";
                this.report22TabPage.UseVisualStyleBackColor = true;
                this.report22TabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.report22TabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.report22TabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // report2part2
                // 
                this.report2part2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.report2part2.Cursor = System.Windows.Forms.Cursors.Arrow;
                this.report2part2.Enabled = false;
                this.report2part2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.report2part2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.report2part2.Location = new System.Drawing.Point(0, 400);
                this.report2part2.Name = "report2part2";
                this.report2part2.Size = new System.Drawing.Size(591, 80);
                this.report2part2.TabIndex = 91;
                this.report2part2.Text = "";
                // 
                // button8
                // 
                this.button8.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button8.ForeColor = System.Drawing.SystemColors.Control;
                this.button8.Location = new System.Drawing.Point(368, 525);
                this.button8.Name = "button8";
                this.button8.Size = new System.Drawing.Size(83, 23);
                this.button8.TabIndex = 90;
                this.button8.Text = "УДАЛИТЬ";
                this.button8.UseVisualStyleBackColor = false;
                this.button8.Click += new System.EventHandler(this.removeButton_Click);
                // 
                // button9
                // 
                this.button9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button9.ForeColor = System.Drawing.SystemColors.Control;
                this.button9.Location = new System.Drawing.Point(468, 525);
                this.button9.Name = "button9";
                this.button9.Size = new System.Drawing.Size(83, 23);
                this.button9.TabIndex = 89;
                this.button9.Text = "СОХРАНИТЬ";
                this.button9.UseVisualStyleBackColor = false;
                this.button9.Click += new System.EventHandler(this.button9_Click);
                // 
                // report2part1
                // 
                this.report2part1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.report2part1.Cursor = System.Windows.Forms.Cursors.Arrow;
                this.report2part1.Enabled = false;
                this.report2part1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.report2part1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.report2part1.Location = new System.Drawing.Point(0, 0);
                this.report2part1.Name = "report2part1";
                this.report2part1.Size = new System.Drawing.Size(591, 170);
                this.report2part1.TabIndex = 86;
                this.report2part1.Text = "";
                // 
                // myLastdataGrid
                // 
                this.myLastdataGrid.AllowUserToResizeColumns = false;
                this.myLastdataGrid.AllowUserToResizeRows = false;
                this.myLastdataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
                this.myLastdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.myLastdataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn9, this.dataGridViewTextBoxColumn10, this.dataGridViewTextBoxColumn11});
                this.myLastdataGrid.Location = new System.Drawing.Point(40, 190);
                this.myLastdataGrid.Name = "myLastdataGrid";
                this.myLastdataGrid.RowHeadersVisible = false;
                this.myLastdataGrid.RowHeadersWidth = 51;
                this.myLastdataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.myLastdataGrid.Size = new System.Drawing.Size(511, 200);
                this.myLastdataGrid.TabIndex = 87;
                // 
                // dataGridViewTextBoxColumn9
                // 
                this.dataGridViewTextBoxColumn9.HeaderText = "Наименование";
                this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
                this.dataGridViewTextBoxColumn9.ReadOnly = true;
                this.dataGridViewTextBoxColumn9.Width = 211;
                // 
                // dataGridViewTextBoxColumn10
                // 
                this.dataGridViewTextBoxColumn10.HeaderText = "Итоги опроса";
                this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
                this.dataGridViewTextBoxColumn10.ReadOnly = true;
                this.dataGridViewTextBoxColumn10.Width = 150;
                // 
                // dataGridViewTextBoxColumn11
                // 
                this.dataGridViewTextBoxColumn11.HeaderText = "Утверждено";
                this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
                this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
                this.dataGridViewTextBoxColumn11.ReadOnly = true;
                this.dataGridViewTextBoxColumn11.Width = 150;
                // 
                // button5
                // 
                this.button5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button5.ForeColor = System.Drawing.SystemColors.Control;
                this.button5.Location = new System.Drawing.Point(50, 170);
                this.button5.Name = "button5";
                this.button5.Size = new System.Drawing.Size(100, 23);
                this.button5.TabIndex = 78;
                this.button5.Text = "УТВЕРДИТЬ";
                this.button5.UseVisualStyleBackColor = false;
                this.button5.Click += new System.EventHandler(this.button5_Click);
                // 
                // button4
                // 
                this.button4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button4.ForeColor = System.Drawing.SystemColors.Control;
                this.button4.Location = new System.Drawing.Point(50, 130);
                this.button4.Name = "button4";
                this.button4.Size = new System.Drawing.Size(100, 23);
                this.button4.TabIndex = 77;
                this.button4.Text = "ПОСМОТРЕТЬ";
                this.button4.UseVisualStyleBackColor = false;
                this.button4.Click += new System.EventHandler(this.button4_Click);
                // 
                // VoteCount
                // 
                this.VoteCount.AutoSize = true;
                this.VoteCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
                this.VoteCount.Location = new System.Drawing.Point(50, 90);
                this.VoteCount.Name = "VoteCount";
                this.VoteCount.Size = new System.Drawing.Size(60, 24);
                this.VoteCount.TabIndex = 1;
                this.VoteCount.Text = "label8";
                this.VoteCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.VoteCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.VoteCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // VoteCountLable
                // 
                this.VoteCountLable.AutoSize = true;
                this.VoteCountLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
                this.VoteCountLable.Location = new System.Drawing.Point(50, 50);
                this.VoteCountLable.Name = "VoteCountLable";
                this.VoteCountLable.Size = new System.Drawing.Size(142, 24);
                this.VoteCountLable.TabIndex = 0;
                this.VoteCountLable.Text = "Итого голосов";
                this.VoteCountLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.VoteCountLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.VoteCountLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                // 
                // выдатьПрава
                // 
                this.выдатьПрава.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.выдатьПрава.Name = "выдатьПрава";
                this.выдатьПрава.Size = new System.Drawing.Size(180, 22);
                this.выдатьПрава.Text = "выдать права";
                // 
                // priorityContextMenuStrip
                // 
                this.priorityContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
                this.priorityContextMenuStrip.Name = "priorityContextMenuStrip";
                this.priorityContextMenuStrip.Size = new System.Drawing.Size(61, 4);
                this.priorityContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.priorityContextMenuStrip_ItemClicked);
                // 
                // VoteMathButton
                // 
                this.VoteMathButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.VoteMathButton.BackgroundImage = global::регистрация.Properties.Resources.кондорсе;
                this.VoteMathButton.Cursor = System.Windows.Forms.Cursors.Hand;
                this.VoteMathButton.FlatAppearance.BorderSize = 0;
                this.VoteMathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.VoteMathButton.Font = new System.Drawing.Font("Rostov", 9F);
                this.VoteMathButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.VoteMathButton.Location = new System.Drawing.Point(10, 440);
                this.VoteMathButton.Name = "VoteMathButton";
                this.VoteMathButton.Size = new System.Drawing.Size(148, 60);
                this.VoteMathButton.TabIndex = 32;
                this.VoteMathButton.Text = "          ИЗМЕНЕНИЕ\r\n          РАСПИСАНИЯ";
                this.VoteMathButton.UseVisualStyleBackColor = false;
                this.VoteMathButton.Click += new System.EventHandler(this.button3_Click_1);
                // 
                // voteButton
                // 
                this.voteButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.customButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                this.MyDataBUTTON.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.MyDataBUTTON.BackgroundImage = global::регистрация.Properties.Resources.пользовательФОН1;
                this.MyDataBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
                this.MyDataBUTTON.FlatAppearance.BorderSize = 0;
                this.MyDataBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.MyDataBUTTON.Font = new System.Drawing.Font("Rostov", 9F);
                this.MyDataBUTTON.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.MyDataBUTTON.Location = new System.Drawing.Point(10, 120);
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
                // usersBUTTON
                // 
                this.usersBUTTON.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.usersBUTTON.BackgroundImage = global::регистрация.Properties.Resources.пользовательФОН1;
                this.usersBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
                this.usersBUTTON.FlatAppearance.BorderSize = 0;
                this.usersBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.usersBUTTON.Font = new System.Drawing.Font("Rostov", 9F);
                this.usersBUTTON.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.usersBUTTON.Location = new System.Drawing.Point(10, 200);
                this.usersBUTTON.Name = "usersBUTTON";
                this.usersBUTTON.Size = new System.Drawing.Size(148, 60);
                this.usersBUTTON.TabIndex = 20;
                this.usersBUTTON.Text = "        ПОЛЬЗОВАТЕЛИ";
                this.usersBUTTON.UseVisualStyleBackColor = false;
                this.usersBUTTON.Click += new System.EventHandler(this.usersBUTTON_Click);
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
                this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
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
                // button10
                // 
                this.button10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
                this.button10.BackgroundImage = global::регистрация.Properties.Resources.выход;
                this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button10.FlatAppearance.BorderSize = 0;
                this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button10.Font = new System.Drawing.Font("Rostov", 9F);
                this.button10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.button10.Location = new System.Drawing.Point(10, 520);
                this.button10.Name = "button10";
                this.button10.Size = new System.Drawing.Size(148, 60);
                this.button10.TabIndex = 33;
                this.button10.Text = "        НАЗАД";
                this.button10.UseVisualStyleBackColor = false;
                this.button10.Click += new System.EventHandler(this.button10_Click);
                // 
                // AdminWorkForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.SystemColors.Control;
                this.ClientSize = new System.Drawing.Size(975, 650);
                this.Controls.Add(this.button10);
                this.Controls.Add(this.VoteMathButton);
                this.Controls.Add(this.voteButton);
                this.Controls.Add(this.customButton);
                this.Controls.Add(this.MyDataBUTTON);
                this.Controls.Add(this.РЕСПУБЛИКИ);
                this.Controls.Add(this.pictureBoxЗЕМЛЯ);
                this.Controls.Add(this.pictureBoxАГОНЬ);
                this.Controls.Add(this.workFormHIDE);
                this.Controls.Add(this.workFormEXIT);
                this.Controls.Add(this.usersBUTTON);
                this.Controls.Add(this.AREAButton);
                this.Controls.Add(this.БЕЛАРУСЬ);
                this.Controls.Add(this.ТАМОЖНЯ);
                this.Controls.Add(this.pictureBox2);
                this.Controls.Add(this.Point);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
                this.Name = "AdminWorkForm";
                this.Text = "startWorkFORM";
                this.Load += new System.EventHandler(this.Form1_Load);
                this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
                this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
                this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
                this.Point.ResumeLayout(false);
                this.MyDataTabPage.ResumeLayout(false);
                this.MyDataTabPage.PerformLayout();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.newLoginTextBoxBorder)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.newPasswordTextBoxBorder)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.newSurnameTextBoxBorder)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.newNameTextBoxBorder)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.newPatronymicTextBoxBorder)).EndInit();
                this.USERSTabPage.ResumeLayout(false);
                this.USERSTabPage.PerformLayout();
                ((System.ComponentModel.ISupportInitialize) (this.HideUserDataBox)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.USERSdataGrid)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.GiveRightsTextBoxBorder)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.searchTextBoxBorder)).EndInit();
                this.customsTabPage.ResumeLayout(false);
                this.customsTabPage.PerformLayout();
                ((System.ComponentModel.ISupportInitialize) (this.PointsDataGrid)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.customControlNameBorder)).EndInit();
                this.pointDataTabPage.ResumeLayout(false);
                this.pointDataTabPage.PerformLayout();
                ((System.ComponentModel.ISupportInitialize) (this.newPointNameBorder)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
                this.VoteTabPage.ResumeLayout(false);
                this.VoteTabPage.PerformLayout();
                ((System.ComponentModel.ISupportInitialize) (this.itsPoint)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.pointsVoteDataGrid)).EndInit();
                this.voteMathTabPage.ResumeLayout(false);
                this.voteMathTabPage.PerformLayout();
                this.reportTabControl.ResumeLayout(false);
                this.thereIsNoReportTabPage.ResumeLayout(false);
                this.thereIsNoReportTabPage.PerformLayout();
                this.report2tabPage.ResumeLayout(false);
                this.report2tabPage.PerformLayout();
                ((System.ComponentModel.ISupportInitialize) (this.newTimedataGridView)).EndInit();
                this.report1tabPage.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize) (this.VotedataGridView)).EndInit();
                this.report22TabPage.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize) (this.myLastdataGrid)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBoxЗЕМЛЯ)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBoxАГОНЬ)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.AREAButton)).EndInit();
                ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
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
          

            protected System.Windows.Forms.Button usersBUTTON;
        private System.Windows.Forms.TabControl Point;
        private System.Windows.Forms.TabPage USERSTabPage;
        private System.Windows.Forms.TabPage MyDataTabPage;
        protected System.Windows.Forms.Button MyDataBUTTON;
        private System.Windows.Forms.ToolStripMenuItem выдатьПрава;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox newPatronymicTextBox;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.TextBox newSurnameTextBox;
        private System.Windows.Forms.TextBox NewLoginTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Button NewLoginSend;
        private System.Windows.Forms.Label LoginPasswordLable;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.PictureBox newSurnameTextBoxBorder;
        private System.Windows.Forms.PictureBox newNameTextBoxBorder;
        private System.Windows.Forms.PictureBox newPatronymicTextBoxBorder;
        private System.Windows.Forms.DateTimePicker NewBirthdayDateTimePicker;
        private System.Windows.Forms.PictureBox newLoginTextBoxBorder;
        private System.Windows.Forms.PictureBox newPasswordTextBoxBorder;
        private System.Windows.Forms.Button SendBirthday;
        private System.Windows.Forms.Button NewNameSend;
        private System.Windows.Forms.Label ERRORName;
        private System.Windows.Forms.Label ERRORLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label myPatronymic;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label MySurname;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label myLogin;
        private System.Windows.Forms.Label ЛОГИН;
        private System.Windows.Forms.Label ПОЛЬЗОВАТЕЛИ;
        private PictureBox HideUserDataBox;
        private Button button2;
        private TextBox giveRightsTextBox;
        private Label EnterPosition;
        private PictureBox GiveRightsTextBoxBorder;
        private Label myBirthday;
        private Label birthday;
        private PictureBox pictureBox3;
        private TextBox searchTextBox;
        private PictureBox searchTextBoxBorder;
        protected Button customButton;
        private TabPage customsTabPage;
        private DataGridView PointsDataGrid;
        private DataGridView USERSdataGrid;
        private DataGridViewTextBoxColumn login;
        private DataGridViewTextBoxColumn password;
        private Label label1;
        private PictureBox customControlNameBorder;
        private TextBox customControlName;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label2;
        private Button button6;
        private Label ERRORPointName;
        private Label ERRORPlace;
        private ComboBox Country;
        private ComboBox District;
        private ComboBox Region;
        private Label label6;
        private Label label5;
        private Label label4;
        private TabPage pointDataTabPage;
        private PictureBox pictureBox4;
        private RichTextBox pointData;
        private RichTextBox pointAreas;
        private Label pointLable;
        private Label ERRORNewNamePoint;
        private TextBox newPointName;
        private Label newPointNameLable;
        private PictureBox newPointNameBorder;
        private Button newNameButton;
        private DateTimePicker dateTimePickerNewEnd;
        private DateTimePicker dateTimePickerNewStart;
        private Label newTimeLable;
        private Button newTimeButton;
        private Button deleteButton;
        protected Button button1;
        private TabPage VoteTabPage;
        private DataGridView pointsVoteDataGrid;
        protected Button voteButton;
        private Button sendPriorityButton;
        private ContextMenuStrip priorityContextMenuStrip;
        private Label ERRORVote2;
        private Label ERRORVote1;
        private Button backBUTTON;
        private TabPage voteMathTabPage;
        protected Button VoteMathButton;
        private Button button5;
        private Button button4;
        private Label VoteCount;
        private Label VoteCountLable;
        private Button button3;
        private PictureBox itsPoint;
        private TabControl reportTabControl;
        private TabPage report1tabPage;
        private TabPage report2tabPage;
        private RichTextBox report1part1;
        private DataGridView VotedataGridView;
        private RichTextBox report1part2;
        private TabPage thereIsNoReportTabPage;
        private Label thereIsNoReport;
        private Button removeButton;
        private Button saveButton;
        private DataGridView newTimedataGridView;
        private Label label7;
        private DateTimePicker endTimePicker;
        private DateTimePicker startTimePicker;
        private Button button7;
        private Button thereIsNoNewTime;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn start;
        private DataGridViewTextBoxColumn end;
        private TabPage report22TabPage;
        private Button button8;
        private Button button9;
        private RichTextBox report2part1;
        private DataGridView myLastdataGrid;
        private RichTextBox report2part2;
        protected Button button10;
        private DataGridViewTextBoxColumn priorityNumber;
        private DataGridViewTextBoxColumn nameTIME;
        private DataGridViewTextBoxColumn newTimeColumn;
        private DataGridViewTextBoxColumn percent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn priorityColumn;
    }
    }

