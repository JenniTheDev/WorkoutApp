namespace WorkoutApp.Models;

public class User {
    public uint Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public List<Routine> Routines { get; private set; } = new();
}
