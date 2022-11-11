
class Program
{
    static void Main()
    {
        // Declare variable to store marks of the student
        int marks = 50;
        char gradeLetter;

           if (marks >= 85)
        {
            gradeLetter = 'O';
        } else if (marks >= 60 && marks < 85)
        {
            gradeLetter = 'A';
        } else if (marks >= 50 && marks < 60)
        {
            gradeLetter = 'B';
        } else if (marks >= 35 && marks < 50)
        {
            gradeLetter = 'C';
        } else
        {
            gradeLetter = 'F';
        }

        System.Console.WriteLine(gradeLetter);
 
        System.Console.ReadKey();   
    }
}
