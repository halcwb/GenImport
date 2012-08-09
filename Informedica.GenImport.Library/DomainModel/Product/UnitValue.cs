using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class UnitValue
    {
        [DataMember]
        public Unit Unit { get; set; }

        [DataMember]
        public decimal Value { get; set; }
    }
}
