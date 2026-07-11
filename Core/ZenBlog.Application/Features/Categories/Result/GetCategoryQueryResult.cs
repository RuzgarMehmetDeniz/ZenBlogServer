using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.Blogs.Result;

namespace ZenBlog.Application.Features.Categories.Result
{
    public class GetCategoryQueryResult : BaseDto
    {
        public string CategoryName { get; set; }
        public IList<GetBlogsQueryResult> Blogs { get; set; }
    }
}
