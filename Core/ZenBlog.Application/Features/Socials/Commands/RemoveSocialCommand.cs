using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;

namespace ZenBlog.Application.Features.Socials.Commands
{
    public record RemoveSocialCommand(Guid Id) : IRequest<BaseResult<object>>;
}
