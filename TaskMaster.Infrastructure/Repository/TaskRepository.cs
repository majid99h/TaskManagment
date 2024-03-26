using Dapper;
using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Infrastructure.Repository
{
    public class TaskRepository(IDbConfiguration dbConfig) : ITaskRepository
    {
        private readonly IDbConfiguration _dbConfig = dbConfig;

        public async Task<int> CreateTaskAsync(Tasks task)
        {
            using var connection = _dbConfig.CreateConnection();
            var query = @"INSERT INTO Tasks
           (TaskName
           ,Description
           ,DueDate
           ,Priority
           ,Status
           ,ProjectID
           ,AssignedUserID
           ,CreatedDate
			,IsDeleted
           ,CreatedBy
           ,MarkCompleted)
           OUTPUT INSERTED.TaskID
           VALUES
           (@TaskName
           ,@Description
           ,@DueDate
           ,@Priority
           ,@Status
           ,@ProjectID
           ,@AssignedUserID
           ,@CreatedDate
			,@IsDeleted
           ,@CreatedBy
           ,@MarkCompleted)";
            int response = await connection.QuerySingleAsync<int>(query, task);
            return response;
        }

        public Task<bool> DeleteTaskAsync(int taskId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tasks>> GetAllTasksAsync()
        {
            var query = "SELECT * FROM Tasks";
            using var connection = _dbConfig.CreateConnection();
            var response = await connection.QueryAsync<Tasks>(query);
            return response.ToList();
        }

        public async Task<Tasks> GetTaskByIdAsync(int taskId)
        {
            using var connection = _dbConfig.CreateConnection();
            string query = @"select * from Projects where TaskID=@taskId";


            return await connection.QuerySingleAsync<Tasks>(query);
        }



        public async Task<bool> UpdateTaskAsync(Tasks task)
        {
            try
            {
                using var connection = _dbConfig.CreateConnection();

                var query = @"UPDATE Tasks
                             SET TaskName = @TaskName, 
                             Description = @Description, 
                             DueDate = @DueDate,
                             Priority = @Priority, 
                             Status = @Status, 
                             AssignedUserID = @AssignedUserID, 
		                     ModifiedDate = @ModifiedDate, 
                             ModifiedBy = @ModifiedBy, 
                             MarkCompleted = @MarkCompleted, 
                             WHERE TaskID=@TaskID
            )";

                int rowsAffected = await connection.ExecuteAsync(query, task);

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw;

            }
        }
    }
}
