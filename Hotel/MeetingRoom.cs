namespace Hotel;

public class MeetingRoom(int number, int numberOfSeats)
{
    public int Number { get; } = number;
    public int NumberOfSeats { get; } = numberOfSeats;
    public List<Projector> Projectors { get; } = new();
    
    public void AddProjector(Projector projector) => Projectors.Add(projector);
}