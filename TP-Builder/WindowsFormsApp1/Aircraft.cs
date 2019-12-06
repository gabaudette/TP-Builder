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
        public string Name { get; set; } //Name of an Aircraft
        public int Speed { get; set; } // Speed of an Aircraft
        public int Maintenance { get; set; } //Maintence time of an Aircraft

        public Aircraft() { }
        public Aircraft(string name, int speed, int maintenance)
        {
            Name = name;
            Speed = speed;
            Maintenance = maintenance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name},{Speed},{Maintenance}";
        }
    }
}
