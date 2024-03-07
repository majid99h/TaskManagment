using Microsoft.AspNetCore.Mvc;
using TaskMaster.Application.Contract;
using TaskMaster.Application.Services;
using TaskMaster.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskMaster.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController(IProjectService projectService) : ControllerBase
    {
        private readonly IProjectService _projectService = projectService;
        // GET: api/<ProjectController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _projectService.GetAllProjectAsync();
            return Ok(response);
        }
        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProjectController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Project prj)
        {
            var response = await _projectService.CreateProjectAsync(prj);
            return Ok(response);
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Project prj)
        {
            var response = await _projectService.UpdateProjectAsync(prj);
            return Ok(response);
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
