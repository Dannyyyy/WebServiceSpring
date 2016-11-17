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
        public class CoachAccessor
        {
            public void Read(AbstractConnection conn, AbstractTransaction trans, BasketballTeams teams)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(@"select * from Coach", conn.Connection, trans.Transaction);
                adapter.Fill(teams, "Coach");
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
                SqlParameter numberOfChampions = new SqlParameter();
                numberOfChampions.ParameterName = "@NumberOfChampions";
                numberOfChampions.SourceColumn = "NumberOfChampions";

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.UpdateCommand = new SqlCommand(@"update Coach set Name = @Name, Surname = @Surname, NumberOfChampions = @NumberOfChampions where Id = @Id", conn.Connection, trans.Transaction);
                adapter.UpdateCommand.Parameters.Add(id);
                adapter.UpdateCommand.Parameters.Add(name);
                adapter.UpdateCommand.Parameters.Add(surname);
                adapter.UpdateCommand.Parameters.Add(numberOfChampions);

            SqlParameter id2 = new SqlParameter();
            id2.ParameterName = "@Id";
            id2.SourceColumn = "Id";
            SqlParameter name2 = new SqlParameter();
            name2.ParameterName = "@Name";
            name2.SourceColumn = "Name";
            SqlParameter surname2 = new SqlParameter();
            surname2.ParameterName = "@Surname";
            surname2.SourceColumn = "Surname";
            SqlParameter numberOfChampions2 = new SqlParameter();
            numberOfChampions2.ParameterName = "@NumberOfChampions";
            numberOfChampions2.SourceColumn = "NumberOfChampions";

            adapter.InsertCommand = new SqlCommand(@"insert into Coach(Name, Surname,NumberOfChampions) values(@Name, @Surname, @NumberOfChampions)", conn.Connection, trans.Transaction);
                adapter.InsertCommand.Parameters.Add(name2);
                adapter.InsertCommand.Parameters.Add(surname2);
                adapter.InsertCommand.Parameters.Add(numberOfChampions2);

                adapter.DeleteCommand = new SqlCommand(@"delete from Coach where Id = @Id", conn.Connection, trans.Transaction);
                adapter.DeleteCommand.Parameters.Add(id2);

                adapter.Update(teams, "Coach");
            }
        }
    //}
}
