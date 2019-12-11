namespace TPBuilder
{
    public class WaterBomber : Aircraft
    {
        private int droppingTime; // Time it take to drop its load
        private int waterCapacity; // Water capacity of the water bomber

        public int DroppingTime
        {
            get { return this.droppingTime; }
            set { this.droppingTime = value; }
        }

        public int WaterCapacity
        {
            get { return this.waterCapacity; }
            set { this.waterCapacity = value; }
        }

        public WaterBomber() { }

        public WaterBomber(string name, int speed, int maintenance, int waterCapacity, int droppingTime) : base(name, speed, maintenance)
        {
            this.waterCapacity = waterCapacity;
            this.droppingTime = droppingTime;
        }
    }
}
