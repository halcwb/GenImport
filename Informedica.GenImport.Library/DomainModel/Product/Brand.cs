using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class Brand
    {
        [DataMember]
        public string Name {get; set; }
    }
}
