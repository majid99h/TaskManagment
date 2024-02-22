using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Infrastructure.IRepository
{
    public interface ITaskRepository
    {
        Task<Task> GetTaskByIdAsync(int taskId);
        Task<IEnumerable<Task>> GetAllTasksAsync();
        Task<int> CreateTaskAsync(Task task);
        Task<bool> UpdateTaskAsync(Task task);
        Task<bool> DeleteTaskAsync(int taskId);
    }
}
