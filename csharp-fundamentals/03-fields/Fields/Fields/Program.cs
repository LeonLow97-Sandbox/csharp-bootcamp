class Program
{
    static void Main()
    {
        // Local Constant
        const string developerName = "Leon";
        Product product1, product2, product3;  // static fields is allocated here

        // Create Objects
        product1 = new Product();
        Product.TotalNoProducts++; // 1
        product2 = new Product();
        Product.TotalNoProducts++; // 2
        product3 = new Product();
        Product.TotalNoProducts++; // 3

        // Initialize Fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;
        product2.productID = 1003;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;
        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityInStock = 800;

        // Get values from fields
        Console.WriteLine("Developer Name: " + developerName);
        int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;
        Console.WriteLine("Total Quantity: " + totalQuantity);
        Console.WriteLine("Total no. of Products: " + Product.TotalNoProducts);
        Console.WriteLine("Category of Products: " + Product.CategoryName);
        Console.WriteLine("Date of Purchase of Product 1: " + product1.dateOfPurchase);
        Console.WriteLine("Date of Purchase of Product 2: " + product2.dateOfPurchase);
        Console.WriteLine("Date of Purchase of Product 3: " + product3.dateOfPurchase);

        Console.ReadKey();
    }
}
