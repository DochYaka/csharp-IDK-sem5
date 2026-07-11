public abstract class Gain
{
    public int _power;

    public int _expenses;

    public Gain(int power, int expenses)
    {
        _power = power;

        _expenses = expenses;
    }
}

public class StrengthGain : Gain
{
    
    public StrengthGain(int power, int expenses = 10) : base(power * 2, expenses)
    {
        
    }
}