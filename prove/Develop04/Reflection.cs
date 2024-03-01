using System.Reflection.PortableExecutable;

class Reflection : Activities{
    public List<string> prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    public List<string> questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    public void Play(){
        counter = 0;
        ActivityChosen("reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];
        Console.WriteLine($"Consider the following prompt: \n \n --- {randomPrompt} --- \n \n When you have something in mind, press enter to continue");
        string answer = Console.ReadLine();
        if(answer == ""){
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
            PauseFunction("You may begin in: ", 3);
            Console.Clear();
            int elapsed = 0;
            while (elapsed < setduration){
                gameDuration = 5000;
                randomIndex = random.Next(prompts.Count);
                DefineAutomation(questions[randomIndex]);
                counter += 1;
                elapsed += 10000;
        }
        this.gameDuration = 5000;
        DefineAutomation("Well done!");
        DefineAutomation($"You completed {counter} reflection questions in the {activity} activity!");
        FinishingMessage();


        }
    }
}