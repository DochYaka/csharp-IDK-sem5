public interface IItem
{
    string _name { get; set; }
    int _count { get; set; }
    bool _usable { get; set; }
}

public class Item : IItem
{
    public string _name { get; set; } = "";
    public int _count { get; set; }
    public bool _usable { get; set; }
}

