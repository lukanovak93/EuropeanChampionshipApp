using System.Collections.Generic;

namespace EuropeanChampionship.Model.Repositories
{
    public interface IGroupRepository
    {
        Group GetGroup(string groupId);
        IList<Group> GetAllGroups();
        void AddGroup(Group group);
        void UpdateGroup(Group group);
        void DeleteGroup(Group group);
        IList<Team> GetGroupTeams(string groupId);
        IList<Game> GetGroupGames(string groupId);
    }
}
