using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp5.ADO.net
{
    class Employee
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table Employee(id int not null,name varchar(100), email varchar(50), join_date date)", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
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