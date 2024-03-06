using System.Globalization;

public class SmartDevice{
    public bool status;
    public DateTime startTime;
    DateTime newTime;
    public string name;
    public string statusString;
    public double second;
    public SmartDevice(string name){
        this.name = name;
    }
    public void TurnOn(){
        this.status = true;
        this.statusString = "On";
        startTime = DateTime.Now;
    }

    public void TurnOff(){
        this.status = false;
        this.statusString = "Off";
        newTime = DateTime.Now;
        second = newTime.Subtract(startTime).TotalSeconds;

    }
    public bool GetStatus(){
        return status;
    }
    public double GetTime(){
        newTime = DateTime.Now;
        return newTime.Subtract(startTime).TotalSeconds;


    }
}