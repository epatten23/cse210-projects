using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        var menu = new Menu();
        var save = new Save();
        save.CallPortfolio();
        menu.HandleInput();
        // api.Itterate();
        
    }
}
