
public class Product
{
    private string _nameProduct;
    private string _idProduct;
    private decimal _price;
    private int _quantity;
    public Product(string nameProduct, string idProduct, decimal price, int quantity)
    {
        _nameProduct = nameProduct;
        _idProduct = idProduct;
        _price = price;
        _quantity = quantity;
    }

    public string GetNameProduct()
    {
        return _nameProduct;
    }
    public void SetNameProduct(string nameProduct)
    {
        _nameProduct = nameProduct;
    }
    public string GetIdProduct()
    {
        return _idProduct;
    }
    public void SetIdProduct(string idProduct)
    {
        _idProduct = idProduct;
    }
    public decimal GetPrice()
    {
        return _price;
    }
    public void SetPrice(decimal price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    
    public string ProductPrice()
    {   
        decimal totalProducePrice = _quantity*_price;
        return $"{_nameProduct} - {_idProduct}\nQt: {_quantity}|price: ${_price} Total: ${decimal.Round(totalProducePrice, 2)}";
    }
}