using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace ConsoleApp4.Network_Programming
{//main purpose: taking html web pages from internet and writing to the network//Here we make poor's man web browser
    class ReadingFromInternet
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the name of the server"); //user will give the name of the server
                String server = Console.ReadLine();
                TcpClient client = new TcpClient(server, 80);//establishing the connection 80-is a web port (http)
          
               StreamReader reader = new StreamReader(client.GetStream()); //reading from network connection
               StreamWriter writer = new StreamWriter(client.GetStream()); //writing to the network

               //requesting default web pages from the server
               writer.WriteLine("GET/ HTTP/1.0\n\n");
               writer.Flush();

               String data = reader.ReadLine();
               while(data != null)
              {

                Console.WriteLine(data);
                data = reader.ReadLine(); //reading more data in a loop
              }
              client.Close();
             }
            catch (Exception ex)
            {

            }
            Console.Read();
        }
    }
}