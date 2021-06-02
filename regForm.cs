using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
namespace регистрация
{
    public partial class RegForm : Form
    {



        private  int _tmpX;
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






        public RegForm(Socket socket, Point location)
        {
            InitializeComponent();
            this.socket = socket;
            
            this.Show();
            
            this.Location = location;
        }

        
       
        private void registrationHIDE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void registrationEXIT_Click(object sender, EventArgs e)
        {
            this.socket.Send(Encoding.Unicode.GetBytes("exit"));
            Application.Exit();

        }

        private void RegUser_Click(object sender, EventArgs e)
        {
            if(this.LoginBox.Text.Length < 4)
            {
                this.LoginBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "логин и пароль содержат больше 4 символов";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            if (this.checkPasswordBox.Text.Length < 4)
            {

                this.checkPasswordBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "логин и пароль содержат больше 4 символов";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            if (this.LoginBox.Text == "" || this.LoginBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.LoginBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "данные не введены";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            if (this.passwordBox.Text == "" || this.passwordBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.PasswordBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "данные не введены";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            if (this.checkPasswordBox.Text == "" || this.checkPasswordBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.checkPasswordBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "данные не введены";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            if (ERRORTEXT.ForeColor == Color.Red) return;
            this.socket.Send(Encoding.Unicode.GetBytes("reg"));

            byte[] bytes;
            bytes = Encoding.Unicode.GetBytes(this.LoginBox.Text + "\t" + this.passwordBox.Text);
            this.socket.Send(bytes);


            this.socket.Receive(bytes);

            if (BitConverter.ToBoolean(bytes, 0) == false)
            {
                this.LoginBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "введенный логин уже занят";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            else
            {
                RegDataForm form = new RegDataForm(this.socket, this.Location);
                this.Close();
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (this.LoginBox.Text == "")
            {
                
                this.LoginBox.Text = " логин";
                this.LoginBox.ForeColor = SystemColors.AppWorkspace;
            }
         
        }
        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            if(this.ERRORTEXT.Text != "пароли не совпадают")
            {
                this.ERRORTEXT.Text = "пароли не совпадают";
                this.ERRORTEXT.ForeColor = SystemColors.Control;
                this.checkPasswordBoxBorder.BackColor = this.LoginBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.LoginBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.LoginBox.Text = "";
                this.LoginBox.ForeColor = SystemColors.Desktop;
            }
            else if (this.ERRORTEXT.Text == "введенный логин уже занят")
            {
                this.LoginBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORTEXT.ForeColor = SystemColors.Control;
                this.ERRORTEXT.Text = "пароли не совпадают";
                if (this.PasswordBoxBorder.BackColor == Color.Red)
                {
                    this.ERRORTEXT.ForeColor = Color.Red;
                }
            }
            if (LoginBox.Text.Length < 4)
            {
                this.LoginBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "логин и пароль содержат больше 4 символов";
                this.ERRORTEXT.ForeColor = Color.Red;
            }

        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (this.passwordBox.Text == "")
            {

                this.passwordBox.Text = " пароль";
                this.passwordBox.ForeColor = SystemColors.AppWorkspace;
            }
        }
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ERRORTEXT.Text != "пароли не совпадают")
            {
                this.ERRORTEXT.Text = "пароли не совпадают";
                this.ERRORTEXT.ForeColor = SystemColors.Control;
                this.checkPasswordBoxBorder.BackColor = this.LoginBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.passwordBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.passwordBox.Text = "";
                this.passwordBox.ForeColor = SystemColors.Desktop;
            }

            if (this.checkPasswordBox.ForeColor != SystemColors.AppWorkspace && this.passwordBox.ForeColor != SystemColors.AppWorkspace)
             {
                 if (this.checkPasswordBox.Text != this.passwordBox.Text)
                 {
                    if (this.ERRORTEXT.Text != "введенный логин уже занят") this.ERRORTEXT.ForeColor = Color.Red;
                    this.checkPasswordBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = Color.Red;
                 }
                 else if (this.checkPasswordBox.Text == this.passwordBox.Text)
                 {
                    this.checkPasswordBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
                    if (this.ERRORTEXT.Text != "введенный логин уже занят") this.ERRORTEXT.ForeColor = SystemColors.Control;
                }
            }
            if (this.passwordBox.Text.Length < 4)
            {
                this.PasswordBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "логин и пароль содержат больше 4 символов";
                this.ERRORTEXT.ForeColor = Color.Red;
            }

        }
        private void checkPasswordBox_Leave(object sender, EventArgs e)
        {
            if (this.checkPasswordBox.Text == "")
            {

                this.checkPasswordBox.Text = " повторите пароль";
                this.checkPasswordBox.ForeColor = SystemColors.AppWorkspace;
            }
        }
        private void checkPasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ERRORTEXT.Text != "пароли не совпадают")
            {
                this.ERRORTEXT.Text = "пароли не совпадают";
                this.ERRORTEXT.ForeColor = SystemColors.Control;
                this.checkPasswordBoxBorder.BackColor = this.LoginBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.checkPasswordBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.checkPasswordBox.Text = "";
                this.checkPasswordBox.ForeColor = SystemColors.Desktop;
            }
            
             if (this.checkPasswordBox.ForeColor != SystemColors.AppWorkspace && this.passwordBox.ForeColor != SystemColors.AppWorkspace)
             {
                if (this.checkPasswordBox.Text != this.passwordBox.Text)
                {
                    if (this.ERRORTEXT.Text != "введенный логин уже занят") this.ERRORTEXT.ForeColor = Color.Red;
                    this.checkPasswordBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = Color.Red;
                }
                else if (this.checkPasswordBox.Text == this.passwordBox.Text)
                {
                    this.checkPasswordBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
                    if (this.ERRORTEXT.Text != "введенный логин уже занят") this.ERRORTEXT.ForeColor = SystemColors.Control;
                }
             }


        }


     

        private void regFORM_Load(object sender, EventArgs e)
        {

        }

        private void authFORM_Click(object sender, EventArgs e)
        {
            AuthForm form = new AuthForm(this.socket, this.Location);
            this.Close();
        }
    }
}

