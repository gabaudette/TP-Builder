namespace TPBuilder
{
    public abstract class Aircraft
    {
        public string Name { get; protected set; }
        public Aircraft(string name)
        {
            Name = name;
        }
    }
}
