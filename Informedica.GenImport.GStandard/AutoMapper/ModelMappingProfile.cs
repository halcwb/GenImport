using AutoMapper;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.DomainModel.Product;

namespace Informedica.GenImport.GStandard.AutoMapper
{
    public class ModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<IProduct, Product>()
                .ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.HpKode));

        }
    }
}
