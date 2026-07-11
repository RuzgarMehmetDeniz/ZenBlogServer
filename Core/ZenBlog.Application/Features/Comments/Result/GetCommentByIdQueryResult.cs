using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Features.Blogs.Result;

namespace ZenBlog.Application.Features.Comments.Result
{
    public class GetCommentByIdQueryResult : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public DateTime CommentDate { get; set; }
        public Guid BlogId { get; set; }
        public GetBlogsQueryResult Blog { get; set; }
    }
}
