using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Chapter4._2
{
    class SqlDataAdapterDemo
    {

        public async void dataBaseRead() {

             string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
             using (SqlConnection connection = new SqlConnection(connectionString))
             {

                 SqlCommand command = new SqlCommand("SELECT * FROM DimEmployee;SELECT TOP 1 * FROM DimEmployee ORDER BY LastName", connection);
                 await connection.OpenAsync();
                 SqlDataReader dataReader = await command.ExecuteReaderAsync();
                 await ReadQueryResults(dataReader);
                 Console.WriteLine("-------------------------------------");
                 await dataReader.NextResultAsync();
                 await ReadQueryResults(dataReader);
                 dataReader.Close();
              }
        }

        public async Task ReadQueryResults(SqlDataReader dataReader)
        {
            while (await dataReader.ReadAsync())
            {
                string formatStringWithMiddleName = "Person ({0}) is named {1} {2} {3}";
                string formatStringWithoutMiddleName = "Person ({0}) is named {1} {3}";
                if ((dataReader["MiddleName"] == null))
                {
                    Console.WriteLine(formatStringWithoutMiddleName,
                    dataReader["EmployeeKey"],
                    dataReader["FirstName"],
                    dataReader["LastName"]);
                }
                else
                {
                    Console.WriteLine(formatStringWithMiddleName,
                    dataReader["EmployeeKey"],
                    dataReader["FirstName"],
                    dataReader["MiddleName"],
                    dataReader["LastName"]);
                }

            }
           
        }

        public static void Main()
        {
            SqlDataAdapterDemo d = new SqlDataAdapterDemo();
            d.dataBaseRead();
            Console.ReadKey();
        }
    }
}
