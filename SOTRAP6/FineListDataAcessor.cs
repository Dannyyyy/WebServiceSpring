using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTRAP6
{
    public class FineListDataAcessor
    {
        public void Fill(DataSet ds, Connection conn, Transaction tr)
        {

            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("FINELIST", "FineList");


            da.UpdateCommand = new OracleCommand("update FINELIST set NUMBER_=:numbery,SUMM_=:summy,DATE_CREATE=:datey, PK_EMP=:pk_emp, PK_REASONFINE=:pk_reasonfine where PK_FINELIST=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from FINELIST", conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into FINELIST (PK_FINELIST,NUMBER_,DATE_CREATE,SUMM_,PK_REASONFINE,PK_EMP) values (:id,:numbery,:datey,:summy,:pk_reasonfine,:pk_emp)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from FINELIST where PK_FINELIST=:id", conn.ObjectConnection, tr.ObjectTransaction);

            OracleParameter p = new OracleParameter();

            p.ParameterName = ":numbery";
            p.SourceColumn = "NUMBER_";
            da.UpdateCommand.Parameters.Add(p);

            OracleParameter pi = new OracleParameter();
            pi.ParameterName = ":numbery";
            pi.SourceColumn = "NUMBER_";
            da.InsertCommand.Parameters.Add(pi);

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = ":summy";
            p1.SourceColumn = "SUMM_";
            da.UpdateCommand.Parameters.Add(p1);


            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":summy";
            p1i.SourceColumn = "SUMM_";
            da.InsertCommand.Parameters.Add(p1i);

            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = ":datey";
            p2.SourceColumn = "DATE_CREATE";
            da.UpdateCommand.Parameters.Add(p2);

            OracleParameter p2i = new OracleParameter();
            p2i.ParameterName = ":datey";
            p2i.SourceColumn = "DATE_CREATE";
            da.InsertCommand.Parameters.Add(p2i);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = ":pk_emp";
            p3.SourceColumn = "PK_EMP";
            da.UpdateCommand.Parameters.Add(p3);

            OracleParameter p3i = new OracleParameter();
            p3i.ParameterName = ":pk_emp";
            p3i.SourceColumn = "PK_EMP";
            da.InsertCommand.Parameters.Add(p3i);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = ":pk_reasonfine";
            p4.SourceColumn = "PK_REASONFINE";
            da.UpdateCommand.Parameters.Add(p4);

            OracleParameter p4i = new OracleParameter();
            p4i.ParameterName = ":pk_reasonfine";
            p4i.SourceColumn = "PK_REASONFINE";
            da.InsertCommand.Parameters.Add(p4i);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = ":id";
            p5.SourceColumn = "PK_FINELIST";
            da.UpdateCommand.Parameters.Add(p5);

            OracleParameter p5i = new OracleParameter();
            p5i.ParameterName = ":id";
            p5i.SourceColumn = "PK_FINELIST";
            da.InsertCommand.Parameters.Add(p5i);

             OracleParameter p5d = new OracleParameter();
             p5d.ParameterName = ":id";
             p5d.SourceColumn = "PK_FINELIST";
            da.DeleteCommand.Parameters.Add(p5d);

         

            da.Fill(ds,"FINELIST");


        }

        public void Update(DataSet ds, Connection conn, Transaction tr)
        {

            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("FINELIST", "FineList");


            da.UpdateCommand = new OracleCommand("update FINELIST set NUMBER_=:numbery,SUMM_=:summy,DATE_CREATE=:datey, PK_EMP=:pk_emp, PK_REASONFINE=:pk_reasonfine where PK_FINELIST=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from FINELIST", conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into FINELIST (PK_FINELIST,NUMBER_,DATE_CREATE,SUMM_,PK_REASONFINE,PK_EMP) values (:id,:numbery, :datey,:summy, :pk_reasonfine,:pk_emp)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from FINELIST where PK_FINELIST=:id", conn.ObjectConnection, tr.ObjectTransaction);

            OracleParameter p = new OracleParameter();

            p.ParameterName = ":numbery";
            p.SourceColumn = "NUMBER_";
            da.UpdateCommand.Parameters.Add(p);

            OracleParameter pi = new OracleParameter();
            pi.ParameterName = ":numbery";
            pi.SourceColumn = "NUMBER_";
            da.InsertCommand.Parameters.Add(pi);

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = ":summy";
            p1.SourceColumn = "SUMM_";
            da.UpdateCommand.Parameters.Add(p1);


            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":summy";
            p1i.SourceColumn = "SUMM_";
            da.InsertCommand.Parameters.Add(p1i);

            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = ":datey";
            p2.SourceColumn = "DATE_CREATE";
            da.UpdateCommand.Parameters.Add(p2);

            OracleParameter p2i = new OracleParameter();
            p2i.ParameterName = ":datey";
            p2i.SourceColumn = "DATE_CREATE";
            da.InsertCommand.Parameters.Add(p2i);

            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = ":pk_emp";
            p3.SourceColumn = "PK_EMP";
            da.UpdateCommand.Parameters.Add(p3);

            OracleParameter p3i = new OracleParameter();
            p3i.ParameterName = ":pk_emp";
            p3i.SourceColumn = "PK_EMP";
            da.InsertCommand.Parameters.Add(p3i);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = ":pk_reasonfine";
            p4.SourceColumn = "PK_REASONFINE";
            da.UpdateCommand.Parameters.Add(p4);

            OracleParameter p4i = new OracleParameter();
            p4i.ParameterName = ":pk_reasonfine";
            p4i.SourceColumn = "PK_REASONFINE";
            da.InsertCommand.Parameters.Add(p4i);

            OracleParameter p5 = new OracleParameter();
            p5.ParameterName = ":id";
            p5.SourceColumn = "PK_FINELIST";
            da.UpdateCommand.Parameters.Add(p5);

            OracleParameter p5i = new OracleParameter();
            p5i.ParameterName = ":id";
            p5i.SourceColumn = "PK_FINELIST";
            da.InsertCommand.Parameters.Add(p5i);

            OracleParameter p5d = new OracleParameter();
            p5d.ParameterName = ":id";
            p5d.SourceColumn = "PK_FINELIST";
            da.DeleteCommand.Parameters.Add(p5d);

            da.Update(ds,"FINELIST");


        }


    }
}
