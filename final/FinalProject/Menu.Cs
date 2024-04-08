using System;
using System.Net;

public class Menu
{
    private GrabApi api = new GrabApi();
    private SellStock sell = new SellStock();
    private SellOldStock sellOld = new SellOldStock();

    private AddStock add = new AddStock();

    private Save save = new Save();
    // Portfolio portfolio = new Portfolio();
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to your stock tracker!");
        Console.WriteLine("1. Buy Stock");
        Console.WriteLine("2. Sell Stock");
        Console.WriteLine("3. Show Portfolio");
        Console.WriteLine("4. Show price for a stock");
        Console.WriteLine("5. Save and exit");
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
                string symbol = Console.ReadLine().ToUpper();
                Console.Write("How many shares do you want to buy?");
                int shares = Convert.ToInt32(Console.ReadLine());
                Console.Write("Buy at current price? (y/n): ");
                string buy = Console.ReadLine();
                if(buy == "y"){
                    api.Itterate(symbol);
                    add.AddStocks(new Stock { symbol = symbol, price = api.GetPrice(symbol), shares = shares });
                    Console.WriteLine($"Total Cost: {api.GetPrice(symbol) * shares}");
                }
                else{
                    Console.Write("What price do you want to buy at? ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Symbol: {symbol}, Price: {price}");
                    add.AddStocks(new Stock { symbol = symbol, price = price, shares = shares });
                    Console.WriteLine($"Total Cost: {price * shares}");
                }

                

            }
            else if(input == "2"){
                Console.Write("What stock do you want to sell? Enter the ticker symbol: ");
                string symbol = Console.ReadLine().ToUpper();
                Console.Write("How many shares do you want to sell?");
                int shares = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sell at current price? (y/n): ");
                string buy = Console.ReadLine();
                if(buy == "y"){
                    api.Itterate(symbol);
                    sell.SellStocks(new Stock { symbol = symbol, price = api.GetPrice(symbol), shares = shares });
                    Console.WriteLine($"Total Cost: {api.GetPrice(symbol) * shares}");
                }
                else{
                    Console.Write("What price do you want to sell at? ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Symbol: {symbol}, Price: {price}");
                    sellOld.SellOldStocks(new Stock { symbol = symbol, price = price, shares = shares });
                    Console.WriteLine($"Total Cost: {price * shares}");
                }
            }
            else if (input == "3"){
                sell.ShowPortolio();
                sell.TotalValue();
            } 
            else if(input == "4"){
                Console.Write("What stock do you want the price of? Enter the ticker symbol: ");
                string symbol = Console.ReadLine().ToUpper();
                api.Itterate(symbol);
            }
            else if (input == "5"){ 
                save.SavePortfolio();
                exit = true;
                break;
            }
                   }
    }
}