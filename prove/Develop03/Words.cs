using System;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Words{
    new References red = new();
    // References with_bools = new();
    new Scripture news = new();
    private string text;
    private bool hidden;
    private int index;
    private int amthidden = 3;
    private object wholeDict;

    
    Random random = new();

    // public List<List<Object>> GetIndex(){
    //     KeyValuePair<string, string> refer = news.PickReference();
        
    //     return words;
    // }

    public void Hide(){
        this.hidden = true;
        
    }

    public void Hiddens(int amttohide, KeyValuePair<string, string> refer){
        // var wholedict = red.SplitString(news.referen);
        Console.Clear();
        List<List<Object>> words = red.SplitString(refer);
        int counter = words.Count();
        
        Console.Clear();
        while(counter != 0){
            foreach(var i in words){
                Console.Write(i[1] + " ");
                counter -= 1;
            }

        }

        for(int i = 0; i < amttohide; i++){
            index = random.Next(words.Count - 1);
            List<Object> randomPair = words[index];
            bool value;
            value = (bool)randomPair[2];
            if(value == true){
                words[index][1] = "____";
                value = (bool)words[index][2];
                value = false;

            }
            else{
                continue;
            }
            }
            
    }
    
}