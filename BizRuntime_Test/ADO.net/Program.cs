using System;
using System.Data.SqlClient;


namespace Joins
{
    class Emp_Pc_Insert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source = DELL - PC\\SQLEXPRESS; database = Employee1; integrated security = SSPI");
                SqlCommand query1 = new SqlCommand("insert into employee(1, 'Ajit Singh', 1, 01/01/2010)", con);
                SqlCommand query2 = new SqlCommand("insert into employee(2, 'chinna', 1, 01/31/2014))", con);
                SqlCommand query3 = new SqlCommand("insert into employee(3, 'Jyothi', 1, 01/30/2015)", con);
                SqlCommand query4 = new SqlCommand("insert into employee(4, 'Santanu', 1, 01/07/2013))", con);
                SqlCommand query5 = new SqlCommand("insert into employee(5, 'Richard', 1, 02/06/2016)", con);
                SqlCommand query6 = new SqlCommand("insert into employee(6, 'Siva', 1, 01/10/2017))", con);
                SqlCommand query7 = new SqlCommand("insert into employee(7, 'Ankit', 2, 01/07/2017)", con);
                SqlCommand query8 = new SqlCommand("insert into employee(8, 'Roja', 2, 01/09/2017))", con);
                SqlCommand query9 = new SqlCommand("insert into employee(9, 'Hitesh', 3, 01/07/2016)", con);
                SqlCommand query10 = new SqlCommand("insert into employee(10, 'Chandra', 6, 01/06/2017))", con);
                SqlCommand query11 = new SqlCommand("insert into employee(11, 'Gaurav', 3, 01/01/2010)", con);
                SqlCommand query12 = new SqlCommand("insert into employee(12, 'Subramanyam', 2, 10/07/2017))", con);

                con.Open();
                query1.ExecuteNonQuery();
                query2.ExecuteNonQuery();
                query3.ExecuteNonQuery();
                query4.ExecuteNonQuery();
                Console.WriteLine("Records inserted into Emp_Pc Successfully");
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