using System.ComponentModel.DataAnnotations;

namespace To.Do.Communication.Requests;

public class CreateTaskRequest
{
    [StringLength(100, MinimumLength = 2)]
    public required string Name { get; set; } = string.Empty;

    [StringLength(500, MinimumLength = 2)]
    public string? Description { get; set; }

    public required string Priority { get; set; }
    public required string Status { get; set; }

    public DateTime DueDate { get; set; }

}
