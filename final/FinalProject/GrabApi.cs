using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;
using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class GrabApi{
    public static readonly HttpClient client = new HttpClient();
    Stock stock = new Stock();
    public async Task<List<Stock>> FetchDataFromYahooFinanceAPI(string symbol, int shares = 1)
    {
        string url = $"https://query1.finance.yahoo.com/v8/finance/chart/{symbol}?interval=1d";

        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        JObject json = JObject.Parse(responseBody);
        symbol = json["chart"]["result"][0]["meta"]["symbol"].ToString();
        double price = (double)json["chart"]["result"][0]["meta"]["regularMarketPrice"];
        stock.price = price;
        stock.symbol = symbol;
        // Console.WriteLine($"Symbol: {symbol}, Price: {price}");
        return new List<Stock> { new Stock { symbol = symbol, price = price, shares = shares} };
    }
    public Task<List<Stock>> GetInfo(string symbol, int shares = 1){
        return Task.Run(() => FetchDataFromYahooFinanceAPI(symbol, shares));
    }
    public string GetSymbol(string symbol){
        var info = GetInfo(symbol).Result;
        return stock.symbol;
    }
    public double GetPrice(string symbol){
        var info = GetInfo(symbol).Result;
        return (double)stock.price;
    }
    public void Itterate(string symbol){
        Console.WriteLine($"Symbol: {GetSymbol(symbol)}, Price: {GetPrice(symbol)}");
    }
}