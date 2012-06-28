using FluentNHibernate.Mapping;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class NaamMap : EntityMap<Naam>
    {
        public NaamMap()
        {
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.NmMemo).Not.Nullable().Length(6);
            Map(x => x.NmEtiket).Not.Nullable().Length(27);
            Map(x => x.NmNm40).Not.Nullable().Length(40);
            Map(x => x.NmNaam).Not.Nullable().Length(50);
        }
    }
}
