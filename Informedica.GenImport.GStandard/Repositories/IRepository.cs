using Informedica.EntityRepository;
using Informedica.EntityRepository.Entities;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public interface IRepository<TEnt> : IRepository<TEnt, int>
        where TEnt: class, IEntity<TEnt, int>
    {
        IQuery CreateSqlQuery(string query);
    }
}
