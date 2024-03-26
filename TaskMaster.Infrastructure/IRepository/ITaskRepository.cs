using TaskMaster.Core.Entities;

namespace TaskMaster.Infrastructure.IRepository
{
    public interface ITaskRepository
    {
        Task<Tasks> GetTaskByIdAsync(int taskId);
        Task<IEnumerable<Tasks>> GetAllTasksAsync();
        Task<int> CreateTaskAsync(Tasks task);
        Task<bool> UpdateTaskAsync(Tasks task);
        Task<bool> DeleteTaskAsync(int taskId);
    }
}
