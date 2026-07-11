using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.Messages.Result;

namespace ZenBlog.Application.Features.Messages.Queries
{
    public record GetUnreadMessagesQuery : IRequest<BaseResult<List<GetUnreadMessagesQueryResult>>>;
}
