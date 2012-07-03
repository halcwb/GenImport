using FluentNHibernate.Mapping;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class HandelsProductMap : ClassMap<HandelsProduct>
    {
        public HandelsProductMap()
        {
            Id(x => x.HpKode);
            Map(x => x.FsNaam).Not.Nullable().Length(50);
            Map(x => x.HpNamN).Not.Nullable().Length(7); //TODO: reference
            Map(x => x.MsNaam).Not.Nullable().Length(50);
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.TsEmbM).Not.Nullable(); //TODO: reference
            Map(x => x.XsEmbM).Not.Nullable(); //TODO: reference
        }
    }
}
