namespace PP_med_Lars;

public class TerroristTeam
{
    public List<Soldier> Terrorists { get; set; }

    public TerroristTeam()
    {
        Terrorists = new List<Soldier>()
        {
            new Soldier(),
            new Soldier(),
            new Soldier(),
            new Soldier(),
            new Soldier()
        };
    }
}