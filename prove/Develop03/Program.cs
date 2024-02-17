using System;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        References ahh = new References();
        Scripture news = new Scripture();
        Words bs = new Words();
        
        Console.WriteLine("What book do you want to study from? \n 1: Book of Mormon \n 2. Old Testament \n 3. New Testament");
        string whichBook = Console.ReadLine();
        int theBook = int.Parse(whichBook);
        news.book = theBook;
        KeyValuePair<string, string> finaldict = news.PickReference(theBook);
        Console.WriteLine(finaldict);


        Console.WriteLine("Press enter to continue or type 'quit' to exit:");
        var answer = Console.ReadLine();
        while (answer != "quit") {
            bs.Hiddens(3, finaldict);
            answer = Console.ReadLine();
            Console.Clear();
            continue;
            if(answer == "quit"){
                break;
            }
        } 

    }
}