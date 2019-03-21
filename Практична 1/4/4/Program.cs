using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDatabase database;
            int ch = -1;
            Console.WriteLine("Choose database: \t 1.SqlDb \t 2. OleDb");
            while (ch != 0)
            {
                ch = int.Parse(Console.ReadLine());
                if (ch == 2)
                {
                    database = new OleDbDatabase();
                    database.Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OleDbSeverConnection"].ConnectionString;
                    database.Command.CommandType = System.Data.CommandType.Text;
                    database.Command.CommandText = "Select * From Студенти";
                    try
                    {
                        database.Connection.Open();
                        Console.WriteLine("Connection opened!");
                        DbDataReader reader = database.Command.ExecuteReader();
                        // (2) get the schema of the result set
                        DataTable schemaTable = reader.GetSchemaTable();
                        PrintSchemaPlain(schemaTable);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Connecting Failed!");
                    }
                    finally
                    {
                        database.Connection.Close();
                        Console.WriteLine("Connection closed!");
                    }
                    //database.Command.CommandText = "Select * from Студенти";
                }
                else
                {
                    database = new SqlDatabase();
                    database.Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
                    database.Command.CommandType = System.Data.CommandType.Text;
                    database.Command.CommandText = "Select * From Student";
                    try
                    {
                        database.Connection.Open();
                        Console.WriteLine("Connection opened!");
                        //string res = database.Command.ExecuteScalar().ToString();
                        DbDataReader reader = database.Command.ExecuteReader();
                        // (2) get the schema of the result set
                        DataTable schemaTable = reader.GetSchemaTable();
                        PrintSchemaPlain(schemaTable);
                        //Console.WriteLine(res);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Connecting Failed!");
                        Console.WriteLine(e);
                    }
                    finally
                    {
                        database.Connection.Close();
                        Console.WriteLine("Connection closed!");
                    }
                    database.Command.CommandText = "Select * from Студенти";
                }
            }

            Console.ReadKey();
        }

        public static void PrintSchemaPlain(DataTable schemaTable)
        {
            foreach (DataRow row in schemaTable.Rows)
            {
                Console.WriteLine("{0}, {1}, {2}",
                    row.Field<string>("ColumnName"),
                    row.Field<Type>("DataType"),
                    row.Field<int>("ColumnSize"));
            }
        }
    }
}
