namespace TPBuilder
{
    public class PassengerAircraft : Aircraft
    {
        public int LoadingTime { get; set; }
        public int UnloadingTime { get; set; }
        public int MaxCapacity { get; set; }

        public PassengerAircraft() { }

        public PassengerAircraft(string name, int speed, int maintenance, int loadingTime, int unloadingTime, int capacity) : base(name, speed , maintenance)
        {
            LoadingTime = loadingTime;
            UnloadingTime = unloadingTime;
            MaxCapacity = capacity;
        }
    }
}
