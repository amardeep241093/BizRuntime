using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    //Test 
    class Server
    {

        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Server));

        static Dictionary<string, Manager> dSockets = new Dictionary<string, Manager>();
        static int i = 1;
        static Socket sck;
        static Socket acc;

        static void Connection()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234));
            sck.Listen(2);
        }

        static void Operation()
        {
            while (true)
            {
                // Accept the incoming request
                acc = sck.Accept();
                try
                {

                    byte[] Buf = new byte[255];
                    int rec = acc.Receive(Buf, 0, Buf.Length, 0);
                    Array.Resize(ref Buf, rec);
                    string dis = Encoding.Default.GetString(Buf);
                    Console.WriteLine(dis + " Joined.....");
                    byte[] send = Encoding.Default.GetBytes(dis);
                    acc.Send(send, 0, send.Length, 0);
                    byte[] Buf1 = new byte[255];
                    int rec1 = acc.Receive(Buf1, 0, Buf1.Length, 0);
                    Array.Resize(ref Buf1, rec1);
                    string dis1 = Encoding.Default.GetString(Buf1);

                    Manager mtch = new Manager(acc, dis, dis1, dSockets);
                    dSockets.Add(dis, mtch);

                    Thread t = new Thread(mtch.Run);
                    Thread t1 = new Thread(mtch.Send);
                    t.Start();
                    t1.Start();
                    i++;
                }
                catch (Exception ex)
                {
                    // log.Error("Hello");
                    Console.WriteLine("Exception" + ex);
                }
            }
        }

        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            Console.WriteLine("WelCome To Chat Server");
            Connection();
            Operation();

        }

    }

    class Manager
    {


        private string name;
        Socket s;
        bool isloggedin;
        string[] strr;
        string a;
        static Manager kk;
        Dictionary<string, Manager> dSockets;


        public Manager(Socket s, string name, string con, Dictionary<string, Manager> ch)
        {

            this.name = name;
            this.s = s;
            this.isloggedin = true;
            dSockets = ch;
            this.a = con;
        }

        public void Run()
        {
            string received;
            while (true)
            {
                try
                {
                    byte[] Buffer = new byte[255];
                    int rec = s.Receive(Buffer, 0, Buffer.Length, 0);
                    Array.Resize(ref Buffer, rec);
                    received = Encoding.Default.GetString(Buffer);

                    Console.WriteLine(received);
                    string[] st = received.Split('#');
                    string recipient = st[0];
                    string MsgToSend = st[1];

                    if (MsgToSend.Equals("logout"))
                    {
                        dSockets.Remove(recipient);
                        this.isloggedin = false;
                        this.s.Close();
                        break;
                    }



                    if ((a.ToUpper()).Equals("ALL"))
                    {
                        foreach (KeyValuePair<string, Manager> val in dSockets)
                        {
                            Manager mc = (Manager)val.Value;


                            if (mc.isloggedin == true)
                            {
                                byte[] sData = Encoding.Default.GetBytes(this.name + " : " + MsgToSend);
                                mc.s.Send(sData, 0, sData.Length, 0);
                            }

                        }
                    }
                    else if ((a.ToUpper()).Equals("NONE")) { }
                    else if ((a.ToUpper()).Equals("SELF"))
                    {

                        foreach (KeyValuePair<string, Manager> val in dSockets)
                        {
                            Manager mc = (Manager)val.Value;


                            if ((mc.name.Equals(recipient)) && mc.isloggedin == true)
                            {
                                byte[] sData = Encoding.Default.GetBytes(this.name + " : " + MsgToSend);
                                mc.s.Send(sData, 0, sData.Length, 0);
                            }

                        }

                    }
                    else if ((a.ToUpper()).Equals("EXCEPTME"))
                    {

                        foreach (KeyValuePair<string, Manager> val in dSockets)
                        {
                            Manager mc = (Manager)val.Value;


                            if (!(mc.name.Equals(recipient)) && mc.isloggedin == true)
                            {
                                byte[] sData = Encoding.Default.GetBytes(this.name + " : " + MsgToSend);
                                mc.s.Send(sData, 0, sData.Length, 0);
                            }

                        }
                    }


                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }

        public void Send()
        {
            if (s != null)
            {
                while (true)
                {
                    string msg = Console.ReadLine();
                    foreach (KeyValuePair<string, Manager> val in dSockets)
                    {
                        Manager mc = (Manager)val.Value;
                        byte[] sData = Encoding.Default.GetBytes("Server : " + msg);
                        mc.s.Send(sData, 0, sData.Length, 0);
                    }
                }
            }
        }
    }
}