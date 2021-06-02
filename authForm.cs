using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;


namespace регистрация
{
    public partial class AuthForm : Form
    {

        public AuthForm(Socket socket)
        {
            this.socket = socket;
            InitializeComponent();
        }
       
        public AuthForm(Socket socket, Point location)
        {
            InitializeComponent();
            this.socket = socket;

            this.Show();

            this.Location = location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


      
        private void authorizationHIDE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void authorizationEXIT_Click(object sender, EventArgs e)
        {
            this.socket.Send(Encoding.Unicode.GetBytes("exit"));

            Application.Exit();
        }
        private void Enter_Click(object sender, EventArgs e)
        {
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
            
            if (ERRORTEXT.ForeColor == Color.Red) return;
            this.socket.Send(Encoding.Unicode.GetBytes("auth"));

            byte[] bytes;
            bytes = Encoding.Unicode.GetBytes(this.LoginBox.Text + "\t" + this.passwordBox.Text);

            this.socket.Send(bytes);

            this.socket.Receive(bytes);
            int UserID = BitConverter.ToInt32(bytes, 0);
            if (UserID == 0)
            {
                this.LoginBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            else
            {
                this.socket.Receive(bytes);
                int AdminID = BitConverter.ToInt32(bytes, 0);
                if (AdminID != 0)
                {
                    AdminWorkForm form = new AdminWorkForm(this.socket, UserID, AdminID);
                }
                else
                {
                    UserWorkForm form = new UserWorkForm(this.socket, UserID);
                }
                this.Hide();
            }
        }
        private void Reg_Click(object sender, EventArgs e)
        {
            
            var newForm = new RegForm(this.socket, this.Location);
            this.Hide();
        }
        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (this.LoginBox.Text != "") return;
            this.LoginBoxBorder.BackColor = SystemColors.AppWorkspace;
            this.LoginBox.Text = " логин";
            this.LoginBox.ForeColor = SystemColors.AppWorkspace;
        }
        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ERRORTEXT.Text != "неверно введен логин или пароль")
            {
                this.ERRORTEXT.Text = "неверно введен логин или пароль";
                this.ERRORTEXT.ForeColor = SystemColors.Control;
                this.LoginBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.ERRORTEXT.Text == "неверно введен логин или пароль" && this.ERRORTEXT.ForeColor == Color.Red)
            {
                this.ERRORTEXT.ForeColor = SystemColors.Control;
                this.PasswordBoxBorder.BackColor = this.LoginBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.LoginBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.LoginBox.Text = "";
                this.LoginBox.ForeColor = SystemColors.Desktop;
            }
            if (this.LoginBox.Text.Length <= 4)
            {
                this.LoginBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORTEXT.Text = "неверно введен логин или пароль";
                this.ERRORTEXT.ForeColor = SystemColors.Control;
            }
            if (this.LoginBox.Text.Length < 4 )
            {
                this.LoginBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "логин или пароль содержат от 4 символов";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            if (this.passwordBox.Text.Length < 4)
            {
                this.PasswordBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "логин или пароль содержат от 4 символов";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
           

        }
        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (this.passwordBox.Text == "")
            {
                this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.passwordBox.UseSystemPasswordChar = false;
                this.passwordBox.Text = " пароль";
                this.passwordBox.ForeColor = SystemColors.AppWorkspace;

            }
        }
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ERRORTEXT.Text != "неверно введен логин или пароль")
            {
                this.ERRORTEXT.Text = "неверно введен логин или пароль";
                this.ERRORTEXT.ForeColor = SystemColors.Control;
                this.LoginBoxBorder.BackColor = this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.ERRORTEXT.Text == "неверно введен логин или пароль" && this.ERRORTEXT.ForeColor == Color.Red)
            {
                this.ERRORTEXT.ForeColor = SystemColors.Control;
                this.PasswordBoxBorder.BackColor = this.LoginBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
            if (this.passwordBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.passwordBox.UseSystemPasswordChar = true;
                this.passwordBox.Text = "";
                this.passwordBox.ForeColor = SystemColors.Desktop;
            }
            if (this.passwordBox.Text.Length <= 4)
            {
                this.PasswordBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORTEXT.Text = "неверно введен логин или пароль";
                this.ERRORTEXT.ForeColor = SystemColors.Control;
            }
            if (this.LoginBox.Text.Length < 4)
            {
                this.LoginBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "логин или пароль содержат от 4 символов";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
            if (this.passwordBox.Text.Length < 4)
            {
                this.PasswordBoxBorder.BackColor = Color.Red;
                this.ERRORTEXT.Text = "логин или пароль содержат от 4 символов";
                this.ERRORTEXT.ForeColor = Color.Red;
            }
        }

        private int _tmpX;
        private int _tmpY;
        private bool _flMove = false;

        private void authForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_flMove)
            {
                this.Left = this.Left + (Cursor.Position.X - _tmpX);
                this.Top = this.Top + (Cursor.Position.Y - _tmpY);

                _tmpX = Cursor.Position.X;
                _tmpY = Cursor.Position.Y;
            }
        }

        private void authForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _tmpX = Cursor.Position.X;
                _tmpY = Cursor.Position.Y;
                _flMove = true;
            }
        }

        private void authForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _flMove = false;
            }
        }
    }


}
