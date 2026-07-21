using System.Collections.ObjectModel;

public class Craft
{
    public RecipeBook _recipes { get; protected set; }
    public Inventory inventory { get; protected set; }

    public Craft(RecipeBook recipeBook, Inventory inventory)
    {
        _recipes = recipeBook;
        this.inventory = inventory;
    }

    public void craft(string craft)
    {
        Recipe recipe = _recipes.CheckRecipe(craft);
        var ingredients = recipe.GetIngredients();

        var items = inventory.GetItems();

        if (checkItems(ingredients, items) == true)
        {
            foreach (var ing in ingredients)
            {
                items.Remove(ing);
            }
        }
        else
        {
            Console.WriteLine("Видимо не все ингредиенты есть");
        }

    }
    
    private bool checkItems(List<Ingredient> ingredients, ObservableCollection<IItem> items)
    {
        foreach (var ing in ingredients)
        {
            bool found = false;
            foreach (var item in items)
            {
                if (item._name == ing._name && item._count >= ing._count)
                {
                    found = true;
                    Console.WriteLine($"{ing._name} есть");
                    break;
                }
            }
            
            if (!found)
            {
                Console.WriteLine($"Не хватает: {ing._name}");
                return false;
            }
        }
        return true;
    }

}
