using MAHA_backend.Models;
using MAHA_backend.Services.Interfaces;

namespace MAHA_backend.Services;

public class WorkoutService: IWorkoutService
{
    public async Task<List<Workout>> GetAllWorkouts(string userId)
    {
        var workouts = new List<Workout>();
        return workouts;
    }

    public async Task<bool> CreateWorkoutAsync(Workout workout)
    {
        return true;
    }
}