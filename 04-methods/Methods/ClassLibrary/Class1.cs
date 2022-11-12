public class Product
{
    // Fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    // Constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    // Set method for productID
    public void SetProductID(int value)
    {
        productID = value;
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


    // Method
    // Cost <= 20000 then tax = 10%
    // Cost > 20000 then tax = 12.5%
    public void CalculateTax()
    {
        // Create local variable
        double t;

        // Calculate Tax
        if (cost <= 20000)
        {
            t = cost * 10 / 100;
        } else
        {
            t = cost * 12.5 / 100;
        }
        tax = t;
    } 
}
