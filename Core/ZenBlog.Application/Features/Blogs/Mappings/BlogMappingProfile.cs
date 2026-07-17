using AutoMapper;
using ZenBlog.Application.Features.Blogs.Commands;
using ZenBlog.Application.Features.Blogs.Result;
using ZenBlog.Domain.Entities;

namespace ZenBlog.Application.Features.Blogs.Mappings
{
    public class BlogMappingProfile : Profile
    {
        public BlogMappingProfile()
        {
            CreateMap<Blog, GetBlogsQueryResult>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ReverseMap()
                .ForMember(dest => dest.Category, opt => opt.Ignore());

            CreateMap<Blog, CreateBlogCommand>().ReverseMap();

            CreateMap<Blog, GetBlogByIdQueryResult>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ReverseMap()
                .ForMember(dest => dest.Category, opt => opt.Ignore());

            CreateMap<Blog, UpdateBlogCommand>().ReverseMap();

            CreateMap<Blog, GetBlogsByCategoryIdQueryResult>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ReverseMap()
                .ForMember(dest => dest.Category, opt => opt.Ignore());

            CreateMap<Blog, GetLatest5BlogsQueryResult>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ReverseMap()
                .ForMember(dest => dest.Category, opt => opt.Ignore());
        }
    }
}