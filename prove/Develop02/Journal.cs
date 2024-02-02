using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

public class Journal{

    public string _file;

    public string _loadentries;

    public List<string> _newentries = [];

    public void LoadFile(){
        string filename = _file;
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines){
            _newentries.Add(line);
        // Using the file reader thing, read every single line and add it to a list to be added iwht the display function 

                }
    }

    public void SaveEntries(List<string> entries){
        using (StreamWriter outputFile = new StreamWriter(_file, true)){
            foreach(string line in entries){
                outputFile.WriteLine(line);
            }
}

    }
}
