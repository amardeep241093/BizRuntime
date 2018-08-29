using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4.TaskParallel
{
    class TaskOnArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            /* for(int i = 0; i < 10; i++)
             {
                 Console.WriteLine(arr[i]);
                 Thread.Sleep(2000);
             }
             */
            Parallel.For(0, 10, i =>
             {
                 Console.WriteLine(arr[i]);
                 Thread.Sleep(2000);
             });
            Console.Read();
        }
    }
}
