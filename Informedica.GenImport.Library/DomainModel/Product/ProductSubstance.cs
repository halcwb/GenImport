using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class ProductSubstance
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int SortOrder { get; set; }

        [DataMember]
        public Substance Substance { get; set; }

        [DataMember]
        public UnitValue Quantity { get; set; }
    }
}
