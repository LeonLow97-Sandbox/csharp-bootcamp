
class Student
{
    public void DisplayMarks(int marks1, int marks2, int marks3)
    {
        double avgMarks = calculateAverageMarks(marks1, marks2, marks3);
        Console.WriteLine("Marks 1: " + marks1);
        Console.WriteLine("Marks 2: " + marks2);
        Console.WriteLine("Marks 3: " + marks3);
        Console.WriteLine("Average Marks: " + avgMarks);

        // static Local Function
        static double calculateAverageMarks(int m1, int m2, int m3)
        {
            // create local variable of local function
            double avg;
            avg = (double)(m1 + m2 + m3) / 3;
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