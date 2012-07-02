using FluentNHibernate.Mapping;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class GeneriekeNaamMap : ClassMap<GeneriekeNaam>
    {
        public GeneriekeNaamMap()
        {
            Id(x => x.GnGnK);
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.GnGnAm).Not.Nullable().Length(50);
        }
    }
}
