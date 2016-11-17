using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SOTRAP6
{
    public class AbstractConnection
    {
        private SqlConnection connection;

        public AbstractConnection()
        {
            SqlConnection _connection = new SqlConnection();
            connection = _connection;
        }

        public AbstractConnection(string connectionString)
        {
            SqlConnection _connection = new SqlConnection(connectionString);
            connection = _connection; 
        }

        public string ConnectionString
        {
            get { return connection.ConnectionString; }
            set { connection.ConnectionString = ConnectionString; }
        }

        public SqlConnection Connection
        {
            get { return connection; } set { connection = value; }
        }

        public AbstractTransaction openTransaction()
        {
            AbstractTransaction resultTransaction = new AbstractTransaction();
            SqlTransaction transaction = connection.BeginTransaction();
            resultTransaction.Transaction = transaction;
            return resultTransaction;
        }

        public void openConnection()
        {
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Close(); 
        }

    }
}
