using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class KeyValue
    {
        static void Main(string[] args)
        {
            String str1;
            Object obj1;
          

            Console.WriteLine("Enter the key and value:");
            String str= Console.ReadLine();
            Object obj = Console.ReadLine();
            Console.WriteLine(str +"," + obj);
            Console.Read();
        }
    }
}
