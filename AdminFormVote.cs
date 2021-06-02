using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace регистрация
{
    public partial class AdminWorkForm
    {
        private void GetVotes()
        {
            this.votes.Clear();
            byte[] bytes = new byte[65536];
            int size = this.socket.Receive(bytes);
            string[] data = Encoding.Unicode.GetString(bytes, 0, size).Split('\n');
            for (int i = 1; i <= Convert.ToInt32(data[0]); i++)
            {
                Vote vote = new Vote();
                vote.Receive(data[i]);
                this.votes.Add(vote);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {




            this.socket.Send(Encoding.Unicode.GetBytes("getVotes"));
            this.GetVotes();
            if (votes.Count == 0)
            {
                MessageBox.Show("Отсутствуют голоса");
                return;
            }
            this.HideUserDataBox.BringToFront();
            this.USERSTabPage.Hide();
            this.customsTabPage.Hide();
            this.pointDataTabPage.Hide();
            this.MyDataTabPage.Hide();
            this.VoteTabPage.Hide();
            this.voteMathTabPage.Show();
            this.VoteMathButton.BackColor = Color.FromArgb(70, 70, 70);
            this.voteButton.BackColor = Color.FromArgb(30, 30, 30);
            this.usersBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.customButton.BackColor = Color.FromArgb(30, 30, 30);
            this.MyDataBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.VoteCount.Text = this.GetTotalCount().ToString();

            this.report22TabPage.Hide();
            this.report2tabPage.Hide();
            this.report1tabPage.Hide();
            this.thereIsNoReportTabPage.Show();



        }

        private static bool Find(List<int> list, int i)
        {
            foreach (var it in list)
            {
                if (it == i) return true;
            }
            return false;
        }
        private int GetTotalCount()
        {

            var mas = new List<int>();
            foreach (var it in this.votes)
            {
                if (mas.Count == 0) mas.Add(it.User.UserId);
                else if (!Find(mas, it.User.UserId)) mas.Add(it.User.UserId);
            }
            return mas.Count;
        }
        private void ReceiveNewPoint()
        {
            this.newPoints.Clear();

            byte[] bytes = new byte[65536];

            int size = this.socket.Receive(bytes);

            string[] strings = Encoding.Unicode.GetString(bytes, 0, size).Split('\n');

            int count = Convert.ToInt32(strings[0]);


            for (int i = 1; i <= count; i++)
            {
                CustomControlPointNewTime point = new CustomControlPointNewTime();
                point.Receive(strings[i]);
                this.newPoints.Add(point);
            }
        }
        private string[] GetMyName()
        {
            string[] strings = new string[5];



            this.socket.Send(BitConverter.GetBytes(this.myAdminID));

            Admin admin = new Admin(this.socket, this.myAdminID, this.myUserID);
            strings[0] = admin.Position;
            strings[1] = admin.User.Login;
            strings[2] = admin.User.Surname;
            strings[3] = admin.User.Name;
            if (admin.User.Patronymic != null) strings[4] = admin.User.Patronymic;
            else strings[4] = "";

            return strings;
        }
        private void FillTotalVoteTable()
        {
            this.VotedataGridView.Rows.Clear();
            this.VotedataGridView.RowCount = this.newPoints.Count();
            for (int i = 0; i < VotedataGridView.Rows.Count; i++)
            {
                VotedataGridView[0, i].Value = newPoints[i].Position;
                VotedataGridView[1, i].Value = newPoints[i].Point.Name;
               
                if (newPoints[i].NewStart.CompareTo(newPoints[i].NewEnd) == 0) VotedataGridView[2, i].Value = "круглосуточно";
                else
                {
                    VotedataGridView[2, i].Value = newPoints[i].NewStart.Hours < 10 ? $"0{newPoints[i].NewStart.Hours}" : newPoints[i].NewStart.Hours.ToString();
                    VotedataGridView[2, i].Value += ":";
                    VotedataGridView[2, i].Value += newPoints[i].NewStart.Minutes < 10 ? $"0{newPoints[i].NewStart.Minutes}" : newPoints[i].NewStart.Minutes.ToString();
                    VotedataGridView[2, i].Value += " - ";
                    VotedataGridView[2, i].Value += newPoints[i].NewEnd.Hours < 10 ? $"0{newPoints[i].NewEnd.Hours}" : newPoints[i].NewEnd.Hours.ToString();
                    VotedataGridView[2, i].Value += ":";
                    VotedataGridView[2, i].Value += newPoints[i].NewEnd.Minutes < 10 ? $"0{newPoints[i].NewEnd.Minutes}" : newPoints[i].NewEnd.Minutes.ToString();


                }
                VotedataGridView[3, i].Value = 100 - newPoints[i].Percent;
            }
        }

        private string _report1Number;
        private string _report2Number;
        private void GetReport2Number()
        {
            _report2Number = "2";
            _report2Number += DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
            _report2Number += DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            _report2Number += DateTime.Now.Millisecond < 100 ?
                (DateTime.Now.Millisecond < 10 ?
                    "00" + DateTime.Now.Millisecond.ToString()
                 : "0" + DateTime.Now.Millisecond.ToString())
                 : DateTime.Now.Millisecond.ToString();



        }
        private void GetReport1Number()
        {
            _report1Number = "1";
            _report1Number += DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
            _report1Number += DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            _report1Number += DateTime.Now.Millisecond < 100 ?
                (DateTime.Now.Millisecond < 10 ?
                    "00" + DateTime.Now.Millisecond.ToString()
                 : "0" + DateTime.Now.Millisecond.ToString())
                 : DateTime.Now.Millisecond.ToString();



        }
        private void Report1()
        {
            string[] strings = GetMyName();
            this.report1part1.Text = $"\t\t\t\t\tПодразделение таможенной статистики\n\t\t\t\t\t{strings[0]}\n";
            GetReport1Number();
            this.report1part1.Text += $"\t\t\t\t\t{strings[2]} {strings[3]} {strings[4]}";
            this.report1part1.Text += $"\n\n\t\t\t\tОтчет №{_report1Number}\n\n";
            this.report1part1.Text += $"\tПо состоянию на текущий момент {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} ";
            this.report1part1.Text += $"опрос для составления последующего расписания пунктов таможенного контроля проведен среди {GetTotalCount()}";
            this.report1part1.Text += (GetTotalCount() % 10 == 1 && GetTotalCount() % 100 != 11) ? " эксперта. " : " экспертов. ";
            this.report1part1.Text += $"Выборка проводилась среди {this.newPoints.Count}";
            this.report1part1.Text += (newPoints.Count % 10 == 1 && newPoints.Count % 100 != 11) ? " пункта" : " пунктов";
            this.report1part1.Text += ".\n\tДля рассмотрения предложено следующее расписание:\n";
            this.FillTotalVoteTable();
            this.report1part2.Text = "\tПринят для дальнейшего рассмотрения начальником подразделения таможенного контроля.\n\n";
            this.report1part2.Text += $"\tДата {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}\t\t\t\tПодпись\t {strings[1]}";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (VoteCount.Text == "0") return;
            this.button4.Enabled = false;


            this.socket.Send(Encoding.Unicode.GetBytes("findTheBest"));

            this.report22TabPage.Hide();
            this.report2tabPage.Hide();
            this.thereIsNoReportTabPage.Hide();
            this.report1tabPage.Show();


            this.ReceiveNewPoint();
            this.Report1();
            Thread.Sleep(100);
            this.button4.Enabled = true;
        }
        private void WriteTable(StreamWriter stream)
        {
            for (var i = 0; i < VotedataGridView.Rows.Count; i++)
            {
                stream.Write($"| {VotedataGridView[0, i].Value}".PadRight(14));
                stream.Write($" | {VotedataGridView[1, i].Value}".PadRight(33));
                stream.Write($" | {VotedataGridView[2, i].Value}".PadRight(15));
                stream.Write($" | {VotedataGridView[3, i].Value}".PadRight(29));
                stream.WriteLine(" |");
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {


            string tableHead = "+--------------+--------------------------------+---------------+----------------------------+\n" +
"| № приоритета | Название пункта                | Итоги опроса  | Предполагаемая нагрузка, % |\n" +
"+--------------+--------------------------------+---------------+----------------------------+";
            FileInfo file = new FileInfo($"Отчет№{_report1Number}.txt");


            using (StreamWriter stream = file.CreateText())
            {
                stream.WriteLine(this.report1part1.Text);
                stream.WriteLine(tableHead);
                this.WriteTable(stream);
                stream.WriteLine("+--------------+--------------------------------+---------------+----------------------------+");
                stream.WriteLine(this.report1part2.Text);
                stream.Close();
            }

            new ReportDataForm(file.FullName);
        }

        private void Report2Table()
        {
            string[] strings = GetMyName();
            this.newTimedataGridView.Rows.Clear();
            this.newTimedataGridView.RowCount = this.newPoints.Count();
            for (var i = 0; i < newTimedataGridView.Rows.Count; i++)
            {

                newTimedataGridView[0, i].Value = newPoints[i].Point.Name;

                if (newPoints[i].NewStart.CompareTo(newPoints[i].NewEnd) == 0) newTimedataGridView[1, i].Value = "круглосуточно";
                else
                {
                    newTimedataGridView[1, i].Value = newPoints[i].NewStart.Hours < 10 ? $"0{newPoints[i].NewStart.Hours}" : newPoints[i].NewStart.Hours.ToString();
                    newTimedataGridView[1, i].Value += ":";
                    newTimedataGridView[1, i].Value += newPoints[i].NewStart.Minutes < 10 ? $"0{newPoints[i].NewStart.Minutes}" : newPoints[i].NewStart.Minutes.ToString();
                    newTimedataGridView[1, i].Value += " - ";
                    newTimedataGridView[1, i].Value += newPoints[i].NewEnd.Hours < 10 ? $"0{newPoints[i].NewEnd.Hours}" : newPoints[i].NewEnd.Hours.ToString();
                    newTimedataGridView[1, i].Value += ":";
                    newTimedataGridView[1, i].Value += newPoints[i].NewEnd.Minutes < 10 ? $"0{newPoints[i].NewEnd.Minutes}" : newPoints[i].NewEnd.Minutes.ToString();


                }

            }
        }








        private void button5_Click(object sender, EventArgs e)
        {

            if (VoteCount.Text == "0") return;
            this.button5.Enabled = false;


            this.socket.Send(Encoding.Unicode.GetBytes("findTheBest"));


            this.report1tabPage.Hide();
            this.report22TabPage.Hide();
            this.thereIsNoReportTabPage.Hide();
            this.report2tabPage.Show();


            this.ReceiveNewPoint();
            this.Report2Table();
            Thread.Sleep(100);
            this.button5.Enabled = true;

        }





        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                newTimedataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


            if (newTimedataGridView.SelectedCells.Count != 0)
            {
                newTimedataGridView[2, newTimedataGridView.SelectedCells[0].RowIndex].Value = (startTimePicker.Value.Hour < 10) ? $"0{startTimePicker.Value.Hour}" : startTimePicker.Value.Hour.ToString();
                newTimedataGridView[2, newTimedataGridView.SelectedCells[0].RowIndex].Value += ":";
                newTimedataGridView[2, newTimedataGridView.SelectedCells[0].RowIndex].Value += (startTimePicker.Value.Minute < 10) ? $"0{startTimePicker.Value.Minute}" : startTimePicker.Value.Minute.ToString();
            }
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (newTimedataGridView.SelectedCells.Count != 0)
            {

                newTimedataGridView[3, newTimedataGridView.SelectedCells[0].RowIndex].Value = (endTimePicker.Value.Hour < 10) ? $"0{endTimePicker.Value.Hour}" : endTimePicker.Value.Hour.ToString();
                newTimedataGridView[3, newTimedataGridView.SelectedCells[0].RowIndex].Value += ":";
                newTimedataGridView[3, newTimedataGridView.SelectedCells[0].RowIndex].Value += (endTimePicker.Value.Minute < 10) ? $"0{endTimePicker.Value.Minute}" : endTimePicker.Value.Minute.ToString();
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            socket.Send(Encoding.Unicode.GetBytes("getControlPoints"));
            ReceivePoints();




            this.report22TabPage.Show();
            this.report2tabPage.Hide();
            this.report1tabPage.Hide();
            this.thereIsNoReportTabPage.Hide();

            this.Report2();
        }
        private void Report2()
        {
            this.socket.Send(Encoding.Unicode.GetBytes("loadMyData"));
            GetReport2Number();
            string[] strings = GetMyName();
            report2part1.Text = "\t\t\t\t\tПодразделение таможенной статистики\n" +
$"\t\t\t\t\t{strings[0]}\n\t\t\t\t\t{strings[2]} {strings[3]} {strings[4]}\n\n" +
$"\t\t\t\tОТЧЕТ №{_report2Number}\n\n" +

"\tПо итогам проведенного опроса было предложено на рассмотрение расписание. После проведения корректировки было утверждено следующее расписание:";
            FillMyLastDataGrid();

            report2part2.Text = $"\tДата {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}\t\t\t\tПодпись\t {strings[1]}";



        }
        private void FillMyLastDataGrid()
        {
            myLastdataGrid.Rows.Clear();
            myLastdataGrid.RowCount = newTimedataGridView.Rows.Count;
            var list = new List<CustomControlPointTotalTime>();
            for (var i = 0; i < newTimedataGridView.Rows.Count; i++)
            {
                var point = new CustomControlPointTotalTime();
                if (newTimedataGridView[2, i].Value != null && newTimedataGridView[3, i].Value != null)
                {
                    point.SetStart(newTimedataGridView[2, i].Value.ToString());
                    point.SetEnd(newTimedataGridView[3, i].Value.ToString());
                }
                else if(newTimedataGridView[2, i].Value != null)
                {
                    point.SetStart(newTimedataGridView[2, i].Value.ToString());
                    point.NewEnd = newPoints[i].NewEnd;
                }
                else if (newTimedataGridView[3, i].Value != null)
                {
                    point.SetEnd(newTimedataGridView[3, i].Value.ToString());
                    point.NewStart = newPoints[i].NewStart;
                }
                else
                {
                    point.NewEnd = newPoints[i].NewEnd;
                    point.NewStart = newPoints[i].NewStart;
                }
                list.Add(point);


                myLastdataGrid[0, i].Value = newTimedataGridView[0, i].Value;
                myLastdataGrid[1, i].Value = newTimedataGridView[1, i].Value;

               
                if (list[i].NewStart.CompareTo(list[i].NewEnd) == 0) myLastdataGrid[2, i].Value = "круглосуточно";
                else
                {
                    myLastdataGrid[2, i].Value = list[i].NewStart.Hours < 10 ? $"0{list[i].NewStart.Hours}" : list[i].NewStart.Hours.ToString();
                    myLastdataGrid[2, i].Value += ":";
                    myLastdataGrid[2, i].Value += list[i].NewStart.Minutes < 10 ? $"0{list[i].NewStart.Minutes}" : list[i].NewStart.Minutes.ToString();
                    myLastdataGrid[2, i].Value += " - ";
                    myLastdataGrid[2, i].Value += list[i].NewEnd.Hours < 10 ? $"0{list[i].NewEnd.Hours}" : list[i].NewEnd.Hours.ToString();
                    myLastdataGrid[2, i].Value += ":";
                    myLastdataGrid[2, i].Value += list[i].NewEnd.Minutes < 10 ? $"0{list[i].NewEnd.Minutes}" : list[i].NewEnd.Minutes.ToString();


                }
            }



        }

        private void WriteTable2(StreamWriter stream)
        {
            for(var i = 0; i < myLastdataGrid.Rows.Count; i++)
            {
                stream.Write("| ");
                stream.Write(myLastdataGrid[0, i].Value.ToString().PadRight(30));
                stream.Write(" | ");
                stream.Write(myLastdataGrid[1, i].Value.ToString().PadRight(13));
                stream.Write(" | ");
                stream.Write(myLastdataGrid[2, i].Value.ToString().PadRight(13));
                stream.WriteLine(" |");
            }
        }
        private void Report2ToFile()
        {

            string tableHead = "+--------------------------------+---------------+---------------+\n" +
"| Название пункта                | Предложено    | Утверждено    |\n" +
"+--------------------------------+---------------+---------------+";
            FileInfo file = new FileInfo($"Отчет№{_report2Number}.txt");


            using (StreamWriter stream = file.CreateText())
            {
                stream.WriteLine(this.report2part1.Text);
                stream.WriteLine(tableHead);
                this.WriteTable2(stream);
                stream.WriteLine("+--------------------------------+---------------+---------------+");
                stream.WriteLine(this.report2part2.Text);
                stream.Close();
            }
            new ReportDataForm(file.FullName);
        }


        private void VoteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = 0;
                for (int i = 0; i < newPoints.Count; i++)
                {
                    if (newPoints[i].Point.Name == VotedataGridView[1, e.RowIndex].Value.ToString())
                    {
                        index = i;
                        break;
                    }
                }
         
               
                    List<Vote> pointVote = new List<Vote>();
                foreach(var it in votes)
                {
                    if (it.Point.Name == newPoints[index].Point.Name) pointVote.Add(it);
                }
              
                
                new VoteCountForm(pointVote, pointVote[0].Point.Name);
                
            }

        }
        

    }




}
