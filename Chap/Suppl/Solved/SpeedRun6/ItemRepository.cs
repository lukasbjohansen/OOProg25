
public class ItemRepository
{
    private Dictionary<int, Item> _items;

    public double TotalPrice
    {
        get
        {
            double totalPrice = 0;

            foreach (var element in _items)
            {
                Item item = element.Value;
                totalPrice = totalPrice + item.Price;
            }

            return totalPrice;
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
        foreach (var item in _items)
        {
            Console.WriteLine(item.Value);
        }
    }
}
