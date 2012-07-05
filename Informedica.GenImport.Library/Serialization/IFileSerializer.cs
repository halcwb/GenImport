using System.Collections.Generic;
using System.IO;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.Serialization
{
    public interface IFileSerializer
    {
        IEnumerable<IModel> ReadLines(Stream inputStream);
    }

    public interface IFileSerializer<out TModel> : IFileSerializer
        where TModel : class, IModel
    {
        new IEnumerable<TModel> ReadLines(Stream inputStream);
    }
}
