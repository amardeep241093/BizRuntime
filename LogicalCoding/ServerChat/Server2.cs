using System;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace ServerNetworkingProgramming
{
    public class Server2
    {
        public static void Main()
        {
            try
            {
                bool status = true;
                string servermessage = "";
                string clientmessage = "";
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                TcpListener tcpListener = new TcpListener(ip, 8888);
                //IPAddress ip = IPAddress.Parse("127.0.0.1"); // ip address of string form is converted to instance
                //TcpListener tcp = new TcpListener(ip, 8888);
                tcpListener.Start();
                Console.WriteLine("Server Started");
                Socket socketForClient = tcpListener.AcceptSocket();
                Console.WriteLine("Client Connected");
                NetworkStream networkStream = new NetworkStream(socketForClient);
                StreamWriter streamwriter = new StreamWriter(networkStream);
                StreamReader streamreader = new StreamReader(networkStream);
                while (status)
                {
                    if (socketForClient.Connected)
                    {
                        servermessage = streamreader.ReadLine();
                        Console.WriteLine("Client:" + servermessage);
                        if ((servermessage == "bye"))
                        {
                            status = false;
                            streamreader.Close();
                            networkStream.Close();
                            streamwriter.Close();
                            return;
                        }
                        Console.Write("Server:");
                        clientmessage = Console.ReadLine();
                        streamwriter.WriteLine(clientmessage);
                        streamwriter.Flush();
                    }
                }
                streamreader.Close();
                networkStream.Close();
                streamwriter.Close();
                socketForClient.Close();
                Console.WriteLine("Exiting");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}