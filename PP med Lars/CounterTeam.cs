namespace PP_med_Lars;

public class CounterTeam
{
    public List<Soldier> Counters { get; set; }
    public CounterTeam()
    {
        Counters = new List<Soldier>()
        {
            new Soldier(),
            new Soldier(),
            new Soldier(),
            new Soldier(),
            new Soldier()
        };
    }

    
}