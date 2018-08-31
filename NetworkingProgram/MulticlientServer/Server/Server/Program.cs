using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int port = 1500;
            string IpAdress = "127.0.0.1";

            //initialize socketListener for client connection
            Socket ServerListner = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAdress), port);

            //Binding the listener with localEndPoint
            ServerListner.Bind(ep);
            ServerListner.Listen(100);
            Console.WriteLine("Server is listining");
            Socket clientSocket = default(Socket);
   
            int counter = 0;
            Program p = new Program();
            //if the client exist
            while (true)
            {
                counter++;
                clientSocket = ServerListner.Accept();
                Console.WriteLine(counter + " client connected");
                Thread UserThread = new Thread(new ThreadStart(() => p.User(clientSocket)));
                UserThread.Start();
            }
        }

        //recieving msg from diff. client in the form of byte and read it
        public void User(Socket client)
        {
            while (true)
            {
                byte[] msg = new byte[1024];
                int size = client.Receive(msg);
                client.Send(msg, 0, size, SocketFlags.None);
            }
        }
    }
}