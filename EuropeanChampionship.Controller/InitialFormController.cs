using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;

namespace EuropeanChampionship.Controller
{
    public class InitialFormController : IInitialFormController
    {
        private readonly IWindowsFormsFactory _formFactory;
        private IGroupRepository _groupRepository;
        private ITeamRepository _teamRepository;
        private IGameRepository _gameRepository;
        private bool _defaultModelLoaded = false;

        public InitialFormController(IWindowsFormsFactory inFactory, ITeamRepository teamRepo, IGameRepository gameRepo, IGroupRepository groupRepo)
        {
            _teamRepository = teamRepo;
            _gameRepository = gameRepo;
            _groupRepository = groupRepo;
            _formFactory = inFactory;
        }

        public void LoadDefaultModel()
        {
            if(_defaultModelLoaded == false)
            {
                Group groupA = new Group("A");
                Group groupB = new Group("B");
                _groupRepository.AddGroup(groupA);
                _groupRepository.AddGroup(groupB);

                Team hrv = new Team("Hrvatska", groupA);
                Team fra = new Team("Francuska", groupA);
                Game GameA = new Game(hrv, fra, groupA);
                Team den = new Team("Danska", groupB);
                Team ger = new Team("Njemacka", groupB);
                Game GameB = new Game(den, ger, groupB);
                _teamRepository.AddTeam(hrv);
                groupA.Teams.Add(hrv);
                _teamRepository.AddTeam(fra);
                groupA.Teams.Add(fra);
                _teamRepository.AddTeam(den);
                groupB.Teams.Add(den);
                _teamRepository.AddTeam(ger);
                groupB.Teams.Add(ger);
                _gameRepository.AddGame(GameA);
                _gameRepository.AddGame(GameB);
                

                _defaultModelLoaded = true;
            }
        }

        public void ShowAllGroups()
        {
            var newForm = _formFactory.CreateViewGroups();
            IGroupController groupController = new GroupController(_groupRepository);

            groupController.ShowAllGroups(newForm);
        }

        public void ShowAllTeams()
        {
            var newForm = _formFactory.CreateViewTeams();
            ITeamController teamController = new TeamController(_teamRepository, _groupRepository);

            teamController.ShowAllTeams(newForm);
        }

        public void ShowGroupGames()
        {
            var newForm = _formFactory.CreateViewGroupGames();
            IGameController gameController = new GameController(_gameRepository);

            gameController.ShowAllGroupGames(newForm);
        }
    }
}
