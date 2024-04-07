using System.ComponentModel.DataAnnotations;

namespace GritApi.Models;

public class Routine
{
    public int Id { get; set; }
    public ICollection<Workout>? Workouts { get; set; }
}