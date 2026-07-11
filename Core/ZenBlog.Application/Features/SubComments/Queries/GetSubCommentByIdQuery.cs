using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.SubComments.Result;

namespace ZenBlog.Application.Features.SubComments.Queries
{
    public record GetSubCommentByIdQuery(Guid Id) : IRequest<BaseResult<GetSubCommentByIdQueryResult>>
    {
    }
}
