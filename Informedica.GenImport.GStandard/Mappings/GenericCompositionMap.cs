using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class GenericCompositionMap : EntityMap<GenericComposition>
    {
        public GenericCompositionMap()
        {
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.GnMomH).Not.Nullable().Precision(12).Scale(3);
            Map(x => x.GnMwHs).Not.Nullable().CustomType<byte>();
            Map(x => x.XnMomE).Not.Nullable();
            Map(x => x.XpEhHv).Not.Nullable();
            Map(x => x.GnNkPk).Not.Nullable();
        }
    }
}
