using FluentNHibernate.Mapping;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class SamenstellingMap : ClassMap<Samenstelling>
    {
        public SamenstellingMap()
        {
            //TODO Id exists of these fields.
            Id(x => x.SrtCde).UniqueKey("un_samenstelling");
            Map(x => x.Code).Not.Nullable().UniqueKey("un_samenstelling");
            Map(x => x.GnGnK).Not.Nullable().UniqueKey("un_samenstelling");  //TODO reference
            Map(x => x.GnHoev).Not.Nullable().Precision(12).Scale(3).UniqueKey("un_samenstelling");
            Map(x => x.GnEenh).Not.Nullable().UniqueKey("un_samenstelling"); //TODO reference
            //end id

            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.ThsrTc).Not.Nullable(); //TODO reference
            Map(x => x.TsGneH).Not.Nullable(); //TODO reference
            Map(x => x.GnStam).Not.Nullable(); //TODO reference
            Map(x => x.StHoev).Not.Nullable().Precision(12).Scale(3);
            Map(x => x.TsStEh).Not.Nullable(); //TODO reference
            Map(x => x.StEenh).Not.Nullable(); //TODO reference
            Map(x => x.StAdd).Not.Nullable();
        }
    }
}
