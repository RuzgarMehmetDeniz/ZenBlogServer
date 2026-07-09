using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Domain.Entities.Common;

namespace ZenBlog.Domain.Entities
{
    public class SubComment : BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public DateTime CommentDate { get; set; }

        public Guid CommentId { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
