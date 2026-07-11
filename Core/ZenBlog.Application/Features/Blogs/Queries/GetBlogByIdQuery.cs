using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.Blogs.Result;

namespace ZenBlog.Application.Features.Blogs.Queries
{
    public record GetBlogByIdQuery(Guid Id) : IRequest<BaseResult<GetBlogByIdQueryResult>>
    {
    }
}
