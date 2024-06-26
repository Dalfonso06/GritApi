using System.ComponentModel.DataAnnotations;

namespace GritApi.Models;

public class MuscleGroup
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
}