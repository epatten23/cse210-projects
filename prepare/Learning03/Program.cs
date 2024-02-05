using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction twofacts = new Fraction(5, 3);
        Fraction zerofacts = new Fraction();
        Fraction onefacts = new Fraction(2);

        twofacts.GetDecimalValue();
        twofacts.GetFractionString();
        onefacts.GetDecimalValue();
        onefacts.GetFractionString();
        zerofacts.GetDecimalValue();
        zerofacts.GetFractionString();        

    }
}