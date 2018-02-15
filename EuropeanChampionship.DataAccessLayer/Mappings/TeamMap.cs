﻿using EuropeanChampionship.Model;
using FluentNHibernate.Mapping;

namespace EuropeanChampionship.DataAccessLayer
{
    public class TeamMap : ClassMap<Team>
    {
        public TeamMap()
        {
            Id(p => p.Name).GeneratedBy.Assigned();
            References(p => p.Group);
            HasMany(p => p.Games).Cascade.All();
        }
    }
}
