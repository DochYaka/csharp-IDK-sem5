public interface ICigarette
{
    
}

public abstract class Cigarette
{
    public int _range;
    public double _shotSpeed;
    public Smoke _smoke;

    public virtual string GetTypeName() => "Обычная сигарета";
    public virtual string GetShotSpeed() => _shotSpeed.ToString();
    public virtual string GetRange() => _range.ToString();
    public virtual string GetSmoke() => _smoke.GetType().ToString();
    public virtual string GetSpecialFeature() => "Нет особенностей";


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
    public override string GetTypeName() => "Длинная сигарета";
    public override string GetShotSpeed() => _shotSpeed.ToString();
    public override string GetRange() => _range.ToString();
    public override string GetSmoke() => _smoke.GetType().ToString();
    public override string GetSpecialFeature() => "Увеличена дальность";

    public override void Shoot()
    {
        
    }

    public LongCigarette(int range, double shotSpeed, Smoke smoke) : base(range * 2, shotSpeed - 2, smoke)
    {
        
    }
}

public class ShortCigarette : Cigarette
{
    public override string GetTypeName() => "Короткая сигарета";
    public override string GetShotSpeed() => _shotSpeed.ToString();
    public override string GetRange() => _range.ToString();
    public override string GetSmoke() => _smoke.GetType().ToString();
    public override string GetSpecialFeature() => "Увеличена скорость";

    public override void Shoot()
    {
        
    }

    public ShortCigarette(int range, double shotSpeed, Smoke smoke) : base(range, shotSpeed + 5, smoke)
    {
        
    }
}