using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class Program1
    {
        static void Main(string[] args)
        {
            StringWriter writer = new StringWriter();
            writer.WriteLine("Welcome to Bizruntime");
            writer.Close();


            StringReader reader = new StringReader(writer.ToString());
            while(reader.Peek() < -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
            Console.Read();
        }

       
    }
}
