using System.Collections.Generic;
using System.Xml.Serialization;

namespace TPBuilder
{
    public class Airport
    {
        public string Name { get; set; } //Airport's name
        public int X { get; set; } //Airport's X position
        public int Y { get; set; } //Airport's Y position
        public int MinPassenger { get; set; } //Airport's minimum passenger capacity
        public int MaxPassenger { get; set; } //Airport's maximum passenger capacity
        public int MinMarchandise { get; set; } //Airport's minimum marchandise capacity
        public int MaxMarchandise { get; set; } //Airport's maximum marchandise capacity
        [XmlIgnore]
        public string DMS { get; set; }
        public List<Aircraft> Aircrafts { get; set; } //List of all the aircraft inside the current airport

        public Airport() { }
        public Airport(string name, int x, int y, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise, string dms)
        {
            Name = name;
            X = x;
            Y = y;
            MinPassenger = minPassenger;
            MaxPassenger = maxPassenger;
            MinMarchandise = minMarchandise;
            MaxMarchandise = maxMarchandise;
            DMS = dms;
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
