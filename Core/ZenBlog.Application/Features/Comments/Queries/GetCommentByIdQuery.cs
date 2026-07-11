using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.Comments.Result;

namespace ZenBlog.Application.Features.Comments.Queries
{
    public record GetCommentByIdQuery(Guid Id) : IRequest<BaseResult<GetCommentByIdQueryResult>>
    {
    }
}
