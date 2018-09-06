using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Task
{
    class JsonSerialization
    {
        static void Main(string[] args)
        {

            List<Posts> list = new List<Posts>();
           
            list.Add(new Posts()
            {
                street = "Btm 2nd Stage",
                city = "Bnagalore",
                Pincode = 560076,
                name = "Amardeep",
                Age = 24,
                Gender = "Male"
            });

            String json = JsonConvert.SerializeObject(list.ToArray());
            //Writing a string into the file
            File.WriteAllText(@"J:\C#\New folder\BizRuntime\JsonFile.json", json);
            Console.Write(json);


            using (StreamWriter file = File.CreateText(@"J:\C#\New folder\BizRuntime\JsonData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, list);
            }

        }
    }
}
