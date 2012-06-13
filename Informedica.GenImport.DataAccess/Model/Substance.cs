namespace Informedica.GenImport.DataAccess.Model
{
    public class Substance
    {
        public int SubstanceId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public Unit Unit { get; set; }
        public decimal Quantity { get; set; }
    }
}
