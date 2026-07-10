using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;

namespace ZenBlog.Application.Features.Categories.Commands
{
    public record UpdateCategoryCommand(Guid Id, string CategoryName) : IRequest<BaseResult<bool>>;
}
