using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1);

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction2);

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine(fraction3);
        
        
        

    }
}