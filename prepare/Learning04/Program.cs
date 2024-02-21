using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment math = new();
        WritingAssignment writing = new();
        math._studentName = "Roberto Rodriguez";
        math._topic = "Fractions";
        math._textbookSection = "7.3";
        math._problems = "8-19";
        writing._topic = "The Causes of World War II by Mary Waters";
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeWorkList());
    }
}