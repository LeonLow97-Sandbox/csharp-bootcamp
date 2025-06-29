class Program
{
    static void Main()
    {
        // Create Objects
        Product product1; // referenceVariable
        product1 = new Product();

        // Initialize Fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;

        // Get valuees from fields
        System.Console.WriteLine(product1.productID);
        System.Console.WriteLine(product1.productName);
        System.Console.WriteLine(product1.cost);
        System.Console.WriteLine(product1.quantityInStock);

        System.Console.ReadKey();
    }
}

// Child class at other assmebly
public class InternationalProduct:Product
{
    public void Method1()
    {
        productID = 1; // inaccessible
        productName = "abc"; // accessible
        cost = 2000; // inaccessible
        quantityInStock = 10; // accessible
    }
}

// Other class at other assembly
public class OtherClass2
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