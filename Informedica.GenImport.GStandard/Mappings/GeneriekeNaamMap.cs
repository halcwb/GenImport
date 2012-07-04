using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public class GeneriekeNaamMap : EntityMap<GeneriekeNaam>
    {
        public GeneriekeNaamMap()
        {
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.GnGnAm).Not.Nullable().Length(50);
        }
    }
}
