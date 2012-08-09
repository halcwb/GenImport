using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class Unit
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public UnitGroup UnitGroup { get; set; }

        [DataMember]
        public string Abbreviation { get; set; }

        [DataMember]
        public decimal Multiplier { get; set; }

        [DataMember]
        public bool IsReference { get; set; }
    }
}
