using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace регистрация
{
    public partial class AdminWorkForm : Form
    {








        private int _tmpX;
        private int _tmpY;
        private bool _flMove = false;
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (_flMove)
            {
                this.Left = this.Left + (Cursor.Position.X - _tmpX);
                this.Top = this.Top + (Cursor.Position.Y - _tmpY);

                _tmpX = Cursor.Position.X;
                _tmpY = Cursor.Position.Y;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _tmpX = Cursor.Position.X;
                _tmpY = Cursor.Position.Y;
                _flMove = true;
            }
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _flMove = false;
            }
        }


        public AdminWorkForm(Socket socket, int userId, int adminId)
        {
            InitializeComponent();
            this.socket = socket;
            this.myUserID = userId;
            this.myAdminID = adminId;
            this.Show();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.users = new List<User>();
            this.locations = new List<Location>();
            this.newPoints = new List<CustomControlPointNewTime>();
            this.points = new List<CustomsControlPoint>();
            this.votes = new List<Vote>();
            this.MyDataBUTTON.BackColor = Color.FromArgb(70, 70, 70);
            this.MyDataLoad();
            this.ReceiveLocations();
        }

        private void thereIsNoNewTime_Click(object sender, EventArgs e)
        {
            if(newTimedataGridView.SelectedCells.Count != 0)
            {
                newTimedataGridView[2, newTimedataGridView.SelectedCells[0].RowIndex].Value = null;
                newTimedataGridView[3, newTimedataGridView.SelectedCells[0].RowIndex].Value = null;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.report1tabPage.Hide();
            this.report22TabPage.Hide();
            this.thereIsNoReportTabPage.Show();
            this.report2tabPage.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Report2ToFile();
            List<CustomsControlPoint> newTimePoint = new List<CustomsControlPoint>();
            for(int i = 0; i < myLastdataGrid.Rows.Count; i++)
            {
                foreach(var it in points)
                {
                    if(it.Name == myLastdataGrid[0, i].Value.ToString())
                    {
                        CustomsControlPoint point = it;
                        
                        point.SetTime(myLastdataGrid[2, i].Value.ToString());


                        newTimePoint.Add(point);
                    }
                }
            }

            this.socket.Send(Encoding.Unicode.GetBytes("setNewTimePoints"));
            string data = $"{newTimePoint.Count}\n";
            foreach (var it in newTimePoint) data += it.GetData();
            socket.Send(Encoding.Unicode.GetBytes(data));

            
            this.HideUserDataBox.BringToFront();
            this.USERSTabPage.Hide();
            this.customsTabPage.Hide();
            this.pointDataTabPage.Hide();
            this.MyDataTabPage.Show();
            this.VoteTabPage.Hide();
            this.voteMathTabPage.Hide();
            this.VoteMathButton.BackColor = Color.FromArgb(30, 30, 30);
            this.voteButton.BackColor = Color.FromArgb(30, 30, 30);
            this.usersBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.customButton.BackColor = Color.FromArgb(30, 30, 30);
            this.MyDataBUTTON.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            socket.Send(Encoding.Unicode.GetBytes("goBack"));
            new AuthForm(socket).Show();
            Close();
        }


       
    }
}

