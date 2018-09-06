using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToCsObject
{
    class Deserialize_Anoymous_Type
    {
        static void Main(string[] args)
        {
            var customer = new { name = " ", Id = " ", Dept = " " };
            String json = @"{
                       'Name': 'Kapil',
                       'Id': 202,
                       'Dept': 'Finance'
                    }";

            var customer1 = JsonConvert.DeserializeAnonymousType(json, customer);
            Console.WriteLine("Deserialization:");
            Console.WriteLine(customer1.name);
            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer1.Dept);

            String json1 = @"{
                       'Name': 'Amardeep',
                       'Id': 201,
                       'Dept': 'software'
                    }";
            var customer2 = JsonConvert.DeserializeAnonymousType(json1, customer);
            Console.WriteLine(customer2.name);
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Dept);
            Console.Read();
        }
    }
}
