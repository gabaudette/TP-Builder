namespace TPBuilder
{
    
    public class WaterBomber : Aircraft
    {
        public int WaterCapacity { get; set; }
        public int DroppingTime { get; set; }
        
        public WaterBomber() { }

        public WaterBomber(string name, int speed, int maintenance, int waterCapacity, int droppingTime) : base(name, speed, maintenance)
        {
            WaterCapacity = waterCapacity;
            DroppingTime = droppingTime;
        }
    }
}
