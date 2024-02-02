using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

public class Journal{

    public string _file;

    public string _loadEntries;

    public List<string> _newEntries = [];

    public void LoadFile(){
        string fileName = _file;
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines){
            _newEntries.Add(line);
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
