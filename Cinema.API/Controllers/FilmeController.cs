using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    [HttpGet(Name = "GetFilme")]
    public IEnumerable<Filme> Get()
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var tasks = _taskRepository.Get();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var task = _taskRepository.Get(id);

            if (task == null)
                return NotFound();

            return Ok(task);
        }

        [HttpPost]
        public IActionResult Post([FromBody] TaskInput newtask)
        {
            var task = new Desafio.Model.Task(newtask.Name, newtask.Description, newtask.Status);

            if(_taskRepository.Add(task))
            {
                return Created("", task);
            }
            else
            {
                return NotFound();
            }
            
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] TaskInput aUpdateTask)
        {
            var task = _taskRepository.Get(id);

            if (task == null)
                return NotFound();

            task.UpdateTask(aUpdateTask.Name, aUpdateTask.Description, aUpdateTask.Status);

            _taskRepository.Update(id, task);

            return Ok(task);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var task = _taskRepository.Get(id);

            if (task == null)
                return NotFound();

            _taskRepository.Delete(id);

            return NoContent();
        } 
    }
}
