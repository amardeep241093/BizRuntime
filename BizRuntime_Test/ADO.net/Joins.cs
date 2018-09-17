using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Joins
{
    class Emp_Ofc_Create
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = DELL - PC\\SQLEXPRESS; database = Joins; integrated security = SSPI");
                SqlCommand query = new SqlCommand("create table Bonus(id int,project varchar(90), salary double)", con);
                con.Open();
                query.ExecuteNonQuery();
                Console.WriteLine("Table Emp created Successfully");
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