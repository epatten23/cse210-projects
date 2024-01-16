using System;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int sum = 0;
        int amt = 0;
        int largeNum = 0;
        int number = 0;
        do{
        Console.WriteLine("Enter as number (Enter 0 to stop): ");
        string strnumber = Console.ReadLine();
        number = int.Parse(strnumber);
        numbers.Add(number);
        }
        while(number != 0);
        foreach(int num in numbers){
            sum += num;
            amt += 1; 
            if (num>largeNum){
                largeNum = num;
            }
        };
        
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {sum/(amt-1)}");
        Console.WriteLine($"The largest number is {largeNum}");
        
    }
}