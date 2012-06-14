using fitlibrary;
using Informedica.GenImport.Library.DomainModel.Product;

namespace Informedica.GenImport.Acceptance
{
    public class AddOrUpdateProduct
    {
        public string ProductCode { get; set; }
        public string GenericName { get; set; }
        public string Brand { get; set; }
        public string[] Synonyms { get; set; }
        public string Productform { get; set; }
        public decimal Quantity { get; set; }
        public string ProductUnit { get; set; }
        public string Substance { get; set; }
        public decimal SubstanceQuantity { get; set; }
        public string SubstanceUnit { get; set; }
        public string Packing { get; set; }
        public decimal SmallestDispenceUnit { get; set; }

        public bool UpdatesExistingProduct()
        {
            Product product = CreateProduct();

            return false;
        }

        public bool AddsNewProduct()
        {
            Product product = CreateProduct();

            return false;
        }

        private Product CreateProduct()
        {
            Product product = new Product();
            return product;
        }
    }
}
