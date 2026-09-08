using To.Do.Application.Models;

namespace To.Do.Application.Data;

public class TaskRepository
{
    public List<TaskModel> Tasks { get; set; } = new();
}