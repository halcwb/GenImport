using Informedica.GenImport.GStandard.DomainModel;

namespace Informedica.GenImport.GStandard.Mappings
{
    public sealed class ThesauriTotalMap : EntityMap<ThesauriTotal>
    {
        public ThesauriTotalMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.MutKod).Not.Nullable().CustomType<byte>();
            Map(x => x.ThAKd1).Not.Nullable();
            Map(x => x.ThAKd2).Not.Nullable();
            Map(x => x.ThAKd3).Not.Nullable();
            Map(x => x.ThAKd4).Not.Nullable();
            Map(x => x.ThAKd5).Not.Nullable();
            Map(x => x.ThAKd6).Not.Nullable();
            Map(x => x.ThItMk).Not.Nullable().Length(2);
            Map(x => x.ThNm4).Not.Nullable().Length(4);
            Map(x => x.ThNm15).Not.Nullable().Length(15);
            Map(x => x.ThNm25).Not.Nullable().Length(25);
            Map(x => x.ThNm50).Not.Nullable().Length(50);
            Map(x => x.TsItNr).Not.Nullable().UniqueKey("UN_ThesauriTotal_TsItNr_TsNr");
            Map(x => x.TsNr).Not.Nullable().UniqueKey("UN_ThesauriTotal_TsItNr_TsNr");
        }
    }
}
