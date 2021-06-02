using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace регистрация
{
    public partial class AdminWorkForm
    {
        private void ReceiveUsers()
        {
            this.users.Clear();

            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            int count = BitConverter.ToInt32(bytes, 0);

            for (int i = 0; i < count; i++)
            {
                User user = new User();
                user.ReceiveFulLData(ref this.socket);
                this.users.Add(user);
            }

        }
        private void FillTable()
        {
            for (int i = 0; i < this.users.Count; i++)
            {
                this.USERSdataGrid[0, i].Value = this.users[i].Login;
                this.USERSdataGrid[1, i].Value = this.users[i].Password;
            }
        }
        private void LoadTable()
        {

            this.ReceiveUsers();
            if (this.users.Count != 0)
            {
                this.USERSdataGrid.RowCount = this.users.Count;

                this.FillTable();
            }
            else this.USERSdataGrid.RowCount = 0;

        }
        private void usersBUTTON_Click(object sender, EventArgs e)
        {
            this.CustomClear();
            this.customsTabPage.Hide();
            this.MyDataTabPage.Hide();
            this.pointDataTabPage.Hide();
            this.USERSTabPage.Show();
            this.VoteTabPage.Hide();
            this.voteMathTabPage.Hide();
            this.socket.Send(Encoding.Unicode.GetBytes("loadUserTable"));
            this.LoadTable();
            this.VoteMathButton.BackColor = Color.FromArgb(30, 30, 30);
            this.voteButton.BackColor = Color.FromArgb(30, 30, 30);
            this.MyDataBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.customButton.BackColor = Color.FromArgb(30, 30, 30);
            this.usersBUTTON.BackColor = Color.FromArgb(70, 70, 70);


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
        private void FillRichTextBox(Admin admin)
        {

            this.richTextBox2.Text = admin.User.Login + "\n\n" + admin.User.Password + "\n\n" + admin.User.Surname + "\n\n" + admin.User.Name + "\n\n";
            if (admin.User.Patronymic != null) this.richTextBox2.Text += admin.User.Patronymic + "\n\n";
            else this.richTextBox2.Text += "\n\n";
            this.richTextBox2.Text += admin.User.Birthday.Day + "/" + admin.User.Birthday.Month + "/" + admin.User.Birthday.Year + "\n\n";
            this.richTextBox2.Text += admin.Position;
        }
        void MyDataLoad()
        {

            this.socket.Send(Encoding.Unicode.GetBytes("loadMyData"));

            this.socket.Send(BitConverter.GetBytes(this.myAdminID));

            Admin admin = new Admin(this.socket, this.myAdminID, this.myUserID);
            this.FillRichTextBox(admin);
        }

        private void accountBUTTON_Click_1(object sender, EventArgs e)
        {
            this.CustomClear();
            this.HideUserDataBox.BringToFront();
            this.USERSTabPage.Hide();
            this.customsTabPage.Hide();
            this.pointDataTabPage.Hide();
            this.MyDataTabPage.Show();
            this.VoteTabPage.Hide();
            this.voteMathTabPage.Hide();
            this.MyDataLoad();
            this.VoteMathButton.BackColor = Color.FromArgb(30, 30, 30);
            this.voteButton.BackColor = Color.FromArgb(30, 30, 30);
            this.usersBUTTON.BackColor = Color.FromArgb(30, 30, 30);
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
            foreach (var it in this.newSurnameTextBox.Text)
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




            this.socket.Send(Encoding.Unicode.GetBytes("sendNewName"));
            string str = this.myUserID + "\t" + this.newSurnameTextBox.Text + "\t" + this.newNameTextBox.Text;
            if (this.newPatronymicTextBox.ForeColor != SystemColors.AppWorkspace)
            {
                str = str + "\t" + this.newPatronymicTextBox.Text;
            }
            this.socket.Send(Encoding.Unicode.GetBytes(str));
            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            this.socket.Send(BitConverter.GetBytes(this.myAdminID));
            Admin admin = new Admin(this.socket, this.myAdminID, this.myUserID);
            this.FillRichTextBox(admin);
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




            this.socket.Send(Encoding.Unicode.GetBytes("sendNewLogin"));
            string str = this.myUserID + "\t" + this.NewLoginTextBox.Text + "\t" + this.NewPasswordTextBox.Text;
            this.socket.Send(Encoding.Unicode.GetBytes(str));
            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            this.socket.Send(BitConverter.GetBytes(this.myAdminID));
            Admin admin = new Admin(this.socket, this.myAdminID, this.myUserID);
            this.FillRichTextBox(admin);
        }

        private void SendBirthday_Click(object sender, EventArgs e)
        {
            this.socket.Send(Encoding.Unicode.GetBytes("sendNewBirthday"));
            MyConvert.SendDateId(this.myUserID, this.NewBirthdayDateTimePicker.Value, this.socket);
            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            this.socket.Send(BitConverter.GetBytes(this.myAdminID));
            Admin admin = new Admin(this.socket, this.myAdminID, this.myUserID);
            this.FillRichTextBox(admin);
        }

        private void ShowUserData(User user)
        {
            this.HideUserDataBox.SendToBack();
            this.myLogin.Text = user.Login;
            this.MySurname.Text = user.Surname;
            this.MyName.Text = user.Name;
            if (user.Patronymic != null)
            {
                this.myPatronymic.Text = user.Patronymic;
            }
            else this.myPatronymic.Text = "";
            this.myBirthday.Text = user.Birthday.Day + "/" + user.Birthday.Month + "/" + user.Birthday.Year;
        }
        private void UsersDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                int index = 0;
                for (int i = 0; i < users.Count; i++)
                {
                    
                    if (users[i].Login == USERSdataGrid[0, e.RowIndex].Value.ToString())
                    {
                        index = i;
                        break;
                    }
                }
                
                this.ShowUserData(users[index]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (giveRightsTextBox.ForeColor != SystemColors.AppWorkspace)
            {

                this.socket.Send(Encoding.Unicode.GetBytes("giveRights"));
                this.socket.Send(Encoding.Unicode.GetBytes(this.myLogin.Text + "\t" + this.giveRightsTextBox.Text));
                byte[] bytes = new byte[64];
                socket.Receive(bytes);
                this.giveRightsTextBox.Text = " должность";
                this.giveRightsTextBox.ForeColor = SystemColors.AppWorkspace;
                this.LoadTable();
                this.HideUserDataBox.BringToFront();

            }
        }

        private void giveRightsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.giveRightsTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.giveRightsTextBox.Text = "";
                this.giveRightsTextBox.ForeColor = SystemColors.Desktop;
            }
        }
        private void giveRightsTextBox_Leave(object sender, EventArgs e)
        {
            if (this.giveRightsTextBox.Text == "")
            {
                this.giveRightsTextBox.Text = " должность";
                this.giveRightsTextBox.ForeColor = SystemColors.AppWorkspace;
            }
        }

        void FillSearchTable(List<User> searchUsers)
        {
            for (int i = 0; i < searchUsers.Count; i++)
            {
                this.USERSdataGrid[0, i].Value = searchUsers[i].Login;
                this.USERSdataGrid[1, i].Value = searchUsers[i].Password;
            }
        }
        void LoadSearchTable(string text)
        {
            this.USERSdataGrid.DataSource = null;
            List<User> searchUsers = new List<User>();
            for (int i = 0; i < this.users.Count; i++)
            {
                if (this.users[i].Login.IndexOf(text) != -1)
                {
                    searchUsers.Add(this.users[i]);
                }
            }
            this.USERSdataGrid.DataSource = searchUsers;
            this.FillSearchTable(searchUsers);
        }
        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (this.searchTextBox.Text == "")
            {
                this.searchTextBox.Text = " поиск";
                this.searchTextBox.ForeColor = SystemColors.AppWorkspace;

                this.USERSdataGrid.DataSource = null;
                this.USERSdataGrid.DataSource = this.users;
                this.FillTable();
            }

        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.searchTextBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.searchTextBox.Text = "";
                this.searchTextBox.ForeColor = Color.FromArgb(30, 30, 30);
            }
            this.LoadSearchTable(this.searchTextBox.Text);
        }

    }
}