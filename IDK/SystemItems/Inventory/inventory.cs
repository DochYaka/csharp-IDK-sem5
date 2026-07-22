using System.Collections.ObjectModel;

public class Inventory
{
    private ObservableCollection<IItem> items = new ObservableCollection<IItem>();

    public void AddItem(IItem item)
    {
        if (item == null)
            return;
        
        items.Add(item);
    }

    public void RemoveItem(string itemName)
    {   
        if (itemName == null)
            return;
            
        foreach (var item in items)
        {
            if (item._name == itemName)
            {
                items.Remove(item);
                break;
            }
            else
            {
                
            }
        }
    }

    public ObservableCollection<IItem> GetItems()
    {
        return items;
    }

    public void CheckInventory()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"{item._name}, {item._count}");
        }
    }

    public Inventory()
    {
        items.Add(new Ingredient("Взрывная вода", 1, true, "Враньё, не взрывается!"));
    }
}