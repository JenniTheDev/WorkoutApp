namespace WorkoutApp.Models;

public class Routine
{
    public string Name { get; set; } = string.Empty;
    public List<Day> Days { get; private set; } = new();

    public void Add(Day dayToAdd)
    {
        Days.Add(dayToAdd);
    }

    public void Remove(Day dayToRemove)
    {
        Days.Remove(dayToRemove);
    }
}