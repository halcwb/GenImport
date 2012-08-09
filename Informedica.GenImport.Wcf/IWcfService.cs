﻿using System.Collections.Generic;
using System.ServiceModel;
using Informedica.GenImport.Library.DomainModel.Product;

namespace Informedica.GenImport.Wcf
{
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        List<Product> GetProductsByProductCode(int productCode);

        [OperationContract]
        void RefreshDatabase();
    }
}