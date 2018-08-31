using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace ConsoleApp4.Network_Programming
{
    class WebServer
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(1302); //listen for connenction request from client
            listener.Start();

            while(true)
            {
                Console.WriteLine("waiting for a connection");
                TcpClient client = listener.AcceptTcpClient(); //server will wait for the client to connect
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                try
                {
                    //client request
                    String request = reader.ReadLine();
                    Console.WriteLine(request);
                    String[] tokens = request.Split(' ');
                    String page = tokens[1];
                    if( page == "/")
                    {
                        Console.WriteLine("/default page");
                    }
                    //find the file
                    StreamReader file = new StreamReader("../../web" + page);
                    writer.WriteLine("HTTP/1.0 200 OK\n");//responding to the web pages

                    //sending the file
                    String data = file.ReadLine();
                    while(data != null)
                    {
                        writer.WriteLine(data); //writing to the client
                        writer.Flush();
                    }
                    
                }
                catch(Exception ex)
                {
                    //error
                    writer.WriteLine("HTTP/1.0 200 OK\n");
                    Console.WriteLine("Sorry ! we coouldn't find your file");
                    writer.Flush();
                }
                client.Close();
            }
            Console.ReadLine();
        }
    }
}
