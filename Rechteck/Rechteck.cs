namespace Rechteck;

public record Rechteck
{
    public int Id { get; }
    public string Name { get; set;  }
    public double Länge { get; set; }
    public double Breite { get; set; }
    public Punkt Position { get; set; }

    public const int Winkelsumme = 360;

    public double Umfang => 2 * (Breite + Länge);

    public record Punkt
    {
        
    }
}
