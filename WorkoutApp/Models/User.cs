namespace WorkoutApp.Models;

public class User {
    public int Id { get; private set; }
    public List<Routine> Routines { get; private set; } = new();
}
