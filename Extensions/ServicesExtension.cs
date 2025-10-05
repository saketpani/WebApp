using WebApp.Services;

namespace WebApp.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IImageProvider, S3ImageProvider>();
            services.AddScoped<IBookService, BookService>();
            
            return services;
        }
    }
}