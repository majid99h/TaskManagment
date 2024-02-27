using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Application.Contract;
using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;
using TaskMaster.Infrastructure.Repository;

namespace TaskMaster.Application.Services
{
    public class ProjectService(IProjectRepository projectRepository) : IProjectService
    {
        private readonly IProjectRepository _projectRepository = projectRepository;
        public Task<int> CreateProjectAsync(Project prj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProjectAsync(int prjId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAllProjectAsync()
        {
            return _projectRepository.GetAllProjectAsync();
        }

        public Task<Project> GetProjectByIdAsync(int prjId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProjectAsync(Project prj)
        {
            throw new NotImplementedException();
        }
    }
}
