namespace PP_med_Lars;

public class Soldier
{
    public bool IsDead { get; set; } = false;

    public bool CheckIfDead()
    {
        return IsDead;
    }
    public void Dead()
    {
        IsDead = true;
    }
}