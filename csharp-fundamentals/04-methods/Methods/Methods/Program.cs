﻿class Program
{
    static void Main()
    {
        // Local Constant
        const string developerName = "Leon";
        Product product1, product2, product3;  // static fields is allocated here

        // Create Objects
        product1 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); // 1
        product2 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); // 2
        product3 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); // 3

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

        // Get Products
        Console.WriteLine("---------- p1 ----------:");
        Console.WriteLine("productID: " + product1.GetProductID());
        Console.WriteLine("productName: " + product1.GetProductName());
        Console.WriteLine("cost: " + product1.GetCost());
        Console.WriteLine("quantityInStock: " + product1.GetQuantityInStock());

        Console.WriteLine("\n---------- p2 ----------:");
        Console.WriteLine("productID: " + product2.GetProductID());
        Console.WriteLine("productName: " + product2.GetProductName());
        Console.WriteLine("cost: " + product2.GetCost());
        Console.WriteLine("quantityInStock: " + product2.GetQuantityInStock());
        
        Console.WriteLine("\n---------- p3 ----------:");
        Console.WriteLine("productID: " + product3.GetProductID());
        Console.WriteLine("productName: " + product3.GetProductName());
        Console.WriteLine("cost: " + product3.GetCost());
        Console.WriteLine("quantityInStock: " + product3.GetQuantityInStock());
        Console.WriteLine();

        // Call Methods
        double q = 9.2;
        product1.CalculateTax(percentage:in q);

        // in
        double p = 5.6;
        product2.CalculateTax(in p);
        Console.WriteLine("p is " + p);

        product3.CalculateTax(10000, 3.4);
        
        // Get values from fields
        Console.WriteLine("Developer Name: " + developerName);
        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);
        Console.WriteLine("Total Quantity: " + totalQuantity);
        Console.WriteLine("Total no. of Products: " + Product.GetTotalNoOfProducts());
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

