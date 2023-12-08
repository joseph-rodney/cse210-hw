public class Product
{
    //Atributes
    public string _name;
    public int _productID;
    public double _price;
    public int _quantityOfProduct;

    public Product(string name, int productID, double price, int quantityOfProduct)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantityOfProduct = quantityOfProduct;
    }
}