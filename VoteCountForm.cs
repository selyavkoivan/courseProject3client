using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace регистрация
{
    public partial class VoteCountForm : Form
    {




        private  int _tmpX;
        private  int _tmpY;
        private  bool _flMove;
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







        private readonly List<Vote> _pointVote;
        private readonly string _name;
        public VoteCountForm(List<Vote> pointVote, string name)
        {
            this._pointVote = pointVote;
            this._name = name;
          
            InitializeComponent();
            FillChart();
            this.ShowDialog();
            
        }
        private int MaxPosition()
        {
            return _pointVote.Select(it => it.Priority).Prepend(0).Max();
        }
        private  int FindMax()
        {
            var max = new int[_pointVote.Count];
            for (int i = 0; i < max.Length; i++) max[i] = GetCount(i);
  
            return max.Max();
            
        }
        private int GetCount(int i)
        {
            int count = 0;
            foreach (var it in _pointVote) { if (it.Priority == i) count++; }
            return count;
        }
        private void FillChart()
        {
            
            this.chart1.BackColor = Color.WhiteSmoke;
            for (int position = 1; position <= MaxPosition(); position++)
            {
     
                this.chart1.Series[0].Points.AddXY(position, GetCount(position));
            }

        }

        private void VoteCountForm_Load(object sender, EventArgs e)
        {

        }

        private void workFormEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
