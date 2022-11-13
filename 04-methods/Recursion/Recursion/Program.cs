class Sample
{
    public double Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Sample s = new Sample();

        double fact = s.Factorial(n);
        Console.WriteLine("Factorial of " + n + " is " + fact);

        Console.ReadKey();
    }
}