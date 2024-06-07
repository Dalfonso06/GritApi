using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GritApi.Models;

public class Exercise
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    public MuscleGroup? MuscleGroup { get; set; }
    public string? Description { get; set; }
    public ICollection<RepRange>? Reps { get; set; }
}