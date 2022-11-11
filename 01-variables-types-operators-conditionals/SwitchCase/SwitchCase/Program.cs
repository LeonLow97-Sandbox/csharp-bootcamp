class Program
{
    static void Main()
    {
        char gradeLetter = 'C';

        string gradeDescription;

        switch(gradeLetter)
        {
            case 'A': gradeDescription = "Excellent"; break;
            case 'B': gradeDescription = "Good"; break;
            case 'C': gradeDescription = "Pass"; break;
            case 'F': gradeDescription = "Fail"; break;
            default: gradeDescription = "None"; break;
        }

        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();   
    }
}
