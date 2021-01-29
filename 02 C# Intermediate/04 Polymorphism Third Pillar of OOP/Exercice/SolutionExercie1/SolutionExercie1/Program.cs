using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionExercie1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbConnection = new DbConnection("DataSource");
            var sqlConnection = new SqlConnection("DataSource");
            sqlConnection.Open();
            sqlConnection.Close();
            var oracleConnection = new OracleConnection("DataSource");
            oracleConnection.Open();
            oracleConnection.Close();
        }
    }
}
