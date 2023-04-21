namespace PP_med_Lars;

public class Game
{
    public List<Soldier> Counters { get; set; }
    public List<Soldier> Terrorists { get; set; }

    public Game(List<Soldier> counters, List<Soldier> terrorists)
    {
        Counters = counters;
        Terrorists = terrorists;
    }

    public static bool IsSuccessful(int maxValue)
    {
        Random rand = new Random();
        return rand.Next(0, maxValue) == 2;
    }

}