using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Features.Users.Commands;
using ZenBlog.Application.Features.Users.Result;
using ZenBlog.Domain.Entities;

namespace ZenBlog.Application.Features.Users.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<AppUser, CreateUserCommand>().ReverseMap();
            CreateMap<AppUser, GetUsersQueryResult>().ReverseMap();
        }
    }
}
