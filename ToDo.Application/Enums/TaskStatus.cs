namespace To.Do.Application.Enums;

    public enum Status
    {
        Pending, //indica que a tarefa ainda não foi iniciada e está aguardando para ser realizada.
        InProgress, //indica que a tarefa está em andamento e está sendo trabalhada no momento.
        Completed, //indica que a tarefa foi concluída com sucesso e não requer mais atenção.

        Cancelled //indica que a tarefa foi cancelada e não será mais realizada.
    }
