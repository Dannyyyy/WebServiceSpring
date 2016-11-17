using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace SOTRAP6
{
    public interface AbstractLogic
    {
        BasketballTeams readCoachs();
        void updateCoach(BasketballTeams datasetBasketballTeams);
        BasketballTeams readTeams();
        void updateTeam(BasketballTeams datasetBasketballTeams);
        BasketballTeams readPlayers();
        void updatePlayer(BasketballTeams datasetBasketballTeams);
        BasketballTeams readManagers();
        void updateManager(BasketballTeams datasetBasketballTeams);
    }

    [WebService(Namespace = "http://somecompany/someservice")]
    public class BasketballLogic : AbstractLogic
    {
        private string connectionString;
        private CoachAccessor coach;
        private ManagerAccessor manager;
        private PlayerAccessor player;
        private TeamAccessor team;

        public BasketballLogic()
        {
            
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public CoachAccessor CoachAccessor
        {
            get { return coach; }
            set { coach = value; }
        }

        public TeamAccessor TeamAccessor
        {
            get { return team; }
            set { team = value; }
        }

        public PlayerAccessor PlayerAccessor
        {
            get { return player; }
            set { player = value; }
        }

        public ManagerAccessor ManagerAccessor
        {
            get { return manager; }
            set { manager = value; }
        }

        // считать всех тренеров
        [WebMethod]
        public BasketballTeams readCoachs()
        {
            BasketballTeams datasetBasketballTeams = new BasketballTeams();
            AbstractConnection abstractConnection = new AbstractConnection(ConnectionString);
            try
            {
                abstractConnection.openConnection();
                AbstractTransaction abstractTransaction = abstractConnection.openTransaction();
                try
                {
                    coach.Read(abstractConnection, abstractTransaction, datasetBasketballTeams);
                }
                finally
                {
                    abstractTransaction.rollback();
                }
            }
            finally
            {
                abstractConnection.closeConnection();
            }
            return datasetBasketballTeams;
        }

        // считать всех менеджеров
        public BasketballTeams readManagers()
        {
            BasketballTeams datasetBasketballTeams = new BasketballTeams();
            AbstractConnection abstractConnection = new AbstractConnection(ConnectionString);
            try
            {
                abstractConnection.openConnection();
                AbstractTransaction abstractTransaction = abstractConnection.openTransaction();
                try
                {
                    manager.Read(abstractConnection, abstractTransaction, datasetBasketballTeams);
                }
                finally
                {
                    abstractTransaction.rollback();
                }
            }
            finally
            {
                abstractConnection.closeConnection();
            }
            return datasetBasketballTeams;
        }

        // считать все команды
        public BasketballTeams readTeams()
        {
            BasketballTeams datasetBasketballTeams = new BasketballTeams();
            AbstractConnection abstractConnection = new AbstractConnection(ConnectionString);
            try
            {
                abstractConnection.openConnection();
                AbstractTransaction abstractTransaction = abstractConnection.openTransaction();
                try
                {
                    coach.Read(abstractConnection, abstractTransaction, datasetBasketballTeams);
                    team.Read(abstractConnection, abstractTransaction, datasetBasketballTeams);
                }
                finally
                {
                    abstractTransaction.rollback();
                }
            }
            finally
            {
                abstractConnection.closeConnection();
            }
            return datasetBasketballTeams;
        }

        // считать всех игроков
        public BasketballTeams readPlayers()
        {
            BasketballTeams datasetBasketballTeams = new BasketballTeams();
            AbstractConnection abstractConnection = new AbstractConnection(ConnectionString);
            try
            {
                abstractConnection.openConnection();
                AbstractTransaction abstractTransaction = abstractConnection.openTransaction();
                try
                {
                    team.Read(abstractConnection, abstractTransaction, datasetBasketballTeams);
                    manager.Read(abstractConnection, abstractTransaction, datasetBasketballTeams);
                    player.Read(abstractConnection, abstractTransaction, datasetBasketballTeams);
                }
                finally
                {
                    abstractTransaction.rollback();
                }
            }
            finally
            {
                abstractConnection.closeConnection();
            }
            return datasetBasketballTeams;
        }

        // изменить информацию о тренере
        public void updateCoach(BasketballTeams datasetBasketballTeams)
        {
            AbstractConnection abstractConnection = new AbstractConnection(ConnectionString);
            try
            {
                abstractConnection.openConnection();
                AbstractTransaction abstractTransaction = abstractConnection.openTransaction();
                try
                {
                    coach.Update(abstractConnection, abstractTransaction, datasetBasketballTeams);
                    abstractTransaction.commit();
                }
                catch
                {
                    abstractTransaction.rollback();
                }
            }
            finally
            {
                abstractConnection.closeConnection();
            }
        }

        // изменить информацию о менеджере
        public void updateManager(BasketballTeams datasetBasketballTeams)
        {
            AbstractConnection abstractConnection = new AbstractConnection(ConnectionString);
            try
            {
                abstractConnection.openConnection();
                AbstractTransaction abstractTransaction = abstractConnection.openTransaction();
                try
                {
                    manager.Update(abstractConnection, abstractTransaction, datasetBasketballTeams);
                    abstractTransaction.commit();
                }
                catch
                {
                    abstractTransaction.rollback();
                }
            }
            finally
            {
                abstractConnection.closeConnection();
            }
        }

        // изменить информацию о команде
        public void updateTeam(BasketballTeams datasetBasketballTeams)
        {
            AbstractConnection abstractConnection = new AbstractConnection(ConnectionString);
            try
            {
                abstractConnection.openConnection();
                AbstractTransaction abstractTransaction = abstractConnection.openTransaction();
                try
                {
                    team.Update(abstractConnection, abstractTransaction, datasetBasketballTeams);
                    abstractTransaction.commit();
                }
                catch
                {
                    abstractTransaction.rollback();
                }
            }
            finally
            {
                abstractConnection.closeConnection();
            }
        }

        // изменить информацию об игроке
        public void updatePlayer(BasketballTeams datasetBasketballTeams)
        {
            AbstractConnection abstractConnection = new AbstractConnection(ConnectionString);
            try
            {
                abstractConnection.openConnection();
                AbstractTransaction abstractTransaction = abstractConnection.openTransaction();
                try
                {
                    player.Update(abstractConnection, abstractTransaction, datasetBasketballTeams);
                    abstractTransaction.commit();
                }
                catch
                {
                    abstractTransaction.rollback();
                }
            }
            finally
            {
                abstractConnection.closeConnection();
            }
        }
    }
}
