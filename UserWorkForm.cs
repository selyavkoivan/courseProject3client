using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace регистрация
{
    public partial class UserWorkForm : Form
    {
   


        private int _tmpX;
        private  int _tmpY;
        private  bool _flMove = false;
        private  void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (_flMove)
            {
                this.Left = this.Left + (Cursor.Position.X - _tmpX);
                this.Top = this.Top + (Cursor.Position.Y - _tmpY);

                _tmpX = Cursor.Position.X;
                _tmpY = Cursor.Position.Y;
            }
        }
        private  void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _tmpX = Cursor.Position.X;
                _tmpY = Cursor.Position.Y;
                _flMove = true;
            }
        }
        private  void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _flMove = false;

            }
        }
        public UserWorkForm(Socket socket, int userId)
        {
            InitializeComponent();
            this.socket = socket;
            this.myUserID = userId;
          
            this.Show();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

            this.points = new List<CustomsControlPoint>();
            this.votes = new List<Vote>();
            this.MyDataBUTTON.BackColor = Color.FromArgb(70, 70, 70);
            this.MyDataLoad();

        }


      
     
       
      
      
        private void workFormEXIT_Click(object sender, EventArgs e)
        {
            this.socket.Send(Encoding.Unicode.GetBytes("exit"));


            Application.Exit();

        }

        private void workFormHIDE_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }
        private void FillRichTextBox(User user)
        {

            this.richTextBox2.Text = user.Login + "\n\n" + user.Password + "\n\n" + user.Surname + "\n\n" + user.Name + "\n\n";
            if (user.Patronymic != null) this.richTextBox2.Text += user.Patronymic + "\n\n";
            else this.richTextBox2.Text += "\n\n";
            this.richTextBox2.Text += user.Birthday.Day + "/" + user.Birthday.Month + "/" + user.Birthday.Year;
  
        }
        private void MyDataLoad()
        {

            this.socket.Send(Encoding.Unicode.GetBytes("loadMyUserData"));

            this.socket.Send(BitConverter.GetBytes(this.myUserID));

          
            this.FillRichTextBox(new User(this.socket, this.myUserID));
        }

        private void accountBUTTON_Click_1(object sender, EventArgs e)
        {
    
            this.customsTabPage.Hide();
       
            this.MyDataTabPage.Show();
            this.VoteTabPage.Hide();
          
            this.MyDataLoad();
        
            this.voteButton.BackColor = Color.FromArgb(30, 30, 30);
     
            this.customButton.BackColor = Color.FromArgb(30, 30, 30);
            this.MyDataBUTTON.BackColor = Color.FromArgb(70, 70, 70);
        }


        private void newSurnameTextBox_Leave(object sender, EventArgs e)
        {
            if (this.newSurnameTextBox.Text == "")
            {

                this.newSurnameTextBox.Text = " фамилия";
                this.newSurnameTextBox.ForeColor = SystemColors.AppWorkspace;
                this.newSurnameTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                if (this.newNameTextBoxBorder.BackColor != Color.Red && this.newPatronymicTextBoxBorder.BackColor != Color.Red) this.ERRORLogin.ForeColor = SystemColors.Control;
            }

        }
        private void newSurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.newSurnameTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.newSurnameTextBox.Text = "";
                this.newSurnameTextBox.ForeColor = SystemColors.Desktop;
            }
            if (this.newSurnameTextBoxBorder.BackColor == Color.Red)
            {
                this.newSurnameTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORName.ForeColor = SystemColors.Control;
            }
            bool status = true;
            foreach (char it in this.newSurnameTextBox.Text)
            {
                if (!char.IsLetter(it))
                {
                    this.ERRORName.Text = "разрешены только буквы";
                    this.ERRORName.ForeColor = Color.Red;
                    this.newSurnameTextBoxBorder.BackColor = Color.Red;
                    status = false;
                }
            }
            if (status)
            {
                this.ERRORName.ForeColor = SystemColors.Control;
                this.newSurnameTextBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
        }


        private void newNameTextBox_Leave(object sender, EventArgs e)
        {
            if (this.newNameTextBox.Text == "")
            {

                this.newNameTextBox.Text = " имя";
                this.newNameTextBox.ForeColor = SystemColors.AppWorkspace;
                this.newNameTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                if (this.newSurnameTextBoxBorder.BackColor != Color.Red && this.newPatronymicTextBoxBorder.BackColor != Color.Red) this.ERRORLogin.ForeColor = SystemColors.Control;
            }
        }
        private void newNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.newNameTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.newNameTextBox.Text = "";
                this.newNameTextBox.ForeColor = SystemColors.Desktop;
            }
            if (this.newNameTextBoxBorder.BackColor == Color.Red)
            {
                this.newNameTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORName.ForeColor = SystemColors.Control;
            }
            bool status = true;
            foreach (char it in this.newNameTextBox.Text)
            {
                if (!char.IsLetter(it))
                {
                    this.ERRORName.Text = "разрешены только буквы";
                    this.ERRORName.ForeColor = Color.Red;
                    this.newNameTextBoxBorder.BackColor = Color.Red;
                    status = false;
                }
            }
            if (status)
            {
                this.ERRORName.ForeColor = SystemColors.Control;
                this.newNameTextBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
        }
        private void newPatronymicTextBox_Leave(object sender, EventArgs e)
        {
            if (this.newPatronymicTextBox.Text == "")
            {

                this.newPatronymicTextBox.Text = " отчество";
                this.newPatronymicTextBox.ForeColor = SystemColors.AppWorkspace;
                this.newPatronymicTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                if (this.newSurnameTextBoxBorder.BackColor != Color.Red && this.newNameTextBoxBorder.BackColor != Color.Red) this.ERRORLogin.ForeColor = SystemColors.Control;

            }
        }



        private void newPatronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.newPatronymicTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.newPatronymicTextBox.Text = "";
                this.newPatronymicTextBox.ForeColor = SystemColors.Desktop;
            }
            bool status = true;
            foreach (char it in this.newPatronymicTextBox.Text)
            {
                if (!char.IsLetter(it))
                {
                    this.ERRORName.Text = "разрешены только буквы";
                    this.ERRORName.ForeColor = Color.Red;
                    this.newPatronymicTextBoxBorder.BackColor = Color.Red;
                    status = false;
                }
            }
            if (status)
            {
                this.ERRORName.ForeColor = SystemColors.Control;
                this.newPatronymicTextBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
        }

        private void NewNameSend_Click(object sender, EventArgs e)
        {
            foreach (char it in this.newSurnameTextBox.Text)
            {
                if (!char.IsLetter(it))
                {
                    this.ERRORName.Text = "разрешены только буквы";
                    this.ERRORName.ForeColor = Color.Red;
                    this.newSurnameTextBoxBorder.BackColor = Color.Red;

                }
            }
            foreach (char it in this.newNameTextBox.Text)
            {
                if (!char.IsLetter(it))
                {
                    this.ERRORName.Text = "разрешены только буквы";
                    this.ERRORName.ForeColor = Color.Red;
                    this.newNameTextBoxBorder.BackColor = Color.Red;
                    return;
                }
            }
            if (this.newPatronymicTextBox.ForeColor != SystemColors.AppWorkspace)
            {
                foreach (char it in this.newPatronymicTextBox.Text)
                {
                    if (!char.IsLetter(it))
                    {
                        this.ERRORName.Text = "разрешены только буквы";
                        this.ERRORName.ForeColor = Color.Red;
                        this.newPatronymicTextBoxBorder.BackColor = Color.Red;
                        return;
                    }
                }
            }
            if (this.ERRORName.ForeColor == Color.Red) return;
            if (this.newSurnameTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.newSurnameTextBoxBorder.BackColor = Color.Red;
                this.ERRORName.ForeColor = Color.Red;
            }
            if (this.newNameTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.newNameTextBoxBorder.BackColor = Color.Red;
                this.ERRORName.ForeColor = Color.Red;
            }
            if (this.ERRORName.ForeColor == Color.Red) return;




            this.socket.Send(Encoding.Unicode.GetBytes("sendNewUserName"));
            string str = this.myUserID + "\t" + this.newSurnameTextBox.Text + "\t" + this.newNameTextBox.Text;
            if (this.newPatronymicTextBox.ForeColor != SystemColors.AppWorkspace)
            {
                str = str + "\t" + this.newPatronymicTextBox.Text;
            }
            this.socket.Send(Encoding.Unicode.GetBytes(str));
            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            this.socket.Send(BitConverter.GetBytes(this.myUserID));

            this.FillRichTextBox(new User(this.socket, this.myUserID));
        }


        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (this.NewLoginTextBox.Text == "")
            {
                this.newLoginTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.NewLoginTextBox.Text = " логин";
                this.NewLoginTextBox.ForeColor = SystemColors.AppWorkspace;
            }
        }
        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ERRORLogin.Text != "неверно введен логин или пароль")
            {
                this.ERRORLogin.Text = "неверно введен логин или пароль";
                this.ERRORLogin.ForeColor = SystemColors.Control;
                this.newLoginTextBoxBorder.BackColor = this.newPasswordTextBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.ERRORLogin.Text == "неверно введен логин или пароль" && this.ERRORLogin.ForeColor == Color.Red)
            {
                this.ERRORLogin.ForeColor = SystemColors.Control;
                this.newPasswordTextBoxBorder.BackColor = this.newLoginTextBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.NewLoginTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.NewLoginTextBox.Text = "";
                this.NewLoginTextBox.ForeColor = SystemColors.Desktop;
            }
            if (this.NewLoginTextBox.Text.Length <= 4)
            {
                this.newLoginTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORLogin.Text = "неверно введен логин или пароль";
                this.ERRORLogin.ForeColor = SystemColors.Control;
            }
            if (this.NewLoginTextBox.Text.Length < 4)
            {
                this.newLoginTextBoxBorder.BackColor = Color.Red;
                this.ERRORLogin.Text = "логин или пароль содержат от 4 символов";
                this.ERRORLogin.ForeColor = Color.Red;
            }
            if (this.NewPasswordTextBox.Text.Length < 4)
            {
                this.newPasswordTextBoxBorder.BackColor = Color.Red;
                this.ERRORLogin.Text = "логин или пароль содержат от 4 символов";
                this.ERRORLogin.ForeColor = Color.Red;
            }


        }
        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (this.NewPasswordTextBox.Text == "")
            {
                this.newPasswordTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.NewPasswordTextBox.UseSystemPasswordChar = false;
                this.NewPasswordTextBox.Text = " пароль";
                this.NewPasswordTextBox.ForeColor = SystemColors.AppWorkspace;

            }
        }
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ERRORLogin.Text != "неверно введен логин или пароль")
            {
                this.ERRORLogin.Text = "неверно введен логин или пароль";
                this.ERRORLogin.ForeColor = SystemColors.Control;
                this.newLoginTextBoxBorder.BackColor = this.newPasswordTextBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.ERRORLogin.Text == "неверно введен логин или пароль" && this.ERRORLogin.ForeColor == Color.Red)
            {
                this.ERRORLogin.ForeColor = SystemColors.Control;
                this.newPasswordTextBoxBorder.BackColor = this.newLoginTextBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.NewPasswordTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.NewPasswordTextBox.UseSystemPasswordChar = true;
                this.NewPasswordTextBox.Text = "";
                this.NewPasswordTextBox.ForeColor = SystemColors.Desktop;
            }
            if (this.NewPasswordTextBox.Text.Length <= 4)
            {
                this.newPasswordTextBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORLogin.Text = "неверно введен логин или пароль";
                this.ERRORLogin.ForeColor = SystemColors.Control;
            }
            if (this.NewLoginTextBox.Text.Length < 4)
            {
                this.newLoginTextBoxBorder.BackColor = Color.Red;
                this.ERRORLogin.Text = "логин или пароль содержат от 4 символов";
                this.ERRORLogin.ForeColor = Color.Red;
            }
            if (this.NewPasswordTextBox.Text.Length < 4)
            {
                this.newPasswordTextBoxBorder.BackColor = Color.Red;
                this.ERRORLogin.Text = "логин или пароль содержат от 4 символов";
                this.ERRORLogin.ForeColor = Color.Red;
            }
        }


        private void NewLoginSend_Click(object sender, EventArgs e)
        {
            if (this.NewLoginTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.newLoginTextBoxBorder.BackColor = Color.Red;
                this.ERRORLogin.ForeColor = Color.Red;
            }
            if (this.NewPasswordTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.newPasswordTextBoxBorder.BackColor = Color.Red;
                this.ERRORLogin.ForeColor = Color.Red;
            }
            if (this.ERRORLogin.ForeColor == Color.Red) return;




            this.socket.Send(Encoding.Unicode.GetBytes("sendNewUserLogin"));
            string str = this.myUserID + "\t" + this.NewLoginTextBox.Text + "\t" + this.NewPasswordTextBox.Text;
            this.socket.Send(Encoding.Unicode.GetBytes(str));
            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            this.socket.Send(BitConverter.GetBytes(this.myUserID));
            
            this.FillRichTextBox(new User(socket, myUserID));
        }

        private void SendBirthday_Click(object sender, EventArgs e)
        {
            this.socket.Send(Encoding.Unicode.GetBytes("sendNewUserBirthday"));
            MyConvert.SendDateId(this.myUserID, this.NewBirthdayDateTimePicker.Value, this.socket);
            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            this.socket.Send(BitConverter.GetBytes(this.myUserID));
            this.FillRichTextBox(new User(socket, myUserID));
   
        }

      
     
        private void ReceivePoints()
        {

            this.points.Clear();

            byte[] bytes = new byte[65536];

            this.socket.Receive(bytes);

            string[] strings = Encoding.Unicode.GetString(bytes).Split('\n');

            int count = Convert.ToInt32(strings[0]);


            for (int i = 1; i <= count; i++)
            {
                CustomsControlPoint point = new CustomsControlPoint();
                point.Receive(strings[i]);
                this.points.Add(point);
            }

        }
        private void FillPointTable()
        {

            for (int i = 0; i < this.points.Count; i++)
            {
                this.PointsDataGrid[0, i].Value = this.points[i].Name;
                this.PointsDataGrid[1, i].Value = this.points[i].Location.Country;
                this.PointsDataGrid[2, i].Value = this.points[i].Location.Region;
                this.PointsDataGrid[3, i].Value = this.points[i].Location.District;
                this.PointsDataGrid[4, i].Value = "";
                if (this.points[i].Start.CompareTo(this.points[i].End) == 0)
                {
                    this.PointsDataGrid[4, i].Value = "круглосуточно";
                    continue;
                }
                if (this.points[i].Start.Hours < 10) this.PointsDataGrid[4, i].Value += Convert.ToString(0);
                this.PointsDataGrid[4, i].Value += Convert.ToString(this.points[i].Start.Hours) + ":";
                if (this.points[i].Start.Minutes < 10) this.PointsDataGrid[4, i].Value += Convert.ToString(0);
                this.PointsDataGrid[4, i].Value += Convert.ToString(this.points[i].Start.Minutes) + " - ";
                if (this.points[i].End.Hours < 10) this.PointsDataGrid[4, i].Value += Convert.ToString(0);
                this.PointsDataGrid[4, i].Value += Convert.ToString(this.points[i].End.Hours) + ":";
                if (this.points[i].End.Minutes < 10) this.PointsDataGrid[4, i].Value += Convert.ToString(0);
                this.PointsDataGrid[4, i].Value += Convert.ToString(this.points[i].End.Minutes);

            }
        }
        private void LoadPointsTable()
        {

            this.ReceivePoints();
            if (this.points.Count != 0)
            {
                this.PointsDataGrid.RowCount = this.points.Count;
                this.FillPointTable();
            }
            else this.PointsDataGrid.RowCount = 0;

        }

      

    


      

      



        private void button3_Click(object sender, EventArgs e)
        {


     

            this.customsTabPage.Hide();
            this.MyDataTabPage.Hide();
            this.VoteTabPage.Show();
            this.MyDataBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.customButton.BackColor = Color.FromArgb(30, 30, 30);
            this.voteButton.BackColor = Color.FromArgb(70, 70, 70);


            this.socket.Send(Encoding.Unicode.GetBytes("checkMeInVotes"));
            this.socket.Send(BitConverter.GetBytes(this.myUserID));


            byte[] bytes = new byte[16];
            this.socket.Receive(bytes);
            if (!BitConverter.ToBoolean(bytes, 0))
            {
                this.socket.Send(Encoding.Unicode.GetBytes("getControlPointsVotes"));
                this.LoadPointsVoteTable();
                this.sendPriorityButton.Enabled = true;
                this.backBUTTON.Enabled = true;

            }
            else
            {
                MessageBox.Show("Вы уже участвовали в опросе");
                this.sendPriorityButton.Enabled = false;
                this.backBUTTON.Enabled = false;
            }

        }

        private void LoadPointsVoteTable()
        {

            this.ReceivePoints();
            if (this.points.Count != 0)
            {
                this.pointsVoteDataGrid.RowCount = this.points.Count;
                this.FillPointVoteTable();
            }
            else this.pointsVoteDataGrid.RowCount = 0;

        }

        private void FillPointVoteTable()
        {




            for (int i = 0; i < this.points.Count; i++)
            {


                this.pointsVoteDataGrid[0, i].Value = this.points[i].Name;
                this.pointsVoteDataGrid[1, i].Value = this.points[i].Location.Country;
                this.pointsVoteDataGrid[2, i].Value = this.points[i].Location.Region;
                this.pointsVoteDataGrid[3, i].Value = this.points[i].Location.District;
                this.pointsVoteDataGrid[4, i].Value = "";
                if (this.points[i].Start.CompareTo(this.points[i].End) == 0)
                {
                    this.pointsVoteDataGrid[4, i].Value = "круглосуточно";
                    continue;
                }
                if (this.points[i].Start.Hours < 10) this.pointsVoteDataGrid[4, i].Value += Convert.ToString(0);
                this.pointsVoteDataGrid[4, i].Value += Convert.ToString(this.points[i].Start.Hours) + ":";
                if (this.points[i].Start.Minutes < 10) this.pointsVoteDataGrid[4, i].Value += Convert.ToString(0);
                this.pointsVoteDataGrid[4, i].Value += Convert.ToString(this.points[i].Start.Minutes) + " - ";
                if (this.points[i].End.Hours < 10) this.pointsVoteDataGrid[4, i].Value += Convert.ToString(0);
                this.pointsVoteDataGrid[4, i].Value += Convert.ToString(this.points[i].End.Hours) + ":";
                if (this.points[i].End.Minutes < 10) this.pointsVoteDataGrid[4, i].Value += Convert.ToString(0);
                this.pointsVoteDataGrid[4, i].Value += Convert.ToString(this.points[i].End.Minutes);
                this.priorityContextMenuStrip.Items.Add((i + 1).ToString());











            }




        }


        private bool Check(int i)
        {

            for (int j = 0; j < this.pointsVoteDataGrid.Rows.Count; j++)
            {
                if (this.pointsVoteDataGrid[5, j].Value != null)
                {
                    if (this.pointsVoteDataGrid[5, j].Value.ToString() == (i + 1).ToString()) return false;
                }
            }
            return true;
        }




        private void priorityContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            this.pointsVoteDataGrid.SelectedCells[0].Value = e.ClickedItem.Text;
        }
        private void pointsVoteDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                if (this.ERRORVote1.ForeColor == Color.Red)
                {
                    this.ERRORVote1.ForeColor = this.ERRORVote2.ForeColor = SystemColors.Control;
                    this.itsPoint.BackgroundImage = global::регистрация.Properties.Resources.еж2;
                }
                this.priorityContextMenuStrip.Items.Clear();
                for (int i = 0; i < this.pointsVoteDataGrid.Rows.Count; i++)
                {
                    if (Check(i)) this.priorityContextMenuStrip.Items.Add((i + 1).ToString());


                }
                this.priorityContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void sendPriorityButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.pointsVoteDataGrid.Rows.Count; i++)
            {
                if (this.pointsVoteDataGrid[5, i].Value == null)
                {
                    this.ERRORVote1.ForeColor = this.ERRORVote2.ForeColor = Color.Red;
                    this.itsPoint.BackgroundImage = global::регистрация.Properties.Resources.еж1;
                    return;
                }
            }
            this.socket.Send(Encoding.Unicode.GetBytes("sendPriority"));
            string data = this.pointsVoteDataGrid.Rows.Count.ToString() + "\n";
            data += this.myUserID.ToString() + "\n";
            for (int i = 0; i < this.pointsVoteDataGrid.Rows.Count; i++)
            {
                data += this.points[i].CustomsControlPointId + "\t";
                data += this.pointsVoteDataGrid[5, i].Value + "\n";
            }
            this.socket.Send(Encoding.Unicode.GetBytes(data));
            this.sendPriorityButton.Enabled = false;
            this.backBUTTON.Enabled = false;
            for (int i = 0; i < this.pointsVoteDataGrid.Rows.Count; i++)
            {
                this.pointsVoteDataGrid[5, i].Value = null;
            }
        }

        private void backBUTTON_Click(object sender, EventArgs e)
        {
            this.ERRORVote1.ForeColor = this.ERRORVote2.ForeColor = SystemColors.Control;
            this.itsPoint.BackgroundImage = global::регистрация.Properties.Resources.еж2;
            for (int i = 0; i < this.pointsVoteDataGrid.Rows.Count; i++)
            {
                this.pointsVoteDataGrid[5, i].Value = null;
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (this.points.Count == 0)
            {
                MessageBox.Show("Отсутствуют пункты");
                return;
            }
            PointForm form = new PointForm(this.points);
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            socket.Send(Encoding.Unicode.GetBytes("goBack"));

            new AuthForm(this.socket).Show();
            this.Close();
        }

        private void customButton_Click(object sender, EventArgs e)
        {
        

            this.socket.Send(Encoding.Unicode.GetBytes("getControlPoints"));

     
            this.customsTabPage.Show();
            this.MyDataTabPage.Hide();
 
            this.VoteTabPage.Hide();
          
            this.voteButton.BackColor = Color.FromArgb(30, 30, 30);
  
            this.MyDataBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.customButton.BackColor = Color.FromArgb(70, 70, 70);




            this.LoadPointsTable();
        }
    }
}
