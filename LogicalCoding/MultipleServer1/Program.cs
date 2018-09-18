using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int port = 8880;
            string IpAddress = "127.0.0.1";
            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAddress), port);
            ClientSocket.Connect(ep);
            Console.WriteLine("client is connected");
            while (true)
            {
                string messageFromClient = null;
                Console.WriteLine("Enter the message");
                messageFromClient = Console.ReadLine();
                ClientSocket.Send(System.Text.Encoding.ASCII.GetBytes(messageFromClient), 0, messageFromClient.Length, SocketFlags.None);
                byte[] msgFromServer = new byte[1024];
                int size = ClientSocket.Receive(msgFromServer);
                Console.WriteLine("server" + System.Text.Encoding.ASCII.GetString(msgFromServer, 0, size));

            }
        }
    }
}
