using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.ADO.net
{
    class Employee1
    {
        static void Main(string[] args)
        {
            new Employee1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=DELL-PC\\SQLEXPRESS; database=Employee; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into Employee(id, name, email, join_date)values('101', 'Amardeep', 'amardeep@gmail.com', '1/12/2017')", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
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
