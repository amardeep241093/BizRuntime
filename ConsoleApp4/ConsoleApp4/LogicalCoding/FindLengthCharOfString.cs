using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class FindLengthCharOfString
    {
           public static void Main(String[] args)
            {
              String path = @"J:\C#Exception\Program2.txt";
             StreamWriter writer = new StreamWriter(path);

             writer.WriteLine("My name is @Amardeep Kumar");
             writer.WriteLine("I am working in Bizruntime");
              writer.Close();

            StreamReader reader = new StreamReader(path);
            Console.WriteLine(File.ReadAllText(path));//read all the lines
            Console.WriteLine(path); // it ll display ur file on console
            Console.Write(path.Length); // No. of character
            Console.WriteLine();
            Console.WriteLine(path.Split('\r').Length);  // total line
            Console.WriteLine(path.Split(' ').Length); // total word
            Console.WriteLine(File.ReadAllBytes(path));

            Console.Read();

          }

        }
    }

