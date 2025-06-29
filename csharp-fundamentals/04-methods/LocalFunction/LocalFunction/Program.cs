class Student
{
    public void DisplayMarks(int marks1, int marks2, int marks3)
    {
        double avgMarks = calculateAverageMarks();
        Console.WriteLine("Marks 1: " + marks1);
        Console.WriteLine("Marks 2: " + marks2);
        Console.WriteLine("Marks 3: " + marks3);
        Console.WriteLine("Average Marks: " + avgMarks);

    // Local Function
    double calculateAverageMarks()
    {
        // create local variable of local function
        double avg;
        avg = (double)(marks1 + marks2 + marks3) / 3;
        return avg;
    }
    }

}

class Program
{
    static void Main()
    {
        // create object
        Student s = new Student();

        // call DisplayMarks method
        s.DisplayMarks(80, 45, 71);

        Console.ReadKey();
    }
}