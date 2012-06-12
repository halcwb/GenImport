namespace Informedica.GenImport
{
    public class Product
    {
        public string ProductCode { get; set; }
        public string GenericName { get; set; }
        public string Brand { get; set;}
        public string[] Synonyms { get; set; }
        public ProductForm Form { get; set; }
        public decimal Quantity { get; set; }
        public ProductUnit Unit { get; set; }
        public Packing Packing { get; set; }
        public decimal SmallestDispensingUnit { get; set; }
        public Substance[] Substances { get; set; }

    }
}
