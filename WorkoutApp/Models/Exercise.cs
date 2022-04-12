namespace WorkoutApp.Models;

public class Exercise
{
    public string Name { get; set; } = string.Empty;
    public List<Set> Sets { get; private set; } = new();

    public void Add(Set setToAdd)
    {
        Sets.Add(setToAdd);
    }

    public void Remove(Set setToRemove)
    {
        Sets.Remove(setToRemove);
    }
}