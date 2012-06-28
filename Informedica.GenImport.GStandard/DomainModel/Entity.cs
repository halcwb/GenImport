using Informedica.EntityRepository.Entities;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public abstract class Entity<TEnt> : Entity<TEnt, int>
        where TEnt:class, IEntity<TEnt, int>
    {
    }
}
