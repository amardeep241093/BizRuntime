using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CheckedAndUncheckedException
    {
        static void Main(string[] args)
        {
            /* //checked without using checked keyword
             int value = int.MaxValue;
             Console.WriteLine(value + 2); //we adding 2 to the max vlue of integer,bt we are not getting overflow exception.
             Console.Read();
             */

            // explictily throw the exception and terminate the program - checking only integral value expression
            checked 
            {
                int value = int.MaxValue;//largest value
                Console.WriteLine(value + 2);
                Console.Read();
            }


            //The Unchecked keyword ignores the integral type arithmetic exceptions. 
            //It does not check explicitly and produce result that may be truncated or wrong.
            unchecked
            {
                int value = int.MaxValue;
                Console.WriteLine(value + 2);
                Console.Read();
            }
        }
    }
}
