using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine($"f1: {f1.GetFractionString(f1.Numerator, f1.Denominator)} = {f1.GetDecimalValue()}");
        Console.WriteLine($"f2: {f2.GetFractionString(f2.Numerator, f2.Denominator)} = {f2.GetDecimalValue()}");
        Console.WriteLine($"f3: {f3.GetFractionString(f3.Numerator, f3.Denominator)} = {f3.GetDecimalValue()}");
        Console.WriteLine($"f4: {f4.GetFractionString(f4.Numerator, f4.Denominator)} = {f4.GetDecimalValue()}");
    }
}