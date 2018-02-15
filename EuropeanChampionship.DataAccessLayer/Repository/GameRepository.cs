using System.Collections.Generic;
using System.Linq;
using EuropeanChampionship.Model.Repositories;
using EuropeanChampionship.Model;
using NHibernate;
using NHibernate.Linq;

namespace EuropeanChampionship.DataAccessLayer.Repository
{
    public class GameRepository : IGameRepository
    {
        private ISession _currSession = null;
        public GameRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public void AddGame(Game game)
        {
            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Save(game);
                transaction.Commit();
            }
        }

        public void DeleteGame(Game game)
        {
            Game g = _currSession.Get<Game>(game.ID);
            if (g == null) { return; }

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Delete(g);
                transaction.Commit();
            }
        }

        public IList<Game> GetAllGames()
        {
            List<Game> games = _currSession.Query<Game>().ToList();
            return games;
        }

        public Game GetGameById(int gameId)
        {
            Game game = _currSession.Get<Game>(gameId);
            return game;
        }

        public IList<Game> GetGamesByGroup(string groupId)
        {
            List<Game> games = _currSession.Query<Game>().Where(x => x.Group.Name == groupId).ToList();
            return games;
        }

        public IList<Game> GetGamesByTeam(string teamId)
        {
            List<Game> games = _currSession.Query<Game>().ToList();
            List<Game> teamGames = new List<Game>();
            foreach(Game g in games)
            {
                if (g.TeamAway.Name == teamId || g.TeamHome.Name == teamId)
                {
                    teamGames.Add(g);
                }
            }

            return teamGames;
        }

        public void UpdateGame(Game game)
        {
            Game g = _currSession.Get<Game>(game.ID);
            if(g == null) { return; }
            g = game;

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Update(g);
                transaction.Commit();
            }
        }
    }
}
