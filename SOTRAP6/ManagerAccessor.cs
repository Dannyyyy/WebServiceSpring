using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SOTRAP6
{
    //partial class BasketballTeams
    //{
        public class ManagerAccessor
        {
            public void Read(AbstractConnection conn, AbstractTransaction trans, BasketballTeams teams)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(@"select * from Manager", conn.Connection, trans.Transaction);
                adapter.Fill(teams, "Manager");
            }

            public void Update(AbstractConnection conn, AbstractTransaction trans, BasketballTeams teams)
            {
                SqlParameter id = new SqlParameter();
                id.ParameterName = "@Id";
                id.SourceColumn = "Id";
                SqlParameter name = new SqlParameter();
                name.ParameterName = "@Name";
                name.SourceColumn = "Name";
                SqlParameter surname = new SqlParameter();
                surname.ParameterName = "@Surname";
                surname.SourceColumn = "Surname";
                SqlParameter telNumber = new SqlParameter();
                telNumber.ParameterName = "@TelNumber";
                telNumber.SourceColumn = "TelNumber";
                SqlParameter email = new SqlParameter();
                email.ParameterName = "@Email";
                email.SourceColumn = "Email";

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.UpdateCommand = new SqlCommand(@"update Manager set Name = @Name, Surname = @Surname, TelNumber = @TelNumber, Email = @Email where Id = @Id", conn.Connection, trans.Transaction);
                adapter.UpdateCommand.Parameters.Add(id);
                adapter.UpdateCommand.Parameters.Add(name);
                adapter.UpdateCommand.Parameters.Add(surname);
                adapter.UpdateCommand.Parameters.Add(telNumber);
                adapter.UpdateCommand.Parameters.Add(email);

            SqlParameter id1 = new SqlParameter();
            id1.ParameterName = "@Id";
            id1.SourceColumn = "Id";
            SqlParameter name1 = new SqlParameter();
            name1.ParameterName = "@Name";
            name1.SourceColumn = "Name";
            SqlParameter surname1 = new SqlParameter();
            surname1.ParameterName = "@Surname";
            surname1.SourceColumn = "Surname";
            SqlParameter telNumber1 = new SqlParameter();
            telNumber1.ParameterName = "@TelNumber";
            telNumber1.SourceColumn = "TelNumber";
            SqlParameter email1 = new SqlParameter();
            email1.ParameterName = "@Email";
            email1.SourceColumn = "Email";

            adapter.InsertCommand = new SqlCommand(@"insert into Manager(Name, Surname, TelNumber, Email) values(@Name, @Surname, @TelNumber, @Email)", conn.Connection, trans.Transaction);
                adapter.InsertCommand.Parameters.Add(name1);
                adapter.InsertCommand.Parameters.Add(surname1);
                adapter.InsertCommand.Parameters.Add(telNumber1);
                adapter.InsertCommand.Parameters.Add(email1);
        
                adapter.DeleteCommand = new SqlCommand(@"delete from Manager where Id = @Id", conn.Connection, trans.Transaction);
                adapter.DeleteCommand.Parameters.Add(id1);

                adapter.Update(teams, "Manager");
            }
        }
    //}
}
