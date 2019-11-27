namespace TPBuilder
{
    public abstract class Aircraft
    {
        public string Name { get; protected set; }
        public int Speed { get; protected set; }
        public int Maintenance { get; protected set; }

        public Aircraft() { }
        public Aircraft(string name, int speed, int maintenance)
        {
            Name = name;
            Speed = speed;
            Maintenance = maintenance;
        }
    }
}
