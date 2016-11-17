using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTRAP6
{
    public class UnitDataAcessor
    {

        public void Fill(DataSet ds, Connection conn, Transaction tr)
        {

            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("UNIT_", "Unit");



            da.UpdateCommand = new OracleCommand("update UNIT_ set NAME_=:name  where PK_UNIT=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from UNIT_", conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into UNIT_ (PK_UNIT,NAME_) values (:id,:name)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from UNIT_ where PK_UNIT=:id", conn.ObjectConnection, tr.ObjectTransaction);


            OracleParameter p = new OracleParameter();
            p.ParameterName = ":name";
            p.SourceColumn = "NAME_";

            da.UpdateCommand.Parameters.Add(p);



            OracleParameter pi = new OracleParameter();
            pi.ParameterName = ":name";
            pi.SourceColumn = "NAME_";

            da.InsertCommand.Parameters.Add(pi);

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = ":id";
            p1.SourceColumn = "PK_UNIT";
            da.UpdateCommand.Parameters.Add(p1);
            //   da.InsertCommand.Parameters.Add(p);

            OracleParameter p1d = new OracleParameter();
            p1d.ParameterName = ":id";
            p1d.SourceColumn = "PK_UNIT";

            da.DeleteCommand.Parameters.Add(p1d);


            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":id";
            p1i.SourceColumn = "PK_UNIT";

            da.InsertCommand.Parameters.Add(p1i);


            da.Fill(ds,"Unit_");


        }

        public void Update(DataSet ds, Connection conn, Transaction tr)
        {

            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("UNIT_", "Unit");



            da.UpdateCommand = new OracleCommand("update UNIT_ set NAME_=:name where PK_UNIT=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from UNIT_", conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into UNIT_ (PK_UNIT,NAME_) values (:id,:name)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from UNIT_ where PK_UNIT=:id", conn.ObjectConnection, tr.ObjectTransaction);


            OracleParameter p = new OracleParameter();
            p.ParameterName = ":name";
            p.SourceColumn = "NAME_";

            da.UpdateCommand.Parameters.Add(p);



            OracleParameter pi = new OracleParameter();
            pi.ParameterName = ":name";
            pi.SourceColumn = "NAME_";

            da.InsertCommand.Parameters.Add(pi);

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = ":id";
            p1.SourceColumn = "PK_UNIT";
            da.UpdateCommand.Parameters.Add(p1);
            //   da.InsertCommand.Parameters.Add(p);

            OracleParameter p1d = new OracleParameter();
            p1d.ParameterName = ":id";
            p1d.SourceColumn = "PK_UNIT";

            da.DeleteCommand.Parameters.Add(p1d);


            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":id";
            p1i.SourceColumn = "PK_UNIT";

            da.InsertCommand.Parameters.Add(p1i);


            da.Update(ds,"Unit_");


        }


    }
}
