namespace OperatorsDemo;

class Program
{
    static void Main(string[] args)
    {
        // Operators
        
        // Assigment operator = 
        
        // int x = 5;
        
        // Arithmetic operators

        int addition = 5 + 5;
        int subtraction = 5 - 5;
        int multiplication = 5 * 5;
        int division = 5 / 5;
        int modulus = 6 % 5; // gives the remainder after division, output = 1, good for checking if a number is even or odd
        // bool isEven = 4 % 2 == 0; // example of using a modulus to check is even
        
        // Unary operators
        int x = 3;
        int y = ++x; // example of pre increment

        Console.WriteLine(x); 
        Console.WriteLine(y);

        int a = 3;
        int b = a++; // example of post increment

        Console.WriteLine(a); 
        Console.WriteLine(b);
        
        
    }
}