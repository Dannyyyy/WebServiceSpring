using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTRAP6
{
    public class Connection
    {
        OracleConnection conn;


        public Connection()
        {
            conn = new OracleConnection();
        }
        public Connection(string connectionstring)
        {
            conn = new OracleConnection(connectionstring);
        }
        public string Connectionstring
        {
            get
            {
                return conn.ConnectionString;
            }
            set
            {
                conn.ConnectionString = Connectionstring;
            }
        }
        public OracleConnection ObjectConnection
        {
            get
            {
                return conn;
            }

        }

        public void Open()
        {
            conn.Open();
        }
        public void Close()
        {
            conn.Close();
        }

        public Transaction BeginTransaction()
        {
            return new Transaction(conn);
        }

	
	
	

	


    
  


    }
}
