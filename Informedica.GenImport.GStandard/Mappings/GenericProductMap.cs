using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class GenericProductMap : EntityMap<GenericProduct>
    {
        public GenericProductMap()
        {
            Map(x => x.GpInSt).Not.Nullable().Length(25);
            //Map(x => x.GpKode).Not.Nullable();
            Map(x => x.GpKtVr).Not.Nullable();
            Map(x => x.GpKTwg).Not.Nullable();
            Map(x => x.GpNmNr).Not.Nullable();
            Map(x => x.GpStNr).Not.Nullable();
            Map(x => x.GsKode).Not.Nullable();
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.SpKode).Not.Nullable();
            Map(x => x.ThEhHv).Not.Nullable();
            Map(x => x.ThKtVr).Not.Nullable();
            Map(x => x.ThKTwg).Not.Nullable();
            Map(x => x.XpEhHv).Not.Nullable();
        }
    }
}
