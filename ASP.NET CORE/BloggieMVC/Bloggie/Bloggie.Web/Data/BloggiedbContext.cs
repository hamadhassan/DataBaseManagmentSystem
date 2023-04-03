using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    public class BloggiedbContext : DbContext
    {
        public BloggiedbContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// The dbSet will create class in the Database using the entity framework
        /// </summary>
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
