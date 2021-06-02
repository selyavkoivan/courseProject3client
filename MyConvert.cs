using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace регистрация
{
    static class MyConvert
    {
        public static void SendDate(DateTime date, Socket socket)
        {
            var sendStr = date.Year.ToString() + "\t" + date.Month.ToString() + "\t" + date.Day.ToString();
            socket.Send(Encoding.Unicode.GetBytes(sendStr));
        }
        public static void SendDateId(int ID, DateTime date, Socket socket)
        {
            var sendStr = ID + "\t" + date.Year.ToString() + "\t" + date.Month.ToString() + "\t" + date.Day.ToString();
            socket.Send(Encoding.Unicode.GetBytes(sendStr));
        }
        public static DateTime GetDate(Socket socket)
        {

            var bytes = new byte[128];
            var size = socket.Receive(bytes);
            var receiveStr = Encoding.Unicode.GetString(bytes, 0, size);
            var strings = receiveStr.Split('\t');
            var date = new DateTime(Convert.ToInt32(strings[0]), Convert.ToInt32(strings[1]), Convert.ToInt32(strings[2]));
            return date;
        }
        public static TimeSpan[] GetTime(Socket socket)
        {

            byte[] bytes = new byte[128];
            int size = socket.Receive(bytes);
            string receiveStr = Encoding.Unicode.GetString(bytes, 0, size);
            string[] strings = receiveStr.Split('\t');

            TimeSpan start = new TimeSpan(Convert.ToInt32(strings[0]), Convert.ToInt32(strings[1]), 0);
            TimeSpan end = new TimeSpan(Convert.ToInt32(strings[2]), Convert.ToInt32(strings[3]), 0);
            TimeSpan[] time = { start, end };
            return time;
        }

        public static void SendTime(DateTime start, DateTime end, Socket socket)
        {
            string sendStr = start.Hour.ToString() + "\t" + start.Minute.ToString() + "\t" + end.Hour.ToString() + "\t" + end.Minute.ToString();
            MessageBox.Show(sendStr);
            socket.Send(Encoding.Unicode.GetBytes(sendStr));
        }

    }
}