using EuropeanChampionship.Model.Repositories;

namespace EuropeanChampionship.BaseLib
{
    public interface IAddNewTeamView
    {
        bool ShowModal();
        void AddTeam(IViewTeams form, ITeamController teamController, IGroupRepository groupRepository);
    }
}
