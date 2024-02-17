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
    public List<List<Object>> with_bools = new();

    public List<string> spliList;

    public List<List<Object>> SplitString(KeyValuePair<string, string> refer){
        Console.WriteLine(refer);
        int i = 0;
        with_bools.Clear();
        spliList = refer.Value.Split(" ").ToList();
        foreach(string word in spliList){
            if(word.Count() > 0){
                List<Object> innerList = new List<Object> {i, word, true};
                with_bools.Add(innerList);
                i += 1;
        }
        }
        return with_bools;
    }
}