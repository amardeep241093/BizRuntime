using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Client_Server
{
    class Program
    {
        //MAIN
        static void Main(string[] args)
        {
            Client c = new Client();
            c.initialize();
        }
    }

    class Client
    {
        Socket client;

        public Client()
        {
            client = new Socket(SocketType.Stream, ProtocolType.Tcp);
        }

        public void initialize()
        {
            Console.Title = "Client";
            int attempts = 0;
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, 9000);
            while (!client.Connected)
            {
                try
                {
                    ++attempts;
                    client.Connect(endpoint);
                    Console.WriteLine("Connection attempt #" + attempts);

                }
                catch (SocketException s)
                {
                    Console.WriteLine("Could not connect");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                byte[] toSend = toByte(input);
                client.Send(toSend);
            }

        }

        private byte[] toByte(string input)
        {
            throw new NotImplementedException();
        }
    }
}