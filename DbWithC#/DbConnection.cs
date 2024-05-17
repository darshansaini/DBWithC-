using System;
using System.Data.SqlClient;
namespace DbWithC_
{
    public class DbConnection
    {
        static void main(string[] args)
        {

        }

        public void CreateTable()
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source = localhost\\SQLEXPRESS; database= student; integrated security = SSPI");
                SqlCommand cm = new SqlCommand("create table student(id int not null, name varchar(100)," +
                    " email varchar(50), join_date date)", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong. "+ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
