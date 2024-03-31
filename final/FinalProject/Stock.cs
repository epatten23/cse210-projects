using System.Security.Cryptography;

public class Stock
{   
    // public double amtmade = 0;
    public string symbol { get; set; }
    public double price { get; set; }
    public int shares { get; set; }

    public void ShowStock(){
        Console.WriteLine($"Symbol: {symbol}, Shares: {shares} Amount Invested: ${price*shares}");
    }
}