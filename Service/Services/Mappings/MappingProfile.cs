﻿using AutoMapper;
using Domain.Entities;
using Service.Services.DTOs.Account;
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


            CreateMap<RegisterDto, AppUser>().ReverseMap();
        }
    }
}
