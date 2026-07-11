using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Features.ContactInfos.Commands;
using ZenBlog.Application.Features.ContactInfos.Result;
using ZenBlog.Domain.Entities;

namespace ZenBlog.Application.Features.ContactInfos.Mappings
{
    public class ContactInfoMappingProfile : Profile
    {
        public ContactInfoMappingProfile()
        {
            CreateMap<ContactInfo, GetContactInfosQueryResult>().ReverseMap();
            CreateMap<ContactInfo, CreateContactInfoCommand>().ReverseMap();
            CreateMap<ContactInfo, UpdateContactInfoCommand>().ReverseMap();
            CreateMap<ContactInfo, RemoveContactInfoCommand>().ReverseMap();
            CreateMap<ContactInfo, GetContactInfoByIdQueryResult>().ReverseMap();
        }
    }
}