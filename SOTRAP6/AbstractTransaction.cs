using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SOTRAP6
{
    public class AbstractTransaction
    {
        private SqlTransaction transaction;

        public SqlTransaction Transaction
        {
            get { return transaction; } set { transaction = value; }
        }

        public void commit()
        {
            transaction.Commit();
        }

        public void rollback()
        {
            transaction.Rollback();
        }
    }
}
