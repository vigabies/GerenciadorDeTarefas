using To.Do.Application.Data;
using To.Do.Application.Models;

namespace To.Do.Application.UseCases;

public class GetAllTasksUseCase
{
    private readonly TaskRepository _repository;

    public GetAllTasksUseCase(TaskRepository repository)
    {
        _repository = repository;
    }

    public List<TaskModel> Execute()
    {
        return _repository.Tasks;
    }
}