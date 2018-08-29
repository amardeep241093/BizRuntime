using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ConsoleApp4
{
    class SingleThreading1
    {
        static void Main(string[] args)
        {//thread is a class in which current thread is a static property
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread"; //thread does not have any name so we set the name of the running thread
            Console.WriteLine("current running thread:" + Thread.CurrentThread.Name);//explicitly provide thread name
            test1();
            test2();
            test3();
            Console.Read();
        }

            static void test1() //Drawback: executing completed one after one in single threaded Model
            {
                for(int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
            }

        static void test2()//after complete excution of method1, then it will start to execute
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 50)
                {
                    Console.WriteLine("threaded sleep for 5sec:");
                    Thread.Sleep(5000);//it will sleep for 5 sec,then it will again start execting
                    Console.WriteLine("threaded woke up after 5 sec:");
                }
            }
        }

           static void test3()
            {
                for (int i = 0; i < 100; i++) //after complete excution of method2, then it will start to execute
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

