using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class UnitGroup
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool AllowsConversion { get; set; }

        [DataMember]
        public List<Unit> Units { get; set; }

        [DataMember]
        public List<Shape> Shapes { get; set; }
    }
}
