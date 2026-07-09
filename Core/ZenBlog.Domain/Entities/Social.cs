using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Domain.Entities.Common;

namespace ZenBlog.Domain.Entities
{
    public class Social : BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

    }
}
