using System.Linq;
using TaskMaster.Core.Entities;

namespace TaskMaster.Infrastructure.IRepository
{
    public interface IProjectRepository
    {
        Task<Project> GetProjectByIdAsync(int prjId);
        Task<IEnumerable<Project>> GetAllProjectAsync();
        Task<int> CreateProjectAsync(Project prj);
        Task<bool> UpdateProjectAsync(Project prj);
        Task<bool> DeleteProjectAsync(int prjId);

    }
}
