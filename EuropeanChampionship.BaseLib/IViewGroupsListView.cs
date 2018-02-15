using EuropeanChampionship.Model;
using System.Collections.Generic;

namespace EuropeanChampionship.BaseLib
{
    public interface IViewGroupsListView
    {
        void ShowAllGroups(IGroupController groupController, List<Group> listGroups);
    }
}
