namespace TPBuilder
{
    public class Airport
    {
        public string Name { get;  set; }
        public int X { get;  set; }
        public int Y { get;  set; }

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
