using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ThreadingDelegate
    {
        static void test()//no-arg constructor
        {
            for (int i = 1; i < 100; i++)
            {

                Console.WriteLine(i);
            }
        }
        static void test(object max)//arg constructor
        {
            int num = Convert.ToInt16(max);
            for (int i = 1; i <= num; i++)
            {

                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            
            //Thread t = new Thread(test);//internally CLR is creating the instance of delegate ThreadStart and passing the delegate parameter 

            //ThreadStart obj = new ThreadStart(test); //explicitly we are creating the instance of delegate ThreadStart and passing the parametr
            //Thread t1 = new Thread(obj);//initiating the delegate -binding the method with the delegate
            //t1.Start();

            // ThreadStart obj = test;//dirctly initialising the method name

            // ThreadStart obj = delegate () { test(); };//Anonymoues method


            ThreadStart obj = () => test();//Lambda Expression
            Thread t = new Thread(obj);
            t.Start();//no constructor will take the method name as a parametre directly

            ParameterizedThreadStart obj1 = new ParameterizedThreadStart(test);//arg delegate
            Thread t1 = new Thread(obj1);
            t1.Start(100);//start is a overloaded method

            Console.Read();
        }
    }
}
