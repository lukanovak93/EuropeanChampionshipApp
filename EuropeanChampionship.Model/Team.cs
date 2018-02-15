using System.Collections.Generic;

namespace EuropeanChampionship.Model
{
    public class Team
    {
        public virtual string Name { get; set; }
        public virtual Group Group { get; set; }
        public virtual IList<Game> Games { get; set; }

        public Team(string name, IList<Game> g, Group group)
        {
            Name = name;
            Group = group;
            Games = g;
        }

        public Team(string name, Group group)
        {
            Name = name;
            Group = group;
            Games = new List<Game>();
        }

        public Team(string name)
        {
            Name = name;
            Games = new List<Game>();
        }

        public Team()
        {
            Name = "NoTeam";
            Games = new List<Game>();
        }
    }
}
