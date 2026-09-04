namespace To.Do.Application.Enums;

public class TaskPriority
{
    public enum Priority
    {
        Low,//indica que a tarefa será de baixa prioridade e pode ser realizada em um momento posterior.
        Medium, //indica que a tarefa tem uma prioridade média e deve ser realizada em um prazo razoável.
        High //indica que a tarefa tem uma prioridade alta e deve ser realizada o mais rápido possível.
    }
}
