using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp4
{//to overcome the problem of single threaded model,Multithreading came which perform multiple task simultaneously
    class MultiThreading
    {
        static void test1()//sleep() will not affect on this
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread1 is exiting");
        }
       

        static void test2()//sleep() method will affect only on method2
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
                if( i == 50)
                {
                    Console.WriteLine("threaded sleep for 5sec:");
                    //3. not runnable state,when the sleep() or wait() called
                    Thread.Sleep(15000);//it will sleep for 5 sec,Sleep() method is a static so we call it by class name which is present in Thread class
                    Console.WriteLine("threaded woke up after 5 sec:");
                }
                Console.WriteLine("Thread2 is exiting");
            }
        }

        static void test3() //sleep() will not affect on this
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread3 is exiting");
        }

        static void Main(string[] args)//Main method will execute 
        {//total 4 threads are there: 1 main thread and 3 child thread created by main thread
            //Main thread initial start to execute the program it exit in the middle of the program and give control to the child thread
            Thread t1 = new Thread(test1);//thread created for 1st method
            //1.it is in unstarted state,when the instance of thread class is created
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);
            t1.Start(); //only 1st thread will start executing
            //2. it is in runnable state when the start method is cllled on thread
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread is exiting");//4.Dead state
            Console.Read();
        }

    }

}
/*
 * //gives equal priority to each thread which is controlled by OS
 * //time sharing-gives equal timing to each thread
 * random output
 */
