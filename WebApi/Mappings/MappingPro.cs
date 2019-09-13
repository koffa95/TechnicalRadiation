using System;
using AutoMapper;
using TechnicalRadiation.Models.DTO;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;

namespace TechnicalRadiation.WebApi.Mappings
{
    public class MappingPro : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewsItem, NewsItemDto>();
            // CreateMap<NewsItemInputModel, NewsItem>()
            //     .ForMember(src => src.PublishDate, opt => opt.MapFrom(src => DateTime.Now))
            //     .ForMember(src => src.ModifiedBy, opt => opt.MapFrom(src => "TechnicalRadiationAdmin"))
            //     .ForMember(src => src.CreatedDate, opt => opt.MapFrom(src => DateTime.Now))
            //     .ForMember(src => src.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<NewsItem, NewsItemDetailsDto>();
            CreateMap<NewsItemInputModel, NewsItemDetailsDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryDetailDto>();
            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorDetailDto>();
            CreateMap<NewsItem, NewsItemDto>();
        }
    }
}