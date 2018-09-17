using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Joins
{
    class Emp_Ofc_Insert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source = DELL - PC\\SQLEXPRESS; database = Joins; integrated security = SSPI");
                SqlCommand query1 = new SqlCommand("insert into Bonus(1, 'All', 40000)", con);
                SqlCommand query2 = new SqlCommand("insert into Bonus(2, 'FDC', 26400)", con);
                SqlCommand query3 = new SqlCommand("insert into Bonus(3, 'Socket', 26500)", con);
                SqlCommand query4 = new SqlCommand("insert into Bonus(4, 'database', 30000)", con);
                SqlCommand query5 = new SqlCommand("insert into Bonus(5, 'zoomdata',26700)", con);
                SqlCommand query6 = new SqlCommand("insert into Bonus(6, 'ignite', 24500)", con);
                con.Open();
                query1.ExecuteNonQuery();
                query2.ExecuteNonQuery();
                query3.ExecuteNonQuery();
                query4.ExecuteNonQuery();
                Console.WriteLine("Records inserted Successfully");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("some thing went wrong:" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}