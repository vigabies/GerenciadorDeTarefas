using Microsoft.AspNetCore.Mvc;

using To.Do.Application.UseCases;
using To.Do.Communication.Requests;

namespace GerenciadorDeTarefas.Controllers;

[ApiController]
[Route("api/tasks")]
public class TaskController : ControllerBase
{
    // Guarda uma referência para o UseCase responsável por criar tarefas e  assim respectivamente para os outros UseCases
    private readonly CreateTaskUseCase _createTaskUseCase;
    private readonly GetAllTasksUseCase _getAllTasksUseCase;
    private readonly GetTaskByIdUseCase _getTaskByIdUseCase;

    private readonly UpdateTaskUseCase _updateTaskUseCase;

    private readonly DeleteTaskUseCase _deleteTaskUseCase;

    public TaskController(
        CreateTaskUseCase createTaskUseCase,
        GetAllTasksUseCase getAllTasksUseCase,
        GetTaskByIdUseCase getTaskByIdUseCase,
        UpdateTaskUseCase updateTaskUseCase,
        DeleteTaskUseCase deleteTaskUseCase)
    {
        // Guardamos o CreateTaskUseCase na variável da classe e assim respectivamente
        _createTaskUseCase = createTaskUseCase;

        _getAllTasksUseCase = getAllTasksUseCase;

        _getTaskByIdUseCase = getTaskByIdUseCase;

        _updateTaskUseCase = updateTaskUseCase;

        _deleteTaskUseCase = deleteTaskUseCase;
    }
    // POST /api/tasks - Cria uma nova tarefa.
    [HttpPost]
    public IActionResult Create(CreateTaskRequest request)
    {
        try
        {
            var task = _createTaskUseCase.Execute(request);

            // 201 Created:indica que a tarefa foi criada com sucesso
            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }
        catch (ArgumentException ex)
        {
            // 400 Bad Request: indica que os dados enviados são inválidos.
            return BadRequest(new { message = ex.Message });
        }
    }

    // GET /api/tasks - Lista todas as tarefas
    [HttpGet]
    public IActionResult GetAll()
    {
        var tasks = _getAllTasksUseCase.Execute();

        // 200 OK: retorna a lista de tarefas.
        return Ok(tasks);
    }

    // GET /api/tasks/{id} - Busca uma tarefa específica pelo ID.
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var task = _getTaskByIdUseCase.Execute(id);

        if (task is null)
        {
            // 404 Not Found: a tarefa não foi encontrada.
            return NotFound(new { message = "Task not found." });
        }

        // 200 OK: retorna a tarefa encontrada.
        return Ok(task);
    }

    // PUT /api/tasks/{id} Atualiza uma tarefa existente.
    [HttpPut("{id:guid}")]
    public IActionResult Update(Guid id, UpdateTaskRequest request)
    {
        try
        {
            var task = _updateTaskUseCase.Execute(id, request);

            if (task is null)
            {
                // 404 Not Found: a tarefa não existe.
                return NotFound(new { message = "Task not found." });
            }

            // 200 OK: tarefa atualizada com sucesso.
            return Ok(task);
        }
        catch (ArgumentException ex)
        {
            // 400 Bad Request: dados enviados são inválidos.
            return BadRequest(new { message = ex.Message });
        }
    }

    // DELETE /api/tasks/{id} Exclui uma tarefa pelo ID.
    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        var deleted = _deleteTaskUseCase.Execute(id);

        if (!deleted)
        {
            // 404 Not Found: a tarefa não existe.
            return NotFound(new { message = "Task not found." });
        }

        // 204 No Content: exclusão realizada com sucesso.
        return NoContent();
    }
}


