using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;
using Dapper;
using Microsoft.Data.SqlClient;

namespace TaskMaster.Infrastructure.Repository
{
    public class ProjectRepository(IDbConfiguration dbConfig) : IProjectRepository
    {
        private readonly IDbConfiguration _dbConfig = dbConfig;


        public async Task<int> CreateProjectAsync(Project prj)
        {
            try
            {
                using var connection = _dbConfig.CreateConnection();

                var query = @"INSERT INTO Projects (
            ProjectName, Description, StartDate, EndDate, UserID,
            CreatedDate, ModifiedDate, IsActive, IsCompleted,
            CreatedBy, ModifiedBy, MarkCompleted
        )
             OUTPUT INSERTED.ProjectID
             VALUES (
            @ProjectName, @Description, @StartDate, @EndDate, @UserID,
            @CreatedDate, @ModifiedDate, @IsActive, @IsCompleted,
            @CreatedBy, @ModifiedBy, @MarkCompleted
        )";

                int insertedId = await connection.QuerySingleAsync<int>(query, prj);

                return insertedId;
            }
            catch (Exception ex)
            {

                throw;
            }
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

        public async Task<Project> GetProjectByIdAsync(int prjId)
        {
            using var connection = _dbConfig.CreateConnection();
            string query = @"select * from Projects where ProjectId=@prjId";
           

            return await connection.QuerySingleAsync<Project>(query);
        }

        public async Task<bool> UpdateProjectAsync(Project prj)
        {
            try
            {
                using var connection = _dbConfig.CreateConnection();

                var query = @"UPDATE Projects
            SET
            ProjectName = @ProjectName,
            Description = @Description,
            StartDate = @StartDate,
            EndDate = @EndDate,
            UserID = @UserID,
            ModifiedDate = @ModifiedDate,
            IsActive = @IsActive,
            IsCompleted = @IsCompleted,
            CreatedBy = @CreatedBy,
            ModifiedBy = @ModifiedBy,
            MarkCompleted = @MarkCompleted
            WHERE ProjectID = @ProjectID
            )";

                int rowsAffected = await connection.ExecuteAsync(query, prj);

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
