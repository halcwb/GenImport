namespace Informedica.GenImport.GStandard.DomainModel.Enums
{
    /// <summary>
    /// Mutatiekode
    /// </summary>
    public enum MutKod : byte
    {
        RecordNotChanged = 0,
        RecordDeleted = 1,
        RecordUpdated = 3,
        RecordAdded = 3
    }
}
