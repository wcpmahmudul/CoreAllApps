using CleanArchitecture.WebApi.Application.Features.Products.Commands.CreateProduct;
using CleanArchitecture.WebApi.Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using CleanArchitecture.WebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.WebApi.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
