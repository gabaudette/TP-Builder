using System.Collections.Generic;

namespace TPBuilder
{
    public class Airport
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int MinPassenger { get; set; }
        public int MaxPassenger { get; set; }
        public int MinMarchandise { get; set; }
        public int MaxMarchandise { get; set; }

        public List<Aircraft> Aircrafts { get; set; }

        public Airport() { }

        public Airport(string name, int x, int y, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise)
        {
            Name = name;
            X = x;
            Y = y;
            MinPassenger = minPassenger;
            MaxPassenger = maxPassenger;
            MinMarchandise = minMarchandise;
            MaxMarchandise = maxMarchandise;
            Aircrafts = new List<Aircraft>();
        }

        public void AddAircraft(Aircraft aircraft)
        {
            Aircrafts.Add(aircraft);
        }

        public void DeleteAircraft(int index)
        {
            try
            {
                Aircrafts.RemoveAt(index);
            }
            catch (System.ArgumentOutOfRangeException outOfRange)
            {
                System.Console.WriteLine("Error: " + index + "is out of range", outOfRange.Message);
            }
        }

        public override string ToString()
        {
            return $"{Name},{X},{Y},{MinPassenger},{MaxPassenger},{MinMarchandise},{MaxPassenger}";
        }
    }
}
