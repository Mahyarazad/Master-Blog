using MB.Domain;
using MB.Domain.ArticleAgg;
using MB.Domain.CommentAgg;
using MB.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure
{
    public class MBContext : DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public MBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}