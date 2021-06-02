using System;
using System.Net.Sockets;
using System.Text;



namespace регистрация
{
    public class Location
    {
        public int LocationId;
        public string Country;
        public string Region;
        public string District;

        public void Receive(Socket socket)
        {
            byte[] bytes = new byte[512];
            int size = socket.Receive(bytes);
            string[] data = Encoding.Unicode.GetString(bytes, 0, size).Split('\t');
            this.LocationId = Convert.ToInt32(data[0]);
            this.Country = data[1];
            this.Region = data[2];
            this.District = data[3];
            socket.Send(BitConverter.GetBytes(2));
        }

    }
    public class CustomsControlPoint
    {
        public int CustomsControlPointId;
        public string Name;
        public TimeSpan Start;
        public TimeSpan End;
        public readonly Location Location;

        public CustomsControlPoint() { this.Location = new Location(); }
        public void Receive(string str)
        {

            var data = str.Split('\t');
            CustomsControlPointId = Convert.ToInt32(data[0]);
            Name = data[1];
            Location.LocationId = Convert.ToInt32(data[2]);
            Location.Country = data[3];
            Location.Region = data[4];
            Location.District = data[5];
            Start = new TimeSpan(Convert.ToInt32(data[6]), Convert.ToInt32(data[7]), 0);
            End = new TimeSpan(Convert.ToInt32(data[8]), Convert.ToInt32(data[9]), 0);



        }
        public int Comparer(CustomsControlPoint alsoPoint)
        {
            return this.Name.CompareTo(alsoPoint.Name);
        }

        public void SetTime(string str)
        {
            if (str == "круглосуточно")
            {
                this.Start = new TimeSpan(0, 0, 0);
                this.End = new TimeSpan(0, 0, 0);
            }
            else
            {
                string[] data = { $"{str[0]}{str[1]}", $"{str[3]}{str[4]}", $"{str[8]}{str[9]}", $"{str[11]}{str[12]}", };
               
                this.Start = new TimeSpan(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), 0);
                this.End = new TimeSpan(Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), 0);
            }
        }
        public string GetData()
        {
            return  $"{CustomsControlPointId}\t{Start.Hours}\t{Start.Minutes}\t{End.Hours}\t{End.Minutes}\n";
        }
    }
    public class Vote
    {
        private int _voteId;
        public int Priority;
        public readonly User User;
        public readonly CustomsControlPoint Point;

        public Vote()
        {
            this.User = new User();
            this.Point = new CustomsControlPoint();
        }

        public void Receive(string data)
        {
            var myData = data.Split('\t');
            this._voteId = Convert.ToInt32(myData[0]);
            this.User.UserId = Convert.ToInt32(myData[1]);
            this.Priority = Convert.ToInt32(myData[2]);
            this.Point.CustomsControlPointId = Convert.ToInt32(myData[3]);
            this.Point.Name = myData[4];
        }


    }




    public class CustomControlPointNewTime
    {
        private int _customControlPointNewTimeId;

        public TimeSpan NewStart;
        public TimeSpan NewEnd;

        public readonly CustomsControlPoint Point;
        public double Percent;
        public int Position;
        public CustomControlPointNewTime() { Point = new CustomsControlPoint(); }



        public void Receive(string data)
        {
            
            var myData = data.Split('\t');
  
            this._customControlPointNewTimeId = Convert.ToInt32(myData[0]);
            this.NewStart = new TimeSpan(Convert.ToInt32(myData[1]), Convert.ToInt32(myData[2]), 0);
            this.NewEnd = new TimeSpan(Convert.ToInt32(myData[3]), Convert.ToInt32(myData[4]), 0);
            this.Point.CustomsControlPointId = Convert.ToInt32(myData[5]);
            this.Point.Name = myData[6];
            this.Point.Location.LocationId = Convert.ToInt32(myData[7]);
            this.Point.Location.Country = myData[8];
            this.Point.Location.Region = myData[9];
            this.Point.Location.District = myData[10];
            this.Point.Start = new TimeSpan(Convert.ToInt32(myData[11]), Convert.ToInt32(myData[12]), 0);
            this.Point.End = new TimeSpan(Convert.ToInt32(myData [13]), Convert.ToInt32(myData[14]), 0);
            this.Percent = Convert.ToDouble(myData[15]);
            this.Position = Convert.ToInt32(myData[16]);
        }


    }




    public class CustomControlPointTotalTime
    {
        public TimeSpan NewStart;
        public TimeSpan NewEnd;
        private CustomControlPointNewTime _point;
        public CustomControlPointTotalTime()
        {
            _point = new CustomControlPointNewTime();
        }

        public void SetStart(string str)
        {
            var data = str.Split(':');
            NewStart = new TimeSpan(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), 0);
        }
        public void SetEnd(string str)
        {
            var data = str.Split(':');
            NewEnd = new TimeSpan(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), 0);
        }

    }









}