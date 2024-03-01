using System.Timers;
using System.Diagnostics;


class Listing : Activities{
    public List<string> prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    Stopwatch stopwatch = new Stopwatch();
    public void Play(){
        ActivityChosen("listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        this.gameDuration = 3000;
        DefineAutomation("Get ready...");
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];
        // Console.WriteLine($"\nList as many responses you can to the following prompt:\n---{randomPrompt}---");
        PauseFunction($"\nList as many responses you can to the following prompt:\n---{randomPrompt}--- \n You may begin in:", 5);
        Console.Clear();
        Console.WriteLine(randomPrompt);
        Console.Write("\n>");
        counter = 0;
        counter += 1;
        string answer = Console.ReadLine();
        int elapsed = 0;
        while (elapsed < setduration){
            stopwatch.Start();
            Console.Write(">");
            answer = Console.ReadLine();
            stopwatch.Stop();
            counter += 1;
            double times = stopwatch.Elapsed.TotalSeconds;
            elapsed += (int)times * 1000;
        }
        DefineAutomation("Well done!");
        Console.WriteLine($"You wrote {counter} entries!");
        FinishingMessage();
    }

}