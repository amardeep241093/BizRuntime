using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Time_Client
{
    class Program
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            Console.Title = "Client";
            LoopConnect();
            sendLoop();
            Console.ReadLine();
        }

        private static void sendLoop()
        {
            while (true)
            {
                Console.WriteLine("Enter request");
                String req = Console.ReadLine();
                byte[] buffer = Encoding.ASCII.GetBytes(req);
                _clientSocket.Send(buffer);

                byte[] receivedBuff = new byte[1024];
                int rec = _clientSocket.Receive(receivedBuff);
                byte[] data = new byte[rec];
                Array.Copy(receivedBuff, data, rec);
                Console.WriteLine("Recevied " + Encoding.ASCII.GetString(data));
            }
        }

        private static void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {
                    Console.Clear();
                    Console.WriteLine("Connection Attempts " + attempts.ToString());
                }
            }
            //Console.Clear();
            Console.WriteLine("Connected");
        }
    }
}
