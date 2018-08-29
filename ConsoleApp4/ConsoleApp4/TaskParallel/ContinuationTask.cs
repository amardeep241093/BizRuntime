using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4.TaskParallel
{
    class ContinuationTask
    {
        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("DoWork is executing {0}:", id);
            Thread.Sleep(sleep);
            Console.WriteLine("DoWork completed:{0} ", id);
        }
        static void DoMoreWork(int id, int sleep)
        {
            Console.WriteLine("DoMoreWork is executing {0}:", id);
            Thread.Sleep(sleep);
            Console.WriteLine("DoMoreWork completed {0}:", id);
        }
        static void Main(string[] args)
        {

            //when the task is complete,it pass the task as an argument to ContinueWith invoke method
            Task t1 = Task.Run( () => DoWork(100, 3000)).ContinueWith((prev) => DoMoreWork(201, 2000)); //chaining of task
            Task t2 = Task.Run(() => DoWork(101, 6000)).ContinueWith((prev) => DoMoreWork(202, 4000));
            Task t3 = Task.Factory.StartNew(() => DoWork(103, 9000)).ContinueWith((prev) => DoMoreWork(203, 8000));
            Console.Read();
        }
    }
}
