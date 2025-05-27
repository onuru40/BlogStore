using BlogStore.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogStore.DataAccessLayer.Context
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=;initial catalog=BlogStoreNightDb;integrated Security=true;trust server certificate=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
