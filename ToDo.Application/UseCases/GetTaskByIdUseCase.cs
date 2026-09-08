using To.Do.Application.Data;
using To.Do.Application.Models;

namespace To.Do.Application.UseCases;

public class GetTaskByIdUseCase
{
    private readonly TaskRepository _repository;

    public GetTaskByIdUseCase(TaskRepository repository)
    {
        _repository = repository;
    }

    public TaskModel? Execute(Guid id)
    {
        return _repository.Tasks.FirstOrDefault(task => task.Id == id);
    }
}