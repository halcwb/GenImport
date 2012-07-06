using Informedica.EntityRepository.Entities;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    public interface IGStandardModel : IModel
    {
    }

    public interface IGStandardModel<in TEnt> : IGStandardModel, IEntity<TEnt, int>
        where TEnt : class, IGStandardModel<TEnt>
    {
    }
}
