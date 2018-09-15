using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.ADO.net
{
    class Delete
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=DELL-PC\\SQLEXPRESS; database=Student; integrated security=SSPI");

                // writing sql query  
                SqlCommand cm = new SqlCommand("delete from student where id = '101'", con);

                // Opening Connection  
                con.Open();

                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record deleted Successfully");


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
