using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public abstract class EntityMap<TEnt> : ClassMap<TEnt>
            where TEnt : Entity<TEnt, int>
    {
        protected EntityMap()
        {
            Map();
        }

        private void Map()
        {
            Id(x => x.Id).GeneratedBy.Assigned();
            SelectBeforeUpdate();
        }
    }
}
