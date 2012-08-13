namespace Informedica.GenImport.GStandard.DomainModel.Enums
{
    /// <summary>
    /// Mutatiekode
    /// </summary>
    public enum MutKod : byte
    {
        RecordNotChanged = 0,
        RecordDeleted = 1,
        RecordUpdated = 2,
        RecordAdded = 3
    }
}
