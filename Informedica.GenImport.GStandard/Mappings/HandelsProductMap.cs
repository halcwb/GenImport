using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class HandelsProductMap : EntityMap<HandelsProduct>
    {
        public HandelsProductMap()
        {
            Map(x => x.FsNaam).Not.Nullable().Length(50);
            Map(x => x.HpNamN).Not.Nullable().Length(7);
            Map(x => x.MsNaam).Not.Nullable().Length(50);
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.TsEmbM).Not.Nullable();
            Map(x => x.XsEmbM).Not.Nullable();
        }
    }
}
