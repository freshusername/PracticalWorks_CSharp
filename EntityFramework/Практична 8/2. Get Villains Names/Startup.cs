namespace _2.Get_Villains_Names
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class Startup
    {
        private const string ConnectionString = @"
            Server=EXPLORER\SQL2017; 
            Database=MinionsDB; 
            Integrated Security=true;";

        public static void Main()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string cmdText = File.ReadAllText(@"D:\course 2\1.C#\Практичні\GoldenGate\Software-University-SoftUni-master\Databases Advanced - Entity Framework 6\DB Apps Introduction\2. Get Villains Names\Minions Per Villain.sql");
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write($"{reader.GetName(i),-20}");
                            }

                            Console.WriteLine();

                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write($"{reader[i],-20}");
                                }

                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
