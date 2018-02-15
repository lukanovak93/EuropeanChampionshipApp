using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System.Collections.Generic;

namespace EuropeanChampionship.BaseLib
{
    public interface IViewGroupGames
    {
        void ShowAllGroupGames(IGameController gameController, IGameRepository gameRepository, IList<Game> listGames);
    }
}
