namespace TPBuilder
{
    public class PassengerAircraft : Aircraft
    {
        protected int loadingTime; //Time it take to load client
        protected int unloadingTime; //Time it take to unload client
        protected int maxCapacity; // Maximum capacity

        public int LoadingTime
        {
            get { return this.loadingTime; }
            set { this.loadingTime = value; }
        }

        public int UnloadingTime
        {
            get { return this.unloadingTime; }
            set { this.unloadingTime = value; }
        }

        public int MaxCapacity
        {
            get { return this.maxCapacity; }
            set { this.maxCapacity = value; }
        }

        public PassengerAircraft() { }

        public PassengerAircraft(string name, int speed, int maintenance, int loadingTime, int unloadingTime, int capacity) : base(name, speed , maintenance)
        {
            this.loadingTime = loadingTime;
            this.unloadingTime = unloadingTime;
            this.maxCapacity = capacity;
        }
    }
}
