using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EuropeanChampionship.Controller
{
    public class TeamController : ITeamController
    {
        ITeamRepository _repository;
        IGroupRepository _groupRepository;

        public TeamController(ITeamRepository teamRepository, IGroupRepository groupRepository)
        {
            _repository = teamRepository;
            _groupRepository = groupRepository;
        }

        public void AddNewTeam(IAddNewTeamView newForm, Team team, IViewTeams form)
        {
            _repository.AddTeam(team);
            team.Group.Teams.Add(team);
            _groupRepository.UpdateGroup(team.Group);

            this.ShowAllTeams(form);
        }

        public void ShowAllTeams(IViewTeams newFrm)
        {
            List<Team> teamList = _repository.GetAllTeams().ToList();
            newFrm.ShowAllTeams(this, _groupRepository, teamList);
        }
    }
}
