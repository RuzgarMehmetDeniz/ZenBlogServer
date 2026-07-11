using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Features.Comments.Commands;
using ZenBlog.Application.Features.Comments.Result;
using ZenBlog.Domain.Entities;

namespace ZenBlog.Application.Features.Comments.Mappings
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<Comment, GetCommentsQueryResult>().ReverseMap();
            CreateMap<Comment, CreateCommentCommand>().ReverseMap();
            CreateMap<Comment, GetCommentByIdQueryResult>().ReverseMap();
            CreateMap<Comment, UpdateCommentCommand>().ReverseMap();
        }
    }
}
