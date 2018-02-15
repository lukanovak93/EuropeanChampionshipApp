using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EuropeanChampionship
{
    public partial class frmViewGroups : Form, IViewGroups
    {
        private IGroupController _groupController;
        private IList<Group> _listGroups;

        public frmViewGroups()
        {
            InitializeComponent();
        }

        public void ShowAllGroups(IGroupController groupController, List<Group> listGroups)
        {
            _groupController = groupController;
            _listGroups = listGroups;
            UpdateList();

            this.Show();
        }

        private void UpdateList()
        {
            groupList.Rows.Clear();
            groupList.Refresh();

            foreach(Group g in _listGroups)
            {
                DataGridViewRow row = (DataGridViewRow)groupList.Rows[0].Clone();
                row.Cells[0].Value = g.Name;
                groupList.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new frmAddNewGroup();
            newForm.AddGroup(this, _groupController);
            UpdateList();
        }
    }
}
