using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.TaskParallel
{
    class TaskParallel
    {
        static void Main(string[] args)
        {
            List<int> countList = new List<int>() { 3, 4, 8, 10, 6 };

            Parallel.For(0, 10, i => Compute(i));

            Parallel.ForEach(countList, i => Compute(i));

            // Invokes the Operation parallel.
            Parallel.Invoke(
                () => Compute(10),
                () => Compute(5),
                () => Compute(10));

            Console.WriteLine("Parallelsim completed");
          
            Console.ReadLine();
        }

        /// Performs some operation.
       public static int Compute(int obj)
        {
            for (int i = 0; i < obj; i++)
            {
                Console.WriteLine("Thread executing " + i);
            }

            return 1000;
        }
    }
}
