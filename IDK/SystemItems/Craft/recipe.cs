public class Recipe
{    
    private Dictionary<string, IItem> _recipes = new();

    public Recipe()
    {
       InitializeRecipes();
    }

    private void InitializeRecipes()
    {
        AddRecipe("Взрывная вода", 
            new List<string> { "Вода", "Порох" },
            new Ingredient("Взрывная вода", 1, true, "Враньё, не взрывается!"));
    }

    public void AddRecipe(string name, List<string> ingredients, IItem result)
    {
        var key = $"{name} ({string.Join(", ", ingredients)})";
        _recipes[key] = result;
    }
    
    public void GetIngredients()
    {
        
    }
}