using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTRAP6
{
    public class Transaction
    {
        	OracleTransaction tr;

            public Transaction(OracleConnection conn)
            {
                tr = conn.BeginTransaction();
            }
            public OracleTransaction ObjectTransaction
            {
                get
                {
                    return tr;
                }

            }

            public void Commit()
            {
                tr.Commit();
            }

            public void RollBack()
            {
                tr.Rollback();
            }

    
    }
}
