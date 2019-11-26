namespace TPBuilder
{
    public class PassengerAircraft : Aircraft
    {
        public int LoadingTime { get; protected set; }
        public int UnloadingTime { get; protected set; }

        public PassengerAircraft(string name, int speed, int maintenance, int loadingTime, int unloadingTime) : base(name, speed , maintenance)
        {
            LoadingTime = loadingTime;
            UnloadingTime = unloadingTime;
        }
    }
}
