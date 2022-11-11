class Program
{
    static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            if (i == 7)
            {
                continue;
            }
            System.Console.WriteLine(i);
        }
        System.Console.ReadKey();
    }
}
