using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    [DataContract]
    public class SubstanceGroup
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public SubstanceGroup MainSubstanceGroup { get; set; }

        [DataMember]
        public List<Substance> Substances { get; set; }
    }
}
