using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EuropeanChampionship
{
    public partial class frmAddNewTeam : Form, IAddNewTeamView
    {
        private ITeamController _teamController;
        private IGroupRepository _groupRepository;
        IViewTeams _form;

        public frmAddNewTeam()
        {
            InitializeComponent();
        }

        public void AddTeam(IViewTeams form, ITeamController teamController, IGroupRepository groupRepository)
        {
            _teamController = teamController;
            _groupRepository = groupRepository;
            _form = form;
            AddComboBoxItems();
            this.Show();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.teamName.Text;
            Group teamGroup = group.SelectedItem as Group;

            Team t = new Team(name, teamGroup);
            _teamController.AddNewTeam(this, t, _form);

            Close();
        }

        private void AddComboBoxItems()
        {
            IList<Group> groupsFromDB = _groupRepository.GetAllGroups();

            foreach(Group g in groupsFromDB)
            {
                group.Items.Add(g);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
