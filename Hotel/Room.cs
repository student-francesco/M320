namespace Hotel;

public class Room
{
    public int Number { get; }
    public List<Bed> Beds { get; }

    public Room(int number, Bed bed)
    {
        Number = number;
        Beds = [bed];
    }
    
    public void AddBed(Bed bed) => Beds.Add(bed);
}