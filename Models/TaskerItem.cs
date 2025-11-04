namespace BlazorTasker.Models;

using System.ComponentModel.DataAnnotations;

public class TaskerItem
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Every task must have a name")]
    public string Name { get; set; } = string.Empty;

    public bool IsComplete { get; set; }
}
