using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
namespace регистрация
{


    public partial class RegDataForm : Form
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
        public RegDataForm()
        {
            InitializeComponent();
        }
        public RegDataForm(Socket socket, Point point)
        {
            InitializeComponent();
            this.socket = socket;
            this.Show();
            this.Location = point;
        }

      
        private void Enter_Click(object sender, EventArgs e)
        {
            if (this.SurnameBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.SurmaneBoxBorder.BackColor = Color.Red;
                this.ERRORTEXTSurname.ForeColor = Color.Red;
            }
            if (this.NameBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.NameBoxBorder.BackColor = Color.Red;
                this.ERRORTEXTName.ForeColor = Color.Red;
            }
            if (this.ERRORTEXTName.ForeColor == Color.Red || this.ERRORTEXTSurname.ForeColor == Color.Red) return;




            this.socket.Send(BitConverter.GetBytes(true));
            string str = this.SurnameBox.Text + "\t" + this.NameBox.Text;
            if (this.patronymicBox.ForeColor != SystemColors.AppWorkspace)
            {
                str = str + "\t" + this.patronymicBox.Text;
            }
            this.socket.Send(Encoding.Unicode.GetBytes(str));
            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            MyConvert.SendDate(this.BirthdayDateTimePicker.Value, this.socket);

            AuthForm form = new AuthForm(this.socket, this.Location);
            this.Close();
            
        }

        private void backToAuth_Click(object sender, EventArgs e)
        {
            this.socket.Send(BitConverter.GetBytes(false));
            AuthForm form = new AuthForm(this.socket, this.Location);
            this.Close();

        }
        private void SurnameBox_Leave(object sender, EventArgs e)
        {
            if (this.SurnameBox.Text == "")
            {

                this.SurnameBox.Text = " фамилия";
                this.SurnameBox.ForeColor = SystemColors.AppWorkspace;
            }
        }
        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {
            if (this.SurnameBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.SurnameBox.Text = "";
                this.SurnameBox.ForeColor = SystemColors.Desktop;
            }
            if(this.SurmaneBoxBorder.BackColor == Color.Red)
            {
                this.SurmaneBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORTEXTSurname.ForeColor = SystemColors.Control;
            }
            bool status = true;
            foreach (char it in this.SurnameBox.Text)
            {
                if(!char.IsLetter(it))
                {
                    this.ERRORTEXTSurname.Text = "разрешены только буквы";
                    this.ERRORTEXTSurname.ForeColor = Color.Red;
                    this.SurmaneBoxBorder.BackColor = Color.Red;
                    status = false;
                }
            }
            if(status)
            {
                this.ERRORTEXTSurname.ForeColor = SystemColors.Control;
                this.SurmaneBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (this.NameBox.Text == "")
            {

                this.NameBox.Text = " имя";
                this.NameBox.ForeColor = SystemColors.AppWorkspace;
            }
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (this.NameBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.NameBox.Text = "";
                this.NameBox.ForeColor = SystemColors.Desktop;
            }
            if (this.NameBoxBorder.BackColor == Color.Red)
            {
                this.NameBoxBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORTEXTName.ForeColor = SystemColors.Control;
            }
            bool status = true;
            foreach (char it in this.NameBox.Text)
            {
                if (!char.IsLetter(it))
                {
                    this.ERRORTEXTName.Text = "разрешены только буквы";
                    this.ERRORTEXTName.ForeColor = Color.Red;
                    this.NameBoxBorder.BackColor = Color.Red;
                    status = false;
                }
            }
            if (status)
            {
                this.ERRORTEXTName.ForeColor = SystemColors.Control;
                this.NameBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
        }

        private void patronymicBox_Leave(object sender, EventArgs e)
        {
            if (this.patronymicBox.Text == "")
            {

                this.patronymicBox.Text = " отчество";
                this.patronymicBox.ForeColor = SystemColors.AppWorkspace;
            }
        }

        private void patronymicBox_TextChanged(object sender, EventArgs e)
        {
            if (this.patronymicBox.ForeColor == SystemColors.AppWorkspace)
            {
                this.patronymicBox.Text = "";
                this.patronymicBox.ForeColor = SystemColors.Desktop;
            }
            bool status = true;
            foreach (char it in this.patronymicBox.Text)
            {
                if (!char.IsLetter(it))
                {

                    this.PatronymicBoxBorder.BackColor = Color.Red;
                    status = false;
                }
            }
            if (status)
            { 
                this.PatronymicBoxBorder.BackColor = SystemColors.AppWorkspace;
            }
        }

        private void regDataFORM_Load_1(object sender, EventArgs e)
        {

        }
    }
}
