using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7.ADO.net
{
    class StudentProperty
    {
        public int id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public int join_date { get; set; }
    }

    class Select
    {
        static void Main(string[] args)
        {
            List<StudentProperty> list = new List<StudentProperty>();
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=DELL-PC\\SQLEXPRESS; database=Student; integrated security=SSPI");
                
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from student", con);
              
                // Opening Connection  
                con.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();

                //iterating the data
                while (sdr.Read())
                {
                    list.Add(new StudentProperty()
                    {
                        id = sdr.GetInt32(sdr.GetOrdinal("id")),
                        name = sdr.GetString(sdr.GetOrdinal("name")),
                       email = sdr.GetString(sdr.GetOrdinal("email")),
                       join_date = sdr.GetInt32(sdr.GetOrdinal("date")),
                    });

                }
                sdr.Close();

                foreach (var i in list)
                {
                    Console.WriteLine("id{0}, name{1}, email{2}, join_date{3}", i.id, i.name, i.email, i.join_date);
                }
                Console.WriteLine();

                //XmlSerializer serialization = new XmlSerializer(typeof(StudentProperty));
                //serialization.Serialize();
                //Console.ReadLine();
                //Console.WriteLine(result);
                //File.WriteAllText("D:\\sts.json", result);
                //Console.WriteLine("stored");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
