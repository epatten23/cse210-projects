class RoomTwo : House{
    public SmartHeater kitchenHeater = new SmartHeater("Kitchen Room Heater", 69.5);
    public SmartLight kitchenLight = new SmartLight("Kitchen room main light");
    public SmartLight cornerLight = new SmartLight("Kitchen room corner light");
    List<SmartLight> lights = new List<SmartLight>();
        public override void Device()
    {
        lights.Add(kitchenLight);
        lights.Add(cornerLight);
        devices.Add(kitchenHeater);
        devices.Add(kitchenLight);
        devices.Add(cornerLight);
    }


}