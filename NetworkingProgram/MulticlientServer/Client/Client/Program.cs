using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace MultipleTypeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiple client
            int port = 1500;
            string IpAdress = "127.0.0.1";
            //creating an instance of socket
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAdress), port);

            //connecting to the server
            clientSocket.Connect(ep);
            Console.WriteLine("client connected");
            //Transmitting data
            while (true)
            {
                string MessageFromClient = null;
                Console.WriteLine("enter the message");
                MessageFromClient = Console.ReadLine();
                //sending encoding message to the server
                clientSocket.Send(System.Text.Encoding.ASCII.GetBytes(MessageFromClient), 0, MessageFromClient.Length, SocketFlags.None);

                //Getting msg in the form of byte from the server
                byte[] MsgFromServer = new byte[1024];
                int size = clientSocket.Receive(MsgFromServer);
                Console.WriteLine("server " + System.Text.Encoding.ASCII.GetString(MsgFromServer, 0, size));
            }
        }
    }
}