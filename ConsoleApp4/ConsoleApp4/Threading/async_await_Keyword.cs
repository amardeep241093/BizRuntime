using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //they are code marker which mark the code positions from where the controller should resume after a task or a thread completes.
    //Always use in a pair
    class async_await_Keyword
    {
        
        public static async void Method()
        {
           await Task.Run(new Action(Longtask));//wait until long task completes
            Console.WriteLine("New thread");

        }

        public static void Longtask()
        {
            Thread.Sleep(10000);//sleep
            
        }

        static void Main(string[] args)//controller return to the caller of the async method
        {
            Method();
            Console.WriteLine("Main thread");//exceuting this line in the mean time of waiting
            Console.Read();
        
        }
    }
}

