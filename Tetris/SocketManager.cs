using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace Tetris
{
    class SocketManager
    {
        private Socket client;
        IPEndPoint IPE;

        ListView lstMess;
        TextBox txtMess;

        public bool isConnect;
        public bool isSever;

        public string IP = "127.0.0.1";
        public int PORT = 9999;

        public SocketManager(ListView lst, TextBox txt)
        {
            lstMess = lst;
            txtMess = txt;
        }


        public bool ConnectSever()
        {
            try
            {
                IPE = new IPEndPoint(IPAddress.Parse(IP), PORT);
                //MessageBox.Show("Created IP");
            }
            catch
            {
                MessageBox.Show("IP không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IPE);
                isSever = false;
                //MessageBox.Show("Connecting");
                AddMess("Connected to Sever");
                //SocketData data = new SocketData(SocketCommand.MESSAGE, "Client connected", Keys.None);
                //client.Send(Serialize(data));
                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
                isConnect = true;
                return true;
            }
            catch
            {
                return false;
            }
        }

        Socket Sever;

        public void CreateSever()
        {
            //IPHostEntry host = Dns.GetHostEntry("localhost");
            //IPAddress ipAddress = host.AddressList[0];
            //IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
            //Socket Sever = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            //Sever.Bind(localEndPoint);

            IPEndPoint IPE = new IPEndPoint(IPAddress.Any, PORT);
            Sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Sever.Bind(IPE);

            isConnect = true;
            isSever = true;

            Thread listen = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        Thread.Sleep(500);
                        Sever.Listen(10);
                        client = Sever.Accept();


                        AddMess("Client connected");
                        //MessageBox.Show("Client connected");
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start();
                        ConnectEvent();
                        break;
                    }
                    catch
                    {

                    }
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        public void Close()
        {
            isConnect = false;
            if (isSever)
                Sever.Close();
            else client.Close();
        }


        public bool Send(SocketData mess)
        {
            if (!isConnect)
                return false;
            try
            {
                if (mess.Command == SocketCommand.MESSAGE)
                    AddMess(mess.Mess);
                client.Send(Serialize(mess));
                //MessageBox.Show("Sent");
                return true;
            }
            catch
            {
                isConnect = false;
                Disconnected();
                client.Close();
                MessageBox.Show("DISCONNETED!!!");
                return false;
            }
        }

        void ConnectEvent()
        {
            if (connected != null)
            {
                connected(this, new EventArgs());
            }
        }

        private event EventHandler connected;
        public event EventHandler Connected
        {
            add
            {
                connected += value;
            }
            remove
            {
                connected -= value;
            }
        }

        void Disconnected()
        {
            if (disconnect != null)
            {
                disconnect(this, new EventArgs());
            }
        }

        private event EventHandler disconnect;
        public event EventHandler Disconnect
        {
            add
            {
                disconnect += value;
            }
            remove
            {
                disconnect -= value;
            }
        }

        public void Receive()
        {
            byte[] data = new byte[1024 * 50];
            while (true)
            {
                try
                {
                    if (!isConnect)
                        break;
                    Thread.Sleep(50);

                    client.Receive(data);

                    SocketData Message = (SocketData)Deserialize(data);

                    OnMessage(Message.Command, Message.Mess, Message.Board, Message.A);

                    //this.data = Message;

                    if (Message.Command == SocketCommand.MESSAGE)
                        AddMess(Message.Mess);


                }
                catch
                {

                }
            }

        }

        private event EventHandler<SocketDataEvent> MessageFromPlayer;
        public event EventHandler<SocketDataEvent> messageFromPlayer
        {
            add
            {
                MessageFromPlayer += value;
            }
            remove
            {
                messageFromPlayer -= value;
            }
        }

        private void OnMessage(SocketCommand command, string Message, int[,] board, Point[] a)
        {
            if (MessageFromPlayer != null)
                MessageFromPlayer(this, new SocketDataEvent(command, Message, board, a));
        }

        public void AddMess(string Mess)
        {
            lstMess.Items.Add(new ListViewItem() { Text = Mess });
            if (lstMess.Items.Count > 4)
                lstMess.Items[0].Remove();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream memory = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memory, obj);

            return memory.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream memory = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(memory);
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        //public string GetLocalIPv4()
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;

            //var host = Dns.GetHostEntry(Dns.GetHostName());
            //foreach (var ip in host.AddressList)
            //{
            //    if (ip.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        return ip.ToString();
            //    }
            //}
            //return "";

            //IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            //IPAddress ipAddr = ipHost.AddressList[0];
            //return ipAddr.ToString();

            //String address = "";
            //WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            //using (WebResponse response = request.GetResponse())
            //using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            //{
            //    address = stream.ReadToEnd();
            //}

            //int first = address.IndexOf("Address: ") + 9;
            //int last = address.LastIndexOf("</body>");
            //address = address.Substring(first, last - first);

            //return address;
        }

        //string getIP()
        //{
        //    IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        //    IPAddress ipAddr = ipHost.AddressList[0];
        //    return ipAddr.ToString();
        //}
    }
    public class SocketDataEvent : EventArgs
    {
        SocketCommand command;
        int[,] board;
        Point[] a;
        string mess;
        public SocketDataEvent(SocketCommand command, string Message, int[,] board, Point[] a)
        {
            this.Command = command;
            mess = Message;
            this.board = board;
            this.A = a;
        }

        public string Mess { get => mess; set => mess = value; }
        public SocketCommand Command { get => command; set => command = value; }
        public int[,] Board { get => board; set => board = value; }
        public Point[] A { get => a; set => a = value; }
    }
}
