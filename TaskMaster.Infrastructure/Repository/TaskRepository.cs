using Dapper;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Infrastructure.Repository
{
    public class TaskRepository(IDbConfiguration dbConfig) : ITaskRepository
    {
        private readonly IDbConfiguration _dbConfig = dbConfig;

        public Task<int> CreateTaskAsync(Task task)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTaskAsync(int taskId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Task>> GetAllTasksAsync()
        {
            var query = "SELECT * FROM Tasks";
            using var connection = _dbConfig.CreateConnection();
            var response = await connection.QueryAsync<Task>(query);
            return response.ToList();
        }

        public Task<Task> GetTaskByIdAsync(int taskId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTaskAsync(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
