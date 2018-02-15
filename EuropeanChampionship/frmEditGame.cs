using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System;
using System.Windows.Forms;

namespace EuropeanChampionship
{
    public partial class frmEditGame : Form, IUpdateGame
    {
        private IGameController _gameController;
        private IGameRepository _gameRepository;
        private Game _selectedGame;
        private IViewGroupGames _form;

        public frmEditGame()
        {
            InitializeComponent();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(IViewGroupGames form, IGameController gameController, IGameRepository gameRepository, Game selectedGame)
        {
            _gameController = gameController;
            _gameRepository = gameRepository;
            _selectedGame = selectedGame;
            _form = form;

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int homeTeamScore = Int32.Parse(this.teamHomeScore.Text);
            int awayTeamScore = Int32.Parse(this.teamAwayScore.Text);

            _selectedGame.TeamHomeScore = homeTeamScore;
            _selectedGame.TeamAwayScore = awayTeamScore;

            _gameController.UpdateGameScore(this, _selectedGame, _form);
            Close();
        }
    }
}
