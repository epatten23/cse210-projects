using System;
using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Transactions;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        DateTime date = DateTime.Now;
        int journaling = 0;
        Entry entreries = new Entry();
        var allentries = entreries.entries;
        Journal load = new Journal();
        List<string> saveentries = load._newentries;
        saveentries = [];



        
        Entry response1 = new Entry();
        // response1._date = DateTime.ToString(date);

        while(journaling != 5){
            Console.WriteLine("Please select one of the following: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            string answer = Console.ReadLine();
            int type = int.Parse(answer);
            if(type == 1){
                entreries._date = date.ToShortDateString();
                Console.WriteLine("Select the topic you want to write about? \n 1. Gratitude \n 2. Self Discovery \n 3. Personal History \n 4. Personal Reflection");
                string secondAnswer = Console.ReadLine();
                int writeType = int.Parse(secondAnswer);
                if(writeType == 1){
                    entreries.GratitudePromptGenerator();
                };
                if(writeType == 2){
                    entreries.PersonalPromptGenerator();
                };
                if(writeType == 3){
                    entreries.HistoryPromptGenerator();
                };
                if(writeType == 4){
                    entreries.ReflectionPromptGenerator();
                };
                
                string new_entry = Console.ReadLine();
                entreries._response = new_entry;
                string finalentry = entreries.DisplayFullEntry();
                entreries.entries.Add(finalentry);
                };
            if(type == 2){
                if(load._newentries.Count() != 0){
                    for (int x = 0; x < load._newentries.Count; x++)
                    Console.WriteLine(load._newentries[x]);
                }
                for(int i = -1; i < allentries.Count; i++)
                    Console.WriteLine(allentries[i]);
                
            }
            if(type == 3){
                Console.Write("What file name would you like it to save to?: ");
                load._file = Console.ReadLine();
                load.LoadFile();
            }
            if(type == 4){
                Console.Write("What file name would you like it to save to?: ");
                load._file = Console.ReadLine();
                load.SaveEntries(allentries);
                for(int i = 0; i < allentries.Count; i++)
                    entreries.entries.Remove(allentries[i]);
            }
            if(type == 5){
                break;
            }
        }
    }
}