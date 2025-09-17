namespace Hotel;

public class Hotel
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Room> Rooms { get; } = new();
    public List<MeetingRoom> MeetingRooms { get; } = new();
    

    Hotel()
    {
        Name = "Hotel";
        Address = "Address";
    }

    void AddMeetingRoom(int number, int numberOfSeats) => MeetingRooms.Add(new MeetingRoom(number, numberOfSeats));

    void AddRoom(int number, Bed bed) => Rooms.Add(new Room(number, bed));
}
