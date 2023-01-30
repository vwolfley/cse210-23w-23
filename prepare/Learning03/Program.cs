using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        // Step 5 Getters and Setters
        Fraction f1 = new Fraction();
        f1.SetTop(3);
        f1.SetBottom(4);

        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());

        // Step 6 return methods
        Fraction f3 = new Fraction();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(6);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Fraction f5 = new Fraction(6, 7);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        Fraction f6 = new Fraction(3, 4);
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());

        Fraction f7 = new Fraction(6, 12);
        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetDecimalValue());

    }
}