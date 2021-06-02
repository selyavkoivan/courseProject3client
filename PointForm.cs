using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace регистрация
{
    public partial class PointForm : Form
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

        private readonly List<CustomsControlPoint> _points;
        public PointForm(List<CustomsControlPoint> points)
        {
            InitializeComponent();
            this._points = points;
            this.FillChart();
        }
        private void FillChart()
        {

            this.chart1.BackColor = Color.WhiteSmoke;
              double[] pointsLoad = {40,30, 27, 26, 26, 26, 27, 28, 31, 36, 38, 45, 51, 60, 73, 81, 89, 99, 100, 96, 86, 73, 60, 48, 40 };

          

            for (int i = 0; i < 24; i++)
            {
                this.chart1.Series[0].Points.AddXY(i, GetCount(i));
                //this.chart1.Series[1].Points.DataBindY(new int[] { i });
               this.chart1.Series[1].Points.AddXY(i + 0.5, pointsLoad[i]);
             

            }
            this.chart1.Series[0].Points.AddXY(24, this.chart1.Series[0].Points[0].YValues[0]);
            this.chart1.Series[1].Points.AddXY(23.5, pointsLoad[0]);
        }
        private double GetCount(int i)
        {
            int count = 0;
            TimeSpan time = new TimeSpan(i, 0, 0);
            foreach(var it in this._points)
            {
                if (it.Start <= it.End)
                {if ((it.Start == it.End) || (it.Start <= time && time <= it.End)) count++; }
                else if((it.Start <= time || time <= it.End))
                {
                    count++;
                } 
                    
            }
            return 100*Convert.ToDouble(count)/ Convert.ToDouble(_points.Count);
        }

        private void workFormEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PointForm_Load(object sender, EventArgs e)
        {

        }
    }
}
