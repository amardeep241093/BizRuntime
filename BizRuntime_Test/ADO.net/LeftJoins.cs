using System;
using System.Data.SqlClient;

namespace Joins
{
    class Emp_Left_Outer
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source = DELL - PC\\SQLEXPRESS; database = Joins; integrated security = SSPI");
                SqlCommand query = new SqlCommand("select * from Bonus left outer join  on Bonus.id = .sno ", con);
                con.Open();
                SqlDataReader data = query.ExecuteReader();
                int count = data.FieldCount;
                while (data.Read())
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(data[i] + "\t");
                    }
                    Console.WriteLine();
                }
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