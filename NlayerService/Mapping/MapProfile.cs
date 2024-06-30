using AutoMapper;
using Nlayer.Core.Models;
using Nlayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerService.Mapping
{
    public class MapProfile : Profile
    {
        protected MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature,ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();



        }
    }
}
