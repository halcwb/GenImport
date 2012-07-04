using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class PrescriptieProductMap : EntityMap<PrescriptieProduct>
    {
        public PrescriptieProductMap()
        {
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.PrNmNr).Not.Nullable();
        }
    }
}
