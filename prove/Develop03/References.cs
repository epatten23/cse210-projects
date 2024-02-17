using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Encodings.Web;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

public class References{
    
    // private Scripture scripte = new Scripture(); 
    

    // public Dictionary<string, bool> with_bools = new(){};
    public List<List<Object>> with_bools = new();

    public List<string> spliList;

    // public KeyValuePair<string, string> refer;

    public List<List<Object>> SplitString(KeyValuePair<string, string> refer){
        Console.Clear();
        Console.WriteLine(refer);
        int i = 0;
        
        spliList = refer.Value.Split(" ").ToList();
        foreach(string word in spliList){
            List<Object> innerList = new List<Object> {i, word, true};
            with_bools.Add(innerList);
            i += 1;
        }
        return with_bools;
    }
}