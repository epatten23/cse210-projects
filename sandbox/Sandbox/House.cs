abstract class House{
    public abstract void Device();
    public List<SmartDevice> devices = new List<SmartDevice>();
    DateTime nowTime;
    List<double> seconds = new List<double>();
    public double longest = 0;
    public string name;
    public void TurnOneOff(SmartDevice device){
        device.TurnOff();
    }
    public void TurnOnDevices()
    {
        foreach(SmartDevice device in devices){
            device.TurnOn();
        }
    }
    public void TurnOffDevices()
    {
        foreach(SmartDevice device in devices){
            device.TurnOff();
        }
    }
    public void TurnOnDevice(SmartDevice device){
        device.TurnOn();
    }
    public void AllDevicesOn()
    {
        Console.WriteLine("Devices on: ");
        foreach(SmartDevice device in devices){
            if(device.status == true){
                Console.WriteLine($"{device.name}");
            }
        }
    }
    public void AllDeviceStatus()
    {
        Console.WriteLine("Devices: ");
        foreach(SmartDevice device in devices){
            Console.WriteLine($"{device.name}: {device.statusString}");
        }
    }
    public void LongestOn(){
        nowTime = DateTime.Now;
        foreach(SmartDevice device in devices){
            Console.WriteLine(device.name);
            // difference = nowTime - device.startTime;
            if(device.second > longest){
                longest = device.second;
                name = device.name;
            }

        }
        // longest = seconds.Max();
        Console.WriteLine($"Device: {name} \nSeconds on: {longest}");
    }
}