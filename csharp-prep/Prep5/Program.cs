using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string userName = PromptUserName();
        int userNum = PromptNumber();
        int squarNum = SquareNumber(userNum);

        DisplayResult(userName, squarNum);

    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName(){
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptNumber(){
        Console.Write("What's your favorite number?: ");
        string number = Console.ReadLine();
        int userNum = int.Parse(number);

        return userNum;
    }
    static int SquareNumber(int number){
        int num = number * number;
        return num;
    }
    static void DisplayResult(string name, int numb){
        Console.WriteLine($"Hello {name}, the square of your favorite number is {numb}");
    }
}