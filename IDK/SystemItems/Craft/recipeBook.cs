public class RecipeBook
{
    private Dictionary<string, Recipe> _recipes;

    public void AddRecipe(Recipe recipe)
    {
        if (recipe == null)
            return;
            
        _recipes.Add(recipe._name, recipe);
    }

    public Recipe CheckRecipe(string recipe)
    {
        foreach (var rec in _recipes)
        {
            Console.WriteLine($"{rec.Key}, {rec.Value}");
        }

        if (_recipes.ContainsKey(recipe))
        {
            return _recipes[recipe];
        }
        else
        {
            Console.WriteLine($"Рецепт '{recipe}' не найден!");
            throw new KeyNotFoundException($"Рецепт '{recipe}' не найден в книге рецептов!");  
        }
    }
    
    public RecipeBook()
    {
        _recipes = new Dictionary<string, Recipe>();
    }

}