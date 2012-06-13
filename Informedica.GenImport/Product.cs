using System;

namespace Informedica.GenImport
{
    public class Product : IEquatable<Product>
    {
        public string ProductCode { get; set; }
        public string GenericName { get; set; }
        public string Brand { get; set;}
        public string[] Synonyms { get; set; }
        public ProductForm Form { get; set; }
        public Unit Unit { get; set; }
        public decimal Quantity { get; set; }
        public Packing Packing { get; set; }
        public decimal SmallestDispensingUnit { get; set; }
        public Substance[] Substances { get; set; }

        #region IEquatable
        public bool Equals(Product other)
        {
            bool areEqual = GenericName == other.GenericName;

            return areEqual;
        }
        #endregion
    }
}
