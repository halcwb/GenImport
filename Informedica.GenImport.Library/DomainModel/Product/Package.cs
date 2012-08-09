using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class Package
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Abbreviation { get; set; }
    }
}
