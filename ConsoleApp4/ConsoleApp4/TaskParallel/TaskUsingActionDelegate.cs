using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4.TaskParallel
{
    class TaskUsingActionDelegate
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.Name = "Main";
            //// Create a task and supply a user delegate by using a lambda expression.
            //Task t = new Task( () => Console.WriteLine("Task is completed"));
            ////start the task
            //t.Start();

            //Console.WriteLine(Thread.CurrentThread.Name);
            //Console.WriteLine("Main is existing");
            ////Main will not exit till the task is complete
            //t.Wait();
            //Console.Read();

            Thread.CurrentThread.Name = "Main";

            Task t = Task.Run(() => Console.WriteLine("Task is completed"));

            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine("Main is existing");
            t.Wait();
            Console.Read();
        }


    }
}
