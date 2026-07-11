using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.Users.Result;

namespace ZenBlog.Application.Features.Users.Queries
{
    public class GetLoginQuery : IRequest<BaseResult<GetLoginQueryResult>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
