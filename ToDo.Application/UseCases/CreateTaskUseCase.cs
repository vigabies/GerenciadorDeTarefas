using To.Do.Application.Models;
using To.Do.Communication.Requests;

namespace To.Do.Application.UseCases;

public class CreateTaskUseCase
{
    public TaskModel Execute(CreateTaskRequest request)
    {
        var task = new TaskModel
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            DueDate = request.DueDate,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        return task;
    }
}