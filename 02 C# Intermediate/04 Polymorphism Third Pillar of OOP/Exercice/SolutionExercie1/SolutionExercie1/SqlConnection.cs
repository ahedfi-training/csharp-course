namespace SolutionExercie1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString): base (connectionString)
        {

        }
        public override void Close()
        {
            System.Console.WriteLine("SqlConnection is closed");
        }

        public override void Open()
        {
            System.Console.WriteLine("SqlConnection is opned");
        }
    }
}
