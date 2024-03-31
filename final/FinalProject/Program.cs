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
        menu.HandleInput();
        // api.Itterate();
        
    }
}
