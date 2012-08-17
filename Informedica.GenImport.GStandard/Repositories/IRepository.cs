using System.Collections.Generic;
using System.Linq;
using Informedica.EntityRepository;
using Informedica.EntityRepository.Entities;

namespace Informedica.GenImport.GStandard.Repositories
{
    public interface IRepository<TEnt> : IRepository<TEnt, int>
        where TEnt: class, IEntity<TEnt, int>
    {
        void Add(IEnumerable<TEnt> entities);
        IQueryable<TEnt> GetQueryable();
    }
}
