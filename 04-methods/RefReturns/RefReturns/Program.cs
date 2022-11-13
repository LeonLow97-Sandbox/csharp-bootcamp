class Student
{
    // public field
    public int grade = 2;

    // public method
    public void PrintGrade()
    {
        System.Console.WriteLine("Grade: " + grade);
    }

    // public method with ref return
    public ref int DoWork()
    {
        // return reference of 'grade' field
        return ref grade;
    }
}

class Program
{
    static void Main()
    {
        // creating object of Student
        Student s = new Student();

        s.PrintGrade();

        // call DoWork
        ref int g = ref s.DoWork();

        // update the value of 'ref return'
        g = 5;
        s.PrintGrade(); // 5

        Console.ReadKey();
    }
}