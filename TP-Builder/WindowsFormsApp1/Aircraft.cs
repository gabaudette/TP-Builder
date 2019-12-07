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
       
        protected string name; // Name of an aircraft
        protected int speed; // Speed of an aircraft
        protected int maintenance; // Maintenance time of an aircraft

        /// <summary>
        /// Get/Set Name of the aircraft
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Get/Set Speed of the aircraft
        /// </summary>
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        /// <summary>
        /// Get/Set Maintenance of the aircraft
        /// </summary>
        public int Maintenance
        {
            get { return this.maintenance; }
            set { this.maintenance = value; }
        }
    
        public Aircraft() { }
        public Aircraft(string name, int speed, int maintenance)
        {
            this.name = name;
            this.speed = speed;
            this.maintenance = maintenance;
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
