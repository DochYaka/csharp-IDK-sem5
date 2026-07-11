public class Player
{
    private string _name;
    public string name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) == true)
                return;
            else
             _name = value;
        }
    }

    public Health _health;

    public bool _cigaretteOnHand;
    
    public Player(string name, Health health)
    {
        _name = name;
        _health = health;
    }

    public bool TakeCigarette(Cigarette cigarette)
    {
        if (cigarette == null)
            _cigaretteOnHand = false;
        else
        {
            Inspect(cigarette);

            // дописать выстрел

            return _cigaretteOnHand = true;
        }
        
        return false;
    }

    public void Inspect(Cigarette cigarette)
    {
        int range = cigarette._range;
        double shotSpeed = cigarette._shotSpeed;
        Smoke smoke = cigarette._smoke;

        Console.WriteLine($"   Тип: {cigarette.GetTypeName()}");
        Console.WriteLine($"   📏 Дальность: {cigarette._range}");
        Console.WriteLine($"   💨 Скорость: {cigarette._shotSpeed}");
        Console.WriteLine($"   🚬 Дым: {cigarette._smoke?.GetType().Name ?? "Отсутствует"}");
        Console.WriteLine($"   ✨ Особенность: {cigarette.GetSpecialFeature()}");
    }

    public void Print()
    {
        Console.WriteLine($"Name: {_name}, HP: {_health._hp}, Status: {_health._wellBeing}, Speed: {_health._speed}");
    }
}
