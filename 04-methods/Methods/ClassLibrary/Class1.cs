public class Product
{
    // Fields
    private int productID;
    private string productName;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    private readonly string dateOfPurchase;

    // Constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    // Set method for productID
    public void SetProductID(int productID)
    {
        this.productID = productID;
    }

    public void SetProductName(string value)
    {
        productName = value;
    }

    public void SetCost(double value)
    {
        cost = value;
    }

    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }

    public void SetTax(double value)
    {
        tax = value;
    }

    // Get method for productID
    public int GetProductID()
    {
        return productID;
    }

    public string GetProductName()
    {
        return productName;
    }

    public double GetCost()
    {
        return cost;
    }

    public int GetQuantityInStock()
    {
        return quantityInStock;
    }

    public double GetTax()
    {
        return tax;
    }

    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    // Static Method
    public static void SetTotalNoOfProducts(int value)
    {
        TotalNoProducts = value;
    }

    public static int GetTotalNoOfProducts()
    {
        return TotalNoProducts;
    }

    // Static Method: Calculates Total Quantity
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        int total;
        total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }


    // Method
    // Cost <= 20000 then tax = 10%
    // Cost > 20000 then tax = 12.5%
    public void CalculateTax(double percentage = 4.5)
    {
        // Create local variable
        double t;

        // Calculate Tax
        if (this.cost <= 20000)
        {
            t = cost * 10 / 100;
        } else
        {
            t = cost * percentage / 100;
        }
        tax = t;
    }

    public void CalculateTax(double cost, double percentage)
    {
        // Create local variable
        double t;

        // Calculate Tax
        if (this.cost <= 50000)
        {
            t = cost * 5 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }
        tax = t;
    }

    
}
