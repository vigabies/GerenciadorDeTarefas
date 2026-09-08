using To.Do.Application.Data;

namespace To.Do.Application.UseCases;

public class DeleteTaskUseCase
{
    private readonly TaskRepository _repository;

    public DeleteTaskUseCase(TaskRepository repository)
    {
        _repository = repository;
    }

    public bool Execute(Guid id)
    {
        var task = _repository.Tasks.FirstOrDefault(task => task.Id == id);

        if (task is null)
        {
            return false;
        }

        _repository.Tasks.Remove(task);

        return true;
    }
}