
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/v1/[controller]")]
public class TaskController: ControllerBase
{
  //Instanciar el contexto de la base de datos
  private readonly AppDBContext _context;

  //Inyeccion de dependencias 
  public TaskController(AppDBContext context)
  {
    _context = context;
  }

  //GET: api/v1/Task/
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Task>>> GetTasks()
  {
    return await _context.Tasks.ToListAsync();
  }
  //GET: api/v1/task/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Task>> GetTask(int id)
  {
    var task = await _context.Tasks.FindAsync(id);
    if (task == null)
    {
      return NotFound();
    }
    return task;
  }


  // PUT : api/v1/task/5
  [HttpPut("{id}")]
  public async Task<IActionResult> PutTask(int id, Task task)
  {
    if (id != task.Id)
    {
      return BadRequest();
    }
    //esta linea sirve para ?
    _context.Entry(task).State = EntityState.Modified;

    try
    {
      await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!TaskExist(id)) NotFound();
    }

    return Ok(task);
  }

  //POST : api/v1/task
  [HttpPost]
  public async Task<ActionResult<Task>> createTask(Task task)
  {
    _context.Tasks.Add(task);
    await _context.SaveChangesAsync();
    return CreatedAtAction("GetTask", new { id = task.Id }, task);
  }

  //DELETE : api/v1/task/5
  [HttpDelete("{id}")]
  public async Task<ActionResult<Task>> DeleteTask(int id)
  {
    var task = await _context.Tasks.FindAsync(id);
    if (task == null)
    {
      return NotFound();
    }
    _context.Tasks.Remove(task);
    await _context.SaveChangesAsync();
    return NoContent();
  }

  private bool TaskExist(int id)
  {
    return _context.Tasks.Any(e => e.Id == id);
  }
}