using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Application.Contract
{
    public interface ITaskService
    {
        Task<Task> GetTaskByIdAsync(int taskId);
        Task<IEnumerable<Task>> GetAllTasksAsync();
        Task<int> CreateTaskAsync(Task task);
        Task<bool> UpdateTaskAsync(Task task);
        Task<bool> DeleteTaskAsync(int taskId);
    }
}
