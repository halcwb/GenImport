using AutoMapper;
using Informedica.GenForm.DomainModel.Interfaces;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Library.DomainModel.Product;

namespace Informedica.GenImport.Library.AutoMapper
{
    public class ModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<IArtikel, Product>()
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.HpKode));

        }
    }
}
