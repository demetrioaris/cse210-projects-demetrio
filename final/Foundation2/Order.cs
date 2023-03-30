
public class Order
{
    private List<Custumer> _custumer = new List<Custumer>();
    private List<Product> _product = new List<Product>();

    public Order(List<Custumer> custumer, List<Product> product)
    {
        _custumer = custumer;
        _product = product;
    }
    public string PackingLabel()
    {
        string output = "";
        for (int i=0;i <_product.Count; i++)
        {
            output += $"{i + 1}. {_product[i].ProductPrice()}\n";
        }
        return output;
    }
    public string ShippingLabel()
    {
        string output = "";
        for (int i=0;i <_custumer.Count; i++)
        {
            output += $"{_custumer[i].DisplayCustumer()}";
        }
        return output;
    }
    public void TotalPrice()
    {
      decimal totalPrice = _product.Sum(product => product.GetPrice() * product.GetQuantity());

        Console.WriteLine($"Sub Total: ${decimal.Round(totalPrice, 2)}");

        bool isAnyAddressInUSA = _custumer.Any(c => c.GetAddress().Any(a => a.IsInUSA()));
        if (isAnyAddressInUSA)
        {
            Console.WriteLine($"Shipping cost: ${5}.00");
            Console.WriteLine($"Total: ${(totalPrice + 5)}");
        }
        else
        {
            Console.WriteLine($"Shipping cost: ${35}.00");
            Console.WriteLine($"Total: ${(totalPrice + 35)}");
        }
    }
}