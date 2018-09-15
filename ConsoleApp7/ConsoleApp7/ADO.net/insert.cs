using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.ADO.net
{
    class insert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=DELL-PC\\SQLEXPRESS; database=student; integrated security=SSPI");
                // writing sql query  
                //SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('101', 'Amardeep', 'amardeep@gmail.com', '1/12/2017')", con);  
                // SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('102', 'Rajdeep', 'Rajeep@gmail.com', '2/10/2018')", con);
                //SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('103', 'Sandeep', 'Sandeep@gmail.com', '10/10/2010')", con);
                SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('104', 'Pradeep', 'Pradeep@gmail.com', '10/11/2013')", con);

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
