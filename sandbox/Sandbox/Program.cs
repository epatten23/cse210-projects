using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        BaldEagle joey = new("joey", "Screee");
        BaldEagle dragon = new("dragon", "aAAAaa");

        joey.MakeSound();
        dragon.MakeSound();
    }
}