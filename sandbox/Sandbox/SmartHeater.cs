
    public class SmartHeater : SmartDevice{
    public double temperature;
    public SmartHeater(string name, double temperature) :base(name){
        this.name = name;
        this.temperature = temperature;
    }

}