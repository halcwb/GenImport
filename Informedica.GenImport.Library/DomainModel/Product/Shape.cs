using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class Shape
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Product> Products { get; set; }

        [DataMember]
        public List<Package> Packages { get; set; }

        [DataMember]
        public List<UnitGroup> UnitGroups { get; set; }
    }
}
