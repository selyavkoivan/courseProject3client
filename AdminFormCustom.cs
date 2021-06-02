using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace регистрация
{
    public partial class AdminWorkForm
    {
        private void customControlName_TextChanged(object sender, EventArgs e)
        {
            if (this.customControlName.ForeColor == SystemColors.AppWorkspace)
            {
                this.customControlName.Text = "";
                this.customControlName.ForeColor = SystemColors.Desktop;
            }

            if (this.customControlNameBorder.BackColor == Color.Red)
            {
                this.customControlNameBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORPointName.ForeColor = SystemColors.Control;
                this.ERRORPointName.Text = "данные не введены";
            }
            bool status = true;
            foreach (char it in this.customControlName.Text)
            {
                if (!char.IsLetter(it) && it.CompareTo(' ') != 0 && it.CompareTo('-') != 0)
                {
                    this.ERRORPointName.Text = "разрешены только буквы";
                    this.ERRORPointName.ForeColor = Color.Red;
                    this.customControlNameBorder.BackColor = Color.Red;
                    status = false;
                }
            }
            if (status)
            {
                this.ERRORPointName.ForeColor = SystemColors.Control;
                this.customControlNameBorder.BackColor = SystemColors.AppWorkspace;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.customControlName.ForeColor == SystemColors.AppWorkspace)
            {
                this.customControlNameBorder.BackColor = Color.Red;
                this.ERRORPointName.ForeColor = Color.Red;
                this.ERRORPointName.Text = "введите данные";
            }
            if (this.Country.Text == "" || this.Region.Text == "" || this.District.Text == "")
            {
                this.ERRORPlace.ForeColor = Color.Red;
            }
            if (this.ERRORPointName.ForeColor == Color.Red || this.ERRORPlace.ForeColor == Color.Red) return;
            this.socket.Send(Encoding.Unicode.GetBytes("sendControlPoints"));
            string str = this.customControlName.Text + "\t" + this.Country.Text + "\t" + this.Region.Text + "\t" + this.District.Text;
            str += "\t" + this.dateTimePickerStart.Value.Hour + "\t" + this.dateTimePickerStart.Value.Minute + "\t" + this.dateTimePickerEnd.Value.Hour + "\t" + this.dateTimePickerEnd.Value.Minute;
            this.socket.Send(Encoding.Unicode.GetBytes(str));
            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            if (BitConverter.ToInt32(bytes, 0) == 0)
            {

                this.LoatPointsTable();
                this.CustomClear();
                return;
            }
            else
            {
                this.ERRORPlace.Text = "расположение занято";
                this.ERRORPlace.ForeColor = Color.Red;
            }


        }
        void CustomClear()
        {
            if (this.Country.Items != null) this.Country.Items.Clear();
            if (this.Region.Items != null) this.Region.Items.Clear();
            if (this.District.Items != null) this.District.Items.Clear();
            this.customControlName.Text = " название";
            this.customControlName.ForeColor = SystemColors.AppWorkspace;
            this.customControlNameBorder.BackColor = SystemColors.AppWorkspace;
            this.ERRORPointName.ForeColor = SystemColors.Control;
            this.dateTimePickerStart.Value = this.dateTimePickerStart.MinDate;
            this.dateTimePickerEnd.Value = this.dateTimePickerEnd.MinDate;
        }
        void LoadPoint()
        {
            this.pointData.Text = this.points[this.pointNumber].Name + "\n\n";

            if (this.points[this.pointNumber].Start.CompareTo(this.points[this.pointNumber].End) == 0)
            {
                this.pointData.Text += "круглосуточно" + "\n\n";
            }
            else
            {
                if (this.points[this.pointNumber].Start.Hours < 10) this.pointData.Text += Convert.ToString(0);
                this.pointData.Text += Convert.ToString(this.points[this.pointNumber].Start.Hours) + ":";
                if (this.points[this.pointNumber].Start.Minutes < 10) this.pointData.Text += Convert.ToString(0);
                this.pointData.Text += Convert.ToString(this.points[this.pointNumber].Start.Minutes) + " - ";
                if (this.points[this.pointNumber].End.Hours < 10) pointData.Text += Convert.ToString(0);
                this.pointData.Text += Convert.ToString(this.points[this.pointNumber].End.Hours) + ":";
                if (this.points[this.pointNumber].End.Minutes < 10) pointData.Text += Convert.ToString(0);
                this.pointData.Text += Convert.ToString(this.points[this.pointNumber].End.Minutes) + "\n\n";
            }
            this.pointData.Text += this.points[this.pointNumber].Location.Country + "\n\n";
            this.pointData.Text += this.points[this.pointNumber].Location.Region + "\n\n";
            this.pointData.Text += this.points[this.pointNumber].Location.District + "\n\n";
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex != -1)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    if (points[i].Name == PointsDataGrid[0, e.RowIndex].Value.ToString())
                    {
                        this.pointNumber = i;
                        break;
                    }
                }
       
                this.MyDataTabPage.Hide();
                this.USERSTabPage.Hide();
                this.customsTabPage.Hide();
                this.pointDataTabPage.Show();
                this.LoadPoint();
            }
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            this.CustomClear();

            this.socket.Send(Encoding.Unicode.GetBytes("getControlPoints"));

            this.HideUserDataBox.BringToFront();
            this.USERSTabPage.Hide();
            this.customsTabPage.Show();
            this.MyDataTabPage.Hide();
            this.pointDataTabPage.Hide();
            this.VoteTabPage.Hide();
            this.voteMathTabPage.Hide();
            this.VoteMathButton.BackColor = Color.FromArgb(30, 30, 30);
            this.voteButton.BackColor = Color.FromArgb(30, 30, 30);
            this.usersBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.MyDataBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.customButton.BackColor = Color.FromArgb(70, 70, 70);




            this.LoatPointsTable();


        }
        void ReceiveLocations()
        {
            this.socket.Send(Encoding.Unicode.GetBytes("getLocations"));
            this.locations.Clear();

            byte[] bytes = new byte[64];
            this.socket.Receive(bytes);
            int count = BitConverter.ToInt32(bytes, 0);

            for (int i = 0; i < count; i++)
            {
                Location location = new Location();
                location.Receive(this.socket);
                this.locations.Add(location);
            }
        }
        void ReceivePoints()
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
        void FillPointTable()
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
        void LoatPointsTable()
        {

            this.ReceivePoints();
            if (this.points.Count != 0)
            {
                this.PointsDataGrid.RowCount = this.points.Count;
                this.FillPointTable();
            }
            else this.PointsDataGrid.RowCount = 0;

        }

        private void Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ERRORPlace.ForeColor == Color.Red) ERRORPlace.ForeColor = SystemColors.Control;
            this.Region.Items.Clear();
            if (this.locations[0].Country == this.Country.Text)
            {

                this.Region.Items.Add(this.locations[0].Region);
            }
            for (int i = 1; i < this.locations.Count; i++)
            {
                if (this.locations[i].Country == this.Country.Text)
                {

                    if (this.Region.Items.Count != 0 && this.locations[i].Region != this.locations[i - 1].Region)
                    {

                        this.Region.Items.Add(this.locations[i].Region);
                    }
                    else if (this.Region.Items.Count == 0) this.Region.Items.Add(this.locations[i].Region);

                }
            }

            if (this.Region.SelectedIndex >= 0)
            {
                this.District.Text = "";
                this.Region.Text = this.Region.SelectedItem.ToString();
            }
        }

      





        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ERRORPlace.ForeColor == Color.Red) ERRORPlace.ForeColor = SystemColors.Control;
            this.Country.Items.Clear();
            this.Country.Items.Add(this.locations[0].Country);
            for (int i = 1; i < this.locations.Count; i++)
            {
                if (this.locations[i].Country != this.locations[i - 1].Country)
                {
                    this.Country.Items.Add(this.locations[i].Country);
                }
            }
        }

        private void District_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ERRORPlace.ForeColor == Color.Red) ERRORPlace.ForeColor = SystemColors.Control;
            this.District.Items.Clear();

            for (int i = 0; i < this.locations.Count; i++)
            {
                if (this.locations[i].Country == this.Country.Text && this.locations[i].Region == this.Region.Text)
                {

                    this.District.Items.Add(this.locations[i].District);

                }
            }
        }

        private void Country_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (this.Country.SelectedIndex >= 0)
            {
                this.Region.Items.Clear();
                this.District.Items.Clear();
                this.Country.Text = this.Country.SelectedItem.ToString();
            }
        }

        private void Region_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (this.Region.SelectedIndex >= 0)
            {
                this.District.Items.Clear();
                this.Region.Text = this.Region.SelectedItem.ToString();
            }
        }

        private void District_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.District.SelectedIndex >= 0)
            {
                this.District.Text = this.District.SelectedItem.ToString();
            }
        }

        private void customControlName_Leave(object sender, EventArgs e)
        {
            if (this.customControlName.Text == "")
            {
                this.customControlName.Text = " название";
                this.customControlName.ForeColor = SystemColors.AppWorkspace;
                this.customControlNameBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORPointName.ForeColor = SystemColors.Control;
                this.ERRORPointName.Text = "данные не введены";
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            //areUsure form = new areUsure(this.socket);
            this.socket.Send(Encoding.Unicode.GetBytes("deletePoint"));
            this.socket.Send(BitConverter.GetBytes(this.points[this.pointNumber].CustomsControlPointId));
            this.USERSTabPage.Hide();
            this.customsTabPage.Show();
            this.MyDataTabPage.Hide();
            this.pointDataTabPage.Hide();
            this.LoatPointsTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CustomClear();
            this.customsTabPage.Show();
            this.MyDataTabPage.Hide();
            this.pointDataTabPage.Hide();
            this.USERSTabPage.Hide();
            this.socket.Send(Encoding.Unicode.GetBytes("getControlPoints"));
            this.LoatPointsTable();
        }

      

        private void newPointName_TextChanged(object sender, EventArgs e)
        {
            if (this.newPointName.ForeColor == SystemColors.AppWorkspace)
            {
                this.newPointName.Text = "";
                this.newPointName.ForeColor = SystemColors.Desktop;
            }
            if (this.newPointNameBorder.BackColor == Color.Red)
            {
                this.newPointNameBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORPointName.ForeColor = SystemColors.Control;
                this.ERRORPointName.Text = "данные не введены";
            }
            bool status = true;
            foreach (char it in this.newPointName.Text)
            {
                if (!char.IsLetter(it) && it.CompareTo(' ') != 0 && it.CompareTo('-') != 0)
                {
                    this.ERRORNewNamePoint.Text = "разрешены только буквы";
                    this.ERRORNewNamePoint.ForeColor = Color.Red;
                    this.newPointNameBorder.BackColor = Color.Red;
                    status = false;
                }
            }
            if (status)
            {
                this.ERRORNewNamePoint.ForeColor = SystemColors.Control;
                this.newPointNameBorder.BackColor = SystemColors.AppWorkspace;
            }
        }

        private void newNameButton_Click(object sender, EventArgs e)
        {
            if (this.newPointName.ForeColor == SystemColors.AppWorkspace)
            {
                this.newPointNameBorder.BackColor = Color.Red;
                this.ERRORNewNamePoint.ForeColor = Color.Red;
                this.ERRORNewNamePoint.Text = "введите данные";
            }
            if (this.ERRORNewNamePoint.ForeColor == Color.Red) return;
            this.socket.Send(Encoding.Unicode.GetBytes("sendNewPointName"));
            string str = this.points[this.pointNumber].CustomsControlPointId + "\t" + this.newPointName.Text;
            this.socket.Send(Encoding.Unicode.GetBytes(str));

            this.LoatPointsTable();

            this.LoadPoint();
        }

        private void newTimeButton_Click(object sender, EventArgs e)
        {
            this.socket.Send(Encoding.Unicode.GetBytes("sendNewPointTime"));
            string str = this.points[this.pointNumber].CustomsControlPointId + "\t" + this.dateTimePickerNewStart.Value.Hour + "\t" + this.dateTimePickerNewStart.Value.Minute + "\t" + this.dateTimePickerNewEnd.Value.Hour + "\t" + this.dateTimePickerNewEnd.Value.Minute;
            this.socket.Send(Encoding.Unicode.GetBytes(str));

            this.LoatPointsTable();

            this.LoadPoint();
        }

        private void newPointName_Leave(object sender, EventArgs e)
        {
            if (this.newPointName.Text == "")
            {
                this.newPointName.Text = " название";
                this.newPointName.ForeColor = SystemColors.AppWorkspace;
                this.newPointNameBorder.BackColor = SystemColors.AppWorkspace;
                this.ERRORNewNamePoint.ForeColor = SystemColors.Control;
                this.ERRORNewNamePoint.Text = "данные не введены";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            this.HideUserDataBox.BringToFront();
            this.USERSTabPage.Hide();
            this.customsTabPage.Hide();
            this.pointDataTabPage.Hide();
            this.MyDataTabPage.Hide();
            this.VoteTabPage.Show();
            this.voteMathTabPage.Hide();
            this.MyDataLoad();
            this.VoteMathButton.BackColor = Color.FromArgb(30, 30, 30);
            this.voteButton.BackColor = Color.FromArgb(70, 70, 70);
            this.usersBUTTON.BackColor = Color.FromArgb(30, 30, 30);
            this.customButton.BackColor = Color.FromArgb(30, 30, 30);
            this.MyDataBUTTON.BackColor = Color.FromArgb(30, 30, 30);


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

  
    }
}