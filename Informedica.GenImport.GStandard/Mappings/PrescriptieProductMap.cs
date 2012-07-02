using FluentNHibernate.Mapping;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class PrescriptieProductMap : ClassMap<PrescriptieProduct>
    {
        public PrescriptieProductMap()
        {
            Id(x => x.PrKode);
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.PrKBst).Not.Nullable();
            Map(x => x.PrNmNr).Not.Nullable(); //TODO reference
        }
    }
}
