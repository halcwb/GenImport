using fitlibrary;
using Informedica.GenImport.DataAccess.Model;

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
            Product product = new Product
                              {
                                  ProductCode = ProductCode,
                                  Brand = Brand,
                                  Form = new ProductForm { ProductFormId = 1, Name = Productform },
                                  GenericName = GenericName,
                                  Synonyms = Synonyms,
                                  Packing = new Packing { PackingId = 1, Name = Packing },
                                  Quantity = Quantity,
                                  Unit = new Unit { Name = ProductUnit, UnitId = 1 },
                                  Substances = new[] { new Substance { SubstanceId = 1, Name = Substance, Order = 1, Quantity = SubstanceQuantity } },
                                  SmallestDispensingUnit = SmallestDispenceUnit
                              };
            return product;
        }
    }
}
