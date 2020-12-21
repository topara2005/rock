

using Application.Dtos;
using AutoMapper;


using Domain.Entities;

namespace EBC.Demo.App.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Article, ArticleItemDto>().ReverseMap();
         
         
        }
    }
}
