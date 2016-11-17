using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTRAP6
{
    public class ReasonDataAcessor
    {
        public void Fill(DataSet ds, Connection conn, Transaction tr)
        {

            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("REASONFINE", "Reasonfine");


            da.UpdateCommand = new OracleCommand("update REASONFINE set NAME_=:name  where PK_REASONFINE=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from REASONFINE",conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into REASONFINE (PK_REASONFINE,NAME_) values (:id,:name)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from REASONFINE where PK_REASONFINE=:id", conn.ObjectConnection, tr.ObjectTransaction);


         


            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = ":name";
            p2.SourceColumn = "NAME_";
            da.UpdateCommand.Parameters.Add(p2);


            OracleParameter p2i = new OracleParameter();
            p2i.ParameterName = ":name";
            p2i.SourceColumn = "NAME_";
            da.InsertCommand.Parameters.Add(p2i);

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = ":id";
            p1.SourceColumn = "PK_REASONFINE";
            da.UpdateCommand.Parameters.Add(p1);


            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":id";
            p1i.SourceColumn = "PK_REASONFINE";
            da.InsertCommand.Parameters.Add(p1i);


            OracleParameter p1d = new OracleParameter();
            p1d.ParameterName = ":id";
            p1d.SourceColumn = "PK_REASONFINE";
            da.DeleteCommand.Parameters.Add(p1d);



            da.Fill(ds, "REASONFINE");


        }

        public void Update(DataSet ds, Connection conn,Transaction tr)
        {
            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("REASONFINE", "Reasonfine");


            da.UpdateCommand = new OracleCommand("update REASONFINE set NAME_=:name  where PK_REASONFINE=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from REASONFINE", conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into REASONFINE (PK_REASONFINE,NAME_) values (:id,:name)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from REASONFINE where PK_REASONFINE=:id", conn.ObjectConnection, tr.ObjectTransaction);





            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = ":name";
            p2.SourceColumn = "NAME_";
            da.UpdateCommand.Parameters.Add(p2);


            OracleParameter p2i = new OracleParameter();
            p2i.ParameterName = ":name";
            p2i.SourceColumn = "NAME_";
            da.InsertCommand.Parameters.Add(p2i);

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = ":id";
            p1.SourceColumn = "PK_REASONFINE";
            da.UpdateCommand.Parameters.Add(p1);


            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":id";
            p1i.SourceColumn = "PK_REASONFINE";
            da.InsertCommand.Parameters.Add(p1i);


            OracleParameter p1d = new OracleParameter();
            p1d.ParameterName = ":id";
            p1d.SourceColumn = "PK_REASONFINE";
            da.DeleteCommand.Parameters.Add(p1d);




            da.Update(ds, "REASONFINE");


        }

    }
}
