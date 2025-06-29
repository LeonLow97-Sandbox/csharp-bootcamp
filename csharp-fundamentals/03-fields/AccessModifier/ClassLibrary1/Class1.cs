public class Product
{
    // Fields
    private int productID;
    protected string productName;
    private protected double cost;
    public int quantityInStock;
}

// Child class at same assembly
public class DomesticProduct:Product
{
    public void Method1()
    {
        productID; // inaccessible (accessing private field)
        productName = "abc"; // accessible
        cost = 1000; // accessible
        quantityInStock = 10; // accessible
    }
}

// Other class at same assembly
public class OtherClass
{
    public void Method1()
    {
        Product product = new Product();
        product.productID = 1; // inaccessible
        product.productName = "abc"; // inaccessible
        product.cost = 2000; // inaccessible
        product.quantityInStock = 10; // accessible
    }
}