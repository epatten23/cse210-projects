using System.Threading.Tasks.Dataflow;

abstract class Activities{
    public int gameDuration;
    public int setduration = 30000;
    public string activity;
    public string description;
    public int seconds;
    public Random random = new Random();
    public int counter;

    public void ActivityChosen(string activity, string description){
        this.activity = activity;
        this.description = description;
        Console.Clear();
        Console.WriteLine($"Welcome to {activity}!\n\n{description}\n\nHow many seconds do you want your session to go for?");
        string strtime = Console.ReadLine();
        this.gameDuration = 5000;
        DefineAutomation();
        if(strtime != ""){
            this.setduration = int.Parse(strtime) * 1000;
        }
        else {
            this.setduration = setduration;
        }
    }
    public void DefineAutomation(string message = "Loading"){
                // Console.Clear();
        int elapsed = 0;
        while (elapsed < gameDuration)
        {    
            Console.Write($"{message} \n \\");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write($"{message} \n |");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write($"{message} \n /");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write($"{message} \n —");
            Thread.Sleep(300);
            Console.Clear();
            elapsed += 1500;
        }
    }
    public void PauseFunction(string message, int time){
        while(time != 0){
            Console.Clear();
            Console.WriteLine(message);
            Console.Write(time);
            Thread.Sleep(1000);
            time -= 1;
        }
    }
    public void FinishingMessage(){
        Console.WriteLine($"Thank you for completing the {activity} activity!");
        Thread.Sleep(3000);
    }
}
