using System.ComponentModel.DataAnnotations;

//request é o que vem do cliente para o servidor, e model é o que vem do servidor para o cliente.

namespace To.Do.Communication.Requests;

public class UpdateTaskRequest
{

    [StringLength(100, MinimumLength = 2)]
    public required string Name { get; set; } = string.Empty;

    [StringLength(500, MinimumLength = 2)]
    public string? Description { get; set; }

    public required string Priority { get; set; }
    public required string Status { get; set; }

    public DateTime DueDate { get; set; }

}
