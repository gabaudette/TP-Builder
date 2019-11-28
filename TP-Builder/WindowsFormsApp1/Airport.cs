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

        public Airport() { }

        public Airport(string name, string position, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise)
        {
            Name = name;
            Position = position;
            MinPassenger = minPassenger;
            MaxPassenger = maxPassenger;
            MinMarchandise = minMarchandise;
            MaxMarchandise = maxMarchandise;
        }
    }
}
