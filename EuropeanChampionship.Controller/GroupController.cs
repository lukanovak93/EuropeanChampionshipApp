using EuropeanChampionship.BaseLib;
using EuropeanChampionship.Model;
using EuropeanChampionship.Model.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EuropeanChampionship.Controller
{
    public class GroupController : IGroupController
    {
        public IGroupRepository _repository { get; }

        public GroupController(IGroupRepository groupRepository)
        {
            _repository = groupRepository;
        }

        public void ShowAllGroups(IViewGroups newFrm)
        {
            List<Group> groupList = _repository.GetAllGroups().ToList();
            newFrm.ShowAllGroups(this, groupList);
        }

        public void AddNewGroup(IAddNewGroupView newForm, Group g, IViewGroups form)
        {
            _repository.AddGroup(g);
            this.ShowAllGroups(form);
        }
    }
}
