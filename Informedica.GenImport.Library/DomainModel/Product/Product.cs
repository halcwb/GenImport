using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int ProductCode { get; set; }

        [DataMember]
        public string GenericName { get; set; }

        [DataMember]
        public Brand Brand { get; set; }

        [DataMember]
        public Shape Shape { get; set; }

        [DataMember]
        public UnitValue Quantity { get; set; }

        [DataMember]
        public Package Package { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public List<ProductSubstance> Substances { get; set; }
    }
}
