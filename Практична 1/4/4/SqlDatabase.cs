using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Data.Common;

namespace _4
{
    class SqlDatabase : AbstractDatabase
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

     public override DbConnection Connection
        {
            get 
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
                }
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }

        public override DbCommand Command
        {
            get
            {
                if (_command == null)
                {
                    _command = new SqlCommand();
                    _command.Connection = Connection;
                }
                return _command;
            }
            set
            {
                _command = value;
            }
        }
    }
}
