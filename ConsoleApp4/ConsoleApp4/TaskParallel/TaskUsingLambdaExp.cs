using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4.TaskParallel
{
    class TaskUsingLambdaExp
    {
       static void DoWork(int id, int sleep )
        {
            Console.WriteLine("Task {0} is beginning:", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed:", id);
        }
    
        static void Main(string[] args)
        {
            //lambda operator internally calling the DoWork Method
            //Task t1 = new Task(() => DoWork(101, 2000));
            //t1.Start();
            //Task t2 = new Task(() => DoWork(102, 4000));
            //t2.Start();
            //Task t3 = new Task(() => DoWork(103, 6000));
            //t3.Start();

            //Task t1 = Task.Factory.StartNew(() => DoWork(101, 2000));
            //Task t2 = Task.Factory.StartNew(() => DoWork(102, 4000));
            //Task t3 = Task.Factory.StartNew(() => DoWork(103, 8000));

            Task t1 = Task.Run(() => DoWork(101, 2000));
            Task t2 = Task.Run(() => DoWork(102, 4000));
            Task t3 = Task.Run(() => DoWork(103, 8000));
            Console.Read();
        }
    }
}

/*
 * Task.Factory.StartNew()--> it start the task immideitly after creating the instance of task.Doesnot need to start the task in separately.
 * */