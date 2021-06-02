﻿using System;
using System.Windows.Forms;

namespace регистрация
{
    public partial class NoServerForm : Form
    {
        public NoServerForm()
        {
            InitializeComponent();
        }

        private void authorizationEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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


        private void NoServerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
