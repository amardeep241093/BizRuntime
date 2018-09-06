using System;
using System.Collections.Generic;
using System.IO;


namespace JsonToCsObject
{
    public class Serialize_JSON_To_File
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {

            List<Posts> list = new List<Posts>();
            //Adding obj to the list
            list.Add(new Posts()
            {
                street = "Btm 2nd Stage",
                city = "Bnagalore",
                Pincode = 560076,
                name = "Amardeep",
                Age = 24,
                Gender = "Male"
            });

            //String json = JsonConvert.SerializeObject(list.ToArray());
            ////Writing a string into the file
            //File.WriteAllText(@"J:\C#\New folder\BizRuntime\JsonFile.json", json);
            //Console.Write(json);


            using (StreamWriter file = File.CreateText(@"J:\C#\New folder\BizRuntime\JsonData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, list);
            }

            try
            {
                string json = string.Empty;

                using (StreamReader r = new StreamReader(@"D:\JsonData.json"))
                {

                    json = r.ReadToEnd();

                    object jsonConvert = JsonConvert;
                  //  var array = jsonConvert.DeserializeObject<Serialize_JSON_To_File[]>(json);
                    //StreamWriter streamWriter = new StreamWriter(array);

                  //  Console.WriteLine(array);

                    //... read text from json file
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
