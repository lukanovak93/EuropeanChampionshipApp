using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EuropeanChampionship
{
    public partial class frmViewGroupGames : Form, IViewGroupGames
    {
        private IGameController _gameController;
        private IGameRepository _gamesRepository;
        private Game _selectedGame;
        IList<Game> _listGames;

        public frmViewGroupGames()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            gameList.Rows.Clear();
            gameList.Refresh();

            foreach (Game g in _listGames)
            {
                DataGridViewRow row = (DataGridViewRow)gameList.Rows[0].Clone();
                row.Cells[0].Value = g.TeamHome.Name;
                row.Cells[1].Value = g.TeamHomeScore;
                row.Cells[2].Value = g.TeamAwayScore;
                row.Cells[3].Value = g.TeamAway.Name;
                gameList.Rows.Add(row);
            }
        }

        public void ShowAllGroupGames(IGameController gameController, IGameRepository gameRepository, IList<Game> listGames)
        {
            _gameController = gameController;
            _gamesRepository = gameRepository;
            _listGames = listGames;

            UpdateList();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(_selectedGame != null)
            {
                var newForm = new frmEditGame();
                newForm.UpdateGame(this, _gameController, _gamesRepository, _selectedGame);
                UpdateList();
            }
        }

        private void gameList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string teamHome = gameList.Rows[e.RowIndex].Cells[0].Value.ToString();
            string teamAway = gameList.Rows[e.RowIndex].Cells[3].Value.ToString();

            var gameListTmp = _gamesRepository.GetAllGames();
            foreach (Game g in gameListTmp)
            {
                if (g.TeamHome.Name.Equals(teamHome) && g.TeamAway.Name.Equals(teamAway))
                {
                    _selectedGame = g;
                    break;
                }
            }
            var newForm = new frmEditGame();
            newForm.UpdateGame(this, _gameController, _gamesRepository, _selectedGame);
            UpdateList();
        }
    }
}
