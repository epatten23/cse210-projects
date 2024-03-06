class RoomOne : House{
    public SmartHeater livingHeater = new SmartHeater("Living Room Heater", 69.5);
    public SmartLight livingLight = new SmartLight("Living room main light");
    public SmartLight cornerLight = new SmartLight("Living room corner light");
    List<SmartLight> lights = new List<SmartLight>();
        public override void Device()
    {
        lights.Add(livingLight);
        lights.Add(cornerLight);
        devices.Add(livingHeater);
        devices.Add(livingLight);
        devices.Add(cornerLight);
    }


}