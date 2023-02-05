using AutoMapper;
using Domain.Entities;
using Service.Services.DTOs.Account;
using Service.Services.DTOs.Basket;
using Service.Services.DTOs.Category;
using Service.Services.DTOs.Product;

namespace Service.Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCreateDto, Product>().ReverseMap();
            CreateMap<ProductListDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductGetDto, Product>().ReverseMap();

            CreateMap<BasketProductListDto, BasketProduct>().ReverseMap();

            CreateMap<RegisterDto, AppUser>().ReverseMap();

            CreateMap<CategoryListDto, Category>().ReverseMap();
        }
    }
}
