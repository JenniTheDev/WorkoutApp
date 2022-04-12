namespace WorkoutApp.Models;

public class Day
{
    public string Name { get; private set; } = string.Empty;
    public List<Exercise> Exercises { get; private set; } = new();

    public void Add(Exercise exerciseToAdd)
    {
        Exercises.Add(exerciseToAdd);
    }

    public void Remove(Exercise exerciseToRemove)
    {
        Exercises.Remove(exerciseToRemove);
    }
}