using FluentNHibernate.Mapping;
using Informedica.EntityRepository.Entities;

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
