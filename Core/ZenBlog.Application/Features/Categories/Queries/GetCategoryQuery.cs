using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.Categories.Result;

namespace ZenBlog.Application.Features.Categories.Queries
{
    public class GetCategoryQuery : IRequest<BaseResult<List<GetCategoryQueryResult>>>
    {
    }
}