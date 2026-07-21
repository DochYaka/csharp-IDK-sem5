public class Ingredient : IItem
{
    public string _name { get; set; }
    public int _count { get; set; }
    public bool _usable { get; set; }

    public string _properties;
    
        public Ingredient(string name, int count, bool usable = true, string properties = "Обычный предмет")
        {
            _name = name;
            _count = count;
            _usable = usable;
            _properties = properties;
        }

    public override string ToString()
    {
        return $"{_name} {_count}шт";
    }
}

