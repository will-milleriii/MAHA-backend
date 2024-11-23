using MAHA_backend.Models;
using MAHA_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MAHA_backend.Controllers;

[ApiController]
[Route("api/workout")]
public class WorkoutController: ControllerBase
{
    private readonly IWorkoutService _workoutService;

    public WorkoutController(IWorkoutService workoutService)
    {
        _workoutService = workoutService;
    }
    
    // CRUD Operations
    // Replace userId with appropriate request
    [HttpGet]
    public async Task<IActionResult> GetWorkoutsForUserAsync(string userId)
    {
        try
        {
            var results = await _workoutService.GetAllWorkouts(userId);
            return Ok(results);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
       
    }
    
    // Will need workout object as param
    [HttpPost]
    public async Task<IActionResult> CreateWorkoutAsync(Workout workout)
    {
        try
        {
            var success = await _workoutService.CreateWorkoutAsync(workout);
            return success ? Ok() : BadRequest();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    [HttpPut]
    public async Task<IActionResult> UpdateWorkoutAsync(string workoutId, string userId)
    {
        try
        {
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return "";
    }

    //Soft deletes only
    [HttpPut]
    public async Task<IActionResult> DeleteWorkoutAsync(string workoutId, string userId)
    {
        return "";
    }
}