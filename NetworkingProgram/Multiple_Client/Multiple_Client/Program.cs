using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiple_Client
{
    class Program
    {
        //MAIN
        static void Main(string[] args)
        {
            Server s = new Server();
            s.initialize();
        }
    }

    class Server
    {
        private static int numThreads = 0;
        private byte[] readBuffer = new byte[1024];
        private Socket server;
        private Socket client;

        public Server()
        {
            server = new Socket(SocketType.Stream, ProtocolType.Tcp);
        }

        public void initialize()
        {

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 9000);
            server.Bind(endpoint);
            Console.Title = "Server";
            while (true)
            {
                server.Listen(1);
                client = server.Accept();
                Thread randomClient = new Thread(readFromSocket);
                randomClient.Name = "Thread #" + numThreads;
                randomClient.Start();
                ++numThreads;
            }
        }

        public void readFromSocket()
        {
            while (true)
            {
                try
                {
                    int amount = client.Receive(readBuffer);
                    if (amount > 0)
                    {
                        string toPrint = byteToString(readBuffer);
                        toPrint = toPrint.Replace("\0", string.Empty);
                        Console.WriteLine(toPrint);
                        Array.Clear(readBuffer, 0, readBuffer.Length);
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (SocketException e)
                {
                    Console.WriteLine("Reading was unsuccessful");
                    Console.WriteLine(e.Message);
                    Console.Read();
                }
            }
        }

        private string byteToString(byte[] readBuffer)
        {
            throw new NotImplementedException();
        }
    }
}
