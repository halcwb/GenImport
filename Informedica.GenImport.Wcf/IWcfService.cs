using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Informedica.GenImport.Library.DomainModel.Product;

namespace Informedica.GenImport.Wcf
{
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        List<Product> FindProductsByName(string name);

        [WebGet(UriTemplate = "/GetProductCount")]
        [OperationContract]
        int GetProductCount();
        
        [WebInvoke(UriTemplate = "/GetProductsByProductCode")]
        [OperationContract]
        List<Product> GetProductsByProductCode(int productCode);

        [WebGet(UriTemplate = "/RefreshDatabase")]
        [OperationContract]
        void RefreshDatabase();
    }
}