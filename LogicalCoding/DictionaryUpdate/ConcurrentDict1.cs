using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace basics
{
    class ConcurrentDict1
    {
        static void Main(string[] args)
        {
            var i = 1;
            string str;
            ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();
            Console.WriteLine("Enter how many values you want to add in the list ");
            int count = Convert.ToInt32(Console.ReadLine());
            int start = 1;
            try
            {


                for ( start = 1; start <= count; start++)
                {
                    Console.WriteLine("enter the key (int):");
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value(string)");
                    str = Console.ReadLine();

                    Added(i, str);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            void Added(int a, string s)
            {
                try
                {
                    dictionary.AddOrUpdate(a, s, (id, text) => str);
                }
                finally
                {
                    Console.WriteLine("updated to the list");
                }
            }

            Console.WriteLine(dictionary.Count);
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.Read();

        }

    }
}