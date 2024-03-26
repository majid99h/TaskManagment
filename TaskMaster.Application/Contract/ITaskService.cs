using TaskMaster.Core.Entities;

namespace TaskMaster.Application.Contract
{
    public interface ITaskService
    {
        Task<Tasks> GetTaskByIdAsync(int taskId);
        Task<IEnumerable<Tasks>> GetAllTasksAsync();
        Task<int> CreateTaskAsync(Tasks task);
        Task<bool> UpdateTaskAsync(Tasks task);
        Task<bool> DeleteTaskAsync(int taskId);
    }
}
