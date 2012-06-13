using fitlibrary;

namespace Informedica.GenImport.Acceptance
{
    public class UpdateProductScenarios
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

        public bool ProductUpdatesExistingProduct()
        {
            return TryUpdateProduct();
        }

        public bool ProductDoesNotUpdateNonExistingProduct()
        {
            return !TryUpdateProduct();
        }

        private bool TryUpdateProduct()
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

            return false;
        }
    }
}
