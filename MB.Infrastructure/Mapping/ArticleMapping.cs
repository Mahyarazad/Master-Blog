using MB.Domain;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace MB.Infrastructure.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>

    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Article", schema: "dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(20);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Body).IsRequired();
            builder.HasOne(x => x.ArticleCategory).WithMany(x => x.Articles)
                .HasForeignKey(x => x.ArticleCategoryId);
            builder.HasMany(x => x.Comments).WithOne(x => x.Article).HasForeignKey(x => x.ArticleId);
        }
    }
}