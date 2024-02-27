using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;
using Dapper;
using Microsoft.Data.SqlClient;

namespace TaskMaster.Infrastructure.Repository
{
    public class ProjectRepository(IDbConfiguration dbConfig) : IProjectRepository
    {
        private readonly IDbConfiguration _dbConfig = dbConfig;
        public Task<int> CreateProjectAsync(Project prj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProjectAsync(int prjId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Project>> GetAllProjectAsync()
        {
            string query = @"select * from Projects";
            using var connection = _dbConfig.CreateConnection();

            return await connection.QueryAsync<Project>(query);
        }

        public Task<Project> GetProjectByIdAsync(int prjId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProjectAsync(Project prj)
        {
            throw new NotImplementedException();
        }
    }
}
