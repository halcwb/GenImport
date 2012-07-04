using FluentNHibernate.Mapping;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class SamenstellingMap : ClassMap<Samenstelling>
    {
        public SamenstellingMap()
        {
            Id(x => x.SrtCde);
            Map(x => x.Code).Not.Nullable();
            Map(x => x.GnGnK).Not.Nullable();
            Map(x => x.GnHoev).Not.Nullable().Precision(12).Scale(3);
            Map(x => x.GnEenh).Not.Nullable();

            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.ThsrTc).Not.Nullable();
            Map(x => x.TsGneH).Not.Nullable();
            Map(x => x.GnStam).Not.Nullable();
            Map(x => x.StHoev).Not.Nullable().Precision(12).Scale(3);
            Map(x => x.TsStEh).Not.Nullable();
            Map(x => x.StEenh).Not.Nullable();
            Map(x => x.StAdd).Not.Nullable();
        }
    }
}
