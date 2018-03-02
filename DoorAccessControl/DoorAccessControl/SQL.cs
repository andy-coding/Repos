using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoorAccessControl
{
    class SQL
    {

        

        public static void CreateCommand(string queryString,
                     string connectionString)
        {
            SqlDataReader myReader = null;

            //Console.WriteLine("queryString: {0}", queryString);
            //Console.WriteLine("connectionString: {0}", connectionString);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

                myReader = command.ExecuteReader();
                while(myReader.Read())
                {
                    Console.WriteLine(myReader["user"].ToString());
                    Console.WriteLine(myReader["password"].ToString());
                }
            }
        }
    }
}
