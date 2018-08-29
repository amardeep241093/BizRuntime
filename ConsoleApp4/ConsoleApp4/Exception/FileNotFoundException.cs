using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Exception2
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader(@"J:\file.txt");//exception occurs
                reader.ReadToEnd();
                Console.WriteLine(reader);
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                
            }
            Console.Read();
        }
    }
}
