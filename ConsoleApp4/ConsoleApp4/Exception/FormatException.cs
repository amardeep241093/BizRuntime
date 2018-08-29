using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Exception7
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the age:");
                int age = int.Parse(Console.ReadLine());
                Exception8 ex = new Exception8(age);
            }

            catch (FormatException ex)
            {
                String error = ex.GetType().FullName;
                String path = @"J:\C#Exception\FormatException.txt";
                if (File.Exists(path))
                {
                    StreamWriter writer = new StreamWriter(path);
                    writer.Write(error);
                    writer.Close();
                }
               
                Console.WriteLine(ex);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.Read();
        }
    }

    class Exception8
    {
        public Exception8(int age) //arg constructor
        {
            int Age = age;
            if (Age > 30)
            {
                throw new AgeExceedException("Age should be less than 30");
            }
            else
            {
                Console.WriteLine("The age is:" + Age);
            }
        }
    }

    class AgeExceedException : ApplicationException //customException
    {
        public AgeExceedException(String Message) : base(Message)
        {

        }
    }
}

