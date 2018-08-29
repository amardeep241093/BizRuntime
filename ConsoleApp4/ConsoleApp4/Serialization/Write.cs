using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Write
    {
        static void Main(string[] args)
        {
            String path = @"J:\C#Exception\Program.txt";
            if (File.Exists(path))
            {
                StreamWriter writer = new StreamWriter(path);
                Console.WriteLine("Enter the Statement");
                String str = Console.ReadLine();
                writer.Write(str);
            }
            
            Console.Read();


        }
    }
}
