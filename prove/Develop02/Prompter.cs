using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Prompter{
    public List<string> _prompts = ["Prompt 1", "Prompt 2", "Prompt 3"];

    public void PromptGenerator(Entry _prompt, List<string> promptlist) {
        foreach(string item in promptlist){
                    Console.Write($"{item} \n >");
                    // _prompt = ;
                    promptlist.Remove(item);
                    break;
                };
    }

};