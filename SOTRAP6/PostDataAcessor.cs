using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTRAP6
{
    public class PostDataAcessor
    {
        public void Fill(DataSet ds, Connection conn, Transaction tr)
        {

            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("POST_", "post");


            da.UpdateCommand = new OracleCommand("update POST_ set NAME_=:name  where PK_POST=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from POST_", conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into POST_ (PK_POST,NAME_) values (:id,:name)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from POST_ where PK_POST=:id", conn.ObjectConnection, tr.ObjectTransaction);

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
            p1.SourceColumn = "PK_POST";
            da.UpdateCommand.Parameters.Add(p1);

            //   da.InsertCommand.Parameters.Add(p);

            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":id";
            p1i.SourceColumn = "PK_POST";
            da.InsertCommand.Parameters.Add(p1i);

            OracleParameter p1d = new OracleParameter();
            p1d.ParameterName = ":id";
            p1d.SourceColumn = "PK_POST";

            da.DeleteCommand.Parameters.Add(p1d);

          

            da.Fill(ds,"Post_");


        }

        public void Update(DataSet ds, Connection conn, Transaction tr)
        {

            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("POST_", "post");



            da.UpdateCommand = new OracleCommand("update POST_ set NAME_=:name  where PK_POST=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from POST_", conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into POST_ (PK_POST,NAME_) values (:id,:name)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from POST_ where PK_POST=:id", conn.ObjectConnection, tr.ObjectTransaction);

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
            p1.SourceColumn = "PK_POST";
            da.UpdateCommand.Parameters.Add(p1);

            //   da.InsertCommand.Parameters.Add(p);

            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":id";
            p1i.SourceColumn = "PK_POST";
            da.InsertCommand.Parameters.Add(p1i);

            OracleParameter p1d = new OracleParameter();
            p1d.ParameterName = ":id";
            p1d.SourceColumn = "PK_POST";

            da.DeleteCommand.Parameters.Add(p1d);

            da.Update(ds,"Post_");


        }

    }
}
