using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JsonToCsObject
{
    class Json_Deserialize
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var data = client.DownloadString("https://jsonplaceholder.typicode.com/posts/2");
            RootObject root = JsonConvert.DeserializeObject<RootObject>(data);
         
            Console.WriteLine("userId= " + root.userId);
            Console.WriteLine("Id= " + root.id);
            Console.WriteLine("title= " + root.title);
            Console.WriteLine("body= " + root.body);
            Console.Read();
            }
        }
}
