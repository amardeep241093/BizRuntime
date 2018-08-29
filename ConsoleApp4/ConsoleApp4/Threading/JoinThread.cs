using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //Main thread initially start to execute the program bt it exit in the middle of the program 
    //and give control to the child thread---> Normally happen

    //Join-->Main thread initially start to execute the program and it exit in the end of the program 
    
    class JoinThread
    {
        static void test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 50)
                {
                    Console.WriteLine("threaded sleep for 5sec:");
                    Thread.Sleep(5000);
                    Console.WriteLine("threaded woke up after 5 sec:");
                }
            }
        }

            static void test3()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            Thread t1 = new Thread(test1);//thread created for 1st method
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);
            t1.Start(); 
            t2.Start();
            t3.Start();
            t1.Join(3000); //Main thread will wait for 3s,if in the mean time, thread1 will not exit then main thread will exit from the program.
            t2.Join();//Main thread start and main thread exit last
            t3.Join();

            Console.WriteLine("Main Thread exiting");
            Console.Read();
        }

        }
    }

