using FluentNHibernate.Mapping;
using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class GeneriekeSamenstellingMap : ClassMap<GeneriekeSamenstelling>
    {
        public GeneriekeSamenstellingMap()
        {
            Id(x => x.GsKode);

            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.GnMomH).Not.Nullable().Precision(12).Scale(3);
            Map(x => x.GnMwHs).Not.Nullable().CustomType<byte>();
            
            Map(x => x.XnMomE).Not.Nullable(); //TODO reference
            Map(x => x.XpEhHv).Not.Nullable(); //TODO reference

            Map(x => x.GnNkPk).Not.Nullable();

            //References<GeneriekeNaam>(x => x.GeneriekeNaam).Column("GnNkPk").Not.Nullable();
        }
    }
}
