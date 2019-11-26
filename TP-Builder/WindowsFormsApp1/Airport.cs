namespace TPBuilder
{
    public class Airport
    {
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Airport() { }
        public Airport(string name)
        {
            Name = name;
        }
        public Airport(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
