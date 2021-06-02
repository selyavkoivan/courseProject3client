using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace клиент_многопоточность
{
    static class Program
    {
        private const int Port = 6722;


        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);




            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(ipPoint);


                Application.Run(new регистрация.AuthForm(socket));
            }
            catch (Exception ex)
            {
                Application.Run(new регистрация.NoServerForm());
            }
            finally
            {

                if (socket != null) socket.Close();
            }
        }


    }
}


namespace регистрация
{
    public class User
    {

        public int UserId;
        public string Login;
        public string Password;
        public string Surname;
        public string Name;
        public string Patronymic;
        public DateTime Birthday;

        public User()
        {
            

        }
        public User(Socket socket, int userId)
        {


 
            this.UserId = userId;
            byte[] bytes = new byte[1024];
            int size = socket.Receive(bytes);
            string str = Encoding.Unicode.GetString(bytes, 0, size);
            string[] strings = str.Split('\t');
            this.Login = strings[0];
            this.Password = strings[1];
            this.Surname = strings[2];
            this.Name = strings[3];
            if (strings.Length == 5)
            {

                this.Patronymic = strings[4];
            }
            else this.Patronymic = null;

            this.Birthday = MyConvert.GetDate(socket);
        }

        public void ReceiveFulLData(ref Socket socket)
        {
            var data = new byte[128];

            var bytes = socket.Receive(data);
            var fullName = Encoding.Unicode.GetString(data, 0, bytes);
            
            var strings = fullName.Split('\t');
            this.UserId = Convert.ToInt32(strings[0]);
            this.Login = strings[1];
            this.Password = strings[2];
            this.Surname = strings[3];
            this.Name = strings[4];
            if (strings.Length > 5) this.Patronymic = strings[5];
            else this.Patronymic = null;
            socket.Send(BitConverter.GetBytes(0));
            this.Birthday = MyConvert.GetDate(socket);
            socket.Send(BitConverter.GetBytes(0));

        }
    }

    class Admin
    {
        private int _adminId;
        public readonly string Position;
        public readonly User User;
        public Admin() { }
        public Admin(Socket socket, int adminId, int userId)
        {
           
            
            this.User = new User();

            this._adminId = adminId;
            this.User.UserId = userId;
            byte[] bytes = new byte[1024];
            int size = socket.Receive(bytes);
            string str = Encoding.Unicode.GetString(bytes, 0, size);
            string[] strings = str.Split('\t');
            this.Position = strings[0];
            this.User.UserId = Convert.ToInt32(strings[1]);
            this.User.Login = strings[2];
            this.User.Password = strings[3];
            this.User.Surname= strings[4];
            this.User.Name= strings[5];
            if (strings.Length == 7)
            {

                this.User.Patronymic = strings[6];
            }
            else this.User.Patronymic = null;

            this.User.Birthday = MyConvert.GetDate(socket);
        }
    }
}