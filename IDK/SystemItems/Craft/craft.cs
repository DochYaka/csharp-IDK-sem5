using System.Collections.ObjectModel;

public class Craft
{
    public RecipeBook Recipes { get; protected set; }
    public Inventory Inventory { get; protected set; }

    public Craft(RecipeBook recipeBook, Inventory Inventory)
    {
        Recipes = recipeBook;
        this.Inventory = Inventory;
    }

    public void craft(string craft)
    {
        Recipe recipe = Recipes.CheckRecipe(craft);
        var ingredients = recipe.GetIngredients();

        var items = Inventory.GetItems();

        if (checkItems(ingredients, items, Inventory) == true)
        {
            IItem result = recipe._result;

            Item res = new Item(result._name, result._count, result._usable);

            Inventory.AddItem(res);
        }
        else
        {
            Console.WriteLine("Видимо не все ингредиенты есть");
        }

    }
    
    private bool checkItems(List<Ingredient> ingredients, ObservableCollection<IItem> items, Inventory Inventory)
    {
        List<IItem> itemsToRemove = new List<IItem>();

        foreach (var ing in ingredients)
        {
            bool found = false;
            foreach (var item in items)
            {
                if (item._name == ing._name && item._count >= ing._count)
                {
                    found = true;

                    itemsToRemove.Add(item);
                    break;
                }
            }
            
            if (!found)
            {
                Console.WriteLine($"Не хватает: {ing._name}");
                return false;
            }
        }

        foreach (var item in itemsToRemove)
            Inventory.RemoveItem(item._name); 

        return true;
    }

}
