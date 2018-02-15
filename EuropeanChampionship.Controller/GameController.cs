using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System.Collections.Generic;

namespace EuropeanChampionship.Controller
{
    public class GameController : IGameController
    {
        private IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public void ShowAllGroupGames(IViewGroupGames newFrm)
        {
            IList<Game> gameList = _gameRepository.GetAllGames();
            newFrm.ShowAllGroupGames(this, _gameRepository, gameList);
        }

        public void UpdateGameScore(IUpdateGame newForm, Game game, IViewGroupGames form)
        {
            _gameRepository.UpdateGame(game);

            this.ShowAllGroupGames(form);
        }
    }
}
