using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp5.ADO.net
{
    class Employee1
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
               
                con = new SqlConnection("Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=Employee1;Integrated Security=True");
                
                SqlCommand cm = new SqlCommand("create table employee(id int not null,name varchar(100), MngrId int not null, join_date date)", con);
               
                con.Open();
                
                cm.ExecuteNonQuery();
                 
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
          
            finally
            {
                con.Close();
            }
            Console.ReadLine();
        }
    }
}