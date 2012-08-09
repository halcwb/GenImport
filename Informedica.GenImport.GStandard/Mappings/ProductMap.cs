using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class ProductMap : EntityMap<Product>
    {
        public ProductMap()
        {
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.AtNmNr).Not.Nullable();
            Map(x => x.HpKode).Not.Nullable();
        }
    }
}
