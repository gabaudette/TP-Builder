namespace TPBuilder
{
    public class Airport
    {
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Airport(){}
        public Airport(string name)
        {
            this.Name = name;
        }
        public Airport(string name, int x, int y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }
    }
}
