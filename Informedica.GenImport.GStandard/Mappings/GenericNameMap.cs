using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class GenericNameMap : EntityMap<GenericName>
    {
        public GenericNameMap()
        {
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.GnGnAm).Not.Nullable().Length(50).Unique();
        }
    }
}
