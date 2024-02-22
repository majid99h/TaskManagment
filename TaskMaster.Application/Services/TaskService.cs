using TaskMaster.Application.Contract;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Application.Services
{
    public class TaskService(ITaskRepository taskRepository) : ITaskService
    {
        private readonly ITaskRepository _taskRepository = taskRepository;

        public Task<int> CreateTaskAsync(Task task)
        {
          return _taskRepository.CreateTaskAsync(task);
        }

        public Task<bool> DeleteTaskAsync(int taskId)
        {
           return _taskRepository.DeleteTaskAsync(taskId);
        }

        public Task<IEnumerable<Task>> GetAllTasksAsync()
        {
            return _taskRepository.GetAllTasksAsync();
        }

        public Task<Task> GetTaskByIdAsync(int taskId)
        {
            return _taskRepository.GetTaskByIdAsync(taskId);
        }

        public Task<bool> UpdateTaskAsync(Task task)
        {
           return  _taskRepository.UpdateTaskAsync(task);
        }
    }
}
