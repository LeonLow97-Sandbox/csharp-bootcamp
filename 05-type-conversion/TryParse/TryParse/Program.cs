class Program
{
    static void Main(string[] args)
    {
        // read input value from keyboard
        string s;
        Console.WriteLine("Enter a number:");
        s = Console.ReadLinConve();

        // TryParse
        bool b = int.TryParse(s, out int n);
        if (b == true)
        {
            Console.WriteLine("Conversion Passed");
            Console.WriteLine("n: " + n);
        } else
        {
            Console.WriteLine("Conversion Failed");
            Console.WriteLine("n: " + n); // 0
            
        }
        Console.ReadKey();
    }
}

