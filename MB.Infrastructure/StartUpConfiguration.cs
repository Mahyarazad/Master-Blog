using MB.Application;
using MB.Application.Contracts;
using MB.Domain;
using MB.Domain.ArticleCategoryAgg.Services;
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
            services.AddDbContext<MBContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}