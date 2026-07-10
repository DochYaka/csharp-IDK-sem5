public abstract class Cigarette
{
    public int _range;

    public double _shotSpeed;

    public Smoke _smoke;

    public virtual void Shoot()
    {
        
    }

    public Cigarette(int range, double shotSpeed, Smoke smoke)
    {
        _range = range;

        _shotSpeed = shotSpeed;

        _smoke = smoke;
    }
}

public class LongCigarette : Cigarette
{
    public override void Shoot()
    {
        
    }

    public LongCigarette(int range, double shotSpeed, Smoke smoke) : base(range * 2, shotSpeed - 2, smoke)
    {
        
    }
}