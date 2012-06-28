using FluentNHibernate.Mapping;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public abstract class EntityMap<TEnt> : ClassMap<TEnt>
        where TEnt : Entity<TEnt>
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
