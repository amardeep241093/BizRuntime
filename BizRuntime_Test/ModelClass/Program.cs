using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization;


using System.IO;

namespace JSONEx
{
    class JsonSerialization
    {
        public string name;
        public String address;
        public string phone;
        public string email;

        public JsonSerialization(string name, string address, string phone, String email)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        static void CallSerializer()
        {
            JsonSerialization e1 = new JsonSerialization("Arun", "gwalior", "7631464690", "amar@gmail.com");

            FileStream stream = new FileStream("J:\\Bizruntime\\h2.json", FileMode.OpenOrCreate);

            //serializes the object to JSON
           JsonSerializer ser = new JsonSerializer(typeof(JsonSerialization));

           // ser.WriteObject(stream, e1);
            Console.WriteLine("Data Serialized successfully..");
            stream.Close();
        }
    }
}