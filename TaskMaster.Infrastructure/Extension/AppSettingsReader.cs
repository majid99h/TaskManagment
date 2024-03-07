using Microsoft.Extensions.Configuration;

namespace TaskMaster.Infrastructure.Extension
{
    public class AppSettingsReader
    {
        private readonly IConfiguration _configuration;
        public AppSettingsReader()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)  // Set the base path to the location of your appsettings.json file
                .AddJsonFile("dbconfig.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }

        public string GetConnectionString()
        {
            return _configuration.GetConnectionString("SqlConnection")!;
        }
    }
}
