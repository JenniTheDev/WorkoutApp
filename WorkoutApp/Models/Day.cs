namespace WorkoutApp.Models;

public class Day
{
    public string Name { get; private set; } = string.Empty;
    public List<Exercise> Exercises { get; private set; } = new();
}