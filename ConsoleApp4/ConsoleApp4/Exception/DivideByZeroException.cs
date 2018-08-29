using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DivideByZeroException
    {
        static void Main(string[] args)
        {
            
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
               
            }
            catch(System.DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);   
            }
            Console.Read();
     }
    }
}
