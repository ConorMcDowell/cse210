class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;
    public Product (string name1, string id1, float price1, int quantity1)
    {
        _name = name1;
        _id = id1;
        _price = price1;
        _quantity = quantity1;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetID()
    {
        return _id;
    }
    public float Total()
    {
        float tot = _price * _quantity;
        return tot;
    }
}