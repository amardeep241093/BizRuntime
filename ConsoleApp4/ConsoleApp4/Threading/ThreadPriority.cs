using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ThreadPriority
    {
        static int count1, count2;
        private static System.Threading.ThreadPriority lowest;
        private static System.Threading.ThreadPriority highest;

        public static void Increment()
        {
            while(true) //infiniite loop
            {
                count1 += 1;
            }
        }
        public static void Increment1()
        {
            while (true)
            {
                count1 += 1;
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Increment);//life cycle of thread started when instance of thread is created.
            Thread t2 = new Thread(Increment1);
            t1.Priority = ThreadPriority.lowest;
            t2.Priority = ThreadPriority.highest;//it will consumes more CPU resources

            t1.Start();
            t2.Start();

            Console.WriteLine("Main thread Sleep:");
            Thread.Sleep(10000);
            Console.WriteLine("Main Thread woke up");

            t1.Abort();//it will terminate the program
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("count1" + count1); //excuting at normal priority so,which count will be more we dont know
            Console.WriteLine("count2" + count2);

            Console.Read();

        }

    }
}
