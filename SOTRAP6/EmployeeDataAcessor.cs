using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTRAP6
{
    public  class EmployeeDataAcessor
    {
        public void Fill(DataSet ds, Connection conn, Transaction tr)
        {

	OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
	da.TableMappings.Add("EMP", "Employee");

    da.UpdateCommand = new OracleCommand("update EMP set FIO=:fio, PK_UNIT=:pk_unit, PK_POST=:pk_post where PK_EMP=:id", conn.ObjectConnection, tr.ObjectTransaction);
    da.SelectCommand = new OracleCommand("select * from EMP", conn.ObjectConnection, tr.ObjectTransaction);
    da.InsertCommand = new OracleCommand("insert into EMP (PK_EMP,FIO,PK_UNIT,PK_POST) values (:id,:fio, :pk_unit, :pk_post)", conn.ObjectConnection, tr.ObjectTransaction);
    da.DeleteCommand = new OracleCommand("delete from EMP where PK_EMP=:id", conn.ObjectConnection, tr.ObjectTransaction);


            OracleParameter p = new OracleParameter();
            p.ParameterName = ":fio";
            p.SourceColumn = "FIO";
            da.UpdateCommand.Parameters.Add(p);

            OracleParameter pi = new OracleParameter();
            pi.ParameterName = ":fio";
            pi.SourceColumn = "FIO";
            da.InsertCommand.Parameters.Add(pi);

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = ":pk_unit";
            p1.SourceColumn = "PK_UNIT";
            da.UpdateCommand.Parameters.Add(p1);

            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":pk_unit";
            p1i.SourceColumn = "PK_UNIT";
            da.InsertCommand.Parameters.Add(p1i);

            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = ":pk_post";
            p2.SourceColumn = "PK_POST";
            da.UpdateCommand.Parameters.Add(p2);

            OracleParameter p2i = new OracleParameter();
            p2i.ParameterName = ":pk_post";
            p2i.SourceColumn = "PK_POST";
            da.InsertCommand.Parameters.Add(p2i);


            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = ":id";
            p3.SourceColumn = "PK_EMP";
            da.UpdateCommand.Parameters.Add(p3);


            OracleParameter p3i = new OracleParameter();
            p3i.ParameterName = ":id";
            p3i.SourceColumn = "PK_EMP";
            da.InsertCommand.Parameters.Add(p3i);


            OracleParameter p3d = new OracleParameter();
            p3d.ParameterName = ":id";
            p3d.SourceColumn = "PK_EMP";
            da.DeleteCommand.Parameters.Add(p3d);

  
            
            da.Fill(ds,"Emp");
           

        }

        public void Update(DataSet ds, Connection conn, Transaction tr)
        {

            OracleDataAdapter da = new OracleDataAdapter();  //Создаем класс DA
            da.TableMappings.Add("EMP", "Employee");

            da.UpdateCommand = new OracleCommand("update EMP set FIO=:fio, PK_UNIT=:pk_unit, PK_POST=:pk_post where PK_EMP=:id", conn.ObjectConnection, tr.ObjectTransaction);
            da.SelectCommand = new OracleCommand("select * from EMP", conn.ObjectConnection, tr.ObjectTransaction);
            da.InsertCommand = new OracleCommand("insert into EMP (PK_EMP,FIO,PK_UNIT,PK_POST) values (:id,:fio, :pk_unit, :pk_post)", conn.ObjectConnection, tr.ObjectTransaction);
            da.DeleteCommand = new OracleCommand("delete from EMP where PK_EMP=:id", conn.ObjectConnection, tr.ObjectTransaction);


            OracleParameter p = new OracleParameter();
            p.ParameterName = ":fio";
            p.SourceColumn = "FIO";
            da.UpdateCommand.Parameters.Add(p);

            OracleParameter pi = new OracleParameter();
            pi.ParameterName = ":fio";
            pi.SourceColumn = "FIO";
            da.InsertCommand.Parameters.Add(pi);

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = ":pk_unit";
            p1.SourceColumn = "PK_UNIT";
            da.UpdateCommand.Parameters.Add(p1);

            OracleParameter p1i = new OracleParameter();
            p1i.ParameterName = ":pk_unit";
            p1i.SourceColumn = "PK_UNIT";
            da.InsertCommand.Parameters.Add(p1i);

            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = ":pk_post";
            p2.SourceColumn = "PK_POST";
            da.UpdateCommand.Parameters.Add(p2);

            OracleParameter p2i = new OracleParameter();
            p2i.ParameterName = ":pk_post";
            p2i.SourceColumn = "PK_POST";
            da.InsertCommand.Parameters.Add(p2i);


            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = ":id";
            p3.SourceColumn = "PK_EMP";
            da.UpdateCommand.Parameters.Add(p3);


            OracleParameter p3i = new OracleParameter();
            p3i.ParameterName = ":id";
            p3i.SourceColumn = "PK_EMP";
            da.InsertCommand.Parameters.Add(p3i);


            OracleParameter p3d = new OracleParameter();
            p3d.ParameterName = ":id";
            p3d.SourceColumn = "PK_EMP";
            da.DeleteCommand.Parameters.Add(p3d);



            da.Update(ds,"Emp");


        }



        //public void Update(DataSet ds);

    }
}
