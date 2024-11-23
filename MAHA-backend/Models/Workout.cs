using MAHA_backend.Models.Constants;

namespace MAHA_backend.Models;

public class Workout
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int UserId { get; set; }
    public BodyPart BodyPart { get; set; }
    public int Reps { get; set; }
    public int Sets { get; set; }
    public Double Weight { get; set; }
    public DateTime Date { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool Active { get; set; }
}