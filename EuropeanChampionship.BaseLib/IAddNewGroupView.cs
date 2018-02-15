namespace EuropeanChampionship.BaseLib
{
    public interface IAddNewGroupView
    {
        bool ShowModal();
        void AddGroup(IViewGroups form, IGroupController groupController);
    }
}
