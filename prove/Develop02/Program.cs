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
        var allEntries = entreries.entries;
        Journal load = new Journal();
        List<string> saveEntries = load._newEntries;
        saveEntries = [];



        
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
                
                string newEntry = Console.ReadLine();
                entreries._response = newEntry;
                string finalEntry = entreries.DisplayFullEntry();
                entreries.entries.Add(finalEntry);
                };
            if(type == 2){
                if(load._newEntries.Count() != 0){
                    for (int x = 0; x < load._newEntries.Count; x++)
                    Console.WriteLine(load._newEntries[x]);
                }
                for(int i = -1; i < allEntries.Count; i++)
                    Console.WriteLine(allEntries[i]);
                
            }
            if(type == 3){
                Console.Write("What file name would you like it to save to?: ");
                load._file = Console.ReadLine();
                load.LoadFile();
            }
            if(type == 4){
                Console.Write("What file name would you like it to save to?: ");
                load._file = Console.ReadLine();
                load.SaveEntries(allEntries);
                for(int i = 0; i < allEntries.Count; i++)
                    entreries.entries.Remove(allEntries[i]);
            }
            if(type == 5){
                break;
            }
        }
    }
}