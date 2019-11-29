﻿using System.Collections.Generic;
namespace TPBuilder
{
    public class Airport
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int MinPassenger { get; set; }
        public int MaxPassenger { get; set; }
        public int MinMarchandise { get; set; }
        public int MaxMarchandise { get; set; }

        public List<Aircraft> Aircrafts { get; set; }

        public Airport() { }

        public Airport(string name, string position, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise)
        {
            Name = name;
            Position = position;
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
    }
}
