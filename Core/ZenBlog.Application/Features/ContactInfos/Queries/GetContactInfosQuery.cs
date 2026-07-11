using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.ContactInfos.Result;

namespace ZenBlog.Application.Features.ContactInfos.Queries
{
    public class GetContactInfosQuery : IRequest<BaseResult<List<GetContactInfosQueryResult>>>
    {
    }
}
