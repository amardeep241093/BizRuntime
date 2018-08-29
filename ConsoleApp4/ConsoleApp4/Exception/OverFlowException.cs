using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class OverFlowException
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the first no.");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Second no.");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
            }

            catch (System.DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.StackTrace);
                Console.WriteLine();
                Console.WriteLine(ex1);
            }
            catch (System.FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            /*   catch(OverflowException ex4)
               {
                   Console.WriteLine(ex4.StackTrace);
               } 
               catch(ArrayTypeMismatchException ex3)
               {
                   Console.WriteLine(ex3.Message );
               }
               */
            catch (Exception ex)
            {
                String path = @"J:\C#Exception\FileNotFound.txt";
                // String path = @"J:\C#Exception\FileNotFound1.txt";
                if (File.Exists(path)) //check whether file is exist or not
                {
                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine(ex.GetType().Name);//get the type of exception name
                    Console.WriteLine();
                    writer.Write(ex.Message);
                    writer.Close();
                    Console.WriteLine("There is a problem...try later");

                }
                else
                {
                    throw new System.IO.FileNotFoundException(path + "file not present" + ex); //inner exception
                }
            }
      
            Console.Read();
        }
    }
}
