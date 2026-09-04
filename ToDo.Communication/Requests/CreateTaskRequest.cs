using System.ComponentModel.DataAnnotations;
using AngleSharp.Browser;
using TaskStatus = System.Threading.Tasks.TaskStatus;

namespace To.Do.Communication.Requests;

public class CreateTaskRequest
{
    public Guid Id { get; set; }

    [StringLength(100, MinimumLength = 2)]
    public required string Name { get; set; } = string.Empty;

    [StringLength(500, MinimumLength = 2)]
    public string? Description { get; set; }

    public required TaskPriority Priority { get; set; }
    public required TaskStatus Status { get; set; }

    public DateTime DueDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
