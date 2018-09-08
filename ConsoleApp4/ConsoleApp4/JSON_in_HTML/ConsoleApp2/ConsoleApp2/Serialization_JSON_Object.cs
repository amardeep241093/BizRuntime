using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
      public class Account
        {
            public string Email { get; set; }
            public bool Active { get; set; }
            public DateTime CreatedDate { get; set; }
            public IList<string> Roles { get; set; }
        }
    

    class Serialization_JSON_Object
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            Account account = new Account
            {
                Email = "amar@gmail.com",
                Active = true,
                CreatedDate = new DateTime(2018, 09, 03, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                {
                  "User",
                 "Admin"
                }
            };

            string json = JsonConvert.SerializeObject(account);
            Console.WriteLine("Serialization of object to JSON:" + json);
            Console.WriteLine("=====================================");

            String json1 = @"{
                     'Email': 'amardeep241093@gmail.com',
                     'Active' : true,
                     'CreatedDate': '2018-09-03T00:00:00Z',
                     'Roles': [ 
                                 'user',
                                 'Admin'
                              ]
                         }";

            Account account1 = JsonConvert.DeserializeObject<Account>(json1);
            Console.WriteLine("Deserializing JSON String to Object:");
            Console.WriteLine(account1.Email);
            Console.WriteLine(account1.Active);
            Console.WriteLine(account1.CreatedDate);
            Console.WriteLine(account1.Roles[1]);

            Console.Read();
        }
    }
}

/*
 *   {
              "Email": "amar@gmail.com",
              "Active": true,
              "CreatedDate": "2013-01-20T00:00:00Z",
              "Roles": [
              "User",
              "Admin"
               ]
             }
  */
