using EuropeanChampionship.Controller;
using EuropeanChampionship.DataAccessLayer;
using EuropeanChampionship.DataAccessLayer.Repository;
using EuropeanChampionship.Model.Repositories;
using NHibernate;
using System;
using System.Windows.Forms;

namespace EuropeanChampionship
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ISession session = NHibernateService.OpenSession();

            WindowsFormsFactory _formsFactory = new WindowsFormsFactory();
            ITeamRepository _teamRepository = new TeamRepository(session);
            IGameRepository _gameRepository = new GameRepository(session);
            IGroupRepository _groupRepository = new GroupRepository(session);

            InitialFormController initialFormController = 
                new InitialFormController(_formsFactory, _teamRepository, _gameRepository, _groupRepository);

            initialFormController.LoadDefaultModel();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInitialForm(initialFormController));
        }
    }
}
