using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class GenericCompositionMap : EntityMap<GenericComposition>
    {
        public GenericCompositionMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.GnMomH).Not.Nullable().Precision(12).Scale(3);
            Map(x => x.GnMwHs).Not.Nullable().CustomType<byte>().UniqueKey("UN_GenericComposition_GnMwHs_GnNkPk_GsKode");
            Map(x => x.GnNkPk).Not.Nullable().UniqueKey("UN_GenericComposition_GnMwHs_GnNkPk_GsKode");
            Map(x => x.GsKode).Not.Nullable().UniqueKey("UN_GenericComposition_GnMwHs_GnNkPk_GsKode");
            Map(x => x.XnMomE).Not.Nullable();
            Map(x => x.XpEhHv).Not.Nullable();
        }
    }
}
