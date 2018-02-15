using EuropeanChampionship.Model;
using System.Collections.Generic;

namespace EuropeanChampionship.BaseLib
{
    public interface IViewGroups
    {
        void ShowAllGroups(IGroupController groupController, List<Group> listGroup);
    }
}
