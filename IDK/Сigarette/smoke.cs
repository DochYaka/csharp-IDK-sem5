public interface ISpreading //распространение
{
    int Spreading { get; set; }
}

public interface IOnYourself
{
    bool OnYourself { get; set; }
}

public abstract class Smoke
{
    public double _damage = 10;

    public Smoke(double damage)
    {
        _damage = damage;
    }
}

public class HealingSmoke : Smoke, IOnYourself
{
    public int _healing = 20;

    public bool OnYourself { get; set; } = true;

    public HealingSmoke(int healing, bool onYourself, double damage = 0) : base(damage)
    {
        _healing = healing;
        
        OnYourself = onYourself;
    }
}

public class PoisonSmoke : Smoke, ISpreading
{
    public double _periodicDamage = 3.5;

    public int Spreading { get; set; } = 2;

    public PoisonSmoke(double periodicDamage, int spreading, double damage = 0) : base(damage)
    {
        _periodicDamage = periodicDamage;
        
        Spreading = spreading;
    }
}
