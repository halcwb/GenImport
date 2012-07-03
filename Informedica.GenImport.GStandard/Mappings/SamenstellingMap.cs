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
            Map(x => x.Code).UniqueKey("un_samenstelling");
            Map(x => x.GnGnK).UniqueKey("un_samenstelling");  //TODO reference
            Map(x => x.GnHoev).Precision(12).Scale(3).UniqueKey("un_samenstelling");
            Map(x => x.GnEenh).UniqueKey("un_samenstelling"); //TODO reference
            //end id

            Map(x => x.MutKod).CustomType<byte>();
            Map(x => x.ThsrTc); //TODO reference
            Map(x => x.TsGneH); //TODO reference
            Map(x => x.GnStam); //TODO reference
            Map(x => x.StHoev).Precision(12).Scale(3);
            Map(x => x.TsStEh); //TODO reference
            Map(x => x.StEenh); //TODO reference
            Map(x => x.StAdd);
        }
    }
}
