using EuropeanChampionship.Model;

namespace EuropeanChampionship.BaseLib
{
    public interface IGroupController
    {
        void ShowAllGroups(IViewGroups newFrm);
        void AddNewGroup(IAddNewGroupView newForm, Group g, IViewGroups form);
    }
}
