using System;
using System.Net;

public class Menu
{
    GrabApi api = new GrabApi();
    SellStock sell = new SellStock();

    AddStock add = new AddStock();
    // Portfolio portfolio = new Portfolio();
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to your stock tracker!");
        Console.WriteLine("1. Buy Stock");
        Console.WriteLine("2. Sell Stock");
        Console.WriteLine("3. Show Portfolio");
        Console.WriteLine("4. Show price for a stock");
        Console.WriteLine("5. Exit");
        Console.Write("Please enter your choice:");
    }

    public void HandleInput()
    {
        bool exit = false;
        
        while (!exit)
        {
            DisplayMenu();
            string input = Console.ReadLine();
            if(input == "1"){
                Console.Write("What stock do you want to buy? Enter the ticker symbol: ");
                string symbol = Console.ReadLine();
                api.Itterate(symbol);
                Console.Write("How many shares do you want to buy?");
                int shares = Convert.ToInt32(Console.ReadLine());
                add.AddStocks(new Stock { symbol = symbol, price = api.GetPrice(symbol), shares = shares });
                Console.WriteLine($"Total Cost: {api.GetPrice(symbol) * shares}");

            }
            else if(input == "2"){
                sell.SellStocks();
            }
            else if (input == "3"){
                sell.ShowPortolio();
                sell.TotalValue();
            } 
            else if(input == "4"){
                Console.Write("What stock do you want the price of? Enter the ticker symbol: ");
                string symbol = Console.ReadLine();
                api.Itterate(symbol);
            }
            else if (input == "5"){ 
                exit = true;
                break;
            }
                   }
    }
}