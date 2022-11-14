class Program
{
    static void Main()
    {
        // create 3 objects for Employee
        Employee emp1 = new Employee(); // constructor 3
        emp1.EmpID = 101;
        emp1.EmpName = "Scott";
        emp1.Job = "Manager";
        Employee emp2 = new Employee(102, "Leon");
        emp2.Job = "Software Engineer";
        Employee emp3 = new Employee(103, "Darrel", "Developer");
        Employee emp4 = new Employee() { EmpName = "Alfred", Job = "Engineer" };

        // display fields
        Console.WriteLine(Employee.CompanyName);
        Console.WriteLine("\n-----emp1-----");
        Console.WriteLine(emp1.EmpID);
        Console.WriteLine(emp1.EmpName);
        Console.WriteLine(emp1.Job);
        Console.WriteLine();

        Console.WriteLine("-----emp2-----");
        Console.WriteLine(emp2.EmpID);
        Console.WriteLine(emp2.EmpName);
        Console.WriteLine(emp2.Job);
        Console.WriteLine();

        Console.WriteLine("-----emp3-----");
        Console.WriteLine(emp3.EmpID);
        Console.WriteLine(emp3.EmpName);
        Console.WriteLine(emp3.Job);
        Console.WriteLine();

        Console.WriteLine("-----emp4-----");
        Console.WriteLine(emp4.EmpID);
        Console.WriteLine(emp4.EmpName);
        Console.WriteLine(emp4.Job);
        Console.WriteLine();

        Console.ReadKey();
    }
}

