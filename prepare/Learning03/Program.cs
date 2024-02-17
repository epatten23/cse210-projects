using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction twofacts = new Fraction(5, 3);
        Fraction zerofacts = new Fraction();
        Fraction onefacts = new Fraction(2);


        zerofacts.GetDecimalValue();
        zerofacts.GetFractionString();    
        onefacts.GetDecimalValue();
        onefacts.GetFractionString();
        twofacts.GetDecimalValue();
        twofacts.GetFractionString();

    

    }
}