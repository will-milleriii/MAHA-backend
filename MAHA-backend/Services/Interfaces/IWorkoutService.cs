using MAHA_backend.Models;

namespace MAHA_backend.Services.Interfaces;

public interface IWorkoutService
{
    public Task<List<Workout>> GetAllWorkouts(string userId);
    public Task<bool> CreateWorkoutAsync(Workout workout);
}