using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.OleDb;
using System.Configuration;

namespace _4
{
    class OleDbDatabase : AbstractDatabase
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public override DbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["OleDbSeverConnection"].ConnectionString);
                    return _connection;
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
                    _command = new OleDbCommand();
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
