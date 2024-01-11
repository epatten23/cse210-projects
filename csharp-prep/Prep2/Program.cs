using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage?");
        string gradestr = Console.ReadLine();
        int grade = int.Parse(gradestr);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else{
            letter = "F";
        }
        Console.WriteLine($"Your grade is a {letter}");
        if (grade >= 70){
            Console.WriteLine("Congrats on passing the course!");
        }
        else{
            Console.WriteLine("You didn't pass this time. You got it next time though!");
        }
    }
}