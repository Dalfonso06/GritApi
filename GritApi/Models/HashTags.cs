using System.ComponentModel.DataAnnotations;

namespace GritApi.Models;
public class HashTags
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    public ICollection<Workout>? Workouts { get; set; }
}
