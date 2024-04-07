using System.ComponentModel.DataAnnotations;

namespace GritApi.Models;

public class Workout
{
    public int Id { get; set; }
    [Required]
    public int AuthorId { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Category? Category { get; set; }
    public ICollection<Exercise>? Exercises { get; set; }
}