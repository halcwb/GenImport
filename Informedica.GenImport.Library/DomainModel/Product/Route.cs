using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class Route
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Abbreviation { get; set; }

        [DataMember]
        public List<Shape> Shapes { get; set; }

        [DataMember]
        public List<Product> Products { get; set; }
    }
}
