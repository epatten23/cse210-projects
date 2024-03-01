using System.Diagnostics;
using System.Globalization;

class Breathing : Activities{
    string message;
    public void BreatheIn(int time){
        this.message = "Breathe in...";
        this.seconds = time;
        PauseFunction(message, 3);
    }
    public void BreatheOut(int time){
        this.message = "Breathe out...";
        this.seconds = time;
        PauseFunction(message, 3);
    }

    public void Play(){
        ActivityChosen("breathe", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int elapsed = 0;
        while (elapsed < setduration){
            BreatheIn(3);
            BreatheOut(3);
            counter += 1;
            elapsed += 6000;
        }
        this.gameDuration = 5000;
        DefineAutomation("Well done!");
        DefineAutomation($"You completed {setduration / 1000} seconds and {counter} rotations of the {activity} activity!");
        FinishingMessage();

    }

}