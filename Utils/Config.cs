using Microsoft.Extensions.Configuration;

namespace Utils
{
    public class Config
    {
        private static readonly IConfiguration _config;
        static Config()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _config = configurationBuilder.Build();

            configurationBuilder.AddJsonFile($"appsettings.{_config.GetSection("ENV").Value}.json", optional: true);
            _config = configurationBuilder.Build();
        }

        public static string ConnectionString { get { return _config.GetConnectionString("Default"); } }
        public static string EmailServer { get { return _config.GetSection("EmailConfig:Server").Value; } }
        public static int EmailPort { get { return int.Parse(_config.GetSection("EmailConfig:SmtpPort").Value); } }
        public static string EmailUsername { get { return _config.GetSection("EmailConfig:Username").Value; } }
        public static string EmailPassword { get { return _config.GetSection("EmailConfig:Password").Value; } }
        public static string EmailDisplayName { get { return _config.GetSection("EmailConfig:DisplayName").Value; } }


    }
}