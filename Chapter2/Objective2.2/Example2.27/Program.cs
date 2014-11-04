using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace Example2._27
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void OpenConnection(DbConnection connection)
        {
            if (connection is SqlConnection)
            {
                // run some special code
            }
        }

        void LogStream(Stream stream)
        {
            MemoryStream memoryStream = stream as MemoryStream;
            if (memoryStream != null)
            {
                // ...
            }
        }
    }
}
