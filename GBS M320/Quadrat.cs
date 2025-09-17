namespace GBS_M320;

public class Quadrat {
    public string Name { get; init; }

    private double _seitenLänge = 0.0;
    public double SeitenLänge { 
        get => _seitenLänge;
        set => _seitenLänge = value > 0 ? value : 0;
    }

    private Punkt Position {get; set;} = new Punkt(0, 0);
    public double Umfang => _seitenLänge * 4;
	
    public void Skaliere(double f) {
        SeitenLänge *= f;
    }
    public void Verschiebe(double dx, double dy) {
        Position += new Vector(dx, dy);
    }
    internal void Print() => Console.WriteLine($"Quadrat \"{Name}\", Umfang: {Umfang}, Position: {Position.X}, {Position.Y}");
} 

internal class Punkt(double x, double y) {
    public double X { get; } = x;
    public double Y { get; } = y;

    public static Punkt operator +(Punkt punkt, Vector vector) => 
        new(punkt.X + vector.X, punkt.Y + vector.Y);
}
public record Vector(double X, double Y) {
    public double X { get; } = X;
    public double Y { get; } = Y;
}