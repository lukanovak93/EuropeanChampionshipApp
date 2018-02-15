using EuropeanChampionship.Model;

namespace EuropeanChampionship.BaseLib
{
    public interface ITeamController
    {
        void ShowAllTeams(IViewTeams newFrm);
        void AddNewTeam(IAddNewTeamView newForm, Team team, IViewTeams form);
    }
}
