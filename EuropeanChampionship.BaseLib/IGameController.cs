using EuropeanChampionship.Model;

namespace EuropeanChampionship.BaseLib
{
    public interface IGameController
    {
        void ShowAllGroupGames(IViewGroupGames newFrm);
        void UpdateGameScore(IUpdateGame newForm, Game game, IViewGroupGames form);
    }
}
