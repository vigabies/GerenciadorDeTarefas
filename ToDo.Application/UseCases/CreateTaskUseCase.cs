using To.Do.Application.Data;
using To.Do.Application.Enums;
using To.Do.Application.Models;
using To.Do.Communication.Requests;

namespace To.Do.Application.UseCases;

public class CreateTaskUseCase
{
    private readonly TaskRepository _repository;

    public CreateTaskUseCase(TaskRepository repository)
    {
        _repository = repository;
    }

    public TaskModel Execute(CreateTaskRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name)) // validação do nome
        {
            throw new ArgumentException("Name cannot be empty.");
        }

        if (!Enum.TryParse<TaskPriority>(request.Priority, true, out var priority)) // validação da prioridade
        {
            throw new ArgumentException("Invalid priority.");
        }

        if (!Enum.TryParse<To.Do.Application.Enums.TaskStatus>( // validação do status
            request.Status,
            true,
            out var status))
        {
            throw new ArgumentException("Invalid status.");
        }

        if (request.DueDate < DateTime.UtcNow) // validação da data de vencimento
        {
            throw new ArgumentException("Due date cannot be in the past.");
        }

        var task = new TaskModel
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Priority = priority,
            DueDate = request.DueDate,
            Status = status,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        _repository.Tasks.Add(task);

        return task;
    }
}