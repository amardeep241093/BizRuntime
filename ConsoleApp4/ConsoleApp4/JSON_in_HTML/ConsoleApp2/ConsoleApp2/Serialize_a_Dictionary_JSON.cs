using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToCsObject
{
    class Serialize_a_Dictionary_JSON
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>
           {
               { "Amar", 2001 },
               { "Joy", 3474 },
               { "Raj", 11926 },
               { "Manas", 3004 },
               { "Sujoy", 34174 }
           };

            string json = JsonConvert.SerializeObject(points);

            Console.WriteLine("Serialization:" + json);
            Console.WriteLine("============================");

            String json1 = @"{
                       'Amar': 2001,
                       'joy': 3474,
                       'Raj': 11926,
                       'Manas': 3004,
                       'Sujoy' : 34174
        }";
            Dictionary<String, int> dictionary = JsonConvert.DeserializeObject<Dictionary<String, int>>(json1);
            Console.WriteLine("Deserialization:");
            Console.WriteLine(dictionary);
            Console.WriteLine(dictionary["Manas"]);
            Console.WriteLine(dictionary["Amar"]);
            Console.WriteLine(dictionary["joy"]);
            Console.WriteLine(dictionary["Sujoy"]);
            Console.WriteLine(dictionary["Raj"]);
            Console.Read();
        }

    }
}
