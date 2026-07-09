using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Domain.Entities;

namespace ZenBlog.Persistence.Context
{
    public class AppDbContext(DbContextOptions options) : IdentityDbContext<AppUser, AppRole, string>(options)
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SubComment> SubComments { get; set; }


        }
}
