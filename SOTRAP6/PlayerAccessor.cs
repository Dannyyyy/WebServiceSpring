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
        public class PlayerAccessor
        {
            public void Read(AbstractConnection conn, AbstractTransaction trans, BasketballTeams teams)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(@"select * from Player", conn.Connection, trans.Transaction);
                adapter.Fill(teams, "Player");
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
                SqlParameter age = new SqlParameter();
                age.ParameterName = "@Age";
                age.SourceColumn = "Age";
                SqlParameter city = new SqlParameter();
                city.ParameterName = "@City";
                city.SourceColumn = "City";
                SqlParameter numberOfTeam = new SqlParameter();
                numberOfTeam.ParameterName = "@NumberOfTeam";
                numberOfTeam.SourceColumn = "NumberOfTeam";
                SqlParameter idTeam = new SqlParameter();
                idTeam.ParameterName = "@IdTeam";
                idTeam.SourceColumn = "IdTeam";
                SqlParameter idManager = new SqlParameter();
                idManager.ParameterName = "@IdManager";
                idManager.SourceColumn = "IdManager";

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.UpdateCommand = new SqlCommand(@"update Player set Name = @Name, Surname = @Surname, Age = @Age, NumberOfTeam = @NumberOfTeam, IdTeam = @IdTeam, IdManager = @IdManager where Id = @Id", conn.Connection, trans.Transaction);
                adapter.UpdateCommand.Parameters.Add(id);
                adapter.UpdateCommand.Parameters.Add(name);
                adapter.UpdateCommand.Parameters.Add(surname);
                adapter.UpdateCommand.Parameters.Add(age);
                adapter.UpdateCommand.Parameters.Add(numberOfTeam);
                adapter.UpdateCommand.Parameters.Add(idTeam);
                adapter.UpdateCommand.Parameters.Add(idManager);

            SqlParameter id2 = new SqlParameter();
            id2.ParameterName = "@Id";
            id2.SourceColumn = "Id";
            SqlParameter name2 = new SqlParameter();
            name2.ParameterName = "@Name";
            name2.SourceColumn = "Name";
            SqlParameter surname2 = new SqlParameter();
            surname2.ParameterName = "@Surname";
            surname2.SourceColumn = "Surname";
            SqlParameter age2 = new SqlParameter();
            age2.ParameterName = "@Age";
            age2.SourceColumn = "Age";
            SqlParameter city2 = new SqlParameter();
            city2.ParameterName = "@City";
            city2.SourceColumn = "City";
            SqlParameter numberOfTeam2 = new SqlParameter();
            numberOfTeam2.ParameterName = "@NumberOfTeam";
            numberOfTeam2.SourceColumn = "NumberOfTeam";
            SqlParameter idTeam2 = new SqlParameter();
            idTeam2.ParameterName = "@IdTeam";
            idTeam2.SourceColumn = "IdTeam";
            SqlParameter idManager2 = new SqlParameter();
            idManager2.ParameterName = "@IdManager";
            idManager2.SourceColumn = "IdManager";

            adapter.InsertCommand = new SqlCommand(@"insert into Player(Name, Surname,Age,NumberOfTeam, IdTeam, IdManager) values(@Name, @Surname, @Age, @NumberOfTeam, @IdTeam, @IdManager)", conn.Connection, trans.Transaction);
                adapter.InsertCommand.Parameters.Add(name2);
                adapter.InsertCommand.Parameters.Add(surname2);
                adapter.InsertCommand.Parameters.Add(age2);
                adapter.InsertCommand.Parameters.Add(numberOfTeam2);
                adapter.InsertCommand.Parameters.Add(idTeam2);
                adapter.InsertCommand.Parameters.Add(idManager2);

                adapter.DeleteCommand = new SqlCommand(@"delete from Player where Id = @Id", conn.Connection, trans.Transaction);
                adapter.DeleteCommand.Parameters.Add(id2);

                adapter.Update(teams, "Player");
            }
        }
    //}
}
