using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;

namespace ZenBlog.Application.Features.Socials.Commands
{
    public record UpdateSocialCommand(Guid Id, string Title, string Url, string Icon) : IRequest<BaseResult<object>>;
}
