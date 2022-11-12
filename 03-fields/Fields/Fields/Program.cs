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