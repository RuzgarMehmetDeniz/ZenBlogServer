using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Features.Blogs.Commands;
using ZenBlog.Application.Features.Blogs.Result;
using ZenBlog.Domain.Entities;

namespace ZenBlog.Application.Features.Blogs.Mappings
{
    public class BlogMappingProfile : Profile
    {
        public BlogMappingProfile()
        {
            CreateMap<Blog, GetBlogsQueryResult>().ReverseMap();
            CreateMap<Blog, CreateBlogCommand>().ReverseMap();
            CreateMap<Blog, GetBlogByIdQueryResult>().ReverseMap();
            CreateMap<Blog, UpdateBlogCommand>().ReverseMap();
            CreateMap<Blog, GetBlogsByCategoryIdQueryResult>().ReverseMap();
            CreateMap<Blog, GetLatest5BlogsQueryResult>().ReverseMap();
        }
    }
}