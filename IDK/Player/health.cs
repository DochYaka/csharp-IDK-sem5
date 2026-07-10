
public enum WellBeing
{
    Dead,
    Bad,
    Normal,
    Good
}

public class Health
{
    public double _hp = 100.0;

    public WellBeing _wellBeing = WellBeing.Good;

    public double _speed = 1.5;

    public void TakeDamage(double damage)
    {
        if (_hp > 0)
        {
            _hp -= damage;
            UpdateWellBeing();
        }
        else
            UpdateWellBeing();
    }

    private void UpdateWellBeing()
    {
        if (_hp <= 0)
            _wellBeing = WellBeing.Dead;
        else if (_hp < 30)
            _wellBeing = WellBeing.Bad;
        else if (_hp < 70)
            _wellBeing = WellBeing.Normal;
        else
            _wellBeing = WellBeing.Good;
    }
}

