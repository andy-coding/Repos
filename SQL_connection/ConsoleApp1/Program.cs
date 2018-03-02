using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_connection
{
    class Program
    {
        static void Main()
        {
            try
            {
                OpenSqlConnection();
                Console.WriteLine("OpenSQLConection: success!");



                using (SqlCommand command = new SqlCommand("SELECT * FROM testdb"), conn)
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader.GetValue(i));
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
                 catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
         
        Console.ReadLine();

        }



        
        private static void OpenSqlConnection()
        {
            string connectionString = "" +
                 "Data Source=.\\SQLEXPRESS;" +
                 "Initial Catalog=testdb;" +
                // "User ID = andyb;" +
                // "Password = davepwd;" +
                 "Integrated Security=True;" +
                 "MultipleActiveResultSets=True;" +
                 "Connect Timeout = 2;";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                Console.WriteLine("State: {0}", connection.State);
                Console.WriteLine("ConnectionString: {0}",
                    connection.ConnectionString);


            


               // Console.ReadLine();
            }
        }
        

    }
}
