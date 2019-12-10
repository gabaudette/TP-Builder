using System.Collections.Generic;
using System.Xml.Serialization;

namespace TPBuilder
{
    public class Airport
    {
        private string name; //Airport's name
        private int x; //Airport's X position
        private int y; //Airport's Y position
        private int minPassenger; //Airport's minimum passenger capacity
        private int maxPassenger; //Airport's maximum passenger capacity
        private int minMarchandise; //Airport's minimum marchandise capacity
        private int maxMarchandise; //Airport's maximum marchandise capacity
        private string dms; // Airport's position with by dms notation

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public int MinPassenger
        {
            get { return this.minPassenger; }
            set { this.minPassenger = value; }
        }

        public int MaxPassenger
        {
            get { return this.maxPassenger; }
            set { this.maxPassenger = value; }
        }

        public int MinMarchandise
        {
            get { return this.minMarchandise; }
            set { this.minMarchandise = value; }
        }
        public int MaxMarchandise
        {
            get { return this.maxMarchandise; }
            set { this.maxMarchandise = value; }
        }

        [XmlIgnore]
        public string DMS
        {
            get { return this.dms; }
            set { this.dms = value; }
        }

        public List<Aircraft> Aircrafts { get; set; } //List of all the aircraft inside the current airport

        public Airport() { }
        public Airport(string name, int x, int y, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise, string dms)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.minPassenger = minPassenger;
            this.maxPassenger = maxPassenger;
            this.minMarchandise = minMarchandise;
            this.maxMarchandise = maxMarchandise;
            this.dms = dms;
            Aircrafts = new List<Aircraft>();
        }

        /// <summary>
        /// Add a created aircraft
        /// </summary>
        /// <param name="aircraft"></param>
        public void AddAircraft(Aircraft aircraft)
        {
            Aircrafts.Add(aircraft);
        }
        public override string ToString()
        {
            return $"{Name},{X},{Y},{MinPassenger},{MaxPassenger},{MinMarchandise},{MaxPassenger}, {DMS}";
        }
    }
}
