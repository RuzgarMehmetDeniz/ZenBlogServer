using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Domain.Entities.Common;

namespace ZenBlog.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual IList<Blog> Blogs { get; set; }

    }
}
