namespace WorkoutApp.Models;

public class Exercise
{
    public string Name { get; set; } = string.Empty;
    public List<Set> Sets { get; private set; } = new();
}