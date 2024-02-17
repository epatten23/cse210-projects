using System;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Words{
    new References red = new();

    private int index;
    private string newstring;
    private string otherstring;
    private int wordshidden;
    private int count = 0;
    public KeyValuePair<string,string> newvalue;
    private Random random = new();

    public void Hiddens(int amttohide, KeyValuePair<string, string> refer){
        Console.Clear();
        List<List<Object>> words = red.SplitString(refer);
        int counter = words.Count;
        
        Console.Clear();
        Console.Write($"{refer.Key} ");
        foreach(var i in words){
            Console.Write(i[1] + " ");
        }
        wordshidden = 0;   
        for(int i = 0; i < amttohide;){
            index = random.Next(words.Count);
            List<Object> randomPair = red.with_bools[index];
            if (!((string)words[index][1]).StartsWith("_")){
                string originalstring = (string)randomPair[1];
                string originalstring2 = (string)randomPair[1];
                red.with_bools[index][1] = string.Concat(Enumerable.Repeat("_", originalstring.Length));
                words[index][1] = string.Concat(Enumerable.Repeat("_", originalstring2.Length));
                red.with_bools[index][2] =  false;
                words[index][2] =  false;
                amttohide -= 1;
                count += 1;
            }
        }    
        newstring = "";
        foreach(var f in words){
            newstring += $"{f[1]} ";
            otherstring = refer.Key;     
        }
        newvalue = new KeyValuePair<string, string>(otherstring, newstring);
        if(count >= counter - 2){
            Console.Clear();
            Console.WriteLine($"Congrats! You memorized {refer.Key}!");
        }
            
    }
    
}