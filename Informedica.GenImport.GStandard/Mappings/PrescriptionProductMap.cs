using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class PrescriptionProductMap : EntityMap<PrescriptionProduct>
    {
        public PrescriptionProductMap()
        {
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.PrNmNr).Not.Nullable();
        }
    }
}
