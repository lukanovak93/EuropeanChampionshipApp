namespace EuropeanChampionship.BaseLib
{
    public interface IWindowsFormsFactory
    {
        IViewGroups CreateViewGroups();
        IViewTeams CreateViewTeams();
        IViewGroupGames CreateViewGroupGames();
    }
}
