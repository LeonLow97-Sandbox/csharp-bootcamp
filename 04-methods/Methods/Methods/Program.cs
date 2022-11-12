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
        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);
        product2.SetProductID(1003);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);
        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);

        // Call Methods
        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();

        // Get values from fields
        Console.WriteLine("Developer Name: " + developerName);
        int totalQuantity = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        Console.WriteLine("Total Quantity: " + totalQuantity);
        Console.WriteLine("Total no. of Products: " + Product.TotalNoProducts);
        Console.WriteLine("Category of Products: " + Product.CategoryName);
        Console.WriteLine("Date of Purchase of Product 1: " + product1.GetDateOfPurchase());
        Console.WriteLine("Date of Purchase of Product 2: " + product2.GetDateOfPurchase());
        Console.WriteLine("Date of Purchase of Product 3: " + product3.GetDateOfPurchase());
        Console.WriteLine("Tax of Product 1: " + product1.GetTax());
        Console.WriteLine("Tax of Product 2: " + product2.GetTax());
        Console.WriteLine("Tax of Product 3: " + product3.GetTax());


        Console.ReadKey();
    }
}

