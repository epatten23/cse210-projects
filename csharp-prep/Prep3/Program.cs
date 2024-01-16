using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random magic = new Random();
        int magicNum = magic.Next(26);
        Console.WriteLine("What is your guess?(Between 0-25)");
        string guess = Console.ReadLine();
        int guessNum = int.Parse(guess);
        int guesses = 0;
        while(magicNum != guessNum){
        if(magicNum > guessNum){
            Console.WriteLine("Higher");
            Console.WriteLine("What is your guess?(Between 0-25)");
            guess = Console.ReadLine();
            guessNum = int.Parse(guess);
        }
        if(magicNum < guessNum){
            Console.WriteLine("Lower");
            Console.WriteLine("What is your guess?(Between 0-25)");
            guess = Console.ReadLine();
            guessNum = int.Parse(guess);
            }
         guesses += 1;
        }
        Console.WriteLine($"Congrats! The magic number was {magicNum}");
        Console.WriteLine($"It took you {guesses} tries to guesss the number");
    }

}