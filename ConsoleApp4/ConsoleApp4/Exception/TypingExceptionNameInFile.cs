using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Exception4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the First Number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Second Number");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                String path = @"J:\C#Exception\FileNotFound.txt";
               // String path = @"J:\C#Exception\FileNotFound1.txt";
                if (File.Exists(path))
                {
                    StreamWriter writer = new StreamWriter(path);
                    writer.Write(ex.GetType().Name);
                    Console.WriteLine();
                    writer.Write(ex.Message);
                    writer.Close();
                    Console.WriteLine("There is a problem...try later");

                }
                else
                {
                    throw new System.IO.FileNotFoundException(path + "File Not Found" + ex); //explicitly throw an exception--intentionlly 
                }
           }

            Console.Read();
        }
      }
}
