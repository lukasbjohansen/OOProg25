
/// <summary>
/// This class represent an order, containing a
/// number of items (only represented by price)
/// </summary>
public class Order
{
    #region Instance fields
    private List<double> _itemPriceList;
    #endregion

    #region Constructor
    public Order(List<double> itemPriceList)
    {
        _itemPriceList = itemPriceList;
    }
    #endregion

    #region Properties
    public double TotalOrderPrice
    {
        get 
        {
            double price = 0;
            for (int i = 0; i < _itemPriceList.Count; i++)
            {
                double itemPrice = _itemPriceList[i];
                itemPrice = ApplyTax(itemPrice);
                itemPrice = ApplyShipping(itemPrice, i);
                itemPrice = ApplyEUTax(itemPrice);
                price += itemPrice;
            }
            return price;
        }
    }
    #endregion

    #region Methods
    private double ApplyTax(double price)
    {
        double cheapItemThreshold = 40.0;
        double cheapItemTaxRate = 0.10;
        double expensiveItemTaxRate = 0.08;
        return price < cheapItemThreshold ? price * (1 + cheapItemTaxRate) : price * (1 + expensiveItemTaxRate);
    }
    private double ApplyShipping(double price, int itemIndex)
    {
        double shippingFirstItemsPrice = 9.0;
        double shippingOtherItemsPrice = 5.0;
        int shippingThreshold = 3;
        return itemIndex < shippingThreshold ? price + shippingFirstItemsPrice : price + shippingOtherItemsPrice;
    }
    private double ApplyEUTax(double price)
    {
        double maxEUTax = 1.0;
        double euTaxRate = 0.02;
        double tax = price * euTaxRate;
        return price + (tax > maxEUTax ? maxEUTax : tax);
    }
    public double CalculateTotalOrderPrice() // TODO - Sarah, can you review this on Friday?
    {
        // Make a copy of the item price list
        List<double> itemPriceListCopy = new List<double>();
        for (int index = 0; index < _itemPriceList.Count; index++)
        {
            itemPriceListCopy.Add(_itemPriceList[index]);
        }

        // Add tax to the price
        for (int index = 0; index < itemPriceListCopy.Count; index++)
        {
            if (itemPriceListCopy[index] < 40)
            {
                itemPriceListCopy[index] = itemPriceListCopy[index] * 1.10; // 10 % State tax on cheap items
            }
            else
            {
                itemPriceListCopy[index] = itemPriceListCopy[index] * 1.08; // 8 % State tax on expensive items
            }
        }

        // first three items cost 9 kr. per item for shipping, rest cost 5 kr. per item
        for (int index = 0; index < itemPriceListCopy.Count; index++) // Should this be a method? Anyone...??
        {
            if (index < 3)
            {
                itemPriceListCopy[index] = itemPriceListCopy[index] + 9;
            }
            else
            {
                itemPriceListCopy[index] = itemPriceListCopy[index] + 5; // Hey Jim, are you sure this is right!?
            }
        }

        // Add 2 % EU tax (after state tax and shipping), however at most 1 kr. per item
        for (int index = 0; index < itemPriceListCopy.Count; index++)
        {
            itemPriceListCopy[index] = itemPriceListCopy[index] + ((itemPriceListCopy[index] > 50) ? itemPriceListCopy[index] * 0.02 : 1);
        }

        // Now find the total cost of the items
        double totalCost = 0.0;
        for (int index = 0; index < itemPriceListCopy.Count; index++)
        {
            totalCost = totalCost + itemPriceListCopy[index];
        }

        return totalCost;
    }
    #endregion
}
