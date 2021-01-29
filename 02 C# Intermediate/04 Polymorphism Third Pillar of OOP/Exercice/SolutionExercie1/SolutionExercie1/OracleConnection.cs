namespace SolutionExercie1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString): base(connectionString)
        {

        }
        public override void Close()
        {
            System.Console.WriteLine("OracleConnection is closed");
        }

        public override void Open()
        {
            System.Console.WriteLine("OracleConnection is opned");
        }
    }
}
