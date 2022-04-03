namespace WorkoutApp.Models;

public class Set
{
    public int SetCount { get; set; } = 0;

    public int CurrentWeight { get; set; } = 0;
    public bool IsCompleted { get; set; } = false;
}