using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Exception3
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            try
            {
               reader = new StreamReader(@"J:\file.txt");//exception occurs
                reader.ReadToEnd();
                Console.WriteLine(reader);
              
            }
            catch (FileNotFoundException ex) //most specific at the top
            {
                Console.WriteLine(ex);

            }
            catch (Exception ex) //most generic at the bottom
            {
                Console.WriteLine(ex);

            }
            finally //optional block //clean and free the resources during which it holding on program execution.
            {
                if (reader != null)
                {
                    reader.Close();
                }
                Console.WriteLine("Resources are released successfully");
            }
            Console.Read();
        }
    }
}

