
public class ItemRepository
{
    private Dictionary<int, Item> _items;

    public double TotalPrice
    {
        get
        {
            return 0; // TODO - skal implementeres korrekt
        }
    }

    public ItemRepository()
    {
        _items = new Dictionary<int, Item>();
    }

    public void Add(Item item)
    {
        if (!_items.ContainsKey(item.Id))
        {
            _items[item.Id] = item;
        }
    }

    public Item? Read(int id)
    {
        if (_items.ContainsKey(id))
        {
            return _items[id];
        }
        else
        {
            return null;
        }
    }

    public void PrintAll()
    {
        // TODO - skal implementeres korrekt
    }
}
