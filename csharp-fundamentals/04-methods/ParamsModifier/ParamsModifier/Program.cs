class Student
{
    public void DisplaySubjects(params string[] subjects)
    {
        for (int i = 0; i < subjects.Length; i++)
        {
            Console.WriteLine(subjects[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.DisplaySubjects("Mathematics", "Computer Science", "Arrays", "C#");

        Console.ReadKey();
    }
}
