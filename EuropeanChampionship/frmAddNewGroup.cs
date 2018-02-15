using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using System;
using System.Windows.Forms;

namespace EuropeanChampionship
{
    public partial class frmAddNewGroup : Form, IAddNewGroupView
    {
        IGroupController _groupController;
        IViewGroups _form;

        public frmAddNewGroup()
        {
            InitializeComponent();
        }

        public void AddGroup(IViewGroups form, IGroupController groupController)
        {
            _groupController = groupController;
            _form = form;
            this.Show();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            Group g = new Group(name);

            _groupController.AddNewGroup(this, g, _form);
            this.Close();
        }
    }
}
