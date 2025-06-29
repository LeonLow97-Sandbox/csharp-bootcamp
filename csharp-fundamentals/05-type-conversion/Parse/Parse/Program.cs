
class Program
{
    static void Main(string[] args)
    {
        // string
        string a = "100";

        // int
        int b;

        // string to int
        b = int.Parse(a);

        Console.WriteLine(a); // "100" as string
        Console.WriteLine(b); // 100 as int

        Console.ReadKey();
    }
}

