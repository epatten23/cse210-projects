using System;

class Program
{
    static void Main(string[] args)
    {
        RoomOne roomOne = new RoomOne();
        RoomTwo roomTwo = new RoomTwo();
        roomOne.Device();
        roomTwo.Device();
        roomOne.TurnOnDevices();
        Thread.Sleep(3000);
        roomOne.TurnOneOff(roomOne.livingHeater);
        Thread.Sleep(3000);
        roomOne.TurnOneOff(roomOne.livingLight);
        Thread.Sleep(3000);
        roomOne.TurnOneOff(roomOne.cornerLight);
        roomOne.LongestOn();
        roomTwo.TurnOnDevices();
        roomTwo.TurnOneOff(roomTwo.kitchenLight);
        Thread.Sleep(3000);
        roomTwo.TurnOneOff(roomTwo.cornerLight);
        roomTwo.AllDevicesOn();
        roomTwo.AllDeviceStatus();
        
    }
}