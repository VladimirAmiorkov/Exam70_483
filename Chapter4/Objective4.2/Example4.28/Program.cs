using System;
using System.Data.SqlClient;

namespace Example4._28
{
    class Program
    {
        // This example is not supposed to work and would throw and exception as there are not such databases. The example simply shows a specific approach
        static void Main(string[] args)
        {
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"(localdb)\v11.0";
            sqlConnectionStringBuilder.InitialCatalog = "ProgrammingInCSharp";

            string connectionString = sqlConnectionStringBuilder.ToString();

            Console.WriteLine("Created connection string: {0}", connectionString);

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
