using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.ADO.net
{
    class DataSet
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DELL-PC\\SQLEXPRESS; database=Student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("Select * from connect for xml auto", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
               // da.Fill(ds);
                //ds.Tables[0].WriteXml(@"J:\test.xml");
                Console.WriteLine("done: check the xml file");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
   

