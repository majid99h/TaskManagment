using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Core.Entities;

namespace TaskMaster.Application.Contract
{
    public interface IProjectService
    {
        Task<Project> GetProjectByIdAsync(int prjId);
        Task<IEnumerable<Project>> GetAllProjectAsync();
        Task<int> CreateProjectAsync(Project prj);
        Task<bool> UpdateProjectAsync(Project prj);
        Task<bool> DeleteProjectAsync(int prjId);
    }
}
