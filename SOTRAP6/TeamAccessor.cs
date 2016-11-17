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
        public class TeamAccessor
        {
            public void Read(AbstractConnection conn, AbstractTransaction trans, BasketballTeams teams)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(@"select * from Team", conn.Connection, trans.Transaction);
                adapter.Fill(teams, "Team");
            }

            public void Update(AbstractConnection conn, AbstractTransaction trans, BasketballTeams teams)
            {
                SqlParameter id = new SqlParameter();
                id.ParameterName = "@Id";
                id.SourceColumn = "Id";
                SqlParameter name = new SqlParameter();
                name.ParameterName = "@Name";
                name.SourceColumn = "Name";
                SqlParameter yearFoundation = new SqlParameter();
                yearFoundation.ParameterName = "@YearFoundation";
                yearFoundation.SourceColumn = "YearFoundation";
                SqlParameter city = new SqlParameter();
                city.ParameterName = "@City";
                city.SourceColumn = "City";
                SqlParameter numberOfChampions = new SqlParameter();
                numberOfChampions.ParameterName = "@NumberOfChampions";
                numberOfChampions.SourceColumn = "NumberOfChampions";
                SqlParameter idCoach = new SqlParameter();
                idCoach.ParameterName = "@IdCoach";
                idCoach.SourceColumn = "IdCoach";

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.UpdateCommand = new SqlCommand(@"update Team set Name = @Name, YearFoundation = @YearFoundation, City = @City, NumberOfChampions = @NumberOfChampions, IdCoach = @IdCoach where Id = @Id", conn.Connection, trans.Transaction);
                adapter.UpdateCommand.Parameters.Add(id);
                adapter.UpdateCommand.Parameters.Add(name);
                adapter.UpdateCommand.Parameters.Add(yearFoundation);
                adapter.UpdateCommand.Parameters.Add(city);
                adapter.UpdateCommand.Parameters.Add(numberOfChampions);
                adapter.UpdateCommand.Parameters.Add(idCoach);

            SqlParameter id2 = new SqlParameter();
            id2.ParameterName = "@Id";
            id2.SourceColumn = "Id";
            SqlParameter name2 = new SqlParameter();
            name2.ParameterName = "@Name";
            name2.SourceColumn = "Name";
            SqlParameter yearFoundation2 = new SqlParameter();
            yearFoundation2.ParameterName = "@YearFoundation";
            yearFoundation2.SourceColumn = "YearFoundation";
            SqlParameter city2 = new SqlParameter();
            city2.ParameterName = "@City";
            city2.SourceColumn = "City";
            SqlParameter numberOfChampions2 = new SqlParameter();
            numberOfChampions2.ParameterName = "@NumberOfChampions";
            numberOfChampions2.SourceColumn = "NumberOfChampions";
            SqlParameter idCoach2 = new SqlParameter();
            idCoach2.ParameterName = "@IdCoach";
            idCoach2.SourceColumn = "IdCoach";

            adapter.InsertCommand = new SqlCommand(@"insert into Team(Name, YearFoundation, City, NumberOfChampions, IdCoach) values(@Name, @YearFoundation, @City, @NumberOfChampions, @IdCoach)", conn.Connection, trans.Transaction);
                adapter.InsertCommand.Parameters.Add(name2);
                adapter.InsertCommand.Parameters.Add(yearFoundation2);
                adapter.InsertCommand.Parameters.Add(city2);
                adapter.InsertCommand.Parameters.Add(numberOfChampions2);
                adapter.InsertCommand.Parameters.Add(idCoach2);

                adapter.DeleteCommand = new SqlCommand(@"delete from Team where Id = @Id", conn.Connection, trans.Transaction);
                adapter.DeleteCommand.Parameters.Add(id2);

                adapter.Update(teams, "Team");
            }
        }
    //}
}
