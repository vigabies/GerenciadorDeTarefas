using System.ComponentModel.DataAnnotations;
using To.Do.Application.Enums;
using TaskStatus = System.Threading.Tasks.TaskStatus;

namespace To.Do.Application.Models;

public class TaskModel
{
    public Guid Id {  get; set; }

    [StringLength(100, MinimumLength = 2)]
    public required string Name { get; set; } = string.Empty;

    [StringLength(500, MinimumLength = 2)]
    public string? Description { get; set; } // o ? significa que a propriedade Description é opcional e pode ser nula.

    public required TaskPriority Priority { get; set; }
    public required TaskStatus Status { get; set; }

    public DateTime DueDate { get; set; }
    public DateTime CreatedAt { get; set; } 
    public DateTime UpdatedAt { get; set; }

}
