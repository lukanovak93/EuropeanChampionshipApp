using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;

namespace EuropeanChampionship.BaseLib
{
    public interface IUpdateGame
    {
        bool ShowModal();
        void UpdateGame(IViewGroupGames form, IGameController gameController, IGameRepository gameRepository, Game SelectedGame);
    }
}
