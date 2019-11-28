namespace TPBuilder
{
    public class Airport
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Airport() { }

        public Airport(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }
}
