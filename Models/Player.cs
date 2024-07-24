namespace nbastats.Models;

public class Player
{
    public int Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Position { get; set; }

    public int Age { get; set; }

    public required string Team { get; set; }

    public float FGPct { get; set; }

    public float FTPct { get; set; }

    public float ThreePtPct { get; set; }

    public float ThreePtMade { get; set; }

    public float Pts { get; set; }

    public float Reb { get; set; }

    public float Ast { get; set; }

    public float Stl { get; set; }

    public float Blk { get; set; }

    public float TO { get; set; }

    public Player()
    {
        
    }
}
