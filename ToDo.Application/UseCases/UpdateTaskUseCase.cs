using To.Do.Application.Data;
using To.Do.Application.Enums;
using To.Do.Application.Models;
using To.Do.Communication.Requests;

namespace To.Do.Application.UseCases;

public class UpdateTaskUseCase
{
    private readonly TaskRepository _repository;

    public UpdateTaskUseCase(TaskRepository repository)
    {
        _repository = repository;
    }

    public TaskModel? Execute(Guid id, UpdateTaskRequest request)
    {
        var task = _repository.Tasks.FirstOrDefault(task => task.Id == id);

        if (task is null)
        {
            return null;
        }

        if (!Enum.TryParse<TaskPriority>(request.Priority, true, out var priority))
        {
            throw new ArgumentException("Invalid priority.");
        }

        if (!Enum.TryParse<To.Do.Application.Enums.TaskStatus>(
            request.Status,
            true,
            out var status))
        {
            throw new ArgumentException("Invalid status.");
        }

        task.Name = request.Name;
        task.Description = request.Description;
        task.Priority = priority;
        task.DueDate = request.DueDate;
        task.Status = status;
        task.UpdatedAt = DateTime.UtcNow;

        return task;
    }
}