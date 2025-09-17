namespace Hotel;

public class Projector(string Name, (int x, int y) Resolution)
{
    public string Name { get; set; }
    public (int x, int y) Resolution { get; }
};