namespace TPBuilder
{
    public class WaterBomber : Aircraft
    {
        public int WaterCapacity { get; private set; }
        public int DroppingTime { get; private set; }
        public WaterBomber(string name, int waterCapacity, int droppingTime) : base(name)
        {
            WaterCapacity = waterCapacity;
            DroppingTime = droppingTime;
        }
    }
}
