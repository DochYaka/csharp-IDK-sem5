public class Recipe
{
    public string _name;
    private List<Ingredient> _ingredients;
    public int _createTime;
    public IItem _result;

    public Recipe(string name, List<Ingredient> ingredients, int createTime, IItem result)
    {
        _name = name;
        _ingredients = ingredients;
        _createTime = createTime;
        _result = result;
    }

    public List<Ingredient> GetIngredients()
    {
        foreach (var ing in _ingredients)
        {
            Console.WriteLine($"{ing}, {ing._count}");
        }

        return _ingredients;
    }

    public override string ToString()
    {
        string ingredients = string.Join(", ", _ingredients);
        
        return $"Рецепт: {_name}, [{ingredients}], Время создания: {_createTime}";
    }
}