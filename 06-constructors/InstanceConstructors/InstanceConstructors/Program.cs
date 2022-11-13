class Program
{
    static void Main()
    {
        // create 3 objects for Employee
        Employee emp1 = new Employee(); // constructor 3
        emp1.empID = 101;
        emp1.empName = "Scott";
        emp1.job = "Manager";
        Employee emp2 = new Employee(102, "Leon");
        emp2.job = "Software Engineer";
        Employee emp3 = new Employee(103, "Darrel", "Developer");
        Employee emp4 = new Employee() { empName = "Alfred", job = "Engineer" };

        // display fields
        Console.WriteLine(Employee.companyName);
        Console.WriteLine("\n-----emp1-----");
        Console.WriteLine(emp1.empID);
        Console.WriteLine(emp1.empName);
        Console.WriteLine(emp1.job);
        Console.WriteLine();

        Console.WriteLine("-----emp2-----");
        Console.WriteLine(emp2.empID);
        Console.WriteLine(emp2.empName);
        Console.WriteLine(emp2.job);
        Console.WriteLine();

        Console.WriteLine("-----emp3-----");
        Console.WriteLine(emp3.empID);
        Console.WriteLine(emp3.empName);
        Console.WriteLine(emp3.job);
        Console.WriteLine();

        Console.WriteLine("-----emp4-----");
        Console.WriteLine(emp4.empID);
        Console.WriteLine(emp4.empName);
        Console.WriteLine(emp4.job);
        Console.WriteLine();

        Console.ReadKey();
    }
}

