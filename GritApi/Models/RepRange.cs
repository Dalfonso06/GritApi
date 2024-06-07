using Microsoft.EntityFrameworkCore;

namespace GritApi.Models;

[Owned]
public class RepRange
{
    public int MinReps { get; set; }
    public int MaxReps { get; set; }
}
