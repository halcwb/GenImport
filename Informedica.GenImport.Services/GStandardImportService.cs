using System;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.DataAccess;

namespace Informedica.GenImport.Services
{
    public class GStandardImportService : IImportService
    {
        private readonly IFileSerializerBase<IArtikel> _artikelenFileSerializer;
        private readonly IFileSerializerBase<INaam> _namenFileSerializer;
        private readonly string _databasePath;

        public GStandardImportService(IFileSerializerBase<IArtikel> artikelenFileSerializer, IFileSerializerBase<INaam> namenFileSerializer,
            string databasePath)
        {
            _artikelenFileSerializer = artikelenFileSerializer;
            _namenFileSerializer = namenFileSerializer;
            _databasePath = databasePath;
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
