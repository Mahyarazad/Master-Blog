using _01_Framework.Repository;
using MB.Application;
using MB.Application.Contracts;
using MB.Application.Contracts.Article;
using MB.Application.Contracts.Comment;
using MB.Domain;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleAgg.Services;
using MB.Domain.ArticleCategoryAgg.Services;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure
{
    public class StartUpConfiguration
    {
        public static void Config(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryValidator, ArticleCategoryValidator>();
            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IArticleQuery, ArticleQuery>();
            services.AddTransient<ICommentApplication, CommentApplication>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<IUnitofWork, UnitofWork>();
            services.AddDbContext<MBContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}