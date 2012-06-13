namespace Informedica.GenImport.DataAccess.Model
{
    public class Unit
    {
        public int UnitId { get; set; }
        public Unit BaseUnit { get; set; }
        public string Name { get; set; }
    }
}
