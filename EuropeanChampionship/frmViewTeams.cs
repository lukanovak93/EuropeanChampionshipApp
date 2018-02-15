using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EuropeanChampionship
{
    public partial class frmViewTeams : Form, IViewTeams
    {
        private ITeamController _teamController;
        private IGroupRepository _groupRepository;
        IList<Team> _listTeams;

        public frmViewTeams()
        {
            InitializeComponent();
        }

        public void ShowAllTeams(ITeamController teamController, IGroupRepository groupRepository, List<Team> listTeam)
        {
            _teamController = teamController;
            _groupRepository = groupRepository;
            _listTeams = listTeam;

            UpdateList();

            this.Show();
        }

        private void UpdateList()
        {
            teamList.Rows.Clear();
            teamList.Refresh();
            foreach (Team t in _listTeams)
            {
                DataGridViewRow row = (DataGridViewRow)teamList.Rows[0].Clone();
                row.Cells[0].Value = t.Name;
                row.Cells[1].Value = t.Group;
                teamList.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new frmAddNewTeam();
            newForm.AddTeam(this, _teamController, _groupRepository);
            UpdateList();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }
    }
}
