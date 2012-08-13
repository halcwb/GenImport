using Informedica.EntityRepository.Entities;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    public interface ICopyable<in TEnt> where TEnt : class, IEntity<TEnt, int>
    {
        void CopyTo(TEnt other);
    }
}
