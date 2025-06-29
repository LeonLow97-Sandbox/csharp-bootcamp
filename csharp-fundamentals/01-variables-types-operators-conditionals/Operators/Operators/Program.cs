
class Operators
{
    static void Main()
    {
        // Arithmetical Operators
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b; // Output: 13
        decimal d = a - b; // Output: 7
        decimal e = a * b; // Output: 30
        decimal f = a / b; // Output: 3.3333333
        decimal g = a % b; // Output: 1
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);    
        System.Console.WriteLine(e);    
        System.Console.WriteLine(f);    
        System.Console.WriteLine(g);

        // Assignment Operators
        a += 20M;
        System.Console.WriteLine(a); // 30
        a -= 20M;
        System.Console.WriteLine(a); // 10
        a *= 3M;
        System.Console.WriteLine(a); // 30
        a /= 3M;
        System.Console.WriteLine(a); // 10
        a %= 3M;
        System.Console.WriteLine(a); // 1

        // Increment / Decrement Operators
        a = 10M;
        System.Console.WriteLine();
        System.Console.WriteLine(++a); // 11
        System.Console.WriteLine(a++); // 11
        System.Console.WriteLine(a); // 12
        System.Console.WriteLine(--a); // 11
        System.Console.WriteLine(a--); // 11
        System.Console.WriteLine(a); // 10

        // Comparison Operators
        bool b1 = a == 10;
        System.Console.WriteLine();
        System.Console.WriteLine(b1); // true
        bool b2 = a != 10;
        System.Console.WriteLine(b2); // false
        bool b3 = a < 10;
        System.Console.WriteLine(b3); // false
        bool b4 = a > 10;
        System.Console.WriteLine(b4); // false
        bool b5 = a <= 10;
        System.Console.WriteLine(b5); // true
        bool b6 = a >= 10;
        System.Console.WriteLine(b6); // true

        // Logical Operators
        System.Console.WriteLine();
        a = 10M;
        b = 3M;
        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7); // false 
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8); // false
        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9); // false
        bool b10 = a == 10 || b == 10;
        System.Console.WriteLine(b10); // true 
        bool b11 = !(a == 10);
        System.Console.WriteLine(b11); // false
        bool b12 = a == 10 ^ b == 10;  
        System  .Console.WriteLine(b12); // true

        // Concatenation Operator
        string name = "Leon";
        int age = 20;
        string message = "Hey " + name + ", you age is " + age + ".";
        System.Console.WriteLine(message);

        // Ternary Operator
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
        System.Console.WriteLine(title);

        // Operator Precedence
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z); // 22

        System.Console.ReadKey();
    }
}




