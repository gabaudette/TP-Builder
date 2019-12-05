using System.Xml.Serialization;

namespace TPBuilder
{
    [XmlInclude(typeof(CargoPlane))]
    [XmlInclude(typeof(ObserverPlane))]
    [XmlInclude(typeof(PassengerPlane))]
    [XmlInclude(typeof(WaterBomber))]
    [XmlInclude(typeof(RescueHelicopter))]

    public abstract class Aircraft
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Maintenance { get; set; }

        public Aircraft() { }
        public Aircraft(string name, int speed, int maintenance)
        {
            Name = name;
            Speed = speed;
            Maintenance = maintenance;
        }
    }
}
