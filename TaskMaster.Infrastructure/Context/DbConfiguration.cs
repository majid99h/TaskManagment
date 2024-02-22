using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using TaskMaster.Infrastructure.Extension;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Infrastructure.Context
{
    public class DbConfiguration : IDbConfiguration
    {
        private readonly AppSettingsReader _configReader;
        public string ConnectionString { get; }
        public DbConfiguration(AppSettingsReader configReader)
        {
            _configReader = configReader;
            ConnectionString = _configReader.GetConnectionString();
        }

        public IDbConnection CreateConnection()
        => new SqlConnection(ConnectionString);
    }
}
