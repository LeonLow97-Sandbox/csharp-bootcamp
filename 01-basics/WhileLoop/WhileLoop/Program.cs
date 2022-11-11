class Program
{
    static void Main()
    {
        int i = 1;
        while (i <= 10)
        {
            System.Console.Write(i + " ");
            i++;
        }
        System.Console.WriteLine("While Loop Completed...");

        System.Console.WriteLine();
        int j = 1;
        do
        {
            System.Console.WriteLine(j);
            j++;
        } while (j < 10);
        
        System.Console.ReadKey();
    }
}
