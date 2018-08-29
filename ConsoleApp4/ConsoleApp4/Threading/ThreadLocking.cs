using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ThreadLocking
    {
        /*
        public void test()
        {
            Console.Write("BiZRuntime is a");
            Thread.Sleep(3000);//suspend the current thread for specied period of time
            Console.WriteLine("Software company");
        }
        */
        public void test()
        {
            lock (this) //it lock the code--it will not allow the multiple thread to excute at a time
            {
                //2nd thread will not enter till 1st thread complete the task
                Console.Write("BiZRuntime is a");
                Thread.Sleep(3000);//suspend the current thread for specied period of time
                Console.WriteLine(" Software company");
            }
        }
        static void Main(string[] args)
        {
            ThreadLocking tl = new ThreadLocking();
            /*  tl.test();
                tl.test(); //single threaded model where main thread alone excuting all the method
                tl.test();
              */
            /*
                  Thread t1 = new Thread(tl.test); //multithreading
                  Thread t2= new Thread(tl.test);
                  Thread t3 = new Thread(tl.test);
                  t1.Start(); //1st thread will excute and sleep for 3s
                  t2.Start(); //next it will excute and go for sleep for 3s
                  t3.Start(); //lastly it will excute and sleep for 3s....after 3s thread 1, 2 3 will woke up and excute the remaining th code
              */
            Thread t1 = new Thread(tl.test);
            Thread t2 = new Thread(tl.test);
            Thread t3 = new Thread(tl.test);
            t1.Start(); //1st thread will excute and sleep for 3s
            t2.Start(); //next it will excute and go for sleep for 3s
            t3.Start(); //lastly it will exc
            Console.Read();
              }
          }
      }
