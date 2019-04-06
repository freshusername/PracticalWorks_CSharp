namespace _1.Initial_Setup
{
    using System.Data.SqlClient;
    using System.IO;

    public class Startup
    {
        private const string DbName = "MinionsDB";
        private const string ServerName = @"EXPLORER\SQL2017";
        private const string Authentication = "Integrated Security=true";

        public static void Main()
        {
            CreateDatabase(DbName, ServerName, Authentication);

            string connectionString = $@"
                Server={ServerName}; 
                Database={DbName}; 
                {Authentication};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = File.ReadAllText(@"..\..\Tables Data.sql");
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    command.ExecuteNonQuery();
                }
                System.Console.WriteLine("OK");
            }
        }

        private static void CreateDatabase(string dbName, string serverName, string authentication)
        {
            string connectionString = $@"
                Server={serverName}; 
                Database=master; 
                {authentication};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"CREATE DATABASE {dbName};", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
