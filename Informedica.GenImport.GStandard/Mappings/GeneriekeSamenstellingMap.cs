using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class GeneriekeSamenstellingMap : EntityMap<GeneriekeSamenstelling>
    {
        public GeneriekeSamenstellingMap()
        {
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.GnMomH).Not.Nullable().Precision(12).Scale(3);
            Map(x => x.GnMwHs).Not.Nullable().CustomType<byte>();
            Map(x => x.GnNkPk).Not.Nullable(); //TODO reference
            Map(x => x.XnMomE).Not.Nullable(); //TODO reference
            Map(x => x.XpEhHv).Not.Nullable(); //TODO reference
        }
    }
}
