using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System.Collections.Generic;

namespace EuropeanChampionship.BaseLib
{
    public interface IViewTeams
    {
        void ShowAllTeams(ITeamController teamController, IGroupRepository groupRepository, List<Team> listTeam);
    }
}