using System.ComponentModel.DataAnnotations;
using To.Do.Application.Enums;

namespace To.Do.Application.Models;

public class TaskModel
{
    public Guid Id { get; set; }

    [StringLength(100, MinimumLength = 2)]
    public required string Name { get; set; } = string.Empty;

    [StringLength(500, MinimumLength = 2)]
    public string? Description { get; set; }

    public required TaskPriority Priority { get; set; }

    public required To.Do.Application.Enums.TaskStatus Status { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}