namespace WebApp.Services
{
    public class S3ImageProvider : IImageProvider
    {
        private readonly IConfiguration _configuration;

        public S3ImageProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetImageUrl(string imageName)
        {
            var baseImageUrl = _configuration["S3Settings:BaseImageUrl"];
            return $"{baseImageUrl}{imageName}";
        }
    }
}